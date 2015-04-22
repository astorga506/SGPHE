namespace SistemaGestorRecursosDidacticos
{
    partial class Recordatorio
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
            this.btnNuevoRecor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoRecor
            // 
            this.btnNuevoRecor.Location = new System.Drawing.Point(865, 104);
            this.btnNuevoRecor.Name = "btnNuevoRecor";
            this.btnNuevoRecor.Size = new System.Drawing.Size(92, 23);
            this.btnNuevoRecor.TabIndex = 0;
            this.btnNuevoRecor.Text = "Nuevo Recordatorio";
            this.btnNuevoRecor.UseVisualStyleBackColor = true;
            this.btnNuevoRecor.Click += new System.EventHandler(this.btnNuevoRecor_Click);
            // 
            // Recordatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SistemaGestorRecursosDidacticos.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 581);
            this.Controls.Add(this.btnNuevoRecor);
            this.DoubleBuffered = true;
            this.Name = "Recordatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoRecor;
    }
}