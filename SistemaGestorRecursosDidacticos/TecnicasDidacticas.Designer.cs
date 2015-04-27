namespace SistemaGestorRecursosDidacticos
{
    partial class TecnicasDidacticas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTecDidactica = new System.Windows.Forms.DataGridView();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecDidactica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Las técnicas se consideran como procedimientos didácticos que se prestan a ayudar" +
    " a realizar una parte del\r\n aprendizaje que se persigue con la estrategia. ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTecDidactica
            // 
            this.dgvTecDidactica.AllowUserToAddRows = false;
            this.dgvTecDidactica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTecDidactica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indice,
            this.Nombre,
            this.btnGuardar,
            this.btnEliminar});
            this.dgvTecDidactica.Location = new System.Drawing.Point(144, 192);
            this.dgvTecDidactica.Name = "dgvTecDidactica";
            this.dgvTecDidactica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTecDidactica.Size = new System.Drawing.Size(743, 314);
            this.dgvTecDidactica.TabIndex = 5;
            this.dgvTecDidactica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTecDidactica_CellContentClick);
            this.dgvTecDidactica.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTecDidactica_RowsAdded);
            this.dgvTecDidactica.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvTecDidactica_RowsRemoved);
            // 
            // Indice
            // 
            this.Indice.HeaderText = "Índice";
            this.Indice.Name = "Indice";
            this.Indice.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 400;
            // 
            // btnGuardar
            // 
            this.btnGuardar.HeaderText = "Guardar";
            this.btnGuardar.Name = "btnGuardar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            // 
            // TecnicasDidacticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SistemaGestorRecursosDidacticos.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 594);
            this.Controls.Add(this.dgvTecDidactica);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "TecnicasDidacticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TecnicasDidacticas";
            this.Load += new System.EventHandler(this.TecnicasDidacticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecDidactica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTecDidactica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn btnGuardar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}