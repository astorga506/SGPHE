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
    public partial class EstrategiasEvaluativas : Form
    {
        public EstrategiasEvaluativas()
        {
            InitializeComponent();
        }

        private void EstrategiasEvaluativas_Load(object sender, EventArgs e)
        {
            EstrategiaEvaluativaBusiness eeBus = new EstrategiaEvaluativaBusiness(Application.StartupPath + "\\EstrategiasEvaluativas.xml");
            //gridViewRecDidacticos.DataSource = rdBus.GetRecursosDidacticos();
            //gridViewRecDidacticos.DataMember = "Informacion";
            try
            {
                DataTable datos = eeBus.GetEstrategias().Tables["Estrategia"];
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
            dgvEstrategias.Rows.Add(eeBus.ObtenerIndice().ToString(), "", "Guardar", "Borrar");  
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
                        DialogResult dialogResult = MessageBox.Show("¿Realmente desea borrar esta Estrategia Evaluativa? Esta operación es irreversible", "Eliminar Estrategia Evaluativa", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            EstrategiaEvaluativaBusiness eeBus = new EstrategiaEvaluativaBusiness(Application.StartupPath + "\\EstrategiasEvaluativas.xml");
                            EstrategiaEvaluativa estrategia = new EstrategiaEvaluativa();
                            estrategia.Indice = Int32.Parse(fila.Cells[0].Value.ToString());
                            estrategia.Nombre = fila.Cells[1].Value.ToString();
                            eeBus.EliminarEstrategia(estrategia);
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
                            EstrategiaEvaluativaBusiness eeBus = new EstrategiaEvaluativaBusiness(Application.StartupPath + "\\EstrategiasEvaluativas.xml");
                            EstrategiaEvaluativa estrategia = new EstrategiaEvaluativa();
                            estrategia.Indice = Int32.Parse(fila.Cells[0].Value.ToString());
                            estrategia.Nombre = fila.Cells[1].Value.ToString();
                            eeBus.InsertarEstrategia(estrategia);
                            MessageBox.Show("Información almacenada con éxito.");
                            dgvEstrategias.Rows.Add(eeBus.ObtenerIndice().ToString(), "", "Guardar", "Borrar");
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("¿Desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                EstrategiaEvaluativaBusiness eeBus = new EstrategiaEvaluativaBusiness(Application.StartupPath + "\\EstrategiasEvaluativas.xml");
                                EstrategiaEvaluativa estrategia = new EstrategiaEvaluativa();
                                estrategia.Indice = Int32.Parse(fila.Cells[0].Value.ToString());
                                estrategia.Nombre = fila.Cells[1].Value.ToString();
                                eeBus.ActualizarEstrategia(estrategia);
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
                EstrategiaEvaluativaBusiness eeBus = new EstrategiaEvaluativaBusiness(Application.StartupPath + "\\EstrategiasEvaluativas.xml");
                dgvEstrategias.Rows.Add(eeBus.ObtenerIndice().ToString(), "", "Guardar", "Borrar");
            }
        }

    }
}
