using LibreriaSistema.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorRecursosDidacticos
{
    public partial class Planeamiento : Form
    {

        public Planeamiento()
        {
            InitializeComponent();
            ResizeListViewColumns(lvwEstrategiaEvaluacion);
            lvwEstrategiaEvaluacion.View = View.Details;

            // These are optional
            lvwEstrategiaEvaluacion.GridLines = true;
            lvwEstrategiaEvaluacion.FullRowSelect = true;
        }
        private void Planeamiento_Load(object sender, EventArgs e)
        {

        }
        public void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
        }
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DSPlaneamiento dataSetPlaneamiento = new DSPlaneamiento();
            DataRow rowPlaneamiento =  dataSetPlaneamiento.Tables["Planeamiento"].NewRow();
            DataRow rowDetalle = dataSetPlaneamiento.Tables["ElementosPlaneamiento"].NewRow();
           
            rowPlaneamiento["Docente"]=tbxNombreProfesor.Text.ToString();
            rowPlaneamiento["Asignatura"] = cbxAsignatura.Text;
            rowPlaneamiento["Nivel"] = cbxNivel.Text;
            rowPlaneamiento["Unidad"] = tbxUnidad.Text.ToString();
            rowPlaneamiento["Id"] = ++Main.id_planeamiento;
            rowPlaneamiento["Fecha_Inicio"] = calendarFechaInicio.SelectionEnd.ToString("dd-MM-yyyy");
            rowPlaneamiento["Fecha_Fin"] = calendarFechaFin.SelectionEnd.ToString("dd-MM-yyyy");
            rowPlaneamiento["Aprendizaje"] = tbxAprendizaje.Text.ToString();
            rowPlaneamiento["Estrategia_Mediacion"] = tbxMediacion.Text.ToString();

            foreach (ListViewItem item in lvwEstrategiaEvaluacion.Items)
            {
                rowDetalle["Id_Planeamiento"] = Main.id_planeamiento;
                rowDetalle["EstrategiaEvaluacion"] += "\n-" + item.Text.ToString();
            }
            rowDetalle["Id_Planeamiento"] = Main.id_planeamiento;
            rowDetalle["EstrategiaEvaluacion"] += "\n"+tbxEstrategiaEvaluacion.Text.ToString();
            
            dataSetPlaneamiento.Tables["Planeamiento"].Rows.Add(rowPlaneamiento);
            dataSetPlaneamiento.Tables["ElementosPlaneamiento"].Rows.Add(rowDetalle);

            guardarDatos(dataSetPlaneamiento);

            MostrarReportePlaneamiento reporter = new MostrarReportePlaneamiento(dataSetPlaneamiento);
            reporter.Show();
        }

        private void guardarDatos(DSPlaneamiento dataSet)
        {
            PlaneamientoData data = new PlaneamientoData();
            data.insertarPlaneamiento(dataSet);
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarEstrategia_Click(object sender, EventArgs e)
        {
            SeleccionarEstrategiaEvaluativa select = new SeleccionarEstrategiaEvaluativa(this);
            select.Show();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is BitacoraReportes)
                {
                    frm.Close();
                }
            }
            BitacoraReportes f2 = new SistemaGestorRecursosDidacticos.BitacoraReportes();
            f2.Show();
        }

        private void calendarFechaInicio_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        
    }
}
