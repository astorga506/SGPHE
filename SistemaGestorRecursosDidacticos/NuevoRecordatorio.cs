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
        public NuevoRecordatorio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Recordatorio recordatorio = new Recordatorio();
            recordatorio.Show();
        }

    
    }
}
