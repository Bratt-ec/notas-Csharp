using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace _23_Enero_BD
{
    public partial class curso : Form
    {
        OdbcConnection con;   
        public curso()
        {
            InitializeComponent();
        }
        private void conexion()
        {
            con = new OdbcConnection("Driver={MySQL ODBC 5.2w Driver};server=localhost;uid=root;password=1234;database=practica;port=3306");
            con.Open();
        }
        private void cargar_datos()
        {
            conexion();
            OdbcDataAdapter da = new OdbcDataAdapter("select id_curso,Detalle_curso,paralelo,jornada,semestre from curso where estado = 1", con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            Tabla.DataSource = ds;
            con.Close();
        }
        private void cadena(string sql)
        {
            conexion();
            OdbcCommand cmd = new OdbcCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cargar_datos();
        }
        private void curso_Load(object sender, EventArgs e)
        {            
            cargar_datos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadena("Insert into curso(Detalle_curso,paralelo,jornada,semestre) values('" + detalle.Text + "','" + paralelo.Text + "','" + jornada.Text + "','" + semestre.Text + "')");
            MessageBox.Show("Guardado");
            paralelo.Clear();
            jornada.Clear();
            semestre.Clear();
            detalle.Clear();            
            cargar_datos();         

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadena("update curso set estado = '0' where id_curso = '" + idcurso.Text + "'");
            MessageBox.Show("Registro Eliminado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cadena("update curso set Detalle_curso = '" + detalle.Text + "',paralelo = '" + paralelo.Text + "' ,jornada = '" + jornada.Text + "',semestre = '" + semestre.Text + "' where id_curso='"+idcurso.Text+"'");
            MessageBox.Show("Registro Modificado");
        }

        private void Tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idcurso.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[0].Value.ToString();
            detalle.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[1].Value.ToString();
            paralelo.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[2].Value.ToString();
            jornada.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[3].Value.ToString();
            semestre.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[4].Value.ToString();
        }

        private void buscar_Click(object sender, EventArgs e)
        {

        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteCurso R_curso = new ReporteCurso();
            R_curso.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notas nt = new notas();
            nt.Show();
            this.Hide();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            paralelo.Clear();
            jornada.Clear();
            semestre.Clear();
            detalle.Clear();
            cargar_datos();
        }
    }
}
