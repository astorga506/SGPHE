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
    public partial class ItemsPruebaEscrita : Form
    {
        public ItemsPruebaEscrita()
        {
            InitializeComponent();
        }

        private void ItemsPruebaEscrita_Load(object sender, EventArgs e)
        {
            ItemPruebaBusiness rdBus = new ItemPruebaBusiness(Application.StartupPath + "\\ItemsPruebas.xml");
            //gridViewRecDidacticos.DataSource = rdBus.GetRecursosDidacticos();
            //gridViewRecDidacticos.DataMember = "Informacion";
            try
            {
                DataTable datos = rdBus.GetItemsPrueba().Tables["Item"];
                foreach (DataRow fila in datos.Rows)
                {
                    dgvItems.Rows.Add(fila[0], fila[1]);
                }
            }
            catch (FileNotFoundException fnfe)
            {

            }
            catch (NullReferenceException nre)
            {

            }
            dgvItems.Rows.Add(rdBus.ObtenerIndice().ToString(), "", "Guardar", "Borrar");  
                        
        }

        private void dgvItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataGridViewRow fila = dgv.Rows[dgv.Rows.Count - 1];
            fila.Cells[2].Value = "Guardar";
            fila.Cells[3].Value = "Borrar";
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                        DialogResult dialogResult = MessageBox.Show("¿Realmente desea borrar este Ïtem de Prueba Escrita? Esta operación es irreversible", "Eliminar Ïtem de Prueba Escrita", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            ItemPruebaBusiness ipBus = new ItemPruebaBusiness(Application.StartupPath + "\\ItemsPruebas.xml");
                            ItemPrueba item = new ItemPrueba();
                            item.Indice = Int32.Parse(fila.Cells[0].Value.ToString());
                            item.Nombre = fila.Cells[1].Value.ToString();
                            ipBus.EliminarItemPrueba(item);
                            dgvItems.Rows.RemoveAt(e.RowIndex);
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
                            ItemPruebaBusiness ipBus = new ItemPruebaBusiness(Application.StartupPath + "\\ItemsPruebas.xml");
                            ItemPrueba item = new ItemPrueba();
                            item.Indice = Int32.Parse(fila.Cells[0].Value.ToString());
                            item.Nombre = fila.Cells[1].Value.ToString();
                            ipBus.InsertarItemPrueba(item);
                            MessageBox.Show("Información almacenada con éxito.");
                            dgvItems.Rows.Add(ipBus.ObtenerIndice().ToString(), "", "Guardar", "Borrar");
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("¿Desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                ItemPruebaBusiness ipBus = new ItemPruebaBusiness(Application.StartupPath + "\\ItemsPruebas.xml");
                                ItemPrueba item = new ItemPrueba();
                                item.Indice = Int32.Parse(fila.Cells[0].Value.ToString());
                                item.Nombre = fila.Cells[1].Value.ToString();
                                ipBus.ActualizarItemPrueba(item);
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

        private void gridViewRecDidacticos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvItems.Rows.Count == 0)
            {
                ItemPruebaBusiness ipBus = new ItemPruebaBusiness(Application.StartupPath + "\\ItemsPruebas.xml");
                dgvItems.Rows.Add(ipBus.ObtenerIndice().ToString(), "", "Guardar", "Borrar");
            }
        }
       
    }
}
