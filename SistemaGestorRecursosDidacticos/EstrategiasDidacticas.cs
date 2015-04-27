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
    public partial class EstrategiasDidacticas : Form
    {
        public EstrategiasDidacticas()
        {
            InitializeComponent();
        }

        private void EstrategiasDidacticas_Load(object sender, EventArgs e)
        {
            EstrategiaDidacticaBusiness edBus = new EstrategiaDidacticaBusiness(Application.StartupPath + "\\EstrategiasDidacticas.xml");
            //gridViewRecDidacticos.DataSource = rdBus.GetRecursosDidacticos();
            //gridViewRecDidacticos.DataMember = "Informacion";
            try
            {
                DataTable datos = edBus.GetEstrategias().Tables["Estrategia"];
                foreach (DataRow fila in datos.Rows)
                {
                    dgvEstrategias.Rows.Add(fila[0], fila[1]);
                }
            }
            catch (FileNotFoundException fnfe)
            {

            }
            catch (NullReferenceException nre)
            {

            }
            dgvEstrategias.Rows.Add(edBus.ObtenerIndice().ToString(), "", "Guardar", "Borrar");  
        }

        private void dgvEstrategias_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataGridViewRow fila = dgv.Rows[dgv.Rows.Count - 1];
            fila.Cells[2].Value = "Guardar";
            fila.Cells[3].Value = "Borrar";
        }

        private void dgvEstrategias_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                        DialogResult dialogResult = MessageBox.Show("¿Realmente desea borrar esta Estrategia Didáctica? Esta operación es irreversible", "Eliminar Estrategia Didáctica", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            EstrategiaDidacticaBusiness edBus = new EstrategiaDidacticaBusiness(Application.StartupPath + "\\EstrategiasDidacticas.xml");
                            EstrategiaDidactica estrategia = new EstrategiaDidactica();
                            estrategia.Indice = Int32.Parse(fila.Cells[0].Value.ToString());
                            estrategia.Nombre = fila.Cells[1].Value.ToString();
                            edBus.EliminarEstrategia(estrategia);
                            dgvEstrategias.Rows.RemoveAt(e.RowIndex);
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
                            EstrategiaDidacticaBusiness edBus = new EstrategiaDidacticaBusiness(Application.StartupPath + "\\EstrategiasDidacticas.xml");
                            EstrategiaDidactica estrategia = new EstrategiaDidactica();
                            estrategia.Indice = Int32.Parse(fila.Cells[0].Value.ToString());
                            estrategia.Nombre = fila.Cells[1].Value.ToString();
                            edBus.InsertarEstrategia(estrategia);
                            MessageBox.Show("Información almacenada con éxito.");
                            dgvEstrategias.Rows.Add(edBus.ObtenerIndice().ToString(), "", "Guardar", "Borrar");
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("¿Desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                EstrategiaDidacticaBusiness edBus = new EstrategiaDidacticaBusiness(Application.StartupPath + "\\EstrategiasDidacticas.xml");
                                EstrategiaDidactica estrategia = new EstrategiaDidactica();
                                estrategia.Indice = Int32.Parse(fila.Cells[0].Value.ToString());
                                estrategia.Nombre = fila.Cells[1].Value.ToString();
                                edBus.ActualizarEstrategia(estrategia);
                                MessageBox.Show("Información almacenada con éxito.");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Debe de completar la información solicitada.");
                    }

                }
                //TODO - Button Clicked - Execute Code Here
            }
        }

        private void dgvEstrategias_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvEstrategias.Rows.Count == 0)
            {
                EstrategiaDidacticaBusiness edBus = new EstrategiaDidacticaBusiness(Application.StartupPath + "\\EstrategiasDidacticas.xml");
                dgvEstrategias.Rows.Add(edBus.ObtenerIndice().ToString(), "", "Guardar", "Borrar");
            }
        }

    }
}
