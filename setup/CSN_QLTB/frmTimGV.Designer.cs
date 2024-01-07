namespace CSN_QLTB
{
    partial class frmTimGV
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
            this.paneltop = new System.Windows.Forms.Panel();
            this.cb_maphong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._CSN_QLTB_31_12DataSet = new CSN_QLTB._CSN_QLTB_31_12DataSet();
            this.panelbody = new System.Windows.Forms.Panel();
            this.rpv_gv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.TableAdapterManager();
            this.pHONGTableAdapter = new CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.PHONGTableAdapter();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CSN_QLTB_31_12DataSet)).BeginInit();
            this.panelbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.cb_maphong);
            this.paneltop.Controls.Add(this.label2);
            this.paneltop.Controls.Add(this.button1);
            this.paneltop.Controls.Add(this.label1);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(800, 143);
            this.paneltop.TabIndex = 0;
            // 
            // cb_maphong
            // 
            this.cb_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_maphong.FormattingEnabled = true;
            this.cb_maphong.Location = new System.Drawing.Point(275, 77);
            this.cb_maphong.MaxDropDownItems = 5;
            this.cb_maphong.Name = "cb_maphong";
            this.cb_maphong.Size = new System.Drawing.Size(251, 28);
            this.cb_maphong.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "TÌM GIẢNG VIÊN";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(547, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn mã phòng :";
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this._CSN_QLTB_31_12DataSet;
            // 
            // _CSN_QLTB_31_12DataSet
            // 
            this._CSN_QLTB_31_12DataSet.DataSetName = "_CSN_QLTB_31_12DataSet";
            this._CSN_QLTB_31_12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelbody
            // 
            this.panelbody.Controls.Add(this.rpv_gv);
            this.panelbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbody.Location = new System.Drawing.Point(0, 143);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(800, 307);
            this.panelbody.TabIndex = 1;
            // 
            // rpv_gv
            // 
            this.rpv_gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_gv.Location = new System.Drawing.Point(0, 0);
            this.rpv_gv.Name = "rpv_gv";
            this.rpv_gv.ServerReport.BearerToken = null;
            this.rpv_gv.Size = new System.Drawing.Size(800, 307);
            this.rpv_gv.TabIndex = 0;
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
            this.tableAdapterManager.PHONGTableAdapter = this.pHONGTableAdapter;
            this.tableAdapterManager.SUDUNGTableAdapter = null;
            this.tableAdapterManager.THIETBITableAdapter = null;
            this.tableAdapterManager.THONGSOTableAdapter = null;
            this.tableAdapterManager.THUOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // frmTimGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelbody);
            this.Controls.Add(this.paneltop);
            this.Name = "frmTimGV";
            this.Text = "frmTimGV";
            this.Load += new System.EventHandler(this.frmTimGV_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CSN_QLTB_31_12DataSet)).EndInit();
            this.panelbody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panelbody;
        private System.Windows.Forms.Label label1;
        private _CSN_QLTB_31_12DataSet _CSN_QLTB_31_12DataSet;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private _CSN_QLTB_31_12DataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private _CSN_QLTB_31_12DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_gv;
        private System.Windows.Forms.Label label2;
        private _CSN_QLTB_31_12DataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private System.Windows.Forms.ComboBox cb_maphong;
    }
}