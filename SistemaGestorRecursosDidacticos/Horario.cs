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
    public partial class Horario : Form
    {
        HorarioData horarioData;
        LibreriaSistema.domain.Horario horarioDomain;
        public Horario()
        {

            InitializeComponent();
            horarioData = new HorarioData(Application.StartupPath + "\\Horario.xml");
            horarioDomain = new LibreriaSistema.domain.Horario();
            dgvHorarios.DataSource = horarioData.GetHorarios();
            dgvHorarios.DataMember = "Horario";
            dgvHorarios.Rows[0].DefaultCellStyle.BackColor = Color.Gray; 

            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            
            //MessageBox.Show(fila.Cells[0].Value.ToString());
            
                DialogResult dialogResult = MessageBox.Show("¿Realmente desea borrar esta Estrategia Didáctica? Esta operación es irreversible", "Eliminar Estrategia Didáctica", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataSet dataSet = (DataSet) dgvHorarios.DataSource;
                    horarioDomain.DataSetHorario = dataSet;
                    horarioData.InsertarHorario(horarioDomain);
                }
            
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is ReporteHorario)
                {
                    frm.Show();
                    return;
                }
            }
            ReporteHorario f1 = new SistemaGestorRecursosDidacticos.ReporteHorario();
            f1.Show();
        }
    }
}
