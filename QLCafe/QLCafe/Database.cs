using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace QLCafe
{
    class Database
    {
        SqlConnection sqlConn; //doi tuong ket noi
        SqlDataAdapter daNV;
        DataSet dsNV;

        public Database()
        {
            string strCnn = @"Data Source=TUANKIET\\SQLEXPRESS01;Initial Catalog=QLCF;Integrated Security=True";
            sqlConn= new SqlConnection(strCnn); 
        }

        //phuong thuc thuc hien truy van
        public DataTable Execute(string sqlStr)
        {
            daNV = new SqlDataAdapter(sqlStr, sqlConn);
            dsNV = new DataSet();
            daNV.Fill(dsNV);
            return dsNV.Tables[0];
        }
  
        //phuong thuc them xoa sua
        public void ExecuteNonQuery (string strSQL) 
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL,sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery(); //thuc hien lenh them xoa sua
            sqlConn.Close();

        }


    }
}
