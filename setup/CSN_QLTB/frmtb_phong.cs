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
    public partial class frmtb_phong : Form
    {
        public frmtb_phong()
        {
            InitializeComponent();
        }

        private void frmtb_phong_Load(object sender, EventArgs e)
        {
            LoadMaPhongToComboBox();
            this.rptthietbi.RefreshReport();
        }
        private void LoadMaPhongToComboBox()
        {
            // Xóa mọi item cũ trong ComboBox
            cb_maphong.Items.Clear();

            // Thực hiện truy vấn để lấy mã phòng từ bảng Phong
            using (SqlConnection connection = new SqlConnection("Data Source=PC\\SQLEXPRESS;database=CSN_QLTB_31/12;Integrated Security=true"))
            {
                connection.Open();

                string query = "SELECT ID_PHONG FROM PHONG";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Thêm mã phòng vào ComboBox
                            cb_maphong.Items.Add(reader["ID_PHONG"].ToString());
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
            string sql = "select a.ID_TB,a.TEN_TB,a.NAM_SX from THIETBI as a , PHONG as b, SUDUNG as c where a.ID_TB=c.ID_TB and c.ID_PHONG=b.ID_PHONG and c.ID_PHONG='"+cb_maphong.Text+"'";
            bodocghi = new SqlDataAdapter(sql, ketnoi);
            bodocghi.Fill(banggv);
            rptthietbi.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rptthietbi.LocalReport.ReportPath = ("rpt_tbphong.rdlc");
            if (banggv.Rows.Count > 0)
            {
                ReportDataSource nguondl = new ReportDataSource();
                nguondl.Name = "rpttbp";
                nguondl.Value = banggv;
                rptthietbi.LocalReport.DataSources.Clear();
                rptthietbi.LocalReport.DataSources.Add(nguondl);
                rptthietbi.RefreshReport();
            }
        }
    }
}
