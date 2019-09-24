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
    public partial class login : Form
    {
        OdbcConnection con;    
        public login()
        {
            InitializeComponent();
        }
        private void conexion()
        {
            con = new OdbcConnection("Driver={MySQL ODBC 5.2w Driver};server=localhost;uid=root;password=1234;database=practica;port=3306");
            con.Open();
        }
        private void cadena(string sql)
        {
            conexion();
            OdbcCommand cmd = new OdbcCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (user.Text == "admin")
            {
                if (pass.Text == "admin")
                {
                    Menu mn = new Menu();
                    mn.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Contraseña/Usuario Erroneo");
            }
            /*cadena("select * from login where usuario = '" + textBox1.Text + "' and clave = '"+ textBox2.Text+"'");
            conexion();
            OdbcDataAdapter da = new OdbcDataAdapter("select * from login where usuario = '" + textBox1.Text + "' and clave = '" + textBox2.Text + "'", con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            tabla.DataSource = ds;
            if (tabla.RowCount == 1)
            {
                this.Hide();
                curso lg = new curso();
                lg.Show();

            }
            else
            {
                MessageBox.Show("Contraseña o Usuario incorrecto");
            }*/
           
        }
    }
}
