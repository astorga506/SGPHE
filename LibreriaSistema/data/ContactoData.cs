using LibreriaSistema.domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LibreriaSistema.data
{
    public class ContactoData
    {
        private XDocument document;
        private String path;


        public ContactoData(String path)
        {
            this.path = path;
        }

        public void InsertarContacto(Contacto contacto)
        {
            if (!ExisteContacto(contacto.Codigo))
            {
                if (!File.Exists(path))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;

                    using (XmlWriter writer = XmlWriter.Create(path, settings))
                    {
                        writer.WriteStartElement("Contacto");
                        writer.WriteAttributeString("Index", "1");
                        writer.WriteStartElement("Persona");
                        writer.WriteElementString("Codigo", "1");
                        writer.WriteElementString("Nombre", contacto.Nombre);
                        writer.WriteElementString("Telefono", contacto.Telefono);
                        writer.WriteElementString("Direccion", contacto.Direccion);
                        writer.WriteElementString("Correo", contacto.Correo);
                        writer.WriteEndElement();
                        writer.Flush();
                    }
                    //ActualizarContador();
                }
                else
                {
                    document = XDocument.Load(path);
                    XElement nuevoContacto = new XElement("Persona",
                            new XElement("Codigo", ActualizarContador()),
                            new XElement("Nombre", contacto.Nombre),
                            new XElement("Telefono", contacto.Telefono),
                            new XElement("Direccion", contacto.Direccion),
                            new XElement("Correo", contacto.Correo)

                    );
                    document.Root.Add(nuevoContacto);
                    document.Save(path);
                }

            }
            else { throw new Exception(); }

        }
        public void EliminarContacto(int codigo)
        {
            if (ExisteContacto(codigo))
            {
                document = XDocument.Load(path);
                var itemDel = document.Root.Descendants("Persona");
                foreach (var itm in itemDel)
                {
                    int tmp = Int32.Parse(itm.Element("Codigo").Value);
                    if (codigo == tmp)
                    {
                        itm.Remove();
                        break;
                    }
                }
                document.Save(path);
            }
            else { throw new Exception(); }
        }

        public void EditarContacto(Contacto contacto)
        {
            if (ExisteContacto(contacto.Codigo))
            {
                document = XDocument.Load(path);
                foreach (XElement elm in document.Root.Elements())
                {
                    int tmp = Int32.Parse(elm.Element("Codigo").Value);
                    if (contacto.Codigo == tmp)
                    {
                        elm.SetElementValue("Nombre", contacto.Nombre);
                        elm.SetElementValue("Telefono", contacto.Telefono);
                        elm.SetElementValue("Direccion", contacto.Direccion);
                        elm.SetElementValue("Correo", contacto.Correo);
                        break;
                    }
                }

                document.Save(path);
            }

        }

        public Boolean ExisteContacto(int codigo)
        {
            if (File.Exists(path))
            {
                document = XDocument.Load(path);
                foreach (XElement elm in document.Root.Elements())
                {
                    int tmp = Int32.Parse(elm.Element("Codigo").Value);
                    if (codigo == tmp)
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        public ArrayList GetContactos()
        {            
            ArrayList contactos = new ArrayList();

            if (File.Exists(path))
            {
                document = XDocument.Load(path);
                foreach (XElement elm in document.Root.Elements())
                {
                    Contacto contacto = new Contacto();

                    contacto.Codigo = Int32.Parse(elm.Element("Codigo").Value);
                    contacto.Nombre = elm.Element("Nombre").Value;
                    contacto.Telefono = elm.Element("Telefono").Value;
                    contacto.Direccion = elm.Element("Direccion").Value;
                    contacto.Correo = elm.Element("Correo").Value;
                    contactos.Add(contacto);

                }
                
            }
            else
            {
                throw new FileNotFoundException();
            }

            return contactos;
        }


        public Contacto GetContacto(int codigo)
        {
            Contacto ret = new Contacto();
            if (ExisteContacto(codigo))
            {
                document = XDocument.Load(path);
                foreach (XElement elm in document.Root.Elements())
                {
                    int tmp = Int32.Parse(elm.Element("Codigo").Value);
                    if (codigo == tmp)
                    {
                        ret.Codigo = Int32.Parse(elm.Element("Codigo").Value);
                        ret.Nombre = elm.Element("Nombre").Value;
                        ret.Telefono = elm.Element("Telefono").Value;
                        ret.Direccion = elm.Element("Direccion").Value;
                        ret.Correo = elm.Element("Correo").Value;

                        break;
                    }
                }

            }

            return ret;
        }

        public ArrayList BuscarContacto(String buscar) 
        {
            ArrayList contactos = new ArrayList();

            if (File.Exists(path))
            {
                document = XDocument.Load(path);
                foreach (XElement elm in document.Root.Elements())
                {
                    if (elm.Element("Nombre").Value.IndexOf(buscar, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        Contacto contacto = new Contacto();

                        contacto.Codigo = Int32.Parse(elm.Element("Codigo").Value);
                        contacto.Nombre = elm.Element("Nombre").Value;
                        contacto.Telefono = elm.Element("Telefono").Value;
                        contacto.Direccion = elm.Element("Direccion").Value;
                        contacto.Correo = elm.Element("Correo").Value;
                        contactos.Add(contacto);
                    }
                    
                }
                
            }
            else
            {
                throw new FileNotFoundException();
            }

            return contactos;
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

    }
}
