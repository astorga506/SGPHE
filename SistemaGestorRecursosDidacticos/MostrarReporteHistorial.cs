﻿using System;
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
    public partial class MostrarReporteHistorial : Form
    {
        public MostrarReporteHistorial(DSPlaneamiento parametro)
        {
            InitializeComponent();
            ReporteHistorialReporte rptXMLReport = new ReporteHistorialReporte();
            rptXMLReport.SetDataSource(parametro);
            //rptXMLReport.Load();
            crystalReportViewer1.ReportSource = rptXMLReport;
            rptXMLReport.SetDatabaseLogon("reporte", "reporte");
            //crystalReportViewer1.DisplayGroupTree = false;
           
        }
    }
}
