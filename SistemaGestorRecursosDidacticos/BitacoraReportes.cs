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
    public partial class BitacoraReportes : Form
    {
        public DateTime fechaInicio, fechaFin;
        public String nivel, docente, unidad, asignatura;

        public BitacoraReportes()
        {
            InitializeComponent();
            fechaInicio = DateTime.Today;
            fechaFin = DateTime.Today;
            nivel ="";
            docente="";
            unidad="";
            asignatura = "";
            cbxAsignatura.SelectedIndex=0;
            cbxNivel.SelectedIndex = 0;
        }

        private void BitacoraReportes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataPlaneamientoDataSet.Planeamiento' table. You can move, or remove it, as needed.
            this.planeamientoTableAdapter.Fill(this.dataPlaneamientoDataSet.Planeamiento);
            // TODO: This line of code loads data into the 'dataPlaneamientoDataSet.ElementosPlaneamiento' table. You can move, or remove it, as needed.
            this.elementosPlaneamientoTableAdapter.Fill(this.dataPlaneamientoDataSet.ElementosPlaneamiento);

        }

        private void lblFechaInicio_Click(object sender, EventArgs e)
        {
            //nada
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fechaInicio = dtpFechaInicio.Value;
            actualizarGrid();
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            fechaFin = dtpFechaFin.Value;
            actualizarGrid();
        }
    
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
           
                DSPlaneamiento dataSet = new DSPlaneamiento();
                BindingSource bs = dgvResultados.DataSource as BindingSource;
                BindingSource bs2 =bs.DataSource as BindingSource;
                DataSet ds = bs2.DataSource as DataSet;
                 MostrarReporteHistorial reporter = new MostrarReporteHistorial(ds as DSPlaneamiento);
                 reporter.Show();

        }

        private void cbxNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            nivel = cbxNivel.Text;
            actualizarGrid();
        }

        private void tbxProfesor_TextChanged(object sender, EventArgs e)
        {
            docente = tbxProfesor.Text;
            actualizarGrid();
        }

        private void tbxUnidad_TextChanged(object sender, EventArgs e)
        {
            unidad = tbxUnidad.Text;
            actualizarGrid();
        }

        private void actualizarGrid()
        {
            foreach (DataGridViewRow item in dgvResultados.Rows)
            {
                item.Visible=true;
            }
            String itmDocente="",itmNivel="", itmUnidad="", itmAsignaruta ="";
            DateTime itmFechaInicio,itmFechaFin ;
            this.dgvResultados.CurrentCell = null;
            foreach (DataGridViewRow item in dgvResultados.Rows)
            {

                itmDocente=item.Cells[1].Value.ToString();
                itmAsignaruta = item.Cells[2].Value.ToString();
                itmNivel = item.Cells[3].Value.ToString();
                itmUnidad = item.Cells[4].Value.ToString();

                itmFechaInicio = DateTime.ParseExact(item.Cells[5].Value.ToString(), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                itmFechaFin = DateTime.ParseExact(item.Cells[6].Value.ToString(), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);

                if (!itmDocente.StartsWith(docente)) {
                    item.Visible = false;
                }
                if (!itmUnidad.StartsWith(unidad))
                {
                    item.Visible = false;
                }
                if (!itmNivel.Equals(nivel) && !cbxNivel.Text.Equals("Cualquiera"))
                {
                    item.Visible = false;
                }
                if (!itmAsignaruta.Equals(asignatura) && !cbxAsignatura.Text.Equals("Cualquiera"))
                {
                    item.Visible = false;
                }
                int date1 = DateTime.Compare(itmFechaInicio, fechaInicio);
                int date2 = DateTime.Compare(itmFechaFin, fechaFin) ;

                if ((date1 >= 0) && (date2 <= 0))
                { }else{ item.Visible = false; }

            }
            
        }

        private void cbxAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            asignatura = cbxAsignatura.Text;
            actualizarGrid();
        }
    }
}
