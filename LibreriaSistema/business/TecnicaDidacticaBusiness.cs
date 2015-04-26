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
    public class TecnicaDidacticaBusiness
    {
        private TecnicaDidacticaData tdData;

        public TecnicaDidacticaBusiness(String path)
        {
            tdData = new TecnicaDidacticaData(path);
        }

        public void InsertarTecnicaDidactica(TecnicaDidactica tecnica)
        {
            tdData.InsertarTecnicaDidactica(tecnica);

        }

        public DataSet GetTecnicasDidacticos()
        {
            return tdData.GetTecnicasDidacticos();
        }

        public void ActualizarTecnicaDidactico(TecnicaDidactica tecnica)
        {
            tdData.ActualizarTecnicaDidactico(tecnica);
        }

        public void EliminarTecnicaDidactico(TecnicaDidactica tecnica)
        {
            tdData.EliminarTecnicaDidactico(tecnica);
        }

        public int ObtenerIndice() 
        {
            return tdData.ObtenerIndice();
        }

    }
}
