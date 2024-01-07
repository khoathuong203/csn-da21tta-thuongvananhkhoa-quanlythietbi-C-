using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSN_QLTB
{
    public partial class DSGiangVien : Form
    {
        public DSGiangVien()
        {
            InitializeComponent();
        }

        private void DSGiangVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_CSN_QLTB_31_12DataSet.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this._CSN_QLTB_31_12DataSet.GIANGVIEN);

            this.reportViewer1.RefreshReport();
        }
    }
}
