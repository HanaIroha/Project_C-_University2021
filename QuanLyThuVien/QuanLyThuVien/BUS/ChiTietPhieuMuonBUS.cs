using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BUS
{
    class ChiTietPhieuMuonBUS
    {
        DataConnection dataConnect = new DataConnection();
        public DataTable GetPhieuMuon()
        {
            string sql = "select * from dbo.CHITIETPHIEUMUON";
            DataTable dt = new DataTable();
            dt = dataConnect.GetTable(sql);
            return dt;
        }
        public void SuaTinhTrang(int ID, int TinhTrang)
        {
            string sql = "update dbo.CHITIETPHIEUMUON SET TinhTrang = '" + TinhTrang + "' where ID = '" + ID + "'";
            dataConnect.ExecuteNonQuery(sql);
        }
        public void SuaTinhTrang(int ID, DateTime ngayTra)
        {
            string sql = "update dbo.CHITIETPHIEUMUON SET NgayTra = '" + ngayTra + "' where ID = '" + ID + "'";
            dataConnect.ExecuteNonQuery(sql);
        }
    }
}
