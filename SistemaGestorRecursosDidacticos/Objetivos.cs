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
    public partial class DistribucionObjetivos : Form
    {
        public DistribucionObjetivos()
        {
            InitializeComponent();
        }

        private void DistribucionObjetivos_Load(object sender, EventArgs e)
        {

        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\ICiclo\Español.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void matemáticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\ICiclo\Matematica.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void estudiosSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\ICiclo\Estudios Sociales.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void cienciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\ICiclo\Ciencias.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void músicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\ICiclo\Musica.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void francésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\ICiclo\Frances.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void religiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\ICiclo\Religion.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void españolIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\IICiclo\Espanol.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void matemáticaIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\IICiclo\Matematica.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void estudiosSocialesIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\IICiclo\Estudios sociales.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void cienciasIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\IICiclo\Ciencias.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void músicaIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\IICiclo\Educacion musical.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void francésIIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\IICiclo\Frances.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void religiónIIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(@"C:\Users\Marlon Miranda Rojas\Desktop\SistemaGestorRecursosDidacticos\SistemaGestorRecursosDidacticos\bin\Debug\IICiclo\Educacion religiosa.pdf");
            axAcroPDF1.gotoFirstPage();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Main main = new Main();
            //axAcroPDF1.Dispose();
            //this.Close();
            //main.Show();
        }



 

    }
}
