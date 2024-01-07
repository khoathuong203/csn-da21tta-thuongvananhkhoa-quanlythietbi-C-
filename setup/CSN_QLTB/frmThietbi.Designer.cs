namespace CSN_QLTB
{
    partial class frmThietbi
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
            System.Windows.Forms.Label iD_TBLabel;
            System.Windows.Forms.Label tEN_TBLabel;
            System.Windows.Forms.Label nAM_SXLabel;
            System.Windows.Forms.Label lbbanner;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this._CSN_QLTB_31_12DataSet = new CSN_QLTB._CSN_QLTB_31_12DataSet();
            this.tHIETBIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHIETBITableAdapter = new CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.THIETBITableAdapter();
            this.tableAdapterManager = new CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.TableAdapterManager();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.dtpnsx = new System.Windows.Forms.DateTimePicker();
            this.tHIETBIDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_maphong = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_magv = new System.Windows.Forms.ComboBox();
            iD_TBLabel = new System.Windows.Forms.Label();
            tEN_TBLabel = new System.Windows.Forms.Label();
            nAM_SXLabel = new System.Windows.Forms.Label();
            lbbanner = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._CSN_QLTB_31_12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIETBIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIETBIDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_TBLabel
            // 
            iD_TBLabel.AutoSize = true;
            iD_TBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_TBLabel.Location = new System.Drawing.Point(60, 82);
            iD_TBLabel.Name = "iD_TBLabel";
            iD_TBLabel.Size = new System.Drawing.Size(82, 20);
            iD_TBLabel.TabIndex = 1;
            iD_TBLabel.Text = "Mã thiết bị";
            // 
            // tEN_TBLabel
            // 
            tEN_TBLabel.AutoSize = true;
            tEN_TBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tEN_TBLabel.Location = new System.Drawing.Point(60, 124);
            tEN_TBLabel.Name = "tEN_TBLabel";
            tEN_TBLabel.Size = new System.Drawing.Size(87, 20);
            tEN_TBLabel.TabIndex = 3;
            tEN_TBLabel.Text = "Tên thiết bị";
            // 
            // nAM_SXLabel
            // 
            nAM_SXLabel.AutoSize = true;
            nAM_SXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nAM_SXLabel.Location = new System.Drawing.Point(60, 166);
            nAM_SXLabel.Name = "nAM_SXLabel";
            nAM_SXLabel.Size = new System.Drawing.Size(106, 20);
            nAM_SXLabel.TabIndex = 5;
            nAM_SXLabel.Text = "Năm sản xuất";
            // 
            // lbbanner
            // 
            lbbanner.AutoSize = true;
            lbbanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbbanner.Location = new System.Drawing.Point(269, 19);
            lbbanner.Name = "lbbanner";
            lbbanner.Size = new System.Drawing.Size(303, 31);
            lbbanner.TabIndex = 1;
            lbbanner.Text = "THÔNG TIN THIẾT BỊ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(416, 82);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 20);
            label1.TabIndex = 11;
            label1.Text = "Chọn phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(416, 124);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 20);
            label2.TabIndex = 12;
            label2.Text = "Chọn giảng viên";
            // 
            // _CSN_QLTB_31_12DataSet
            // 
            this._CSN_QLTB_31_12DataSet.DataSetName = "_CSN_QLTB_31_12DataSet";
            this._CSN_QLTB_31_12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHIETBIBindingSource
            // 
            this.tHIETBIBindingSource.DataMember = "THIETBI";
            this.tHIETBIBindingSource.DataSource = this._CSN_QLTB_31_12DataSet;
            // 
            // tHIETBITableAdapter
            // 
            this.tHIETBITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.OTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.SUDUNGTableAdapter = null;
            this.tableAdapterManager.THIETBITableAdapter = this.tHIETBITableAdapter;
            this.tableAdapterManager.THONGSOTableAdapter = null;
            this.tableAdapterManager.THUOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtid
            // 
            this.txtid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHIETBIBindingSource, "ID_TB", true));
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(191, 82);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(195, 26);
            this.txtid.TabIndex = 2;
            // 
            // txtten
            // 
            this.txtten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHIETBIBindingSource, "TEN_TB", true));
            this.txtten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(191, 121);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(195, 26);
            this.txtten.TabIndex = 4;
            // 
            // dtpnsx
            // 
            this.dtpnsx.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tHIETBIBindingSource, "NAM_SX", true));
            this.dtpnsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpnsx.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpnsx.Location = new System.Drawing.Point(191, 160);
            this.dtpnsx.Name = "dtpnsx";
            this.dtpnsx.Size = new System.Drawing.Size(195, 26);
            this.dtpnsx.TabIndex = 6;
            // 
            // tHIETBIDataGridView
            // 
            this.tHIETBIDataGridView.AllowUserToAddRows = false;
            this.tHIETBIDataGridView.AutoGenerateColumns = false;
            this.tHIETBIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tHIETBIDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tHIETBIDataGridView.DataSource = this.tHIETBIBindingSource;
            this.tHIETBIDataGridView.Location = new System.Drawing.Point(125, 268);
            this.tHIETBIDataGridView.Name = "tHIETBIDataGridView";
            this.tHIETBIDataGridView.ReadOnly = true;
            this.tHIETBIDataGridView.Size = new System.Drawing.Size(533, 167);
            this.tHIETBIDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_TB";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã thiết bị";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 170;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TEN_TB";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên thiết bị";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NAM_SX";
            this.dataGridViewTextBoxColumn3.HeaderText = "Năm sản xuất";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 165;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(447, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_maphong
            // 
            this.cb_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_maphong.FormattingEnabled = true;
            this.cb_maphong.Location = new System.Drawing.Point(555, 81);
            this.cb_maphong.Name = "cb_maphong";
            this.cb_maphong.Size = new System.Drawing.Size(193, 28);
            this.cb_maphong.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(217, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_magv
            // 
            this.cb_magv.DropDownHeight = 100;
            this.cb_magv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_magv.FormattingEnabled = true;
            this.cb_magv.IntegralHeight = false;
            this.cb_magv.Location = new System.Drawing.Point(555, 121);
            this.cb_magv.Name = "cb_magv";
            this.cb_magv.Size = new System.Drawing.Size(193, 28);
            this.cb_magv.TabIndex = 15;
            // 
            // frmThietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.cb_magv);
            this.Controls.Add(this.cb_maphong);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tHIETBIDataGridView);
            this.Controls.Add(lbbanner);
            this.Controls.Add(iD_TBLabel);
            this.Controls.Add(this.txtid);
            this.Controls.Add(tEN_TBLabel);
            this.Controls.Add(this.txtten);
            this.Controls.Add(nAM_SXLabel);
            this.Controls.Add(this.dtpnsx);
            this.Name = "frmThietbi";
            this.Text = "frmThietbi";
            this.Load += new System.EventHandler(this.frmThietbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this._CSN_QLTB_31_12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIETBIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIETBIDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _CSN_QLTB_31_12DataSet _CSN_QLTB_31_12DataSet;
        private System.Windows.Forms.BindingSource tHIETBIBindingSource;
        private _CSN_QLTB_31_12DataSetTableAdapters.THIETBITableAdapter tHIETBITableAdapter;
        private _CSN_QLTB_31_12DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.DateTimePicker dtpnsx;
        private System.Windows.Forms.DataGridView tHIETBIDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_maphong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_magv;
    }
}