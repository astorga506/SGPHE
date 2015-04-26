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
    public class ItemPruebaData
    {
     
        private XDocument document;
        private String path;

        public ItemPruebaData(String path)
        {
            this.path = path;
        }

        public void InsertarItemPrueba(ItemPrueba item)
        {
            if (!ExisteItem(item))
            {
                if (!File.Exists(path))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;                    

                    using (XmlWriter writer = XmlWriter.Create(path, settings))
                    {
                        writer.WriteStartElement("ItemPrueba");
                        writer.WriteAttributeString("Index", "0");
                        writer.WriteStartElement("Item");
                        writer.WriteElementString("Indice", item.Indice.ToString());
                        writer.WriteElementString("Nombre", item.Nombre);
                        writer.WriteEndElement();                        
                        writer.Flush();
                    }
                    //ActualizarContador();
                }
                else 
                {
                    document = XDocument.Load(path);
                    XElement nuevoItem = new XElement("Item",
                            new XElement("Indice", item.Indice),
                            new XElement("Nombre", item.Nombre)
                        
                    );
                    document.Root.Add(nuevoItem);
                    document.Save(path);       
                }

                this.ActualizarContador();
                
            }
            else { throw new FormatException(); }

        }
        public void EliminarRecursoPrueba(ItemPrueba item)
        {
            if (ExisteItem(item))
            {
                document = XDocument.Load(path);
                var itemDel = document.Root.Descendants("Item");
                foreach (var itm in itemDel)
                {
                    int tmp = Convert.ToInt32(itm.Element("Indice").Value);
                    if (item.Indice.Equals(tmp))
                    {
                        itm.Remove();
                        break;
                    }
                }
                document.Save(path);
            }
        }

        public void ActualizarItemPrueba(ItemPrueba item)
        {
            if (ExisteItem(item))
            {
                document = XDocument.Load(path);                
                foreach (XElement elm in document.Root.Elements())
                {
                    int indice = Convert.ToInt32(elm.Element("Indice").Value);
                    if (item.Indice.Equals(indice))
                    {
                        elm.SetElementValue("Nombre", item.Nombre);
                        break;
                    }
                }

                document.Save(path);
            }

        }

        public Boolean ExisteItem(ItemPrueba item)
        {
            if (File.Exists(path))
            {
                document = XDocument.Load(path);
                foreach (XElement elm in document.Root.Elements())
                {
                    int tmp = Convert.ToInt32(elm.Element("Indice").Value);
                    if (tmp.Equals(item.Indice))
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

        public DataSet GetItemsPrueba() 
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
