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
    public partial class frmTimGV : Form
    {
        public frmTimGV()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIANGVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CSN_QLTB_31_12DataSet);

        }

        private void frmTimGV_Load(object sender, EventArgs e)
        {
            LoadMaPhongToComboBox();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection ketnoi;
            SqlDataAdapter bodocghi;
            DataTable banggv = new DataTable();
            ketnoi = new SqlConnection();
            string chuoikn = "Data Source=PC\\SQLEXPRESS;database=CSN_QLTB_31/12;Integrated Security=true";
            ketnoi.ConnectionString = chuoikn;
            string sql = "SELECT a.ID_GV,a.TEN_GV FROM GIANGVIEN as a, PHONG as b,O as c WHERE a.ID_GV=c.ID_GV and c.ID_PHONG=b.ID_PHONG and b.ID_PHONG='" + cb_maphong.Text + "'";
            bodocghi = new SqlDataAdapter(sql, ketnoi);
            bodocghi.Fill(banggv);
            rpv_gv.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rpv_gv.LocalReport.ReportPath = ("TimGV.rdlc");
            if (banggv.Rows.Count > 0)
            {
                ReportDataSource nguondl = new ReportDataSource();
                nguondl.Name = "dsgv";
                nguondl.Value = banggv;
                rpv_gv.LocalReport.DataSources.Clear();
                rpv_gv.LocalReport.DataSources.Add(nguondl);
                rpv_gv.RefreshReport();
            }
        }
    }
}