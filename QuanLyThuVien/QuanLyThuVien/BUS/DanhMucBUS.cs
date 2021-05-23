using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.DAL;
using System.IO;

namespace QuanLyThuVien.BUS
{
    class DanhMucBUS
    {
        DataConnection dataConnect = new DataConnection();
        public DataTable GetDanhMuc()
        {
            string sql = "select * from dbo.DANHMUC";
            DataTable dt = new DataTable();
            dt = dataConnect.GetTable(sql);
            return dt;
        }
    }
}
