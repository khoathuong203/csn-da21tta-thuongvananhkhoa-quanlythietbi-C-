namespace CSN_QLTB
{
    partial class frmTimthietbi
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
            this.label2 = new System.Windows.Forms.Label();
            this.bnTim = new System.Windows.Forms.Button();
            this.cbMaGV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rptTimTb = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bnTim);
            this.panel1.Controls.Add(this.cbMaGV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 175);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "TÌM THIẾT BỊ SỬ DỤNG";
            // 
            // bnTim
            // 
            this.bnTim.Location = new System.Drawing.Point(550, 99);
            this.bnTim.Name = "bnTim";
            this.bnTim.Size = new System.Drawing.Size(109, 30);
            this.bnTim.TabIndex = 2;
            this.bnTim.Text = "Tìm";
            this.bnTim.UseVisualStyleBackColor = true;
            this.bnTim.Click += new System.EventHandler(this.bnTim_Click);
            // 
            // cbMaGV
            // 
            this.cbMaGV.AllowDrop = true;
            this.cbMaGV.DropDownHeight = 100;
            this.cbMaGV.FormattingEnabled = true;
            this.cbMaGV.IntegralHeight = false;
            this.cbMaGV.ItemHeight = 20;
            this.cbMaGV.Location = new System.Drawing.Point(259, 99);
            this.cbMaGV.MaxDropDownItems = 5;
            this.cbMaGV.Name = "cbMaGV";
            this.cbMaGV.Size = new System.Drawing.Size(269, 28);
            this.cbMaGV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Giảng viên";
            // 
            // rptTimTb
            // 
            this.rptTimTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptTimTb.Location = new System.Drawing.Point(0, 175);
            this.rptTimTb.Name = "rptTimTb";
            this.rptTimTb.ServerReport.BearerToken = null;
            this.rptTimTb.Size = new System.Drawing.Size(800, 275);
            this.rptTimTb.TabIndex = 1;
            // 
            // frmTimthietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptTimTb);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimthietbi";
            this.Text = "frmTimthietbi";
            this.Load += new System.EventHandler(this.frmTimthietbi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rptTimTb;
        private System.Windows.Forms.Button bnTim;
        private System.Windows.Forms.ComboBox cbMaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}