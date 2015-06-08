using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.domain
{
    public class Contacto
    {
        private String nombre;
        private String telefono;
        private String direccion;
        private String correo;
        private int codigo;

        public Contacto(int codigo, String nombre, String telefono, String direccion, String correo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correo = correo;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }      

        public Contacto()
        {

        }

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

    }
}
