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
            //Hacer funcionar los botones Eliminar y Modificar
            //Acomodar las columnas y el arreglar el comportamiento de la tabla
            var senderGrid = (DataGridView)sender;
            DataGridViewButtonColumn columna = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];

            if (columna.Name.Equals("btnEliminar"))
            {
                Cargar();
            }

            if (columna.Name.Equals("btnModificar"))
            {

                NuevoRecordatorio recordatorio = new NuevoRecordatorio(this);
                recordatorio.Show();

                Cargar();
            }
        }

        public void Cargar()
        {
            RecordatorioBusiness rb = new RecordatorioBusiness(FILE);
            dgvAgenda.DataSource = rb.GetRecordatorios();        
        }

        
    }
}
