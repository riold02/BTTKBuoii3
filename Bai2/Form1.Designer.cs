namespace Bai2
{
    partial class Form1
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
            this.chongtinh = new System.Windows.Forms.GroupBox();
            this.nu = new System.Windows.Forms.RadioButton();
            this.nam = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnt_tomau = new System.Windows.Forms.Button();
            this.rd_xanh = new System.Windows.Forms.RadioButton();
            this.rd_do = new System.Windows.Forms.RadioButton();
            this.txt_hopmau = new System.Windows.Forms.TextBox();
            this.chongtinh.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chongtinh
            // 
            this.chongtinh.Controls.Add(this.nu);
            this.chongtinh.Controls.Add(this.nam);
            this.chongtinh.Location = new System.Drawing.Point(188, 110);
            this.chongtinh.Name = "chongtinh";
            this.chongtinh.Size = new System.Drawing.Size(200, 98);
            this.chongtinh.TabIndex = 0;
            this.chongtinh.TabStop = false;
            this.chongtinh.Text = "Chọn giới tính : ";
            this.chongtinh.Enter += new System.EventHandler(this.chongtinh_Enter);
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Checked = true;
            this.nu.Location = new System.Drawing.Point(21, 42);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(39, 17);
            this.nu.TabIndex = 1;
            this.nu.TabStop = true;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            this.nu.CheckedChanged += new System.EventHandler(this.nu_CheckedChanged);
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Location = new System.Drawing.Point(22, 19);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(47, 17);
            this.nam.TabIndex = 0;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            this.nam.CheckedChanged += new System.EventHandler(this.nam_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_hopmau);
            this.groupBox1.Controls.Add(this.bnt_tomau);
            this.groupBox1.Controls.Add(this.rd_xanh);
            this.groupBox1.Controls.Add(this.rd_do);
            this.groupBox1.Location = new System.Drawing.Point(188, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn màu";
            // 
            // bnt_tomau
            // 
            this.bnt_tomau.Location = new System.Drawing.Point(101, 38);
            this.bnt_tomau.Name = "bnt_tomau";
            this.bnt_tomau.Size = new System.Drawing.Size(75, 23);
            this.bnt_tomau.TabIndex = 0;
            this.bnt_tomau.Text = "Tô Màu";
            this.bnt_tomau.Click += new System.EventHandler(this.bnt_tomau_Click);
            // 
            // rd_xanh
            // 
            this.rd_xanh.AutoSize = true;
            this.rd_xanh.Checked = true;
            this.rd_xanh.Location = new System.Drawing.Point(21, 56);
            this.rd_xanh.Name = "rd_xanh";
            this.rd_xanh.Size = new System.Drawing.Size(74, 17);
            this.rd_xanh.TabIndex = 1;
            this.rd_xanh.TabStop = true;
            this.rd_xanh.Text = "Màu Xanh";
            this.rd_xanh.UseVisualStyleBackColor = true;
            // 
            // rd_do
            // 
            this.rd_do.AutoSize = true;
            this.rd_do.Location = new System.Drawing.Point(21, 27);
            this.rd_do.Name = "rd_do";
            this.rd_do.Size = new System.Drawing.Size(63, 17);
            this.rd_do.TabIndex = 0;
            this.rd_do.Text = "Màu Đỏ";
            this.rd_do.UseVisualStyleBackColor = true;
            // 
            // txt_hopmau
            // 
            this.txt_hopmau.Location = new System.Drawing.Point(196, 19);
            this.txt_hopmau.Multiline = true;
            this.txt_hopmau.Name = "txt_hopmau";
            this.txt_hopmau.Size = new System.Drawing.Size(72, 57);
            this.txt_hopmau.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chongtinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.chongtinh.ResumeLayout(false);
            this.chongtinh.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox chongtinh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_xanh;
        private System.Windows.Forms.RadioButton rd_do;
        private System.Windows.Forms.Button bnt_tomau;
        private System.Windows.Forms.TextBox txt_hopmau;
    }
}

