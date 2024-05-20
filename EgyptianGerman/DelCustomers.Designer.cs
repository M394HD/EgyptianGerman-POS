namespace EgyptianGerman
{
    partial class DelCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelCustomers));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxOnDebt = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxfullName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxHasMoney = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(37, 423);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(123, 70);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxOnDebt
            // 
            this.textBoxOnDebt.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxOnDebt.Location = new System.Drawing.Point(37, 337);
            this.textBoxOnDebt.Name = "textBoxOnDebt";
            this.textBoxOnDebt.Size = new System.Drawing.Size(305, 37);
            this.textBoxOnDebt.TabIndex = 11;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxPhoneNo.Location = new System.Drawing.Point(37, 294);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(305, 37);
            this.textBoxPhoneNo.TabIndex = 10;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxAddress.Location = new System.Drawing.Point(37, 251);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(305, 37);
            this.textBoxAddress.TabIndex = 9;
            // 
            // textBoxfullName
            // 
            this.textBoxfullName.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxfullName.Location = new System.Drawing.Point(37, 208);
            this.textBoxfullName.Name = "textBoxfullName";
            this.textBoxfullName.Size = new System.Drawing.Size(305, 37);
            this.textBoxfullName.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 337);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxHasMoney
            // 
            this.textBoxHasMoney.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxHasMoney.Location = new System.Drawing.Point(37, 380);
            this.textBoxHasMoney.Name = "textBoxHasMoney";
            this.textBoxHasMoney.Size = new System.Drawing.Size(305, 37);
            this.textBoxHasMoney.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(-1, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 108);
            this.panel3.TabIndex = 30;
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
            this.label8.Location = new System.Drawing.Point(596, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 45);
            this.label8.TabIndex = 0;
            this.label8.Text = "حذف العملاء";
            // 
            // DelCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxHasMoney);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxOnDebt);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxfullName);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DelCustomers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxOnDebt;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxfullName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxHasMoney;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
    }
}