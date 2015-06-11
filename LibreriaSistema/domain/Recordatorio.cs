using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.domain
{
    public class Recordatorio
    {
        private int codigo;        
        private String titulo;
        private String descripcion;
        private String lugar;        
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public Recordatorio()
        {

        }

        public Recordatorio(int codigo, String titulo, String descripcion, String lugar, DateTime fechaInicio, DateTime fechaFin)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.lugar = lugar;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public String Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }


        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        
    }
}
