using LibreriaSistema.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.business
{

  public  class EstrategiaDidacticaBusiness
    {
  private EstrategiaDidacticaData edData;

        public EstrategiaDidacticaBusiness(String path)
        {
            edData = new EstrategiaDidacticaData(path);
        }

        public DataSet GetEstrategias()
        {
            return edData.GetEstrategias();
        }

        public void InsertarEstrategia(EstrategiaDidactica estrategia)
        {
            edData.InsertarEstrategia(estrategia);
        }

        public void EliminarEstrategia(EstrategiaDidactica estrategia)
        {
            edData.EliminarEstrategia(estrategia);
        }

        public int ObtenerIndice()
        {
            return edData.ObtenerIndice();
        }

        public void ActualizarEstrategia(EstrategiaDidactica estrategia)
        {
            edData.ActualizarEstrategia(estrategia);
        }
    }
}
