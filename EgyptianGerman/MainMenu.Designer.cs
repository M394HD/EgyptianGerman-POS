namespace EgyptianGerman
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel3 = new System.Windows.Forms.Panel();
            this.labeluserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCashir = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonMange = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.labeluserName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 104);
            this.panel3.TabIndex = 28;
            // 
            // labeluserName
            // 
            this.labeluserName.AutoSize = true;
            this.labeluserName.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluserName.ForeColor = System.Drawing.Color.OrangeRed;
            this.labeluserName.Location = new System.Drawing.Point(511, 64);
            this.labeluserName.Name = "labeluserName";
            this.labeluserName.Size = new System.Drawing.Size(0, 30);
            this.labeluserName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(707, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "مرحبا";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(570, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 45);
            this.label6.TabIndex = 0;
            this.label6.Text = "القائمة الرئيسية";
            // 
            // buttonCashir
            // 
            this.buttonCashir.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCashir.Location = new System.Drawing.Point(689, 141);
            this.buttonCashir.Name = "buttonCashir";
            this.buttonCashir.Size = new System.Drawing.Size(80, 80);
            this.buttonCashir.TabIndex = 29;
            this.buttonCashir.Text = "الكاشير";
            this.buttonCashir.UseVisualStyleBackColor = true;
            this.buttonCashir.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReports.Location = new System.Drawing.Point(689, 233);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(80, 80);
            this.buttonReports.TabIndex = 30;
            this.buttonReports.Text = "التقارير";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonMange
            // 
            this.buttonMange.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonMange.Location = new System.Drawing.Point(689, 320);
            this.buttonMange.Name = "buttonMange";
            this.buttonMange.Size = new System.Drawing.Size(80, 80);
            this.buttonMange.TabIndex = 31;
            this.buttonMange.Text = "الادارة";
            this.buttonMange.UseVisualStyleBackColor = true;
            this.buttonMange.Click += new System.EventHandler(this.buttonMange_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 150);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxIn
            // 
            this.textBoxIn.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxIn.Location = new System.Drawing.Point(125, 184);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(459, 37);
            this.textBoxIn.TabIndex = 33;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.Location = new System.Drawing.Point(44, 182);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 41);
            this.buttonSearch.TabIndex = 34;
            this.buttonSearch.Text = "إبحث";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(473, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "بحث عن فاتورة";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonMange);
            this.Controls.Add(this.buttonReports);
            this.Controls.Add(this.buttonCashir);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labeluserName;
        private System.Windows.Forms.Button buttonCashir;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonMange;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
    }
}