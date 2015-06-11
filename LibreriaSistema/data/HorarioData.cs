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
    public class HorarioData
    {

          private XDocument document;
        private String path;

        public HorarioData(String path)
        {
            this.path = path;
        }

        public void InsertarHorario(Horario horario)
        {
         
                if (!File.Exists(path))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;                    

                    using (XmlWriter writer = XmlWriter.Create(path, settings))
                    {
                        writer.WriteStartElement("Horario");
                        //Se escribe cada fila individualmente, como la cantidad de 
                        //filas es estática no es necesario implementar un eliminar o insertar
                        foreach (DataRow item in horario.DataSetHorario.Tables[0].Rows)
                        { 
                            writer.WriteStartElement("Fila");
                            for (int i = 0; i < item.ItemArray.Length; i++)
                            {  
                               
                                writer.WriteElementString("Celda", item[i].ToString());
                                
                            }
                            writer.WriteEndElement(); 
                        }
                         writer.WriteEndElement();                   
                        writer.Flush();
                    }
                    //ActualizarContador();
                }
                else 
                {
                    File.Delete(path);
                    InsertarHorario(horario);
                }

                //this.ActualizarContador();
                
            }
           
        
       
        public DataSet GetHorarios() 
        {
            if (File.Exists(path))
            {
                DataSet DataSetHorario = new DataSet();
                DataTable tablaHorario = new DataTable();
                tablaHorario.TableName = "Horario";

                DataColumn columnaHoras = new DataColumn();
                DataColumn columnaLunes = new DataColumn();
                DataColumn columnaMartes = new DataColumn();
                DataColumn columnaMiercoles = new DataColumn();
                DataColumn columnaJueves = new DataColumn();
                DataColumn columnaViernes = new DataColumn();

                columnaHoras.ColumnName = "Hora";
                columnaLunes.ColumnName = "Lunes";
                columnaMartes.ColumnName = "Martes";
                columnaMiercoles.ColumnName = "Miercoles";
                columnaJueves.ColumnName = "Jueves";
                columnaViernes.ColumnName = "Viernes";

                columnaHoras.ReadOnly = true;
                columnaHoras.DataType = System.Type.GetType("System.String");
                columnaLunes.DataType = System.Type.GetType("System.String");
                columnaMartes.DataType = System.Type.GetType("System.String");
                columnaMiercoles.DataType = System.Type.GetType("System.String");
                columnaJueves.DataType = System.Type.GetType("System.String");
                columnaViernes.DataType = System.Type.GetType("System.String");

                tablaHorario.Columns.Add(columnaHoras);
                tablaHorario.Columns.Add(columnaLunes);
                tablaHorario.Columns.Add(columnaMartes);
                tablaHorario.Columns.Add(columnaMiercoles);
                tablaHorario.Columns.Add(columnaJueves);
                tablaHorario.Columns.Add(columnaViernes);

                document = XDocument.Load(path);
                foreach (XElement elm in document.Root.Elements())
                {
                    DataRow row1 = tablaHorario.NewRow();
                    row1["Hora"] = elm.Elements().ElementAt(0).Value.ToString();
                    row1["Lunes"] = elm.Elements().ElementAt(1).Value.ToString();
                    row1["Martes"] = elm.Elements().ElementAt(2).Value.ToString();
                    row1["Miercoles"] = elm.Elements().ElementAt(3).Value.ToString();
                    row1["Jueves"] = elm.Elements().ElementAt(4).Value.ToString();
                    row1["Viernes"] = elm.Elements().ElementAt(5).Value.ToString();
                    tablaHorario.Rows.Add(row1);
                }
                document.Save(path);
                DataSetHorario.Tables.Add(tablaHorario);
                return DataSetHorario;
            }
            else {
                document = new XDocument();
                
                XElement root = new XElement("Horario");
                XElement row0 = new XElement("Fila", new XElement("Celda", "7:00-7:40"), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""));
                XElement row1 = new XElement("Fila", new XElement("Celda", "7:40-8:20"), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""));
                XElement row2 = new XElement("Fila", new XElement("Celda", "8:20-8:30"), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""));
                XElement row3 = new XElement("Fila", new XElement("Celda", "8:30-9:10"), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""));
                XElement row4 = new XElement("Fila", new XElement("Celda", "9:10-9:50"), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""));
                XElement row5 = new XElement("Fila", new XElement("Celda", "9:50-10:30"), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""));
                XElement row6 = new XElement("Fila", new XElement("Celda", "10:30-11:10"), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""));
                XElement row7 = new XElement("Fila", new XElement("Celda", "11:10-11:40"), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""));
                XElement row8 = new XElement("Fila", new XElement("Celda", "11:40-12:20"), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""), new XElement("Celda", ""));

                root.Add(row0);
                root.Add(row1);
                root.Add(row2);
                root.Add(row3);
                root.Add(row4);
                root.Add(row5);
                root.Add(row6);
                root.Add(row7);
                root.Add(row8);

                document.Add(root);
                
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                XmlWriter writer =  XmlWriter.Create(path, settings);
                document.WriteTo(writer);
                writer.Flush();
                writer.Close();
               // document.Save(path);       
                return GetHorarios();
            }
            }
        
        }

    }
