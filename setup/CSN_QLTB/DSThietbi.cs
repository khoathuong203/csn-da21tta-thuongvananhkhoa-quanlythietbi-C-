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
    public partial class DSThietbi : Form
    {
        public DSThietbi()
        {
            InitializeComponent();
        }

        private void DSThietbi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_CSN_QLTB_31_12DataSet.THIETBI' table. You can move, or remove it, as needed.
            this.tHIETBITableAdapter.Fill(this._CSN_QLTB_31_12DataSet.THIETBI);

            this.reportViewer1.RefreshReport();
        }
    }
}
