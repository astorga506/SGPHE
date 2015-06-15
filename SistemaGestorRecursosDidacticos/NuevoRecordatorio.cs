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
            dtpDiaInicio.Value = recordatorio.FechaInicio.Date;
            dtpHoraInicio.Value = DateTime.Parse(recordatorio.FechaInicio.ToShortTimeString());
            dtpDiaFin.Value = recordatorio.FechaFin.Date;
            dtpHoraFin.Value = DateTime.Parse(recordatorio.FechaFin.ToShortTimeString());

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
            if (completo())
            {

                    RecordatorioBusiness rb = new RecordatorioBusiness(Agenda.FILE);
                    recordatorio.Titulo = txtTitulo.Text;
                    recordatorio.Descripcion = txtDescrip.Text;
                    recordatorio.Lugar = txtLugar.Text;
                    recordatorio.FechaInicio = dtpDiaInicio.Value.Date + dtpHoraInicio.Value.TimeOfDay;
                    recordatorio.FechaFin = dtpDiaFin.Value.Date + dtpHoraFin.Value.TimeOfDay;
                    if (recordatorio.FechaInicio.CompareTo(recordatorio.FechaFin) <= 0)
                    {
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
                    else
                    {
                        MessageBox.Show("La fecha de finalización debe ser posterior a la de inicio para la actividad.");
                    }

            }
            else
            {
                MessageBox.Show("Debe de proporcionar toda la información solicitada.");
            }

        }

        private void Inicializar()
        {
            dtpDiaInicio.MinDate = DateTime.Today.AddYears(-5);
            dtpDiaInicio.MaxDate = DateTime.Today.AddYears(5);
            dtpDiaFin.MinDate = DateTime.Today.AddYears(-5);
            dtpDiaFin.MaxDate = DateTime.Today.AddYears(5);    

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private Boolean completo()
        {
            Boolean completo;

            completo = txtTitulo.Text.Equals("")?  false :  true;
            completo = txtDescrip.Text.Equals("") || !completo? false : true;
            completo = txtLugar.Text.Equals("") || !completo? false : true;            

            return completo;        
        }
        
    }
}
