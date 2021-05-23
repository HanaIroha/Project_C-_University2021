using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.BUS
{
    class TaiKhoanBUS
    {
        DataConnection dataConnect = new DataConnection();
        public DataTable GetTableTaiKhoan()
        {
            string sql = "Select * from dbo.TAIKHOAN";
            return dataConnect.GetTable(sql);
        }

        public DataTable SearchTenDangNhap(string searchKey)
        {
            string sql = "Select * from dbo.TAIKHOAN where TenDangNhap LIKE '%"+searchKey+"%'";
            return dataConnect.GetTable(sql);
        }
        public DataTable SearchTenNguoiDung(string searchKey)
        {
            string sql = "Select * from dbo.TAIKHOAN where TenNguoiDung LIKE N'%" + searchKey + "%'";
            return dataConnect.GetTable(sql);
        }

        public TaiKhoanDTO GetTaiKhoan(string TenTK)
        {
            string sql = "Select * from dbo.TAIKHOAN where TenDangNhap = '" + TenTK + "'";
            DataTable dt = new DataTable();
            dt = dataConnect.GetTable(sql);
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.ID = Int32.Parse(dt.Rows[0].ItemArray[0].ToString());
            tk.AnhDaiDien = (byte[])dt.Rows[0].ItemArray[1];
            tk.TenDangNhap = dt.Rows[0].ItemArray[2].ToString();
            tk.MatKhau = dt.Rows[0].ItemArray[3].ToString();
            tk.TenNguoiDung = dt.Rows[0].ItemArray[4].ToString();
            tk.LoaiTaiKhoan = Int32.Parse(dt.Rows[0].ItemArray[5].ToString());
            tk.TinhTrang = (bool)dt.Rows[0].ItemArray[6];
            return tk;
        }

        public void AddTaiKhoan(byte[] AnhDaiDien, string TenDanhNhap, string MatKhau, string TenNguoiDung, int LoaiTaiKhoan, bool TinhTrang)
        {
            string sql = "Insert into dbo.TAIKHOAN values(@image,'" + TenDanhNhap + "','" + MatKhau + "',N'" + TenNguoiDung + "','" + LoaiTaiKhoan + "','" + TinhTrang + "')";
            dataConnect.ExecuteNonQueryWithImage(sql, AnhDaiDien);
        }

        public void UpdateTaiKhoan(byte[] AnhDaiDien, string TenDangNhap, string MatKhau, string TenNguoiDung, bool TinhTrang)
        {
            string sql = "Update dbo.TAIKHOAN SET AnhDaiDien=@image, MatKhau='" + MatKhau + "', TenNguoiDung=N'" + TenNguoiDung + "', TinhTrang ='" + TinhTrang + "' where TenDangNhap = '" + TenDangNhap + "'";
            dataConnect.ExecuteNonQueryWithImage(sql, AnhDaiDien);
        }

        public void DeleteTaiKhoan(string TenTK)
        {
            string sql = "Delete from dbo.TAIKHOAN where TenDangNhap='" + TenTK + "'";
            dataConnect.ExecuteNonQuery(sql);
        }
    }
}
