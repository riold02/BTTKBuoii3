using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            txtbox1.Text = txtbox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtbox.Text;
            MessageBox.Show($"Xin chào bạn {tenDaNhap} . Rất  vui được gặp bạn");
        }

 
        private void btn_saochep_Click(object sender, EventArgs e)
        {
            txtbox1.Text = txtbox.Text;
        }
    }
}
