using LibreriaSistema.data;
using LibreriaSistema.domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.business
{
    public class RecordatorioBusiness
    {
        private RecordatorioData rd;

        public RecordatorioBusiness(String file)
        {
            rd = new RecordatorioData(file);
        }

        public void InsertarRecordatorio(Recordatorio recordatorio)
        {
            rd.InsertarRecordatorio(recordatorio);
        }

        public void EliminarRecordatorio(int codigo)
        {
            rd.EliminarRecordatorio(codigo);
        }

        public void EditarRecordatorio(Recordatorio recordatorio)
        {
            rd.EditarRecordatorio(recordatorio);
        }

        public ArrayList GetRecordatorios()
        {
            return rd.GetRecordatorios();
        }

        public Recordatorio GetRecordatorio(int codigo)
        {
            return rd.GetRecordatorio(codigo);
        }
    }
}
