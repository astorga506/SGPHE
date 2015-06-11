using LibreriaSistema.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.business
{
    public class HorarioBusiness
    {
        private HorarioData hData;

        public HorarioBusiness(String path)
        {
            hData = new HorarioData(path);
        }

        public DataSet GetHorarios()
        {
            return hData.GetHorarios();
        }

        public void InsertarHorario(Horario horario)
        {
            hData.InsertarHorario(horario);
        }

        //public void EliminarHorario(Horario horario)
        //{
        //    hData.EliminarHorario(horario);
        //}

        //public int ObtenerIndice()
        //{
        //    return hData.ObtenerIndice();
        //}

        //public void ActualizarHorario(Horario horario)
        //{
        //    hData.ActualizarHorario(horario);
        //}
    }
    }

