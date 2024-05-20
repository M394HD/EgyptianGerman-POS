namespace EgyptianGerman
{
    partial class NewFormReceipt
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
            this.mainReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // mainReport
            // 
            this.mainReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainReport.Location = new System.Drawing.Point(0, 0);
            this.mainReport.Name = "mainReport";
            this.mainReport.ServerReport.BearerToken = null;
            this.mainReport.Size = new System.Drawing.Size(800, 450);
            this.mainReport.TabIndex = 0;
            this.mainReport.Load += new System.EventHandler(this.mainReport_Load);
            // 
            // NewFormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainReport);
            this.Name = "NewFormReceipt";
            this.Text = "NewFormReceipt";
            this.Load += new System.EventHandler(this.NewFormReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer mainReport;
    }
}