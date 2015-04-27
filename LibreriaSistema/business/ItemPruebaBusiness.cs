﻿using LibreriaSistema.data;
using LibreriaSistema.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.business
{
    public class ItemPruebaBusiness
    {
        private ItemPruebaData ipData;

         public ItemPruebaBusiness(String path)
        {
            ipData = new ItemPruebaData(path);
        }

         public DataSet GetItemsPrueba()
        {
            return ipData.GetItemsPrueba();
        }

         public void InsertarItemPrueba(EstrategiaDidactica item)
        {
            ipData.InsertarItemPrueba(item);
        }

         public void EliminarRecursoPrueba(EstrategiaDidactica item)
        {
            ipData.EliminarRecursoPrueba(item);
        }

        public int ObtenerIndice()
        {
            return ipData.ObtenerIndice();
        }

        public void ActualizarItemPrueba(EstrategiaDidactica item)
        {
            ipData.ActualizarItemPrueba(item);
        }

    }
}
