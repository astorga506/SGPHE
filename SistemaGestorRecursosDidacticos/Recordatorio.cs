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
    public partial class Recordatorio : Form
    {
        public Recordatorio()
        {
            InitializeComponent();
        }

        private void btnNuevoRecor_Click(object sender, EventArgs e)
        {
            NuevoRecordatorio nrecordatorio = new NuevoRecordatorio();
            nrecordatorio.Show();
        }
    }
}
