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
    class EstrategiaEvaluativaData
    {
         
        private XDocument document;
        private String path;

        public EstrategiaEvaluativaData(String path)
        {
            this.path = path;
        }

        public void InsertarEstrategia(EstrategiaEvaluativa estrategia)
        {
            if (!ExisteEstategia(estrategia))
            {
                if (!File.Exists(path))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;                    

                    using (XmlWriter writer = XmlWriter.Create(path, settings))
                    {
                        writer.WriteStartElement("EstrategiaEvaluativa");
                        writer.WriteAttributeString("Index", "0");
                        writer.WriteStartElement("Estrategia");
                        writer.WriteElementString("Indice", estrategia.Indice.ToString());
                        writer.WriteElementString("Nombre", estrategia.Nombre);
                        writer.WriteEndElement();                        
                        writer.Flush();
                    }
                    //ActualizarContador();
                }
                else 
                {
                    document = XDocument.Load(path);
                    XElement nuevaEstrategia = new XElement("Estrategia",
                            new XElement("Indice", estrategia.Indice),
                            new XElement("Nombre", estrategia.Nombre)
                        
                    );
                    document.Root.Add(nuevaEstrategia);
                    document.Save(path);       
                }

                this.ActualizarContador();
                
            }
            else { throw new FormatException(); }

        }
        public void EliminarEstrategia(EstrategiaEvaluativa estrategia)
        {
            if (ExisteEstategia(estrategia))
            {
                document = XDocument.Load(path);
                var itemDel = document.Root.Descendants("Item");
                foreach (var itm in itemDel)
                {
                    int tmp = Convert.ToInt32(itm.Element("Indice").Value);
                    if (estrategia.Indice.Equals(tmp))
                    {
                        itm.Remove();
                        break;
                    }
                }
                document.Save(path);
            }
        }

        public void ActualizarEstrategia(EstrategiaEvaluativa estrategia)
        {
            if (ExisteEstategia(estrategia))
            {
                document = XDocument.Load(path);                
                foreach (XElement elm in document.Root.Elements())
                {
                    int indice = Convert.ToInt32(elm.Element("Indice").Value);
                    if (estrategia.Indice.Equals(indice))
                    {
                        elm.SetElementValue("Nombre", estrategia.Nombre);
                        break;
                    }
                }

                document.Save(path);
            }

        }

        public Boolean ExisteEstategia(EstrategiaEvaluativa estrategia)
        {
            if (File.Exists(path))
            {
                document = XDocument.Load(path);
                foreach (XElement elm in document.Root.Elements())
                {
                    int tmp = Convert.ToInt32(elm.Element("Indice").Value);
                    if (tmp.Equals(estrategia.Indice))
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

        public DataSet GetEstrategias() 
        {
            DataSet dsItems = new DataSet();
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
