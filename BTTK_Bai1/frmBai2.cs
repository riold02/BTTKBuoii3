using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTK_Bai1
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bnt_chonhang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);

        }
        private void bnt_TinhTien_Click(object sender, EventArgs e)
        {
            int TinhTien = 0;
            foreach (string hang in listBox2.Items)
            {
                switch (hang)
                {
                    case "Chuột":
                        TinhTien += 100000;
                        break;
                    case "Bàn phím":
                        TinhTien += 150000;
                        break;
                    case "Máy in":
                        TinhTien += 2000000;
                        break;
                    case "USB Kingmax":
                        TinhTien += 200000;
                        break;
                    default:
                        break;

                }

            }
            lbSoTien.Text =TinhTien + " đồng";
        }



    }
}
