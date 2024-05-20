namespace EgyptianGerman
{
    partial class ControlPurshases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPurshases));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxproducts = new System.Windows.Forms.ComboBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
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
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 106);
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
            this.label8.Location = new System.Drawing.Point(525, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 45);
            this.label8.TabIndex = 0;
            this.label8.Text = "تحكم في المشتريات";
            // 
            // comboBoxproducts
            // 
            this.comboBoxproducts.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxproducts.FormattingEnabled = true;
            this.comboBoxproducts.Location = new System.Drawing.Point(166, 138);
            this.comboBoxproducts.Name = "comboBoxproducts";
            this.comboBoxproducts.Size = new System.Drawing.Size(399, 38);
            this.comboBoxproducts.TabIndex = 34;
            this.comboBoxproducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxproducts_SelectedIndexChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxID.Location = new System.Drawing.Point(166, 193);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(399, 37);
            this.textBoxID.TabIndex = 35;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxName.Location = new System.Drawing.Point(166, 236);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(399, 37);
            this.textBoxName.TabIndex = 36;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.Location = new System.Drawing.Point(147, 368);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 38);
            this.buttonUpdate.TabIndex = 38;
            this.buttonUpdate.Text = "تعديل";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDel.Location = new System.Drawing.Point(269, 368);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(109, 38);
            this.buttonDel.TabIndex = 39;
            this.buttonDel.Text = "حذف";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(594, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 30);
            this.label1.TabIndex = 40;
            this.label1.Text = "المنتجات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(594, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 41;
            this.label2.Text = "رقم المنتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(594, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 30);
            this.label3.TabIndex = 42;
            this.label3.Text = "إسم المنتج";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(594, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 30);
            this.label4.TabIndex = 43;
            this.label4.Text = "السعر";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxPrice.Location = new System.Drawing.Point(166, 279);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(399, 37);
            this.textBoxPrice.TabIndex = 37;
            // 
            // ControlPurshases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.comboBoxproducts);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlPurshases";
            this.Text = "ControlPurshases";
            this.Load += new System.EventHandler(this.ControlPurshases_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxproducts;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}