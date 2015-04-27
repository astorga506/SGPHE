using LibreriaSistema.data;
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

         public void InsertarItemPrueba(ItemPrueba item)
        {
            ipData.InsertarItemPrueba(item);
        }

         public void EliminarItemPrueba(ItemPrueba item)
        {
            ipData.EliminarItemPrueba(item);
        }

        public int ObtenerIndice()
        {
            return ipData.ObtenerIndice();
        }

        public void ActualizarItemPrueba(ItemPrueba item)
        {
            ipData.ActualizarItemPrueba(item);
        }

    }
}
