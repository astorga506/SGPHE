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

namespace SistemaGestorRecursosDidacticos
{
    public partial class TecnicasDidacticas : Form
    {
        public TecnicasDidacticas()
        {
            InitializeComponent();
            
        }

        private void TecnicasDidacticas_Load(object sender, EventArgs e)
        {
            TecnicaDidacticaBusiness tdBus = new TecnicaDidacticaBusiness(Application.StartupPath + "\\TecnicasDidacticas.xml");
            //gridViewRecDidacticos.DataSource = rdBus.GetRecursosDidacticos();
            //gridViewRecDidacticos.DataMember = "Informacion";
            try
            {
                DataTable datos = tdBus.GetTecnicasDidacticos().Tables["Tecnica"];
                foreach (DataRow fila in datos.Rows)
                {
                    dgvTecDidactica.Rows.Add(fila[0], fila[1]);
                }
            }
            catch (FileNotFoundException fnfe)
            {

            }
            catch (NullReferenceException nre)
            {

            }
            dgvTecDidactica.Rows.Add(tdBus.ObtenerIndice().ToString(), "", "Guardar", "Borrar");  
        }

        private void dgvTecDidactica_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataGridViewRow fila = dgv.Rows[dgv.Rows.Count - 1];
            fila.Cells[2].Value = "Guardar";
            fila.Cells[3].Value = "Borrar";
        }

        private void dgvTecDidactica_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                    if (fila.Cells[1].Value.ToString() == "")
                    {
                        MessageBox.Show("Debe de seleccionar un campo no vacío");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Realmente desea borrar este tecnica didactica? Esta operación es irreversible", "Eliminar tecnica", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            TecnicaDidacticaBusiness tdBus = new TecnicaDidacticaBusiness(Application.StartupPath + "\\TecnicasDidacticas.xml");
                            TecnicaDidactica tecnica = new TecnicaDidactica();
                            tecnica.Indice = Int32.Parse(fila.Cells[0].Value.ToString());
                            tecnica.Nombre = fila.Cells[1].Value.ToString();
                            tdBus.EliminarTecnicaDidactico(tecnica);
                            dgvTecDidactica.Rows.RemoveAt(e.RowIndex);
                        }
                    
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
                            TecnicaDidacticaBusiness tdBus = new TecnicaDidacticaBusiness(Application.StartupPath + "\\TecnicasDidacticas.xml");
                            TecnicaDidactica tecnica = new TecnicaDidactica();
                            tecnica.Indice = Int32.Parse(fila.Cells[0].Value.ToString());
                            tecnica.Nombre = fila.Cells[1].Value.ToString();
                            tdBus.InsertarTecnicaDidactica(tecnica);
                            MessageBox.Show("Información almacenada con exito.");
                            dgvTecDidactica.Rows.Add(tdBus.ObtenerIndice().ToString(), "", "Guardar", "Borrar");
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("¿Desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                TecnicaDidacticaBusiness tdBus = new TecnicaDidacticaBusiness(Application.StartupPath + "\\TecnicasDidacticas.xml");
                                TecnicaDidactica tecnica = new TecnicaDidactica();
                                tecnica.Indice = Int32.Parse(fila.Cells[0].Value.ToString());
                                tecnica.Nombre = fila.Cells[1].Value.ToString();
                                tdBus.ActualizarTecnicaDidactico(tecnica);
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

        private void dgvTecDidactica_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvTecDidactica.Rows.Count == 0)
            {
                TecnicaDidacticaBusiness tdBus = new TecnicaDidacticaBusiness(Application.StartupPath + "\\TecnicasDidacticas.xml");
                dgvTecDidactica.Rows.Add(tdBus.ObtenerIndice().ToString(), "", "Guardar", "Borrar");
            }
        }

     
    }
}
