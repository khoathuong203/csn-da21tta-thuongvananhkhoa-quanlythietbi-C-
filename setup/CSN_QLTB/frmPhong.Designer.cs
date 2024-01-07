namespace CSN_QLTB
{
    partial class frmPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaphong = new System.Windows.Forms.Label();
            this.lbTenphong = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudsl = new System.Windows.Forms.NumericUpDown();
            this._CSN_QLTB_31_12DataSet = new CSN_QLTB._CSN_QLTB_31_12DataSet();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTableAdapter = new CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.PHONGTableAdapter();
            this.tableAdapterManager = new CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.TableAdapterManager();
            this.pHONGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CSN_QLTB_31_12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN PHÒNG";
            // 
            // lbMaphong
            // 
            this.lbMaphong.AutoSize = true;
            this.lbMaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaphong.Location = new System.Drawing.Point(147, 95);
            this.lbMaphong.Name = "lbMaphong";
            this.lbMaphong.Size = new System.Drawing.Size(80, 20);
            this.lbMaphong.TabIndex = 0;
            this.lbMaphong.Text = "Mã phòng";
            // 
            // lbTenphong
            // 
            this.lbTenphong.AutoSize = true;
            this.lbTenphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenphong.Location = new System.Drawing.Point(147, 146);
            this.lbTenphong.Name = "lbTenphong";
            this.lbTenphong.Size = new System.Drawing.Size(85, 20);
            this.lbTenphong.TabIndex = 0;
            this.lbTenphong.Text = "Tên phòng";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(279, 95);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(313, 26);
            this.txtid.TabIndex = 1;
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(279, 147);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(313, 26);
            this.txtten.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(372, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số lượng";
            // 
            // nudsl
            // 
            this.nudsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudsl.Location = new System.Drawing.Point(279, 199);
            this.nudsl.Name = "nudsl";
            this.nudsl.Size = new System.Drawing.Size(120, 26);
            this.nudsl.TabIndex = 7;
            // 
            // _CSN_QLTB_31_12DataSet
            // 
            this._CSN_QLTB_31_12DataSet.DataSetName = "_CSN_QLTB_31_12DataSet";
            this._CSN_QLTB_31_12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this._CSN_QLTB_31_12DataSet;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.OTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = this.pHONGTableAdapter;
            this.tableAdapterManager.SUDUNGTableAdapter = null;
            this.tableAdapterManager.THIETBITableAdapter = null;
            this.tableAdapterManager.THONGSOTableAdapter = null;
            this.tableAdapterManager.THUOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pHONGDataGridView
            // 
            this.pHONGDataGridView.AllowUserToAddRows = false;
            this.pHONGDataGridView.AutoGenerateColumns = false;
            this.pHONGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pHONGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pHONGDataGridView.DataSource = this.pHONGBindingSource;
            this.pHONGDataGridView.Location = new System.Drawing.Point(167, 312);
            this.pHONGDataGridView.Name = "pHONGDataGridView";
            this.pHONGDataGridView.ReadOnly = true;
            this.pHONGDataGridView.Size = new System.Drawing.Size(520, 188);
            this.pHONGDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PHONG";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã phòng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TEN_PHONG";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên phòng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SO_LUONG_GV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pHONGDataGridView);
            this.Controls.Add(this.nudsl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbTenphong);
            this.Controls.Add(this.lbMaphong);
            this.Controls.Add(this.label1);
            this.Name = "frmPhong";
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CSN_QLTB_31_12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaphong;
        private System.Windows.Forms.Label lbTenphong;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudsl;
        private _CSN_QLTB_31_12DataSet _CSN_QLTB_31_12DataSet;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private _CSN_QLTB_31_12DataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private _CSN_QLTB_31_12DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pHONGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}