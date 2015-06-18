namespace SistemaGestorRecursosDidacticos
{
    partial class BitacoraReportes
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
            this.components = new System.ComponentModel.Container();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.planeamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataPlaneamientoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataPlaneamientoDataSet = new SistemaGestorRecursosDidacticos.DataPlaneamientoDataSet();
            this.elementosPlaneamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementosPlaneamientoTableAdapter = new SistemaGestorRecursosDidacticos.DataPlaneamientoDataSetTableAdapters.ElementosPlaneamientoTableAdapter();
            this.planeamientoTableAdapter = new SistemaGestorRecursosDidacticos.DataPlaneamientoDataSetTableAdapters.PlaneamientoTableAdapter();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.cbxAsignatura = new System.Windows.Forms.ComboBox();
            this.tbxProfesor = new System.Windows.Forms.TextBox();
            this.cbxNivel = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.tbxUnidad = new System.Windows.Forms.TextBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.Reporte = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.docenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlaneamientoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlaneamientoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementosPlaneamientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AllowUserToOrderColumns = true;
            this.dgvResultados.AutoGenerateColumns = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reporte,
            this.docenteDataGridViewTextBoxColumn,
            this.asignaturaDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn,
            this.unidadDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn});
            this.dgvResultados.DataSource = this.planeamientoBindingSource;
            this.dgvResultados.Location = new System.Drawing.Point(12, 93);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(1062, 426);
            this.dgvResultados.TabIndex = 0;
            // 
            // planeamientoBindingSource
            // 
            this.planeamientoBindingSource.DataMember = "Planeamiento";
            this.planeamientoBindingSource.DataSource = this.dataPlaneamientoDataSetBindingSource;
            // 
            // dataPlaneamientoDataSetBindingSource
            // 
            this.dataPlaneamientoDataSetBindingSource.DataSource = this.dataPlaneamientoDataSet;
            this.dataPlaneamientoDataSetBindingSource.Position = 0;
            // 
            // dataPlaneamientoDataSet
            // 
            this.dataPlaneamientoDataSet.DataSetName = "DataPlaneamientoDataSet";
            this.dataPlaneamientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elementosPlaneamientoBindingSource
            // 
            this.elementosPlaneamientoBindingSource.DataMember = "ElementosPlaneamiento";
            this.elementosPlaneamientoBindingSource.DataSource = this.dataPlaneamientoDataSetBindingSource;
            // 
            // elementosPlaneamientoTableAdapter
            // 
            this.elementosPlaneamientoTableAdapter.ClearBeforeFill = true;
            // 
            // planeamientoTableAdapter
            // 
            this.planeamientoTableAdapter.ClearBeforeFill = true;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.AutoEllipsis = true;
            this.btnGenerarReporte.Location = new System.Drawing.Point(971, 527);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(100, 23);
            this.btnGenerarReporte.TabIndex = 1;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // cbxAsignatura
            // 
            this.cbxAsignatura.FormattingEnabled = true;
            this.cbxAsignatura.Items.AddRange(new object[] {
            "Cualquiera",
            "Español",
            "Matemáticas",
            "Ciencias",
            "Estudios Sociales",
            "Francés",
            "Educación Musical",
            "Educación Religiosa",
            "Cómputo"});
            this.cbxAsignatura.Location = new System.Drawing.Point(97, 59);
            this.cbxAsignatura.Name = "cbxAsignatura";
            this.cbxAsignatura.Size = new System.Drawing.Size(224, 21);
            this.cbxAsignatura.TabIndex = 2;
            this.cbxAsignatura.SelectedIndexChanged += new System.EventHandler(this.cbxAsignatura_SelectedIndexChanged);
            // 
            // tbxProfesor
            // 
            this.tbxProfesor.Location = new System.Drawing.Point(95, 23);
            this.tbxProfesor.Name = "tbxProfesor";
            this.tbxProfesor.Size = new System.Drawing.Size(224, 20);
            this.tbxProfesor.TabIndex = 3;
            this.tbxProfesor.TextChanged += new System.EventHandler(this.tbxProfesor_TextChanged);
            // 
            // cbxNivel
            // 
            this.cbxNivel.FormattingEnabled = true;
            this.cbxNivel.Items.AddRange(new object[] {
            "Cualquiera",
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI"});
            this.cbxNivel.Location = new System.Drawing.Point(470, 59);
            this.cbxNivel.Name = "cbxNivel";
            this.cbxNivel.Size = new System.Drawing.Size(213, 21);
            this.cbxNivel.TabIndex = 4;
            this.cbxNivel.SelectedIndexChanged += new System.EventHandler(this.cbxNivel_SelectedIndexChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(826, 24);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(243, 20);
            this.dtpFechaInicio.TabIndex = 5;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(827, 59);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(243, 20);
            this.dtpFechaFin.TabIndex = 6;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(40, 26);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(49, 13);
            this.lblProfesor.TabIndex = 7;
            this.lblProfesor.Text = "Profesor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Asignatura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nivel:";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(424, 25);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(44, 13);
            this.lblUnidad.TabIndex = 10;
            this.lblUnidad.Text = "Unidad:";
            // 
            // tbxUnidad
            // 
            this.tbxUnidad.Location = new System.Drawing.Point(470, 22);
            this.tbxUnidad.Name = "tbxUnidad";
            this.tbxUnidad.Size = new System.Drawing.Size(213, 20);
            this.tbxUnidad.TabIndex = 11;
            this.tbxUnidad.TextChanged += new System.EventHandler(this.tbxUnidad_TextChanged);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(742, 27);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(82, 13);
            this.lblFechaInicio.TabIndex = 12;
            this.lblFechaInicio.Text = "Fecha de inicio:";
            this.lblFechaInicio.Click += new System.EventHandler(this.lblFechaInicio_Click);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(756, 61);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(69, 13);
            this.lblFechaFin.TabIndex = 13;
            this.lblFechaFin.Text = "Fecha de fin:";
            // 
            // Reporte
            // 
            this.Reporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Reporte.HeaderText = "Reporte";
            this.Reporte.Name = "Reporte";
            this.Reporte.ReadOnly = true;
            this.Reporte.Width = 51;
            // 
            // docenteDataGridViewTextBoxColumn
            // 
            this.docenteDataGridViewTextBoxColumn.DataPropertyName = "Docente";
            this.docenteDataGridViewTextBoxColumn.HeaderText = "Docente";
            this.docenteDataGridViewTextBoxColumn.Name = "docenteDataGridViewTextBoxColumn";
            this.docenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asignaturaDataGridViewTextBoxColumn
            // 
            this.asignaturaDataGridViewTextBoxColumn.DataPropertyName = "Asignatura";
            this.asignaturaDataGridViewTextBoxColumn.HeaderText = "Asignatura";
            this.asignaturaDataGridViewTextBoxColumn.Name = "asignaturaDataGridViewTextBoxColumn";
            this.asignaturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            this.nivelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadDataGridViewTextBoxColumn
            // 
            this.unidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad";
            this.unidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
            this.unidadDataGridViewTextBoxColumn.Name = "unidadDataGridViewTextBoxColumn";
            this.unidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha_Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Fin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "Fecha_Fin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            this.fechaFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BitacoraReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 555);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.tbxUnidad);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cbxNivel);
            this.Controls.Add(this.tbxProfesor);
            this.Controls.Add(this.cbxAsignatura);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.dgvResultados);
            this.Name = "BitacoraReportes";
            this.Text = "BitacoraReportes";
            this.Load += new System.EventHandler(this.BitacoraReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlaneamientoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlaneamientoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementosPlaneamientoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.BindingSource dataPlaneamientoDataSetBindingSource;
        private DataPlaneamientoDataSet dataPlaneamientoDataSet;
        private System.Windows.Forms.BindingSource elementosPlaneamientoBindingSource;
        private DataPlaneamientoDataSetTableAdapters.ElementosPlaneamientoTableAdapter elementosPlaneamientoTableAdapter;
        private System.Windows.Forms.BindingSource planeamientoBindingSource;
        private DataPlaneamientoDataSetTableAdapters.PlaneamientoTableAdapter planeamientoTableAdapter;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.ComboBox cbxAsignatura;
        private System.Windows.Forms.TextBox tbxProfesor;
        private System.Windows.Forms.ComboBox cbxNivel;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox tbxUnidad;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn docenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
    }
}