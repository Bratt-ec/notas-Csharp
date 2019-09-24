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
    public partial class Form1 : Form
    {
        //cadena de conecxion =   Driver={MySQL ODBC 5.2w Driver};server=localhost;uid=root;database=sextob;port=3306           
         OdbcConnection con;        
        public Form1()
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
            OdbcDataAdapter da  =  new OdbcDataAdapter("select cedula,nombre,apellido,direccion,telefono from usuarios where estado = 1",con);
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
        private void Form1_Load(object sender, EventArgs e)
        {
            cargar_datos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadena("Insert into usuarios(cedula,nombre,apellido,direccion,telefono,fecha) values('" + Cedula.Text + "','" + Nombre.Text + "','" + Apellido.Text + "','" + Direccion.Text + "','" + Telefono.Text + "','"+fecha.Text+"')");                 
            MessageBox.Show("Guardado");
            Nombre.Clear();
            Apellido.Clear();
            Cedula.Clear();
            Direccion.Clear();
            Telefono.Clear();
            cargar_datos();         
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cargar_datos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadena("update usuarios set estado = '0' where cedula = '" + Cedula.Text + "'");
            MessageBox.Show("Registro Eliminado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cadena("update usuarios set nombre = '" + Nombre.Text + "' where cedula = '" + Cedula.Text + "'");
            MessageBox.Show("Registro Modificado");
        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cedula.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[0].Value.ToString();
            Nombre.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[1].Value.ToString();
            Apellido.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[2].Value.ToString();
            Direccion.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[3].Value.ToString();
            Telefono.Text = Tabla.Rows[Tabla.CurrentRow.Index].Cells[4].Value.ToString();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            conexion();
            if (radioButton1.Checked == true)
            {
                OdbcDataAdapter da = new OdbcDataAdapter("select cedula,nombre,apellido,direccion,telefono from usuarios where nombre = '" + busqueda.Text + "'", con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                Tabla.DataSource = ds;
            }
            if (radioButton2.Checked == true)
            {
                 OdbcDataAdapter d = new OdbcDataAdapter("select cedula,nombre,apellido,direccion,telefono from usuarios where cedula ='" + busqueda.Text + "'", con);
                DataTable ds = new DataTable();
                d.Fill(ds);
                Tabla.DataSource = ds;
            }                        
        }
        public void ejecutar(string nombre_curso,string detalle)
        {
            id_curso.Text = nombre_curso;
            detalle_c.Text = detalle;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            BusquedaCurso bc = new BusquedaCurso();
            bc.Show();
            bc.dt_env += new BusquedaCurso.enviar(ejecutar);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reporte Report = new reporte();
            Report.Show();          
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notas nt = new notas();
            nt.Show();
            this.Hide();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            curso fr = new curso();
            fr.Show();
            this.Hide();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void id_curso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
