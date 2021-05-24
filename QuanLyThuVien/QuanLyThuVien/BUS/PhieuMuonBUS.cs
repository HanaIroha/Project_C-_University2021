using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DAL;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.BUS
{
    class PhieuMuonBUS
    {
        DataConnection dataConnect = new DataConnection();
        public DataTable GetPhieuMuon()
        {
            string sql = "select * from dbo.PHIEUMUON";
            DataTable dt = new DataTable();
            dt = dataConnect.GetTable(sql);
            return dt;
        }

        public void SuaTen(int SoPhieuMuon, string tenDangNhap)
        {
            string sql = "update dbo.PHIEUMUON SET TenDangNhap = '" + tenDangNhap + "' where SoPhieuMuon = '" + SoPhieuMuon + "'";
            dataConnect.ExecuteNonQuery(sql);
        }
        public void SuaMaSV(int SoPhieuMuon, string MaSV)
        {
            string sql = "update dbo.PHIEUMUON SET MaSinhVien = '" + MaSV + "' where SoPhieuMuon = '" + SoPhieuMuon + "'";
            dataConnect.ExecuteNonQuery(sql);
        }
    }
}
