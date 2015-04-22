
using LibreriaSistema.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibreriaSistema.data
{
   public class TecnicaDidacticaData
    {
        
        private XDocument document;
        private String path;

        public TecnicaDidacticaData(String path)
        {
            this.path = path;
        }
        public void insertarTecnicaDidactica(TecnicaDidactica tecnica)
        {
            if (!existeTecnica(tecnica))
            {
                document = XDocument.Load(path);
                XElement elementEstrategia = new XElement("estrategia",
                    new XElement("indice", tecnica.getIndice().ToString()),
                    new XElement("nombre", tecnica.getNombre())
                    );
                document.Root.Add(elementEstrategia);
                document.Save(path);
            }
            else { throw new FormatException();}

        }
        public void eliminarTecnicaDidacticaa(TecnicaDidactica tecnica)
        {
            if (existeTecnica(tecnica))
            {
                document = XDocument.Load(path);
                var estrategiaDelete = document.Root.Descendants("estrategia");
                foreach (var item in estrategiaDelete)
                {
                    int indice = Convert.ToInt32(item.Element("indice").Value);
                    if (tecnica.getIndice().Equals(indice))
                    {
                        item.Remove();
                        break;
                    }
                }
                document.Save(path);
            }
        }
       
        public void actualizarTecnicaDidactica(TecnicaDidactica tecnica)
        {
            if (existeTecnica(tecnica))
            {
                document = XDocument.Load(path);
                var estrategiaDelete = document.Root.Descendants("estrategia");
                foreach (var item in estrategiaDelete)
                {
                    int indice = Convert.ToInt32(item.Element("indice").Value);
                    if (tecnica.getIndice().Equals(indice))
                    {
                        //item.SetElementValue("indice", estrategia.getIndice().ToString());
                        item.SetElementValue("nombre", tecnica.getNombre());
                        break;
                    }
                }

                document.Save(path);
            }
        
        }
        public Boolean existeTecnica(TecnicaDidactica tecnica) {
            document = XDocument.Load(path);
            var estrategiaDelete = document.Root.Descendants("estrategia");
            foreach (var item in estrategiaDelete)
            {
                int indice = Convert.ToInt32(item.Element("indice").Value);
                if (tecnica.getIndice().Equals(indice))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
