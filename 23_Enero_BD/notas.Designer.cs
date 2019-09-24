namespace _23_Enero_BD
{
    partial class notas
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
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.op2 = new System.Windows.Forms.RadioButton();
            this.op1 = new System.Windows.Forms.RadioButton();
            this.busqueda = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cedula = new System.Windows.Forms.TextBox();
            this.nota2 = new System.Windows.Forms.TextBox();
            this.nota1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.idnota = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(358, 4);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(198, 20);
            this.fecha.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.op2);
            this.groupBox1.Controls.Add(this.op1);
            this.groupBox1.Controls.Add(this.busqueda);
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 140);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Location = new System.Drawing.Point(26, 55);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(58, 17);
            this.op2.TabIndex = 20;
            this.op2.TabStop = true;
            this.op2.Text = "Cédula";
            this.op2.UseVisualStyleBackColor = true;
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Location = new System.Drawing.Point(26, 27);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(60, 17);
            this.op1.TabIndex = 19;
            this.op1.TabStop = true;
            this.op1.Text = "Id Nota";
            this.op1.UseVisualStyleBackColor = true;
            // 
            // busqueda
            // 
            this.busqueda.Location = new System.Drawing.Point(22, 85);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(151, 20);
            this.busqueda.TabIndex = 17;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(53, 109);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 25);
            this.buscar.TabIndex = 18;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(439, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 27);
            this.button4.TabIndex = 50;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(439, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 27);
            this.button3.TabIndex = 49;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(15, 169);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(421, 197);
            this.Tabla.TabIndex = 48;
            this.Tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 47;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(315, 119);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(100, 20);
            this.cedula.TabIndex = 46;
            // 
            // nota2
            // 
            this.nota2.Location = new System.Drawing.Point(315, 91);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(100, 20);
            this.nota2.TabIndex = 45;
            // 
            // nota1
            // 
            this.nota1.Location = new System.Drawing.Point(315, 65);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(100, 20);
            this.nota1.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cédula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nota 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nota 1";
            // 
            // button6
            // 
            this.button6.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.button6.Location = new System.Drawing.Point(439, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 33);
            this.button6.TabIndex = 55;
            this.button6.Text = "Reporte";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notasToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.notasToolStripMenuItem.Text = "Curso";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Regresar";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Id Nota";
            this.label1.Visible = false;
            // 
            // idnota
            // 
            this.idnota.Location = new System.Drawing.Point(315, 38);
            this.idnota.Name = "idnota";
            this.idnota.Size = new System.Drawing.Size(100, 20);
            this.idnota.TabIndex = 43;
            this.idnota.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 46);
            this.button2.TabIndex = 57;
            this.button2.Text = "Buscar Alumno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(439, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 27);
            this.button5.TabIndex = 58;
            this.button5.Text = "Nuevo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 387);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota1);
            this.Controls.Add(this.idnota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.notas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton op2;
        private System.Windows.Forms.RadioButton op1;
        private System.Windows.Forms.TextBox busqueda;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.TextBox nota2;
        private System.Windows.Forms.TextBox nota1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idnota;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}