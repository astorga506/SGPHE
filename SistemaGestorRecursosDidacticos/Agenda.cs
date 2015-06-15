using LibreriaSistema.business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorRecursosDidacticos
{
    public partial class Agenda : Form
    {
        public static String FILE = "Recordatorios.xml";
        
        public Agenda()
        {
            InitializeComponent();
            Cargar();
        }

        private void btnNuevoRecor_Click(object sender, EventArgs e)
        {
            NuevoRecordatorio recordatorio = new NuevoRecordatorio(this);
            recordatorio.Show();
        }

        public void Cargar()
        {          
            
            try
            {
                RecordatorioBusiness rb = new RecordatorioBusiness(FILE);
                dgvAgenda.DataSource = rb.GetRecordatorios();
                dgvAgenda.Columns["Codigo"].Visible = false;
                dgvAgenda.Columns["Titulo"].DisplayIndex = 0;
                dgvAgenda.Columns["Descripcion"].DisplayIndex = 1;
                dgvAgenda.Columns["Lugar"].DisplayIndex = 2;
                dgvAgenda.Columns["FechaInicio"].DisplayIndex = 3;
                dgvAgenda.Columns["FechaFin"].DisplayIndex = 4;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;

            }
            catch (Exception e)
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                dgvAgenda.DataSource = null;
                dgvAgenda.Refresh();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvAgenda.SelectedRows[0];
            int cod = Int32.Parse(fila.Cells["codigo"].Value.ToString());
            RecordatorioBusiness rb = new RecordatorioBusiness(FILE);

            rb.EliminarRecordatorio(cod);
            Cargar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvAgenda.SelectedRows[0];
            int cod = Int32.Parse(fila.Cells["codigo"].Value.ToString());
            RecordatorioBusiness rb = new RecordatorioBusiness(FILE);

            NuevoRecordatorio recordatorio = new NuevoRecordatorio(this, rb.GetRecordatorio(cod));
            recordatorio.Show();

            Cargar();
        }

        
    }
}
