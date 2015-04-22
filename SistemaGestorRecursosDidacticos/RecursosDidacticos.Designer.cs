namespace SistemaGestorRecursosDidacticos
{
    partial class RecursosDidacticos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridViewRecDidacticos = new System.Windows.Forms.DataGridView();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecDidacticos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewRecDidacticos
            // 
            this.gridViewRecDidacticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRecDidacticos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Autor,
            this.Titulo,
            this.Enlace});
            this.gridViewRecDidacticos.Location = new System.Drawing.Point(121, 145);
            this.gridViewRecDidacticos.MultiSelect = false;
            this.gridViewRecDidacticos.Name = "gridViewRecDidacticos";
            this.gridViewRecDidacticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewRecDidacticos.Size = new System.Drawing.Size(746, 318);
            this.gridViewRecDidacticos.TabIndex = 0;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            // 
            // Enlace
            // 
            this.Enlace.DataPropertyName = "Enlace";
            this.Enlace.HeaderText = "Enlace";
            this.Enlace.Name = "Enlace";
            // 
            // RecursosDidacticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SistemaGestorRecursosDidacticos.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.gridViewRecDidacticos);
            this.DoubleBuffered = true;
            this.Name = "RecursosDidacticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos Didacticos";
            this.Load += new System.EventHandler(this.RecursosDidacticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecDidacticos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewRecDidacticos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enlace;


    }
}