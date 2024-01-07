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
    public partial class frmTimthietbi : Form
    {
        public frmTimthietbi()
        {
            InitializeComponent();
        }

        private void frmTimthietbi_Load(object sender, EventArgs e)
        {

            this.rptTimTb.RefreshReport();
            LoadMaGVToComboBox();
        }
        private void LoadMaGVToComboBox()
        {
            // Xóa mọi item cũ trong ComboBox
            cbMaGV.Items.Clear();

            // Thực hiện truy vấn để lấy mã phòng từ bảng Phong
            using (SqlConnection connection = new SqlConnection("Data Source=PC\\SQLEXPRESS;database=CSN_QLTB_31/12;Integrated Security=true"))
            {
                connection.Open();

                string query = "SELECT TEN_GV FROM GIANGVIEN";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Thêm mã phòng vào ComboBox
                            cbMaGV.Items.Add(reader["TEN_GV"].ToString());
                        }
                    }
                }
            }

        }

        private void bnTim_Click(object sender, EventArgs e)
        {
            SqlConnection ketnoi;
            SqlDataAdapter bodocghi;
            DataTable banggv = new DataTable();
            ketnoi = new SqlConnection();
            string chuoikn = "Data Source=PC\\SQLEXPRESS;database=CSN_QLTB_31/12;Integrated Security=true";
            ketnoi.ConnectionString = chuoikn;
            string sql = "SELECT a.ID_TB,a.TEN_TB,a.NAM_SX FROM THIETBI as a, SUDUNG as b,GIANGVIEN as c WHERE a.ID_TB=b.ID_TB and b.ID_GV=c.ID_GV and c.TEN_GV like '%"+cbMaGV.Text+"'";
            bodocghi = new SqlDataAdapter(sql, ketnoi);
            bodocghi.Fill(banggv);
            rptTimTb.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rptTimTb.LocalReport.ReportPath = ("rpt_tbphong.rdlc");
            if (banggv.Rows.Count > 0)
            {
                ReportDataSource nguondl = new ReportDataSource();
                nguondl.Name = "rpttbp";
                nguondl.Value = banggv;
                rptTimTb.LocalReport.DataSources.Clear();
                rptTimTb.LocalReport.DataSources.Add(nguondl);
                rptTimTb.RefreshReport();
            }
        }
    }
}
