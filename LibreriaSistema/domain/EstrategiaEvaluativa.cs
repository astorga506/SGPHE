using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.domain
{
    public class EstrategiaEvaluativa
    {
        private int indice;
        private String nombre;

        public EstrategiaEvaluativa()
        {

        }
        public EstrategiaEvaluativa(int indice, String nombre)
        {
            this.indice = indice;
            this.nombre = nombre;
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Indice
        {
            get { return indice; }
            set { indice = value; }
        }
    }
}
