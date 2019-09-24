namespace _23_Enero_BD
{
    partial class curso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Jornada_op = new System.Windows.Forms.RadioButton();
            this.id_curso = new System.Windows.Forms.RadioButton();
            this.busqueda = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.semestre = new System.Windows.Forms.TextBox();
            this.jornada = new System.Windows.Forms.TextBox();
            this.paralelo = new System.Windows.Forms.TextBox();
            this.idcurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.detalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Jornada_op);
            this.groupBox1.Controls.Add(this.id_curso);
            this.groupBox1.Controls.Add(this.busqueda);
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Location = new System.Drawing.Point(15, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 140);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // Jornada_op
            // 
            this.Jornada_op.AutoSize = true;
            this.Jornada_op.Location = new System.Drawing.Point(26, 55);
            this.Jornada_op.Name = "Jornada_op";
            this.Jornada_op.Size = new System.Drawing.Size(63, 17);
            this.Jornada_op.TabIndex = 20;
            this.Jornada_op.TabStop = true;
            this.Jornada_op.Text = "Jornada";
            this.Jornada_op.UseVisualStyleBackColor = true;
            // 
            // id_curso
            // 
            this.id_curso.AutoSize = true;
            this.id_curso.Location = new System.Drawing.Point(26, 27);
            this.id_curso.Name = "id_curso";
            this.id_curso.Size = new System.Drawing.Size(64, 17);
            this.id_curso.TabIndex = 19;
            this.id_curso.TabStop = true;
            this.id_curso.Text = "Id Curso";
            this.id_curso.UseVisualStyleBackColor = true;
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
            this.button4.Location = new System.Drawing.Point(439, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 27);
            this.button4.TabIndex = 34;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(439, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 27);
            this.button3.TabIndex = 33;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(15, 196);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(514, 197);
            this.Tabla.TabIndex = 31;
            this.Tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_CellClick);
            this.Tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 30;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // semestre
            // 
            this.semestre.Location = new System.Drawing.Point(315, 118);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(100, 20);
            this.semestre.TabIndex = 28;
            // 
            // jornada
            // 
            this.jornada.Location = new System.Drawing.Point(315, 90);
            this.jornada.Name = "jornada";
            this.jornada.Size = new System.Drawing.Size(100, 20);
            this.jornada.TabIndex = 27;
            // 
            // paralelo
            // 
            this.paralelo.Location = new System.Drawing.Point(315, 64);
            this.paralelo.Name = "paralelo";
            this.paralelo.Size = new System.Drawing.Size(100, 20);
            this.paralelo.TabIndex = 26;
            // 
            // idcurso
            // 
            this.idcurso.Location = new System.Drawing.Point(315, 37);
            this.idcurso.Name = "idcurso";
            this.idcurso.Size = new System.Drawing.Size(100, 20);
            this.idcurso.TabIndex = 25;
            this.idcurso.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Semestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Jornada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Paralelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Id Curso";
            this.label1.Visible = false;
            // 
            // detalle
            // 
            this.detalle.Location = new System.Drawing.Point(315, 144);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(100, 20);
            this.detalle.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Detalle Curso";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(358, 3);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(198, 20);
            this.fecha.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 27);
            this.button2.TabIndex = 39;
            this.button2.Text = "Reporte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.notasToolStripMenuItem.Text = "Notas";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Regresar";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(439, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 27);
            this.button5.TabIndex = 41;
            this.button5.Text = "Nuevo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 405);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.detalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.semestre);
            this.Controls.Add(this.jornada);
            this.Controls.Add(this.paralelo);
            this.Controls.Add(this.idcurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "curso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.curso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Jornada_op;
        private System.Windows.Forms.RadioButton id_curso;
        private System.Windows.Forms.TextBox busqueda;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox semestre;
        private System.Windows.Forms.TextBox jornada;
        private System.Windows.Forms.TextBox paralelo;
        private System.Windows.Forms.TextBox idcurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox detalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Button button5;
    }
}