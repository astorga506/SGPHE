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

        private RecursoDidacticoData rsData;

        public RecursoDidacticoBusiness(String path)
        {
            rsData = new RecursoDidacticoData(path);
        }

        public DataSet GetRecursosDidacticos()
        {
            return rsData.GetRecursosDidacticos();
        }

        public void InsertarRecursoDidactico(RecursoDidactico recurso)
        {
            rsData.InsertarRecursoDidactico(recurso);
        }

        public void EliminarRecursoDidactico(RecursoDidactico recurso)
        {
            rsData.EliminarRecursoDidactico(recurso);
        }
    }
}
