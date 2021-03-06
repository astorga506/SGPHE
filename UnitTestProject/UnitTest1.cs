﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaSistema;
using LibreriaSistema.domain;
using System.Data;
using System.Data.SqlClient;
using SistemaGestorRecursosDidacticos;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SqlConnection cn = new SqlConnection();
            DSPlaneamiento PlaneamientDataSet = new DSPlaneamiento();
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
                String queryPlaneamiento = "INSERT INTO Planeamiento (Docente,Asignatura,Unidad,Fecha_Inicio,Fecha_Fin,Aprendizaje,Estrategia_Mediacion,Nivel)" +
                "OUTPUT INSERTED.ID VALUES(@docente,@asignatura,@unidad,@f_inicio,@f_fin,@aprendizaje,@estrategia_med,@nivel)";
                SqlCommand commandPlaneamiento = new SqlCommand(queryPlaneamiento, cn);
                commandPlaneamiento.Transaction = transaction;
                //commandPlaneamiento.Parameters.AddWithValue("@id", "abc");
                commandPlaneamiento.Parameters.AddWithValue("@docente", "Alberto");
                commandPlaneamiento.Parameters.AddWithValue("@asignatura", "Matematica");
                commandPlaneamiento.Parameters.AddWithValue("@unidad", "Geometría");
                commandPlaneamiento.Parameters.AddWithValue("@f_inicio", "25/05/2015");
                commandPlaneamiento.Parameters.AddWithValue("@f_fin", "12/06/2015");
                commandPlaneamiento.Parameters.AddWithValue("@aprendizaje", "Calculo de areas");
                commandPlaneamiento.Parameters.AddWithValue("@estrategia_med", "Prácticas");
                commandPlaneamiento.Parameters.AddWithValue("@nivel", "III");
                //commandPlaneamiento.ExecuteNonQuery();
                Int32 newId = (Int32)commandPlaneamiento.ExecuteScalar();

                String queryElementos = "INSERT INTO ElementosPlaneamiento(Id_Planeamiento,EstrategiaEvaluacion)VALUES(@id,@estrategia_evaluacion)";
                SqlCommand commandElementos = new SqlCommand(queryElementos, cn);
                commandElementos.Transaction = transaction;
                commandElementos.Parameters.AddWithValue("@id", newId);
                commandElementos.Parameters.AddWithValue("@estrategia_evaluacion", "Es capaz de determinar las formulas");
                commandElementos.ExecuteNonQuery();
                SqlCommand commandElementos2 = new SqlCommand(queryElementos, cn);
                commandElementos2.Transaction = transaction;
                commandElementos2.Parameters.AddWithValue("@id", newId);
                commandElementos2.Parameters.AddWithValue("@estrategia_evaluacion", "Calcula el área");
                commandElementos2.ExecuteNonQuery(); 
                SqlCommand commandElementos3 = new SqlCommand(queryElementos, cn);
                commandElementos3.Transaction = transaction;
                commandElementos3.Parameters.AddWithValue("@id", newId);
                commandElementos3.Parameters.AddWithValue("@estrategia_evaluacion", "Puede explicar el procedimiento");
                commandElementos3.ExecuteNonQuery();
                transaction.Commit();

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



            cn.Close();
        }
    }
}
