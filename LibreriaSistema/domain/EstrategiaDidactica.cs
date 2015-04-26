using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.domain
{
    public class EstrategiaDidactica
    {
        private int indice;
        private String nombre;

        public EstrategiaDidactica()
        {

        }

        public EstrategiaDidactica(int indice, String nombre)
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
