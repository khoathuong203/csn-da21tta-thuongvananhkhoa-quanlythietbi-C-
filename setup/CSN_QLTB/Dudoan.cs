using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSN_QLTB
{
    public partial class Dudoan : Form
    {
        public Dudoan()
        {
            InitializeComponent();
        }

        private void Dudoan_Load(object sender, EventArgs e)
        {
            this.rpt_dudoan.RefreshReport();
            SqlConnection ketnoi;
            SqlDataAdapter bodocghi;
            DataTable banggv = new DataTable();
            ketnoi = new SqlConnection();
            string chuoikn = "Data Source=PC\\SQLEXPRESS;database=CSN_QLTB_31/12;Integrated Security=true";
            ketnoi.ConnectionString = chuoikn;
            string sql = "SELECT b.ID_PHONG, a.ID_TB, a.TEN_TB, c.TEN_GV, a.NAM_SX FROM THIETBI as a, SUDUNG as b, GIANGVIEN as c  WHERE a.ID_TB=b.ID_TB and b.ID_GV=c.ID_GV and a.NAM_SX <= DATEADD(YEAR, -10, GETDATE())";
            bodocghi = new SqlDataAdapter(sql, ketnoi);
            bodocghi.Fill(banggv);
            rpt_dudoan.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rpt_dudoan.LocalReport.ReportPath = ("rptdudoan.rdlc");
            if (banggv.Rows.Count > 0)
            {
                ReportDataSource nguondl = new ReportDataSource();
                nguondl.Name = "dudoan";
                nguondl.Value = banggv;
                rpt_dudoan.LocalReport.DataSources.Clear();
                rpt_dudoan.LocalReport.DataSources.Add(nguondl);
                rpt_dudoan.RefreshReport();
            }
        }
    }
}
