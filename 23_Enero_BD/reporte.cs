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
    public partial class reporte : Form
    {
        OdbcConnection con;  
        public reporte()
        {
            InitializeComponent();
        }
        private void conexion()
        {
            con = new OdbcConnection("Driver={MySQL ODBC 5.2w Driver};server=localhost;uid=root;password=1234;database=practica;port=3306");
            con.Open();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reporte_Load(object sender, EventArgs e)
        {
            conexion();
            OdbcDataAdapter da = new OdbcDataAdapter("select cedula,nombre,apellido,direccion,telefono from usuarios where estado = 1", con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            ReporteAlumno rpt_alm = new ReporteAlumno();
            rpt_alm.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt_alm;
        }
    }
}
