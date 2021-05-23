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
    class SachBUS
    {
        DataConnection dataConnect = new DataConnection();
        public DataTable GetTableSach()
        {
            string sql = "Select * from dbo.SACH";
            return dataConnect.GetTable(sql);
        }
        public DataTable GetTableSachTenDM()
        {
            string sql = "Select MaS, TenS, TacGia, TenNXB, TenDanhMuc, NamXB, LanXB, SoLuong, GiaMuon, AnhS from dbo.SACH inner join dbo.DANHMUC on SACH.MaDanhMuc = DANHMUC.MaDanhMuc";
            return dataConnect.GetTable(sql);
        }

        public DataTable SearchTen(string searchKey)
        {
            string sql = "Select MaS, TenS, TacGia, TenNXB, TenDanhMuc, NamXB, LanXB, SoLuong, GiaMuon, AnhS from dbo.SACH inner join dbo.DANHMUC on SACH.MaDanhMuc = DANHMUC.MaDanhMuc Where TenS LIKE '%"+ searchKey +"%'";
            return dataConnect.GetTable(sql);
        }

        public DataTable SearchTacGia(string searchKey)
        {
            string sql = "Select MaS, TenS, TacGia, TenNXB, TenDanhMuc, NamXB, LanXB, SoLuong, GiaMuon, AnhS from dbo.SACH inner join dbo.DANHMUC on SACH.MaDanhMuc = DANHMUC.MaDanhMuc Where TacGia LIKE '%"+ searchKey +"%'";
            return dataConnect.GetTable(sql);
        }
        public DataTable SearchDanhMuc(string searchKey)
        {
            string sql = "Select MaS, TenS, TacGia, TenNXB, TenDanhMuc, NamXB, LanXB, SoLuong, GiaMuon, AnhS from dbo.SACH inner join dbo.DANHMUC on SACH.MaDanhMuc = DANHMUC.MaDanhMuc Where TenDanhMuc LIKE '%" + searchKey + "%'";
            return dataConnect.GetTable(sql);
        }
        public DataTable SearchNXB(string searchKey)
        {
            string sql = "Select MaS, TenS, TacGia, TenNXB, TenDanhMuc, NamXB, LanXB, SoLuong, GiaMuon, AnhS from dbo.SACH inner join dbo.DANHMUC on SACH.MaDanhMuc = DANHMUC.MaDanhMuc Where TenNXB LIKE '%" + searchKey + "%'";
            return dataConnect.GetTable(sql);
        }
        public DataTable SearchNamXB(string searchKey)
        {
            string sql = "Select MaS, TenS, TacGia, TenNXB, TenDanhMuc, NamXB, LanXB, SoLuong, GiaMuon, AnhS from dbo.SACH inner join dbo.DANHMUC on SACH.MaDanhMuc = DANHMUC.MaDanhMuc Where NamXB LIKE '%" + searchKey + "%'";
            return dataConnect.GetTable(sql);
        }

        public int GetItemCount(string tenS)
        {
            string sql = "select * from dbo.SACH where TenS=N'" + tenS + "'";
            DataTable dt = new DataTable();
            dt = dataConnect.GetTable(sql);
            return dt.Rows.Count;
        }
        public void InsertItem(string TenS, string TacGia, string TenNXB, int MaDanhMuc, int NamXB, int LanXB, int SoLuong, int GiaMuon, byte[] AnhS)
        {
            string sql = "Insert into dbo.SACH values(N'"+TenS+"',N'"+TacGia+"',N'"+TenNXB+"','"+MaDanhMuc+"','"+NamXB+"','"+LanXB+"','"+SoLuong+"','"+GiaMuon +"',@image)";
            dataConnect.ExecuteNonQueryWithImage(sql, AnhS);
        }
        public void DeleteItem(int MaS)
        {
            string sql = "Delete from dbo.SACH where MaS = '"+MaS+"'";
            dataConnect.ExecuteNonQuery(sql);
        }
    }
}
