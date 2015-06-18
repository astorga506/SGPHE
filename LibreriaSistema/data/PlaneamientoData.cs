using SistemaGestorRecursosDidacticos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.data
{
    public class PlaneamientoData
    {
        public PlaneamientoData()
        {

        }
        public void insertarPlaneamiento(DSPlaneamiento ds)
        {
            SqlConnection cn = new SqlConnection();
            //DSPlaneamiento PlaneamientDataSet = new DSPlaneamiento();
            SqlDataAdapter da;
            SqlCommandBuilder cmdBuilder;
            SqlTransaction transaction;
            //Set the connection string of the SqlConnection object to connect
            //to the SQL Server database in which you created the sample
            //table.
            cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            cn.Open();

            transaction = cn.BeginTransaction("SampleTransaction");

            try
            {
                DataRow datos = ds.Tables["Planeamiento"].Rows[0];
                String queryPlaneamiento = "INSERT INTO Planeamiento (Docente,Asignatura,Unidad,Fecha_Inicio,Fecha_Fin,Aprendizaje,Estrategia_Mediacion,Nivel)" +
                "OUTPUT INSERTED.ID VALUES(@docente,@asignatura,@unidad,@f_inicio,@f_fin,@aprendizaje,@estrategia_med,@nivel)";
                SqlCommand commandPlaneamiento = new SqlCommand(queryPlaneamiento, cn);
                commandPlaneamiento.Transaction = transaction;
                //commandPlaneamiento.Parameters.AddWithValue("@id", "abc");
                commandPlaneamiento.Parameters.AddWithValue("@docente", datos["Docente"]);
                commandPlaneamiento.Parameters.AddWithValue("@asignatura", datos["Asignatura"]);
                commandPlaneamiento.Parameters.AddWithValue("@unidad", datos["Unidad"]);
                commandPlaneamiento.Parameters.AddWithValue("@f_inicio", datos["Fecha_Inicio"]);
                commandPlaneamiento.Parameters.AddWithValue("@f_fin", datos["Fecha_Fin"]);
                commandPlaneamiento.Parameters.AddWithValue("@aprendizaje", datos["Aprendizaje"]);
                commandPlaneamiento.Parameters.AddWithValue("@estrategia_med", datos["Estrategia_Mediacion"]);
                commandPlaneamiento.Parameters.AddWithValue("@nivel", datos["Nivel"]);
                //commandPlaneamiento.ExecuteNonQuery();
                Int32 newId = (Int32)commandPlaneamiento.ExecuteScalar();
                String queryElementos = "INSERT INTO ElementosPlaneamiento(Id_Planeamiento,EstrategiaEvaluacion)VALUES(@id,@estrategia_evaluacion)";

                foreach (DataRow item in ds.Tables["ElementosPlaneamiento"].Rows)
                {
                    SqlCommand commandElementos = new SqlCommand(queryElementos, cn);
                    commandElementos.Transaction = transaction;
                    commandElementos.Parameters.AddWithValue("@id", newId);
                    commandElementos.Parameters.AddWithValue("@estrategia_evaluacion", item["EstrategiaEvaluacion"]);
                    commandElementos.ExecuteNonQuery();
                }

                transaction.Commit();
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);

                // Attempt to roll back the transaction. 
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred 
                    // on the server that would cause the rollback to fail, such as 
                    // a closed connection.
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }
            finally { cn.Close(); }
           
        }
    }
}
