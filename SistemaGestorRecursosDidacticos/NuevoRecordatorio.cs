using LibreriaSistema.business;
using LibreriaSistema.domain;
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
    public partial class NuevoRecordatorio : Form
    {
        private Recordatorio recordatorio;
        private Agenda agenda;
        private Boolean nuevo;

        public NuevoRecordatorio(Agenda agenda, Recordatorio recordatorio)
        {
            InitializeComponent();
            Inicializar();
            nuevo = false;
            txtTitulo.Text = recordatorio.Titulo;
            txtDescrip.Text = recordatorio.Descripcion;
            txtLugar.Text = recordatorio.Lugar;
            calendarInicio.SetDate(recordatorio.FechaInicio);
            calendarFin.SetDate(recordatorio.FechaFin);

            this.recordatorio = recordatorio;
            this.agenda = agenda;
        }

        public NuevoRecordatorio(Agenda agenda)
        {
            InitializeComponent();
            Inicializar();
            nuevo = true;
            recordatorio = new Recordatorio();            
            this.agenda = agenda;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RecordatorioBusiness rb = new RecordatorioBusiness(Agenda.FILE);
            recordatorio.Titulo = txtTitulo.Text;
            recordatorio.Descripcion = txtDescrip.Text;
            recordatorio.Lugar = txtLugar.Text;
            //TODO
            //Validar entradas *calendarios* (importante)

            if (nuevo)
            {
                rb.InsertarRecordatorio(recordatorio);
            }
            else 
            {
                rb.EditarRecordatorio(recordatorio);
            }

            agenda.Focus();
            agenda.Cargar();
            this.Dispose();
        }

        private void Inicializar()
        {
            calendarInicio.MinDate = DateTime.Today;
            calendarInicio.MaxDate = DateTime.Today.AddYears(5);
            calendarFin.MinDate = DateTime.Today;
            calendarFin.MaxDate = DateTime.Today.AddYears(5);    

        }

        private void calendarInicio_DateChanged(object sender, DateRangeEventArgs e)
        {
            recordatorio.FechaInicio = e.Start;            
        }

        private void calendarFin_DateChanged(object sender, DateRangeEventArgs e)
        {
            recordatorio.FechaFin = e.Start;
        }
    
    }
}
