namespace EgyptianGerman
{
    partial class Reporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporting));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDebt = new System.Windows.Forms.Button();
            this.buttonProfit = new System.Windows.Forms.Button();
            this.buttonRefund = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 104);
            this.panel3.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(101, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 50);
            this.label7.TabIndex = 2;
            this.label7.Text = "EGYPTIAN GERMAN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cairo ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(659, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 45);
            this.label8.TabIndex = 0;
            this.label8.Text = "التقارير";
            // 
            // buttonDebt
            // 
            this.buttonDebt.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDebt.Location = new System.Drawing.Point(144, 153);
            this.buttonDebt.Name = "buttonDebt";
            this.buttonDebt.Size = new System.Drawing.Size(129, 75);
            this.buttonDebt.TabIndex = 34;
            this.buttonDebt.Text = "الديون";
            this.buttonDebt.UseVisualStyleBackColor = true;
            this.buttonDebt.Click += new System.EventHandler(this.buttonDebt_Click);
            // 
            // buttonProfit
            // 
            this.buttonProfit.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonProfit.Location = new System.Drawing.Point(316, 153);
            this.buttonProfit.Name = "buttonProfit";
            this.buttonProfit.Size = new System.Drawing.Size(155, 75);
            this.buttonProfit.TabIndex = 35;
            this.buttonProfit.Text = "المبيعات و الارباح";
            this.buttonProfit.UseVisualStyleBackColor = true;
            this.buttonProfit.Click += new System.EventHandler(this.buttonProfit_Click);
            // 
            // buttonRefund
            // 
            this.buttonRefund.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRefund.Location = new System.Drawing.Point(507, 153);
            this.buttonRefund.Name = "buttonRefund";
            this.buttonRefund.Size = new System.Drawing.Size(129, 75);
            this.buttonRefund.TabIndex = 36;
            this.buttonRefund.Text = "المرتجعات";
            this.buttonRefund.UseVisualStyleBackColor = true;
            this.buttonRefund.Click += new System.EventHandler(this.buttonRefund_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 75);
            this.button1.TabIndex = 37;
            this.button1.Text = "الرجوع إلى القائمة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRefund);
            this.Controls.Add(this.buttonProfit);
            this.Controls.Add(this.buttonDebt);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporting";
            this.Text = "Reporting";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDebt;
        private System.Windows.Forms.Button buttonProfit;
        private System.Windows.Forms.Button buttonRefund;
        private System.Windows.Forms.Button button1;
    }
}