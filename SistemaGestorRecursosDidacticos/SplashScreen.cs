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
    public partial class SplashScreen : Form
    {

        Point formPosition;
        Boolean mouseAction;

        PictureBox[] pict;//declaracion de matrices
        int count = 0;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pict = new PictureBox[5] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
        }

        //***********************************************Mover******************************************/
        private void SplashScreen_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void SplashScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
            } 
        }

        private void SplashScreen_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }
//*****************************************************************************************/

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 5)
            {
                pict[count].BackgroundImage = SistemaGestorRecursosDidacticos.Properties.Resources.Circle2;//cambiando la imagen
                count++;
                label1.Text = "Cargando al " + (count * 20) + " %";
            }//if
            else
            {
                timer1.Enabled = false;
                //MessageBox.Show("Carga Completa");
                this.Close();
            }//else
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Dispose(false);
            main.Show();
        }

       
       
    }
}
