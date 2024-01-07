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
    public partial class frm_chinh : Form
    {
        public frm_chinh()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelbody.Controls.Add(childForm);
            panelbody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void btnTrangchu_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGiangvien());
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhong());
        }

        private void thiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThietbi());
        }


        private void kếtXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xuấtDanhSáchThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DSThietbi());
        }

        private void tìmGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimGV());
        }

        private void danhSáchGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DSGiangVien());
        }

        private void tìmThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimthietbi());
        }

        private void danhSáchThiếtBịCủaPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmtb_phong());
        }

        private void dựĐoánBổSungThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dudoan());
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
    }
}
