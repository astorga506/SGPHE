using LibreriaSistema.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.business
{
    public class RecursoDidacticoBusiness
    {

        private RecursoDidacticoData rdData;

        public RecursoDidacticoBusiness(String path)
        {
            rdData = new RecursoDidacticoData(path);
        }

        public DataSet GetRecursosDidacticos()
        {
            return rdData.GetRecursosDidacticos();
        }

        public void InsertarRecursoDidactico(RecursoDidactico recurso)
        {
            rdData.InsertarRecursoDidactico(recurso);
        }

        public void EliminarRecursoDidactico(RecursoDidactico recurso)
        {
            rdData.EliminarRecursoDidactico(recurso);
        }

        public int ObtenerIndice()
        {
            return rdData.ObtenerIndice();
        }

        public void ActualizarRecursoDidactico(RecursoDidactico recurso)
        {
            rdData.ActualizarRecursoDidactico(recurso);
        }
    }
}
