using LibreriaSistema.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibreriaSistema.data
{
    class ItemPruebaData
    {
         
        private XDocument document;
        private String path;

        public ItemPruebaData(String path)
        {
            this.path = path;
        }
        public void insertarItem(ItemPrueba item) {
            if (!existeItem(item))
            {
                document = XDocument.Load(path);
                XElement elementEstrategia = new XElement("item",
                    new XElement("indice", item.getIndice().ToString()),
                    new XElement("nombre", item.getNombre())
                    );
                document.Root.Add(elementEstrategia);
                document.Save(path);
            }
            else { throw new FormatException();}

        }
        public void eliminarItem(ItemPrueba item)
        {
            if (existeItem(item))
            {
                document = XDocument.Load(path);
                var estrategiaDelete = document.Root.Descendants("item");
                foreach (var tmp in estrategiaDelete)
                {
                    int indice = Convert.ToInt32(tmp.Element("indice").Value);
                    if (item.getIndice().Equals(indice))
                    {
                        tmp.Remove();
                        break;
                    }
                }
                document.Save(path);
            }
        }
        public LinkedList<ItemPrueba> getEItem()
        {
            document = XDocument.Load(path);
            LinkedList<ItemPrueba> estrategias = new LinkedList<ItemPrueba>();
            foreach (XElement tmp in document.Nodes())
            {
                ItemPrueba item = new ItemPrueba();
                item.setIndice(Convert.ToInt32(tmp.Attribute("indice").Value));
                item.setNombre(tmp.Element("nombre").Value);
                estrategias.AddLast(item);
            }
            return estrategias;
        
        }
        public void actualizarItem(ItemPrueba item)
        {
            if (existeItem(item))
            {
                document = XDocument.Load(path);
                var estrategiaDelete = document.Root.Descendants("item");
                foreach (var tmp in estrategiaDelete)
                {
                    int indice = Convert.ToInt32(tmp.Element("indice").Value);
                    if (item.getIndice().Equals(indice))
                    {
                        //item.SetElementValue("indice", estrategia.getIndice().ToString());
                        tmp.SetElementValue("nombre", item.getNombre());
                        break;
                    }
                }

                document.Save(path);
            }
        
        }
        public Boolean existeItem(ItemPrueba item) {
            document = XDocument.Load(path);
            var estrategiaDelete = document.Root.Descendants("item");
            foreach (var tmp in estrategiaDelete)
            {
                int indice = Convert.ToInt32(tmp.Element("indice").Value);
                if (item.getIndice().Equals(indice))
                {
                    return true;
                }
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
            document = XDocument.Load(path);
            int i = Convert.ToInt32(document.Root.Attribute("Index").Value);
            return ++i;
        }
    }
}
