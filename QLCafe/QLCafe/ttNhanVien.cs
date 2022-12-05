using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace QLCafe
{
    class ttNhanVien
    {
        Database dtTV;
    
        public ttNhanVien()
        {
            dtTV = new Database();
        }

        public DataTable LayDSNhanVien()
        {
            string strSQL = "SELECT * FROM NHANVIEN NV ";
            DataTable dtNV = dtTV.Execute(strSQL);  
            return dtNV;

        }
       
    }
}
