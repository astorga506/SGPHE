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
using System.Xml;

namespace SistemaGestorRecursosDidacticos
{
    public partial class RecursosDidacticos : Form
    {
        public RecursosDidacticos()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

        }
       
        private void RecursosDidacticos_Load(object sender, EventArgs e)
        {
            RecursoDidacticoBusiness rdBus = new RecursoDidacticoBusiness(Application.StartupPath + "\\RecursosDidacticos.xml");
            //gridViewRecDidacticos.DataSource = rdBus.GetRecursosDidacticos();
            //gridViewRecDidacticos.DataMember = "Informacion";
            DataTable datos = rdBus.GetRecursosDidacticos().Tables["Informacion"];

            foreach (DataRow fila in datos.Rows)
            {
                gridViewRecDidacticos.Rows.Add(fila[0], fila[1], fila[2], "Guardar", "Borrar");
            }
            
        }

        private void gridViewRecDidacticos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataGridViewRow fila = dgv.Rows[dgv.Rows.Count-1];
            fila.Cells[3].Value = "Guardar";
            fila.Cells[4].Value = "Borrar";
        }

        private void gridViewRecDidacticos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewButtonColumn columna = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];

                if (columna.Name.Equals("btnEliminar"))
                {
                    DataGridViewRow fila = (DataGridViewRow)senderGrid.Rows[e.RowIndex];
                    MessageBox.Show(fila.Cells[0].Value.ToString());
                }
                if (columna.Name.Equals("btnGuardar"))
                {
                    DataGridViewRow fila = (DataGridViewRow)senderGrid.Rows[e.RowIndex];
                    MessageBox.Show(e.RowIndex.ToString());
                }
                //TODO - Button Clicked - Execute Code Here
            }
        }

    }
}
