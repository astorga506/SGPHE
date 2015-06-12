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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosDidacticos));
            this.gridViewRecDidacticos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Enlace,
            this.btnGuardar,
            this.btnEliminar});
            this.gridViewRecDidacticos.Location = new System.Drawing.Point(113, 160);
            this.gridViewRecDidacticos.MultiSelect = false;
            this.gridViewRecDidacticos.Name = "gridViewRecDidacticos";
            this.gridViewRecDidacticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewRecDidacticos.Size = new System.Drawing.Size(744, 318);
            this.gridViewRecDidacticos.TabIndex = 0;
            this.gridViewRecDidacticos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewRecDidacticos_CellContentClick);
            this.gridViewRecDidacticos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridViewRecDidacticos_RowsAdded);
            this.gridViewRecDidacticos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridViewRecDidacticos_RowsRemoved);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Los Recursos Didácticos brindan la posibilidad de guardar enlaces con información" +
    " importante \r\npara cada docente. Les permite consultar en todo momento esta info" +
    "rmación del sitio almacenado.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Indice
            // 
            this.Indice.HeaderText = "Índice";
            this.Indice.Name = "Indice";
            this.Indice.ReadOnly = true;
            // 
            // Enlace
            // 
            this.Enlace.HeaderText = "Enlace";
            this.Enlace.Name = "Enlace";
            this.Enlace.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Enlace.Width = 400;
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridViewRecDidacticos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecursosDidacticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos Didacticos";
            this.Load += new System.EventHandler(this.RecursosDidacticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecDidacticos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewRecDidacticos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enlace;
        private System.Windows.Forms.DataGridViewButtonColumn btnGuardar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;


    }
}