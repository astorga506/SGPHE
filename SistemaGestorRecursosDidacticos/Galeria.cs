using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorRecursosDidacticos
{
    public partial class Galeria : Form
    {

       // private Button btnAtras;
//private Button btnSiguiente;
        //private PictureBox pbImagen;
        private string[] rutaImagenes;
        private int indice; 

        public Galeria()
        {
            InitializeComponent();
            this.Text = "Galeria";
            //this.StartPosition = FormStartPosition.CenterScreen;
            //this.Size = new Size(1037, 620);

            //btnAtras = new Button();
            //btnAtras.Text = "Atras";
            //btnAtras.Size = new Size(100, 50);
            //btnAtras.Location = new Point(10, 510);

            //btnSiguiente = new Button();
            //btnSiguiente.Text = "Siguiente";
            //btnSiguiente.Size = new Size(100, 50);
            //btnSiguiente.Location = new Point(680, 510);

            //pbImagen = new PictureBox();
            //pbImagen.Size = new Size(800, 500);
           pbImagen.SizeMode = PictureBoxSizeMode.CenterImage;

            btnAtras.Click += (s, e) =>
            {
                if (indice > 0)
                    pbImagen.Load(rutaImagenes[--indice]);
            };

            btnSiguiente.Click += (s, e) =>
            {
                if (indice < rutaImagenes.Length - 1)
                    pbImagen.Load(rutaImagenes[++indice]);
            };

            this.Load += (s, e) =>
            {
                rutaImagenes = Directory.GetFiles(@"E:\Documentos\Visual Studio 2013\Projects\Photos\Photos\bin\Debug\FotosProyecto", "*.jpg", SearchOption.AllDirectories);

                if (rutaImagenes.Length == 0)
                {
                    MessageBox.Show("No se encontraron imagenes .jpg"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                Array.Sort(rutaImagenes);
                pbImagen.Image = Image.FromFile(rutaImagenes[0]);
            };

            this.Controls.Add(btnAtras);
            this.Controls.Add(btnSiguiente);
            this.Controls.Add(pbImagen);
            indice = 0; 

        }

        private void Galeria_Load(object sender, EventArgs e)
        {

        }
    }
}
