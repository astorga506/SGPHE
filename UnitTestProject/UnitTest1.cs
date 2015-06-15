using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaSistema;
using LibreriaSistema.domain;
using System.Data;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Horario horario = new Horario();
            HorarioData horarioData = new HorarioData("\\Prueba\\Horario.xml");
            horarioData.InsertarHorario(horario);
            foreach (DataRow item in horario.DataSetHorario.Tables[0].Rows)
            {
                for (int i = 0; i < item.ItemArray.Length; i++)
                {
                    Console.Out.Write(item[i] + " ");
                }
                Console.Out.WriteLine();
            }

            //DataSet data = horarioData.GetHorarios();
            //foreach (DataRow item in data.Tables[0].Rows)
            //{
            //    for (int i = 0; i < item.ItemArray.Length; i++)
            //    {
            //        Console.Out.Write(item[i] + " ");
            //    }
            //    Console.Out.WriteLine();
            //}
        }
    }
}
