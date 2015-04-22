using LibreriaSistema.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
        public void InsertarRecursoDidactico(RecursoDidactico recurso)
        {
            if (!ExisteRecurso(recurso))
            {
                if (!File.Exists(path))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;                    

                    using (XmlWriter writer = XmlWriter.Create(path, settings))
                    {
                        writer.WriteStartElement("RecursosDidacticos");
                        writer.WriteStartElement("Recurso");
                        writer.WriteElementString("Autor", recurso.Autor);
                        writer.WriteElementString("Titulo", recurso.Titulo);
                        writer.WriteElementString("Enlace", recurso.Enlace);
                        writer.WriteEndElement();
                        writer.Flush();
                    }
                }
                else 
                {
                    document = XDocument.Load(path);
                    XElement nuevoRecurso = new XElement("Recurso",
                            new XElement("Autor", recurso.Autor),
                            new XElement("Titulo", recurso.Titulo),
                            new XElement("Enlace", recurso.Enlace)
                        
                    );
                    document.Root.Add(nuevoRecurso);
                    document.Save(path);                
                }
                
            }
            else { throw new FormatException(); }

        }
        public void EliminarRecursoDidactico(RecursoDidactico recurso)
        {
            if (ExisteRecurso(recurso))
            {
                document = XDocument.Load(path);
                var recursoDel = document.Root.Descendants("Recursos");
                foreach (var item in recursoDel)
                {
                    String tmp = item.Element("Enlace").Value.ToString();
                    if (recurso.Enlace.Equals(tmp))
                    {
                        item.Remove();
                        break;
                    }
                }
                document.Save(path);
            }
        }

        //public void actualizarRecursoDidactico(RecursoDidactico recurso)
        //{
        //    if (existeRecurso(recurso))
        //    {
        //        document = XDocument.Load(path);
        //        var estrategiaDelete = document.Root.Descendants("recurso");
        //        foreach (var item in estrategiaDelete)
        //        {
        //            int indice = Convert.ToInt32(item.Element("indice").Value);
        //            if (recurso.getIndice().Equals(indice))
        //            {
        //                item.SetElementValue("indice", recurso.getIndice().ToString());
        //                item.SetElementValue("nombre", recurso.getNombre());
        //                break;
        //            }
        //        }

        //        document.Save(path);
        //    }

        //}

        public Boolean ExisteRecurso(RecursoDidactico recurso)
        {
            if (File.Exists(path))
            {
                document = XDocument.Load(path);
                foreach (XElement item in document.Root.Elements())
                {
                    String tmp = item.Element("Enlace").Value.ToString();
                    if (tmp.Equals(recurso.Enlace))
                    {                        
                        item.Remove();                
                    }
                }
                document.Save(path);
            }

            return false;
        }


        

        public DataSet GetRecursosDidacticos() 
        {
            DataSet dsRecursos = new DataSet();
            XmlDataDocument xmldata = new XmlDataDocument();
            try
            {
                xmldata.DataSet.ReadXml(path);
            }
            catch (FileNotFoundException fnfe) 
            {
                throw fnfe;
            }            

            return xmldata.DataSet;
        }
    }
}