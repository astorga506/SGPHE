using LibreriaSistema.business;
using LibreriaSistema.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            try
            {
                DataTable datos = rdBus.GetRecursosDidacticos().Tables["Recurso"];
                foreach (DataRow fila in datos.Rows)
                {
                    gridViewRecDidacticos.Rows.Add(fila[0], fila[1], fila[2], "Guardar", "Borrar");
                }
            }
            catch (FileNotFoundException fnfe)
            {

            }
            catch (NullReferenceException nre)
            { 
            
            }
            
            gridViewRecDidacticos.Rows.Add("", "", "", "Guardar", "Borrar");
            
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
                    //MessageBox.Show(fila.Cells[0].Value.ToString());
                    DialogResult dialogResult = MessageBox.Show("¿Realmente desea borrar este recurso didactico? Esta operación es irreversible", "Eliminar recurso", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        RecursoDidacticoBusiness rdBus = new RecursoDidacticoBusiness(Application.StartupPath + "\\RecursosDidacticos.xml");
                        RecursoDidactico recurso = new RecursoDidactico();
                        recurso.Autor = fila.Cells[0].Value.ToString();
                        recurso.Titulo = fila.Cells[1].Value.ToString();
                        recurso.Enlace = fila.Cells[2].Value.ToString();
                        rdBus.EliminarRecursoDidactico(recurso);
                        gridViewRecDidacticos.Rows.RemoveAt(e.RowIndex);
                    }
                }
                if (columna.Name.Equals("btnGuardar"))
                {
                    DataGridViewRow fila = (DataGridViewRow)senderGrid.Rows[e.RowIndex];
                    //MessageBox.Show(e.RowIndex.ToString());
                    int i = 0;
                    Boolean completo = true;
                    while (i < fila.Cells.Count)
                    {
                        try
                        {
                            if (fila.Cells[i].Value.ToString() == "")
                            {                                
                                completo = false;
                                break;
                            }
                        }
                        catch (NullReferenceException nre)
                        {
                            completo = false;
                        }
 
                        i++;
                    }
                    if (completo)
                    {
                        if (e.RowIndex == senderGrid.Rows.Count - 1)
                        {
                            RecursoDidacticoBusiness rdBus = new RecursoDidacticoBusiness(Application.StartupPath + "\\RecursosDidacticos.xml");
                            RecursoDidactico recurso = new RecursoDidactico();
                            recurso.Autor = fila.Cells[0].Value.ToString();
                            recurso.Titulo = fila.Cells[1].Value.ToString();
                            recurso.Enlace = fila.Cells[2].Value.ToString();
                            rdBus.InsertarRecursoDidactico(recurso);
                            MessageBox.Show("Información almacenada con exito.");
                            gridViewRecDidacticos.Rows.Add("", "", "", "Guardar", "Borrar");
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("¿Desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                /*------------Codigo para llamar función para modificar el registro------------*/

                                MessageBox.Show("Información almacenada con exito.");
                            }
                        }

                    }
                    else 
                    {
                        MessageBox.Show("Debe de completar la información solicitada para cada espacio.");
                    }
                    
                }
                //TODO - Button Clicked - Execute Code Here
            }
        }

        private void gridViewRecDidacticos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (gridViewRecDidacticos.Rows.Count == 0)
            {
                gridViewRecDidacticos.Rows.Add("", "", "", "Guardar", "Borrar");
            }
        }

    }
}
