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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void họTênCủaSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            var form = new frmbai1();
            form.ShowDialog();
        }

        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            var form2 = new frmBai2();
            form2.ShowDialog();
        }
    }
}
