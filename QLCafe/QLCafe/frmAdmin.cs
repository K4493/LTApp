using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCafe
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }
        //1 Load 
        void LoadAccountList()
        {
            string connectionSTR = "";//add sql 
            SqlConnection connection = new SqlConnection(connectionSTR);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void trởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
