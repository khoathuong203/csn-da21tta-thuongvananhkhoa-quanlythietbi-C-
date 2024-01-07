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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        private void pHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHONGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CSN_QLTB_31_12DataSet);

        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_CSN_QLTB_31_12DataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this._CSN_QLTB_31_12DataSet.PHONG);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addItem t = new addItem();
            t.addPhong(txtid.Text, txtten.Text, int.Parse(nudsl.Value.ToString()));
            frmPhong_Load(sender, e);
        }
    }
}
