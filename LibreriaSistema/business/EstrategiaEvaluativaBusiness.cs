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
        private EstrategiaEvaluativaData edData;

        public EstrategiaEvaluativaBusiness(String path)
        {
            edData = new EstrategiaEvaluativaData(path);

        }

        public DataSet GetEstrategias()
        {
            return edData.GetEstrategias();
        }

        public void InsertarEstrategia(EstrategiaEvaluativa estrategia)
        {
            edData.InsertarEstrategia(estrategia);
        }

        public void EliminarEstrategia(EstrategiaEvaluativa estrategia)
        {
            edData.EliminarEstrategia(estrategia);
        }

        public int ObtenerIndice()
        {
            return edData.ObtenerIndice();
        }

        public void ActualizarEstrategia(EstrategiaEvaluativa estrategia)
        {
            edData.ActualizarEstrategia(estrategia);
        }
    }
}