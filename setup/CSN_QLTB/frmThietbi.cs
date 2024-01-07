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
    public partial class frmThietbi : Form
    {
        public frmThietbi()
        {
            InitializeComponent();
        }

        private void tHIETBIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tHIETBIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CSN_QLTB_31_12DataSet);

        }

        private void frmThietbi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_CSN_QLTB_31_12DataSet.THIETBI' table. You can move, or remove it, as needed.
            this.tHIETBITableAdapter.Fill(this._CSN_QLTB_31_12DataSet.THIETBI);
            LoadMaPhongToComboBox();
            LoadMaGVToComboBox();

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
        private void LoadMaGVToComboBox()
        {
            // Xóa mọi item cũ trong ComboBox
            cb_magv.Items.Clear();

            // Thực hiện truy vấn để lấy mã phòng từ bảng Phong
            using (SqlConnection connection = new SqlConnection("Data Source=PC\\SQLEXPRESS;database=CSN_QLTB_31/12;Integrated Security=true"))
            {
                connection.Open();

                string query = "SELECT ID_GV FROM GIANGVIEN";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Thêm mã phòng vào ComboBox
                            cb_magv.Items.Add(reader["ID_GV"].ToString());
                        }
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addItem t = new addItem();
            DateTime selectedDate = dtpnsx.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd HH:mm:ss");
            t.addTB(txtid.Text, txtten.Text, formattedDate);
            t.addthuoc(txtid.Text, cb_maphong.Text);
            t.addsd(txtid.Text, cb_magv.Text, cb_maphong.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtten.Text = "";
            dtpnsx.Value = DateTime.Now;
            cb_magv.Text = "";
            cb_maphong.Text = "";
        }
    }
}
