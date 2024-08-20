namespace BTTK_Bai1
{
    partial class frmbai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbai1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_xanh = new System.Windows.Forms.RadioButton();
            this.rd_trang = new System.Windows.Forms.RadioButton();
            this.rd_do = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.bntTinhTien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_SoTien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_xanh);
            this.groupBox1.Controls.Add(this.rd_trang);
            this.groupBox1.Controls.Add(this.rd_do);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(560, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Màu Xe";
            // 
            // rd_xanh
            // 
            this.rd_xanh.AutoSize = true;
            this.rd_xanh.Location = new System.Drawing.Point(27, 65);
            this.rd_xanh.Name = "rd_xanh";
            this.rd_xanh.Size = new System.Drawing.Size(59, 21);
            this.rd_xanh.TabIndex = 2;
            this.rd_xanh.TabStop = true;
            this.rd_xanh.Text = "Xanh";
            this.rd_xanh.UseVisualStyleBackColor = true;
            this.rd_xanh.CheckedChanged += new System.EventHandler(this.rd_xanh_CheckedChanged);
            // 
            // rd_trang
            // 
            this.rd_trang.AutoSize = true;
            this.rd_trang.Location = new System.Drawing.Point(27, 42);
            this.rd_trang.Name = "rd_trang";
            this.rd_trang.Size = new System.Drawing.Size(64, 21);
            this.rd_trang.TabIndex = 1;
            this.rd_trang.TabStop = true;
            this.rd_trang.Text = "Trắng";
            this.rd_trang.UseVisualStyleBackColor = true;
            this.rd_trang.CheckedChanged += new System.EventHandler(this.rd_trang_CheckedChanged);
            // 
            // rd_do
            // 
            this.rd_do.AutoSize = true;
            this.rd_do.Location = new System.Drawing.Point(27, 19);
            this.rd_do.Name = "rd_do";
            this.rd_do.Size = new System.Drawing.Size(44, 21);
            this.rd_do.TabIndex = 0;
            this.rd_do.TabStop = true;
            this.rd_do.Text = "Đỏ";
            this.rd_do.UseVisualStyleBackColor = true;
            this.rd_do.CheckedChanged += new System.EventHandler(this.rd_do_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đơn giá : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(616, 219);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(113, 23);
            this.txtDonGia.TabIndex = 4;
            this.txtDonGia.Text = "22000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(735, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng :";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(616, 266);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(113, 23);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // bntTinhTien
            // 
            this.bntTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTinhTien.Location = new System.Drawing.Point(616, 313);
            this.bntTinhTien.Name = "bntTinhTien";
            this.bntTinhTien.Size = new System.Drawing.Size(93, 26);
            this.bntTinhTien.TabIndex = 8;
            this.bntTinhTien.Text = "Tính tiền";
            this.bntTinhTien.UseVisualStyleBackColor = true;
            this.bntTinhTien.Click += new System.EventHandler(this.bntTinhTien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng số tiền thanh toán: ";
            // 
            // lb_SoTien
            // 
            this.lb_SoTien.AutoSize = true;
            this.lb_SoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoTien.Location = new System.Drawing.Point(613, 408);
            this.lb_SoTien.Name = "lb_SoTien";
            this.lb_SoTien.Size = new System.Drawing.Size(12, 17);
            this.lb_SoTien.TabIndex = 10;
            this.lb_SoTien.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(735, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "$.";
            // 
            // frmbai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_SoTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntTinhTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmbai1";
            this.Text = "Mua bán xe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_xanh;
        private System.Windows.Forms.RadioButton rd_trang;
        private System.Windows.Forms.RadioButton rd_do;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button bntTinhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_SoTien;
        private System.Windows.Forms.Label label5;
    }
}