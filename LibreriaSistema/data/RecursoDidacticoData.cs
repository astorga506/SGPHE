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
                        writer.WriteAttributeString("Index", "0");
                        writer.WriteStartElement("Recurso");
                        writer.WriteElementString("Indice", recurso.Indice.ToString());
                        writer.WriteElementString("Nombre", recurso.Nombre);
                        writer.WriteEndElement();                        
                        writer.Flush();
                    }
                    //ActualizarContador();
                }
                else 
                {
                    document = XDocument.Load(path);
                    XElement nuevoRecurso = new XElement("Recurso",
                            new XElement("Indice", recurso.Indice),
                            new XElement("Nombre", recurso.Nombre)
                        
                    );
                    document.Root.Add(nuevoRecurso);
                    document.Save(path);       
                }

                this.ActualizarContador();
                
            }
            else { throw new FormatException(); }

        }
        public void EliminarRecursoDidactico(RecursoDidactico recurso)
        {
            if (ExisteRecurso(recurso))
            {
                document = XDocument.Load(path);
                var recursoDel = document.Root.Descendants("Recurso");
                foreach (var item in recursoDel)
                {
                    int tmp = Convert.ToInt32(item.Element("Indice").Value);
                    if (recurso.Indice.Equals(tmp))
                    {
                        item.Remove();
                        break;
                    }
                }
                document.Save(path);
            }
        }

        public void ActualizarRecursoDidactico(RecursoDidactico recurso)
        {
            if (ExisteRecurso(recurso))
            {
                document = XDocument.Load(path);                
                foreach (XElement item in document.Root.Elements())
                {
                    int indice = Convert.ToInt32(item.Element("Indice").Value);
                    if (recurso.Indice.Equals(indice))
                    {
                        item.SetElementValue("Nombre", recurso.Nombre);
                        break;
                    }
                }

                document.Save(path);
            }

        }

        public Boolean ExisteRecurso(RecursoDidactico recurso)
        {
            if (File.Exists(path))
            {
                document = XDocument.Load(path);
                foreach (XElement item in document.Root.Elements())
                {
                    int tmp = Convert.ToInt32(item.Element("Indice").Value);
                    if (tmp.Equals(recurso.Indice))
                    {
                        return true;        
                    }
                }
                document.Save(path);
            }

            return false;
        }

        private int ActualizarContador()
        {
            document = XDocument.Load(path);
            int i = Convert.ToInt32(document.Root.Attribute("Index").Value);
            i += 1;
            document.Root.SetAttributeValue("Index", i);
            document.Save(path);

            return i;
        }

        public int ObtenerIndice()
        {
            if (!File.Exists(path))
            {
                return 1;
            }
            else
            {
                document = XDocument.Load(path);
                int i = Convert.ToInt32(document.Root.Attribute("Index").Value);
                return ++i;
            
            }            
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