using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.domain
{
    public class RecursoDidactico
    {
        private String autor;
        private String titulo;
        private String enlace;

        public RecursoDidactico()
        {

        }

        public RecursoDidactico(String enlace, String titulo, String autor)
        {
            this.enlace = enlace;
            this.titulo = titulo;
            this.autor = autor;
        }
        public String Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }
        

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        

        public String Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        
    }
}
