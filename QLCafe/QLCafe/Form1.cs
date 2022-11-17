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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rl;
            rl = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (rl == DialogResult.No) 
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmInfor f = new frmInfor();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister f = new frmRegister();
            this.Hide(); f.ShowDialog(); this.Show();
        }
    }
}
