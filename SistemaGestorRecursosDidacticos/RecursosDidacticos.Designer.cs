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
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecDidacticos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewRecDidacticos
            // 
            this.gridViewRecDidacticos.AllowUserToAddRows = false;
            this.gridViewRecDidacticos.AllowUserToDeleteRows = false;
            this.gridViewRecDidacticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRecDidacticos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indice,
            this.Nombre,
            this.btnGuardar,
            this.btnEliminar});
            this.gridViewRecDidacticos.Location = new System.Drawing.Point(113, 146);
            this.gridViewRecDidacticos.MultiSelect = false;
            this.gridViewRecDidacticos.Name = "gridViewRecDidacticos";
            this.gridViewRecDidacticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewRecDidacticos.Size = new System.Drawing.Size(744, 318);
            this.gridViewRecDidacticos.TabIndex = 0;
            this.gridViewRecDidacticos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewRecDidacticos_CellContentClick);
            this.gridViewRecDidacticos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridViewRecDidacticos_RowsAdded);
            this.gridViewRecDidacticos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridViewRecDidacticos_RowsRemoved);
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
            this.btnGuardar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn btnGuardar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;


    }
}