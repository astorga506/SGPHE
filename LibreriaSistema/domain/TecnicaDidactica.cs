using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.domain
{
   public class TecnicaDidactica
    {
        private int indice;
        private String nombre;
        public TecnicaDidactica()
        {

        }
        public TecnicaDidactica(int indice, String nombre)
        {
            this.indice = indice;
            this.nombre = nombre;
        }
        public void setIndice(int indice){
            this.indice=indice;
        }
        public int getIndice()
        {
           return this.indice;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String getNombre()
        {
           return this.nombre;
        }
    }
}
