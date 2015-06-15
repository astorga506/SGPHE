using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.domain
{
    public class Horario
    {

        public DataSet DataSetHorario { get; set; }
        public Horario()
        {
            DataSetHorario = new DataSet();
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

            DataRow row1 = tablaHorario.NewRow();
            row1["Hora"] = "07:00 am";
            row1["Lunes"] = "4-5";
            row1["Martes"] = "6-3";
            row1["Miercoles"] = "3-1";
            row1["Jueves"] = "5-5";
            row1["Viernes"] = "6-2";

            tablaHorario.Rows.Add(row1);
            DataRow row2 = tablaHorario.NewRow();
            row2["Hora"] = "07:40 am";
            row2["Lunes"] = "4-5";
            row2["Martes"] = "6-3";
            row2["Miercoles"] = "3-1";
            row2["Jueves"] = "5-5";
            row2["Viernes"] = "6-2";

            tablaHorario.Rows.Add(row2);
            DataRow row3 = tablaHorario.NewRow();
            row3["Hora"] = "08:20 am";
            row3["Lunes"] = "6-3";
            row3["Martes"] = "2-4";
            row3["Miercoles"] = "3-2";
            row3["Jueves"] = "4-3";
            row3["Viernes"] = "5-5";

            tablaHorario.Rows.Add(row3);

            DataSetHorario.Tables.Add(tablaHorario);

        }

        public DataSet GetHorario() {
            return DataSetHorario;
        }
    }
}
