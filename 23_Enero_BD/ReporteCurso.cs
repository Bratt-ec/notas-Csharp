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
    public partial class ReporteCurso : Form
    {
        OdbcConnection con;
        public ReporteCurso()
        {
            InitializeComponent();
        }
    public void conexion()   
    {
            con = new OdbcConnection("Driver={MySQL ODBC 5.2w Driver};server=localhost;uid=root;password=1234;database=practica;port=3306");
            con.Open();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void ReporteCurso_Load(object sender, EventArgs e)
        {
            conexion();
            OdbcDataAdapter da = new OdbcDataAdapter("select id_curso,Detalle_curso,paralelo,jornada,semestre from curso where estado = 1", con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            Curso rpt_alm = new Curso();
            rpt_alm.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt_alm;
        }
    }
}
