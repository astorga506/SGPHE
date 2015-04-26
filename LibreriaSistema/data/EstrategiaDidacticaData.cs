using LibreriaSistema.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibreriaSistema
{
    public class EstrategiaDidacticaData
    {
        
        private XDocument document;
        private String path;

        public EstrategiaDidacticaData(String path)
        {
            this.path = path;
        }
        //public void insertarEstrategia(EstrategiaDidactica estrategia) {
        //    if (!existeEstrategia(estrategia))
        //    {
        //        document = XDocument.Load(path);
        //        XElement elementEstrategia = new XElement("estrategia",
        //            new XElement("indice", estrategia.getIndice().ToString()),
        //            new XElement("nombre", estrategia.getNombre())
        //            );
        //        document.Root.Add(elementEstrategia);
        //        document.Save(path);
        //    }
        //    else { throw new FormatException();}

        //}
        //public void eliminarEstrategiaDidactica(EstrategiaDidactica estrategia)
        //{
        //    if (existeEstrategia(estrategia))
        //    {
        //        document = XDocument.Load(path);
        //        var estrategiaDelete = document.Root.Descendants("estrategia");
        //        foreach (var item in estrategiaDelete)
        //        {
        //            int indice = Convert.ToInt32(item.Element("indice").Value);
        //            if (estrategia.getIndice().Equals(indice))
        //            {
        //                item.Remove();
        //                break;
        //            }
        //        }
        //        document.Save(path);
        //    }
        //}
        //public LinkedList<EstrategiaDidactica> getEstrategiasDidacticas()
        //{
        //    document = XDocument.Load(path);
        //    LinkedList<EstrategiaDidactica> estrategias = new LinkedList<EstrategiaDidactica>();
        //    foreach (XElement item in document.Nodes())
        //    {
        //        EstrategiaDidactica nuevaEstrategia = new EstrategiaDidactica();
        //        nuevaEstrategia.setIndice(Convert.ToInt32(item.Attribute("indice").Value));
        //        nuevaEstrategia.setNombre(item.Element("nombre").Value);
        //        estrategias.AddLast(nuevaEstrategia);
        //    }
        //    return estrategias;
        
        //}
        //public void actualizarEstrategiaDidactica(EstrategiaDidactica estrategia)
        //{
        //    if (existeEstrategia(estrategia))
        //    {
        //        document = XDocument.Load(path);
        //        var estrategiaDelete = document.Root.Descendants("estrategia");
        //        foreach (var item in estrategiaDelete)
        //        {
        //            int indice = Convert.ToInt32(item.Element("indice").Value);
        //            if (estrategia.getIndice().Equals(indice))
        //            {
        //                //item.SetElementValue("indice", estrategia.getIndice().ToString());
        //                item.SetElementValue("nombre", estrategia.getNombre());
        //                break;
        //            }
        //        }

        //        document.Save(path);
        //    }
        
        //}
        //public Boolean existeEstrategia(EstrategiaDidactica estrategia) {
        //    document = XDocument.Load(path);
        //    var estrategiaDelete = document.Root.Descendants("estrategia");
        //    foreach (var item in estrategiaDelete)
        //    {
        //        int indice = Convert.ToInt32(item.Element("indice").Value);
        //        if (estrategia.getIndice().Equals(indice))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        
    }
}
