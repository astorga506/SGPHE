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

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO 
            //Acomodar las columnas y el arreglar el comportamiento de la tabla
            var senderGrid = (DataGridView)sender;
            DataGridViewButtonColumn columna = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];
            DataGridViewRow fila = (DataGridViewRow)senderGrid.Rows[e.RowIndex];
            int cod = Int32.Parse(fila.Cells["Codigo"].Value.ToString());
            RecordatorioBusiness rb = new RecordatorioBusiness(FILE);

            if (columna.Name.Equals("btnEliminar"))
            {
                rb.EliminarRecordatorio(cod);
                Cargar();
            }

            if (columna.Name.Equals("btnModificar"))
            {
                
                NuevoRecordatorio recordatorio = new NuevoRecordatorio(this, rb.GetRecordatorio(cod));
                recordatorio.Show();

                Cargar();
            }
        }

        public void Cargar()
        {
            try
            {
                RecordatorioBusiness rb = new RecordatorioBusiness(FILE);
                dgvAgenda.DataSource = rb.GetRecordatorios();
                dgvAgenda.Columns["Codigo"].Visible = false;
            }
            catch (Exception e){ }

        }

        
    }
}
