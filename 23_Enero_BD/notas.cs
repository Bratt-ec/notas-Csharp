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
    public partial class notas : Form
    {
        OdbcConnection con;   
        public notas()
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
            OdbcDataAdapter da = new OdbcDataAdapter("select id_notas,nota1,nota2,cedula from notas where estado = 1", con);
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
        private void notas_Load(object sender, EventArgs e)
        {
            cargar_datos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cadena("update notas set nota1 = '" + nota1.Text + "',nota2 = '" + nota2.Text + "'  where id_notas='" + idnota.Text + "'");
            MessageBox.Show("Registro Modificado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadena("Insert into notas(nota1,nota2,cedula) values('" + nota1.Text + "','" + nota2.Text + "','" + cedula.Text + "')");
            MessageBox.Show("Guardado");
            idnota.Clear();
            nota1.Clear();
            nota2.Clear();
            cedula.Clear();           
            cargar_datos();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadena("update notas set estado = '0' where cedula = '" + cedula.Text + "'");
            MessageBox.Show("Registro Eliminado");
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            conexion();
            if (op1.Checked == true)
            {
                OdbcDataAdapter da = new OdbcDataAdapter("select id_notas,nota1,nota2,cedula from notas where id_notas = '" + busqueda.Text + "'", con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                Tabla.DataSource = ds;
            }
            if (op2.Checked == true)
            {
                OdbcDataAdapter d = new OdbcDataAdapter("select id_notas,nota1,nota2,cedula from notas where cedula ='" + busqueda.Text + "'", con);
                DataTable ds = new DataTable();
                d.Fill(ds);
                Tabla.DataSource = ds;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reporte_Notas Report_n = new Reporte_Notas();
            Report_n.Show();       
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            curso fr = new curso();
            fr.Show();
            this.Hide();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void Tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idnota.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[0].Value.ToString();
            nota1.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[1].Value.ToString();
            nota2.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[2].Value.ToString();
            cedula.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[3].Value.ToString();
            
        }
        public void ejecutar(string cedula_e)
        {
            cedula.Text = cedula_e;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BusquedaAlumno busqA = new BusquedaAlumno();
            busqA.Show();
            busqA.dt_env += new BusquedaAlumno.enviar(ejecutar);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            idnota.Clear();
            nota1.Clear();
            nota2.Clear();
            cedula.Clear();
            cargar_datos();
        }
    }
}
