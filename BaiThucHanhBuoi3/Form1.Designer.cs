namespace BaiThucHanhBuoi3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_saochep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên của bạn :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(131, 54);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(201, 20);
            this.txtbox.TabIndex = 2;
            this.txtbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xử lý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(131, 130);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(201, 20);
            this.txtbox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bạn Đã Nhập";
            // 
            // btn_saochep
            // 
            this.btn_saochep.Location = new System.Drawing.Point(257, 91);
            this.btn_saochep.Name = "btn_saochep";
            this.btn_saochep.Size = new System.Drawing.Size(75, 23);
            this.btn_saochep.TabIndex = 8;
            this.btn_saochep.Text = "Sao Chép";
            this.btn_saochep.UseVisualStyleBackColor = true;
            this.btn_saochep.Click += new System.EventHandler(this.btn_saochep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_saochep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_saochep;
    }
}

