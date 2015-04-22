using LibreriaSistema.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LibreriaSistema
{
    public class RecursoDidacticoData
    {

        private XDocument document;
        private String path;

        public RecursoDidacticoData(String path)
        {
            this.path = path;
        }
        public void insertarRecursoDidactico(RecursoDidactico recurso)
        {
            if (!existeRecurso(recurso))
            {
                document = XDocument.Load(path);
                XElement elementEstrategia = new XElement("recurso",
                    new XElement("indice", recurso.getIndice().ToString()),
                    new XElement("nombre", recurso.getNombre())
                    );
                document.Root.Add(elementEstrategia);
                document.Save(path);
            }
            else { throw new FormatException(); }

        }
        public void eliminarRecursoDidactico(RecursoDidactico recurso)
        {
            if (existeRecurso(recurso))
            {
                document = XDocument.Load(path);
                var estrategiaDelete = document.Root.Descendants("recurso");
                foreach (var item in estrategiaDelete)
                {
                    int indice = Convert.ToInt32(item.Element("indice").Value);
                    if (recurso.getIndice().Equals(indice))
                    {
                        item.Remove();
                        break;
                    }
                }
                document.Save(path);
            }
        }

        public void actualizarRecursoDidactico(RecursoDidactico recurso)
        {
            if (existeRecurso(recurso))
            {
                document = XDocument.Load(path);
                var estrategiaDelete = document.Root.Descendants("recurso");
                foreach (var item in estrategiaDelete)
                {
                    int indice = Convert.ToInt32(item.Element("indice").Value);
                    if (recurso.getIndice().Equals(indice))
                    {
                        item.SetElementValue("indice", recurso.getIndice().ToString());
                        item.SetElementValue("nombre", recurso.getNombre());
                        break;
                    }
                }

                document.Save(path);
            }

        }
        public Boolean existeRecurso(RecursoDidactico recurso)
        {
            document = XDocument.Load(path);
            var recursoDelete = document.Root.Descendants("recurso");
            foreach (var item in recursoDelete)
            {
                int indice = Convert.ToInt32(item.Element("indice").Value);
                if (recurso.getIndice().Equals(indice))
                {
                    return true;
                }
            }
            return false;
        }


        public DataSet GetRecursosDidacticos()
        {
            DataSet dsRecursos = new DataSet();
            XmlDataDocument xmldata = new XmlDataDocument();
            xmldata.DataSet.ReadXml(path);

            return xmldata.DataSet;
        }
    }
}