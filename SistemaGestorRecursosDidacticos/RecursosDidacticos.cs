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

            XmlDataDocument xmldata = new XmlDataDocument();
            xmldata.DataSet.ReadXml(Application.StartupPath + "\\RecursosDidacticos.xml");

            gridViewRecDidacticos.DataSource = xmldata.DataSet;
            gridViewRecDidacticos.DataMember = "Informacion";

            DataGridViewButtonColumn btnAgregar = new DataGridViewButtonColumn();
            gridViewRecDidacticos.Columns.Add(btnAgregar);
            btnAgregar.HeaderText = "";
            btnAgregar.Text = "Insertar";
            btnAgregar.Name = "btnInsertar";
            btnAgregar.UseColumnTextForButtonValue = true;
            btnAgregar.AutoSizeMode =
            DataGridViewAutoSizeColumnMode.AllCells;
            btnAgregar.FlatStyle = FlatStyle.Standard;
            btnAgregar.CellTemplate.Style.BackColor = Color.Honeydew;
            //BtnAdd.DisplayIndex = 3;


            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn();
            gridViewRecDidacticos.Columns.Add(btnModificar);
            btnModificar.HeaderText = "";
            btnModificar.Text = "Modificar";
            btnModificar.Name = "btnModificar";
            btnModificar.UseColumnTextForButtonValue = true;
            btnModificar.AutoSizeMode =
            DataGridViewAutoSizeColumnMode.AllCells;
            btnModificar.FlatStyle = FlatStyle.Standard;
            btnModificar.CellTemplate.Style.BackColor = Color.Honeydew;
            //BtnAdd.DisplayIndex = 3;

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            gridViewRecDidacticos.Columns.Add(btnEliminar);
            btnEliminar.HeaderText = "";
            btnEliminar.Text = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.AutoSizeMode =
            DataGridViewAutoSizeColumnMode.AllCells;
            btnEliminar.FlatStyle = FlatStyle.Standard;
            btnEliminar.CellTemplate.Style.BackColor = Color.Honeydew;
            //BtnAdd.DisplayIndex = 3;
            
        }
       
        private void RecursosDidacticos_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewButtonColumn columna = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];
                if (columna.Name.Equals("btnInsertar")) {
                    DataGridViewRow fila = (DataGridViewRow)senderGrid.Rows[e.RowIndex];
                    //fila.Cells[];
                }
                if (columna.Name.Equals("btnEliminar"))
                {
                   
                }
                if (columna.Name.Equals("btnModificar"))
                {
                  
                }
                //TODO - Button Clicked - Execute Code Here
            }
        }

    }
}
