namespace _23_Enero_BD
{
    partial class BusquedaCurso
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
            this.Tabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(12, 12);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(507, 249);
            this.Tabla.TabIndex = 0;
            this.Tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_CellClick);
            this.Tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_CellContentClick);
            // 
            // BusquedaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 275);
            this.Controls.Add(this.Tabla);
            this.Name = "BusquedaCurso";
            this.Text = "BusquedaCurso";
            this.Load += new System.EventHandler(this.BusquedaCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabla;
    }
}