using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCafe
{
    public partial class frmInfor : Form
    {
        public frmInfor()
        {
            InitializeComponent();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTTNV f = new frmTTNV();
            f.ShowDialog();
        }

        private void danhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            this.Hide();
            f.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
          
        }

        private void frmInfor_Load(object sender, EventArgs e)
        {

        }
    }
}
