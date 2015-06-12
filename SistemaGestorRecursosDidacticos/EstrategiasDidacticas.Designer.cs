namespace SistemaGestorRecursosDidacticos
{
    partial class EstrategiasDidacticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstrategiasDidacticas));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEstrategias = new System.Windows.Forms.DataGridView();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstrategias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Las Estrategias Didácticas son el conjunto de procedimientos, apoyados en técnica" +
    "s de enseñanza \r\nque tiene por objeto alcanzar los objetivos de aprendizaje. \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEstrategias
            // 
            this.dgvEstrategias.AllowUserToAddRows = false;
            this.dgvEstrategias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstrategias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indice,
            this.Nombre,
            this.btnGuardar,
            this.btnEliminar});
            this.dgvEstrategias.Location = new System.Drawing.Point(135, 163);
            this.dgvEstrategias.Name = "dgvEstrategias";
            this.dgvEstrategias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstrategias.Size = new System.Drawing.Size(745, 325);
            this.dgvEstrategias.TabIndex = 8;
            this.dgvEstrategias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstrategias_CellContentClick);
            this.dgvEstrategias.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvEstrategias_RowsAdded);
            this.dgvEstrategias.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvEstrategias_RowsRemoved);
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
            this.btnGuardar.Text = "Guardar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            // 
            // EstrategiasDidacticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SistemaGestorRecursosDidacticos.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 581);
            this.Controls.Add(this.dgvEstrategias);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EstrategiasDidacticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estrategias Didacticas";
            this.Load += new System.EventHandler(this.EstrategiasDidacticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstrategias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEstrategias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn btnGuardar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;

    }
}