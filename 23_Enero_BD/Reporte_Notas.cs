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
    public partial class Reporte_Notas : Form
    {
        OdbcConnection con;  
        public Reporte_Notas()
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

        private void Reporte_Notas_Load(object sender, EventArgs e)
        {
            conexion();
            OdbcDataAdapter da = new OdbcDataAdapter("select id_notas,nota1,nota2,cedula from notas where estado = 1", con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            Notas rpt_alm = new Notas();
            rpt_alm.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt_alm;
        }
    }
}
