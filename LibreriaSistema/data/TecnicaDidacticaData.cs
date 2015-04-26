
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
        public void InsertarTecnicaDidactica(TecnicaDidactica tecnica)
        {
            if (!ExisteTecnica(tecnica))
            {
                if (!File.Exists(path))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;

                    using (XmlWriter writer = XmlWriter.Create(path, settings))
                    {
                        writer.WriteStartElement("TecnicasDidacticas");
                        writer.WriteAttributeString("Index", "0");
                        writer.WriteStartElement("Tecnica");
                        writer.WriteElementString("Indice", tecnica.Indice.ToString());
                        writer.WriteElementString("Nombre", tecnica.Nombre);
                        writer.WriteEndElement();
                        writer.Flush();
                    }
                    //ActualizarContador();
                }
                else
                {
                    document = XDocument.Load(path);
                    XElement nuevoRecurso = new XElement("Tecnica",
                            new XElement("Indice", tecnica.Indice.ToString()),
                            new XElement("Nombre", tecnica.Nombre)

                    );
                    document.Root.Add(nuevoRecurso);
                    document.Save(path);
                }
                this.ActualizarContador();

            }
            else { throw new FormatException(); }

        }
        public void EliminarTecnicaDidactico(TecnicaDidactica tecnica)
        {
            if (ExisteTecnica(tecnica))
            {
                document = XDocument.Load(path);
                var tecnicaDel = document.Root.Descendants("Tecnica");
                foreach (var item in tecnicaDel)
                {
                    int tmp = Convert.ToInt32(item.Element("Indice").Value);
                    if (tecnica.Indice.Equals(tmp))
                    {
                        item.Remove();
                        break;
                    }
                }
                document.Save(path);
            }
        }

        public void ActualizarTecnicaDidactico(TecnicaDidactica tecnica)
        {
            if (ExisteTecnica(tecnica))
            {
                document = XDocument.Load(path);
                foreach (XElement item in document.Root.Elements())
                {
                    int indice = Convert.ToInt32(item.Element("Indice").Value);
                    if (tecnica.Indice.Equals(indice))
                    {
                        item.SetElementValue("Nombre", tecnica.Nombre);
                        break;
                    }
                }

                document.Save(path);
            }

        }

        private Boolean ExisteTecnica(TecnicaDidactica tecnica)
        {
            if (File.Exists(path))
            {
                document = XDocument.Load(path);
                foreach (XElement item in document.Root.Elements())
                {
                    int tmp = Convert.ToInt32(item.Element("Indice").Value);
                    if (tmp.Equals(tecnica.Indice))
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

        public DataSet GetTecnicasDidacticos()
        {
            DataSet dsTecnicas = new DataSet();
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
