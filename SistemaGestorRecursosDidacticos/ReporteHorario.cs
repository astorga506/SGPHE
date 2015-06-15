using LibreriaSistema;
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
    public partial class ReporteHorario : Form
    {
        public ReporteHorario()
        {
            InitializeComponent();
        }

        private void ReporteHorario_Load(object sender, EventArgs e)
        {

            DataSet dsReport = new DSHorario();
            DataSet dsTempReport = new DataSet();
            try
            {
                HorarioData horarioData = new HorarioData(Application.StartupPath + "\\Horario.xml");
               // using ReadXml method of DataSet read XML data from books.xml file 
               // dsTempReport.ReadXml(@"C:\articles\XmlCrystalReport\cd_catalog.xml"); 
                dsTempReport = horarioData.GetHorarios();
                // copy XML data from temp dataset to our typed data set 
            dsReport.Tables[0].Merge(dsTempReport.Tables[0]); 
            //prepare report for preview 
            ReporteHorarioReport rptXMLReport = new ReporteHorarioReport(); 
            rptXMLReport.SetDataSource(dsReport.Tables[0]); 
            crystalReportViewer1.DisplayGroupTree = false; 
            crystalReportViewer1.ReportSource = rptXMLReport;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
