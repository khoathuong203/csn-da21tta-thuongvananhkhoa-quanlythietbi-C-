namespace CSN_QLTB
{
    partial class frmtb_phong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rptthietbi = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_maphong = new System.Windows.Forms.ComboBox();
            this.bnTim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bnTim);
            this.panel1.Controls.Add(this.cb_maphong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 132);
            this.panel1.TabIndex = 0;
            // 
            // rptthietbi
            // 
            this.rptthietbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptthietbi.Location = new System.Drawing.Point(0, 132);
            this.rptthietbi.Name = "rptthietbi";
            this.rptthietbi.ServerReport.BearerToken = null;
            this.rptthietbi.Size = new System.Drawing.Size(800, 318);
            this.rptthietbi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn mã phòng:";
            // 
            // cb_maphong
            // 
            this.cb_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_maphong.FormattingEnabled = true;
            this.cb_maphong.Location = new System.Drawing.Point(257, 67);
            this.cb_maphong.Name = "cb_maphong";
            this.cb_maphong.Size = new System.Drawing.Size(243, 28);
            this.cb_maphong.TabIndex = 1;
            // 
            // bnTim
            // 
            this.bnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnTim.Location = new System.Drawing.Point(506, 67);
            this.bnTim.Name = "bnTim";
            this.bnTim.Size = new System.Drawing.Size(84, 29);
            this.bnTim.TabIndex = 2;
            this.bnTim.Text = "Tìm";
            this.bnTim.UseVisualStyleBackColor = true;
            this.bnTim.Click += new System.EventHandler(this.bnTim_Click);
            // 
            // frmtb_phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptthietbi);
            this.Controls.Add(this.panel1);
            this.Name = "frmtb_phong";
            this.Text = "frmtb_phong";
            this.Load += new System.EventHandler(this.frmtb_phong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rptthietbi;
        private System.Windows.Forms.Button bnTim;
        private System.Windows.Forms.ComboBox cb_maphong;
        private System.Windows.Forms.Label label1;
    }
}