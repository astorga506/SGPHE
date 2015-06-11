using LibreriaSistema.data;
using LibreriaSistema.domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSistema.business
{
    public class ContactoBusiness
    {
        private ContactoData cd;


        public ContactoBusiness(String file)
        {
            cd = new ContactoData(file);
        }

        public void InsertarContacto(Contacto contacto) 
        {
            cd.InsertarContacto(contacto);
        }

        public void EliminarContacto(int codigo)
        {
            cd.EliminarContacto(codigo);
        }

        public void EditarContacto(Contacto contacto)
        {
            cd.EditarContacto(contacto);
        }

        public ArrayList GetContactos()
        {
            return cd.GetContactos();
        }

        public Contacto GetContacto(int codigo)
        {
            return cd.GetContacto(codigo);
        }

        public ArrayList BuscarContacto(String buscar)
        {
            return cd.BuscarContacto(buscar);
        }

    }
}
