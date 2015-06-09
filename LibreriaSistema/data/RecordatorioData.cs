using LibreriaSistema.domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LibreriaSistema.data
{
    public class RecordatorioData
    {
        private XDocument document;
        private String path;


        public RecordatorioData(String path)
        {
            this.path = path;
        }

        public void InsertarRecordatorio(Recordatorio recordatorio)
        {
            if (!ExisteRecordatorio(recordatorio.Codigo))
            {
                if (!File.Exists(path))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;

                    using (XmlWriter writer = XmlWriter.Create(path, settings))
                    {
                        writer.WriteStartElement("Agenda");
                        writer.WriteAttributeString("Index", "1");
                        writer.WriteStartElement("Recordatorio");
                        writer.WriteElementString("Codigo", "1");
                        writer.WriteElementString("Titulo", recordatorio.Titulo);
                        writer.WriteElementString("Descripcion", recordatorio.Descripcion);
                        writer.WriteElementString("Lugar", recordatorio.Lugar);
                        writer.WriteElementString("FechaInicio", recordatorio.FechaInicio.ToString());
                        writer.WriteElementString("FechaFin", recordatorio.FechaFin.ToString());
                        writer.WriteEndElement();
                        writer.Flush();
                    }
                    //ActualizarContador();
                }
                else
                {
                    document = XDocument.Load(path);
                    XElement nuevoContacto = new XElement("Recordatorio",
                            new XElement("Codigo", ActualizarContador()),
                            new XElement("Titulo", recordatorio.Titulo),
                            new XElement("Descripcion", recordatorio.Descripcion),
                            new XElement("Lugar", recordatorio.Lugar),
                            new XElement("FechaInicio", recordatorio.FechaInicio.ToString()),
                            new XElement("FechaFin", recordatorio.FechaFin.ToString())

                    );
                    document.Root.Add(nuevoContacto);
                    document.Save(path);
                }

            }
            else { throw new Exception(); }

        }

        public void EliminarRecordatorio(int codigo)
        {
            if (ExisteRecordatorio(codigo))
            {
                document = XDocument.Load(path);
                var itemDel = document.Root.Descendants("Recordatorio");
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

        public void EditarRecordatorio(Recordatorio recordatorio)
        {
            if (ExisteRecordatorio(recordatorio.Codigo))
            {
                document = XDocument.Load(path);
                foreach (XElement elm in document.Root.Elements())
                {
                    int tmp = Int32.Parse(elm.Element("Codigo").Value);
                    if (recordatorio.Codigo == tmp)
                    {
                        elm.SetElementValue("Titulo", recordatorio.Titulo);
                        elm.SetElementValue("Descripcion", recordatorio.Descripcion);
                        elm.SetElementValue("Lugar", recordatorio.Lugar);
                        elm.SetElementValue("FechaInicio", recordatorio.FechaInicio);
                        elm.SetElementValue("FechaFin", recordatorio.FechaFin);
                        break;
                    }
                }

                document.Save(path);
            }

        }

        public Boolean ExisteRecordatorio(int codigo)
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

        public ArrayList GetRecordatorios()
        {
            ArrayList recordatorios = new ArrayList();

            if (File.Exists(path))
            {
                document = XDocument.Load(path);

                if (document.Root.HasElements)
                {
                    foreach (XElement elm in document.Root.Elements())
                    {
                        Recordatorio recordatorio = new Recordatorio();

                        recordatorio.Codigo = Int32.Parse(elm.Element("Codigo").Value);
                        recordatorio.Titulo = elm.Element("Titulo").Value;
                        recordatorio.Descripcion = elm.Element("Descripcion").Value;
                        recordatorio.Lugar = elm.Element("Lugar").Value;
                        recordatorio.FechaInicio = DateTime.Parse(elm.Element("FechaInicio").Value);
                        recordatorio.FechaFin = DateTime.Parse(elm.Element("FechaFin").Value);
                        recordatorios.Add(recordatorio);

                    }
                }
                else { throw new Exception(); }

            }

            return recordatorios;
        }


        public Recordatorio GetRecordatorio(int codigo)
        {
            Recordatorio recordatorio = new Recordatorio();
            if (ExisteRecordatorio(codigo))
            {
                document = XDocument.Load(path);
                foreach (XElement elm in document.Root.Elements())
                {
                    int tmp = Int32.Parse(elm.Element("Codigo").Value);
                    if (codigo == tmp)
                    {                        
                        recordatorio.Codigo = codigo;
                        recordatorio.Titulo = elm.Element("Titulo").Value;
                        recordatorio.Descripcion = elm.Element("Descripcion").Value;
                        recordatorio.Lugar = elm.Element("Lugar").Value;
                        recordatorio.FechaInicio = DateTime.Parse(elm.Element("FechaInicio").Value);
                        recordatorio.FechaFin = DateTime.Parse(elm.Element("FechaFin").Value);

                        break;
                    }
                }

            }

            return recordatorio;
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
