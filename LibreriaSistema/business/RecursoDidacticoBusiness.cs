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
    }
}
