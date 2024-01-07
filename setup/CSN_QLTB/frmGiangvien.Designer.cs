namespace CSN_QLTB
{
    partial class frmGiangvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbMaGv = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.txtTenGv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._CSN_QLTB_31_12DataSet = new CSN_QLTB._CSN_QLTB_31_12DataSet();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.TableAdapterManager();
            this.txtMaGv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_maphong = new System.Windows.Forms.ComboBox();
            this.gIANGVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._CSN_QLTB_31_12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaGv
            // 
            this.lbMaGv.AutoSize = true;
            this.lbMaGv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaGv.Location = new System.Drawing.Point(28, 90);
            this.lbMaGv.Name = "lbMaGv";
            this.lbMaGv.Size = new System.Drawing.Size(106, 20);
            this.lbMaGv.TabIndex = 0;
            this.lbMaGv.Text = "Mã giảng viên";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(28, 145);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(111, 20);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Tên giảng viên";
            // 
            // txtTenGv
            // 
            this.txtTenGv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGv.Location = new System.Drawing.Point(177, 143);
            this.txtTenGv.Name = "txtTenGv";
            this.txtTenGv.Size = new System.Drawing.Size(219, 26);
            this.txtTenGv.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(335, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "NHẬP THÔNG TIN GIẢNG VIÊN";
            // 
            // _CSN_QLTB_31_12DataSet
            // 
            this._CSN_QLTB_31_12DataSet.DataSetName = "_CSN_QLTB_31_12DataSet";
            this._CSN_QLTB_31_12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this._CSN_QLTB_31_12DataSet;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.OTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.SUDUNGTableAdapter = null;
            this.tableAdapterManager.THIETBITableAdapter = null;
            this.tableAdapterManager.THONGSOTableAdapter = null;
            this.tableAdapterManager.THUOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtMaGv
            // 
            this.txtMaGv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGv.Location = new System.Drawing.Point(177, 90);
            this.txtMaGv.Name = "txtMaGv";
            this.txtMaGv.Size = new System.Drawing.Size(219, 26);
            this.txtMaGv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng";
            // 
            // cb_maphong
            // 
            this.cb_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_maphong.FormattingEnabled = true;
            this.cb_maphong.Location = new System.Drawing.Point(569, 87);
            this.cb_maphong.Name = "cb_maphong";
            this.cb_maphong.Size = new System.Drawing.Size(219, 28);
            this.cb_maphong.TabIndex = 4;
            // 
            // gIANGVIENDataGridView
            // 
            this.gIANGVIENDataGridView.AllowUserToAddRows = false;
            this.gIANGVIENDataGridView.AutoGenerateColumns = false;
            this.gIANGVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gIANGVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.gIANGVIENDataGridView.DataSource = this.gIANGVIENBindingSource;
            this.gIANGVIENDataGridView.Location = new System.Drawing.Point(241, 210);
            this.gIANGVIENDataGridView.Name = "gIANGVIENDataGridView";
            this.gIANGVIENDataGridView.ReadOnly = true;
            this.gIANGVIENDataGridView.Size = new System.Drawing.Size(343, 141);
            this.gIANGVIENDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_GV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã giảng viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TEN_GV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên giảng viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // frmGiangvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 521);
            this.Controls.Add(this.gIANGVIENDataGridView);
            this.Controls.Add(this.cb_maphong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTenGv);
            this.Controls.Add(this.txtMaGv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbMaGv);
            this.Name = "frmGiangvien";
            this.Text = "frmGiangvien";
            this.Load += new System.EventHandler(this.frmGiangvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this._CSN_QLTB_31_12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaGv;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txtTenGv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private _CSN_QLTB_31_12DataSet _CSN_QLTB_31_12DataSet;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private _CSN_QLTB_31_12DataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private _CSN_QLTB_31_12DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtMaGv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_maphong;
        private System.Windows.Forms.DataGridView gIANGVIENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}