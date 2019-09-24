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
    public partial class BusquedaCurso : Form
    {
        public delegate void enviar(string nombre_curso ,string detalle);
        public event enviar dt_env;
        OdbcConnection con;
        public BusquedaCurso()
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
            OdbcDataAdapter da = new OdbcDataAdapter("select * from curso where estado=1", con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            Tabla.DataSource = ds;
            con.Close();
        }

        private void BusquedaCurso_Load(object sender, EventArgs e)
        {
          
            cargar_datos();
        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dt_env(Tabla.Rows[Tabla.CurrentRow.Index].Cells[0].Value.ToString(), Tabla.Rows[Tabla.CurrentRow.Index].Cells[1].Value.ToString());
            this.Hide();
        }
    }
}
