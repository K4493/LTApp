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
    public partial class frmTTNV : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command;
        string str = @"Data Source=TUANKIET\\SQLEXPRESS01;Initial Catalog=QLCF;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();  
        List<string> listGioiTinh = new List<string>() { "Nam", "Nữ", "Không xác định"};
        public frmTTNV()
        {
            InitializeComponent();
        }

        void LoadData()
        {
           command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM NHANVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvTTNV.DataSource = table;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Thongtinnhanvien_Load(object sender, EventArgs e)
        {
            cbmPHAI.DataSource= listGioiTinh;
            connection= new SqlConnection(str);
           
            LoadData();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTTableNV_Click(object sender, EventArgs e)
        {
            frmInfor f = new frmInfor();
            this.Hide();
            f.ShowDialog();
        }

        private void btnAddTTNV_Click(object sender, EventArgs e)
        {
            dtgvTTNV.Rows.Add(txtMANV.Text, txtHOTEN.Text, dtNGAYSINH.Text, txtDIACHINHA.Text, txtSDT.Text, cbmPHAI.Text);
        }

        private void dtgvTTNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbmPHAI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtgvTTNV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvTTNV.CurrentRow.Index;
            txtMANV.Text = dtgvTTNV.Rows[i].Cells[0].Value.ToString();
            txtHOTEN.Text = dtgvTTNV.Rows[i].Cells[1].Value.ToString();
            dtNGAYSINH.Text = dtgvTTNV.Rows[i].Cells[2].Value.ToString();
            txtDIACHINHA.Text = dtgvTTNV.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dtgvTTNV.Rows[i].Cells[4].Value.ToString();
            cbmPHAI.Text = dtgvTTNV.Rows[i].Cells[5].Value.ToString();
           
        }
        


        
    }
}
