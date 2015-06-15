using LibreriaSistema.business;
using LibreriaSistema.domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorRecursosDidacticos
{
    public partial class Contactos : Form
    {
        private static String FILE = "Contactos.xml";
        private Boolean nuevo = true;

        public Contactos()
        {
            InitializeComponent();
            ContactoBusiness cb = new ContactoBusiness(FILE);
            try
            {                
                CargarContactos(cb.GetContactos());
            }
            catch (FileNotFoundException fnfe)
            { 
                
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Equals(""))
            {
                MessageBox.Show("Debe de proporcionar el nombre del contacto que desea buscar.");
            }
            else 
            {
                ContactoBusiness cb = new ContactoBusiness(FILE);
                CargarContactos(cb.BuscarContacto(txtBuscar.Text));

            }
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!nuevo) 
            {
                if (txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("Debe de proporcionar el nombre del contacto que desea eliminar.");
                }
                else
                {
                    try
                    {
                        Contacto contacto = (Contacto)lbContactos.SelectedItem;
                        ContactoBusiness cb = new ContactoBusiness(FILE);
                        cb.EliminarContacto(contacto.Codigo);
                        btnEliminar.Enabled = false;
                        CargarContactos(cb.GetContactos());
                        Reset();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("El contacto que desea eliminar no existe. Verifique la información y vuelva a intentarlo después.");
                    }
                
                }

            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Completo())
            {
                ContactoBusiness cb = new ContactoBusiness(FILE);
                Contacto contacto = new Contacto();
                contacto.Nombre = txtNombre.Text;
                contacto.Telefono = txtTelefono.Text;
                contacto.Correo = txtCorreo.Text;
                contacto.Direccion = txtDireccion.Text;
  
                if (nuevo)
                {
                    cb.InsertarContacto(contacto);                    
                }
                else
                {
                    Contacto aux = (Contacto)lbContactos.SelectedItem;
                    contacto.Codigo = aux.Codigo;
                    cb.EditarContacto(contacto);
                }
                CargarContactos(cb.GetContactos());
                MessageBox.Show("La información ha sido almacenada con éxito.");
            }
            else
            {
                MessageBox.Show("Debe de proporcionar todos los datos para el contacto.");
            }

          
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {            
            btnEliminar.Enabled = false;
            Reset();
        }

        private void lbContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            nuevo = false;
            btnEliminar.Enabled = true;

            Contacto contacto = (Contacto)lbContactos.SelectedItem;
            txtNombre.Text = contacto.Nombre;
            txtTelefono.Text = contacto.Telefono;
            txtCorreo.Text = contacto.Correo;
            txtDireccion.Text = contacto.Direccion;
        }

        private Boolean Completo() 
        {
            Boolean completo;
            completo = txtNombre.Text.Equals("")? false:true;
            completo = txtTelefono.Text.Equals("") || !completo? false : true;
            completo = txtCorreo.Text.Equals("") || !completo? false : true;
            completo = txtDireccion.Text.Equals("") || !completo? false : true;

            return completo;
        }

        private void Reset()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            nuevo = true;
        }

        private void CargarContactos(ArrayList contactos)
        {
            lbContactos.DataSource = contactos;
            lbContactos.DisplayMember = "Nombre";
        }
                  
    }
}
