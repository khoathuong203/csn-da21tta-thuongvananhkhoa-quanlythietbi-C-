namespace CSN_QLTB
{
    partial class Dudoan
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
            this.rpt_dudoan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpt_dudoan
            // 
            this.rpt_dudoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_dudoan.Location = new System.Drawing.Point(0, 0);
            this.rpt_dudoan.Name = "rpt_dudoan";
            this.rpt_dudoan.ServerReport.BearerToken = null;
            this.rpt_dudoan.Size = new System.Drawing.Size(800, 450);
            this.rpt_dudoan.TabIndex = 0;
            // 
            // Dudoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpt_dudoan);
            this.Name = "Dudoan";
            this.Text = "Dudoan";
            this.Load += new System.EventHandler(this.Dudoan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_dudoan;
    }
}