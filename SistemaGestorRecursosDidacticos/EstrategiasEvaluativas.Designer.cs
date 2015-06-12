namespace SistemaGestorRecursosDidacticos
{
    partial class EstrategiasEvaluativas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstrategiasEvaluativas));
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
            this.label1.Location = new System.Drawing.Point(138, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
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
            this.dgvEstrategias.Location = new System.Drawing.Point(141, 205);
            this.dgvEstrategias.Name = "dgvEstrategias";
            this.dgvEstrategias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstrategias.Size = new System.Drawing.Size(744, 292);
            this.dgvEstrategias.TabIndex = 6;
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
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            // 
            // EstrategiasEvaluativas
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
            this.Name = "EstrategiasEvaluativas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstrategiasEvaluativas";
            this.Load += new System.EventHandler(this.EstrategiasEvaluativas_Load);
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