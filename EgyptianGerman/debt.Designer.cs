namespace EgyptianGerman
{
    partial class debt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(debt));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonHasMoney = new System.Windows.Forms.Button();
            this.buttononDebt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 106);
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
            this.label8.Location = new System.Drawing.Point(678, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 45);
            this.label8.TabIndex = 0;
            this.label8.Text = "الديون";
            // 
            // buttonHasMoney
            // 
            this.buttonHasMoney.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.buttonHasMoney.Location = new System.Drawing.Point(468, 149);
            this.buttonHasMoney.Name = "buttonHasMoney";
            this.buttonHasMoney.Size = new System.Drawing.Size(162, 48);
            this.buttonHasMoney.TabIndex = 31;
            this.buttonHasMoney.Text = "الدائن";
            this.buttonHasMoney.UseVisualStyleBackColor = true;
            this.buttonHasMoney.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttononDebt
            // 
            this.buttononDebt.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.buttononDebt.Location = new System.Drawing.Point(300, 149);
            this.buttononDebt.Name = "buttononDebt";
            this.buttononDebt.Size = new System.Drawing.Size(162, 48);
            this.buttononDebt.TabIndex = 32;
            this.buttononDebt.Text = "المديون";
            this.buttononDebt.UseVisualStyleBackColor = true;
            this.buttononDebt.Click += new System.EventHandler(this.buttononDebt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(111, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 209);
            this.dataGridView1.TabIndex = 33;
            // 
            // debt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttononDebt);
            this.Controls.Add(this.buttonHasMoney);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "debt";
            this.Text = "debt";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonHasMoney;
        private System.Windows.Forms.Button buttononDebt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}