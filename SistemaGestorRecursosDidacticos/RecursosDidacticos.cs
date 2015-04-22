using LibreriaSistema.business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SistemaGestorRecursosDidacticos
{
    public partial class RecursosDidacticos : Form
    {
        public RecursosDidacticos()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

        }
       
        private void RecursosDidacticos_Load(object sender, EventArgs e)
        {
            RecursoDidacticoBusiness rdBus = new RecursoDidacticoBusiness(Application.StartupPath + "\\RecursosDidacticos.xml");
            gridViewRecDidacticos.DataSource = rdBus.GetRecursosDidacticos();
            gridViewRecDidacticos.DataMember = "Informacion";
        }


    }
}
