namespace CSN_QLTB
{
    partial class DSThietbi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._CSN_QLTB_31_12DataSet = new CSN_QLTB._CSN_QLTB_31_12DataSet();
            this.cSNQLTB3112DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHIETBIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHIETBITableAdapter = new CSN_QLTB._CSN_QLTB_31_12DataSetTableAdapters.THIETBITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._CSN_QLTB_31_12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSNQLTB3112DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIETBIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSthietbi";
            reportDataSource1.Value = this.tHIETBIBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CSN_QLTB.DSThietbi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // _CSN_QLTB_31_12DataSet
            // 
            this._CSN_QLTB_31_12DataSet.DataSetName = "_CSN_QLTB_31_12DataSet";
            this._CSN_QLTB_31_12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cSNQLTB3112DataSetBindingSource
            // 
            this.cSNQLTB3112DataSetBindingSource.DataSource = this._CSN_QLTB_31_12DataSet;
            this.cSNQLTB3112DataSetBindingSource.Position = 0;
            // 
            // tHIETBIBindingSource
            // 
            this.tHIETBIBindingSource.DataMember = "THIETBI";
            this.tHIETBIBindingSource.DataSource = this.cSNQLTB3112DataSetBindingSource;
            // 
            // tHIETBITableAdapter
            // 
            this.tHIETBITableAdapter.ClearBeforeFill = true;
            // 
            // DSThietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DSThietbi";
            this.Text = "DSThietbi";
            this.Load += new System.EventHandler(this.DSThietbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this._CSN_QLTB_31_12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSNQLTB3112DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIETBIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cSNQLTB3112DataSetBindingSource;
        private _CSN_QLTB_31_12DataSet _CSN_QLTB_31_12DataSet;
        private System.Windows.Forms.BindingSource tHIETBIBindingSource;
        private _CSN_QLTB_31_12DataSetTableAdapters.THIETBITableAdapter tHIETBITableAdapter;
    }
}