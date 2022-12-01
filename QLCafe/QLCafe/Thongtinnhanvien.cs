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
        ttNhanVien clsNhanvien = new ttNhanVien();
        List<string> listGioiTinh = new List<string>() { "Nam", "Nữ", "Không xác định"};
        public frmTTNV()
        {
            InitializeComponent();
        }

        void hienthiNhanVien()
        {
            DataTable dtNV = clsNhanvien.LayDSNhanVien();
            for (int i = 0; i < dtNV.Rows.Count; i++)
            {
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Thongtinnhanvien_Load(object sender, EventArgs e)
        {
            cbmPHAI.DataSource= listGioiTinh;
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
            dtgvTTNV.Rows.Add(txtMANV.Text, txtHOTEN.Text, dtNGAYSINH.Text, txtDIACHINHA.Text, txtSDT.Text, cbmPHAI.Text);
        }
        public void LayDSNV()
        {
            //khoi tao cac doi tuong 
            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            //lay ket noi

            //
            try
            {
                // mo chuoi ket noi
                conn.Open();
                //khai bao doi tuong
                da.SelectCommand = new SqlCommand();
                //goi thu tuc tu sql
                da.SelectCommand.CommandText = "SP_Retrieve_Student";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //gán chuỗi kết nối
                da.SelectCommand.Connection = conn;
                //sử dụng phương thức fill để điền dữ liệu từ datatable vào SqlDataAdapter
                da.Fill(dt);
                //gán dữ liệu từ datatable vào datagridview
                dtgvTTNV.DataSource = dt;
                //đóng chuỗi kết nối
                conn.Close();
                //

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
