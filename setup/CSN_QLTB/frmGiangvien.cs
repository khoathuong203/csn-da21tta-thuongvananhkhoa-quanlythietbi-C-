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
    public partial class frmGiangvien : Form
    {
        public frmGiangvien()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIANGVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CSN_QLTB_31_12DataSet);

        }

        private void frmGiangvien_Load(object sender, EventArgs e)
        {
            LoadMaPhongToComboBox();
            this.gIANGVIENTableAdapter.Fill(this._CSN_QLTB_31_12DataSet.GIANGVIEN);

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

        private void button3_Click(object sender, EventArgs e)
        {
            frm_chinh frm = new frm_chinh();
            frm.btnTrangchu_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addItem t = new addItem();

            t.addGV(txtMaGv.Text, txtTenGv.Text);
            t.addo(cb_maphong.Text, txtMaGv.Text);
            frmGiangvien_Load(sender, e);
        }
    }
}

