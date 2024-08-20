using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chongtinh_Enter(object sender, EventArgs e)
        {

        }

        private void nam_CheckedChanged(object sender, EventArgs e)
        {   
            if (nam.Checked )
            MessageBox.Show("Bạn chọn giơi tính Nam", "Thông Báo");

        }

        private void nu_CheckedChanged(object sender, EventArgs e)
        {
            if (nu.Checked)
                MessageBox.Show("Bạn chọn giơi tính Nữ", "Thông Báo");
        }

        private void bnt_tomau_Click(object sender, EventArgs e)
        {
            if (rd_do.Checked)
                txt_hopmau.BackColor = Color.Red;
            else
                txt_hopmau.BackColor= Color.Green;
        }
    }
}
