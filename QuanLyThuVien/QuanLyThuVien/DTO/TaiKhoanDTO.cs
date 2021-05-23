using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class TaiKhoanDTO
    {
        public int ID { get; set; }
        public byte[] AnhDaiDien { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenNguoiDung { get; set; }
        public int LoaiTaiKhoan { get; set; }
        public bool TinhTrang { get; set; }
    }
}
