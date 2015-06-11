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
    public class EstrategiaEvaluativaBusiness
    {
        private EstrategiaEvaluativaData eeData;
        //

        public EstrategiaEvaluativaBusiness(String path)
        {
            eeData = new EstrategiaEvaluativaData(path);
        }

        public DataSet GetEstrategias()
        {
            return eeData.GetEstrategias();
        }

        public void InsertarEstrategia(EstrategiaEvaluativa estrategia)
        {
            eeData.InsertarEstrategia(estrategia);
        }

        public void EliminarEstrategia(EstrategiaEvaluativa estrategia)
        {
            eeData.EliminarEstrategia(estrategia);
        }

        public int ObtenerIndice()
        {
            return eeData.ObtenerIndice();
        }

        public void ActualizarEstrategia(EstrategiaEvaluativa estrategia)
        {
            eeData.ActualizarEstrategia(estrategia);
        }
    }
    
}
