using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BUS
{
    class ThongKeBUS
    {
        DataConnection dataConnect = new DataConnection();
        public int getSachMuonNgay(string ngay)
        {
            string sql = "select COUNT(ID) from dbo.CHITIETPHIEUMUON where NgayMuon = '" + ngay + "'";
            DataTable da = dataConnect.GetTable(sql);
            return Int32.Parse(da.Rows[0].ItemArray[0].ToString());
        }
        public int getSachTraNgay(string ngay)
        {
            string sql = "select COUNT(ID) from dbo.CHITIETPHIEUMUON where NgayTra = '" + ngay + "'";
            DataTable da = dataConnect.GetTable(sql);
            return Int32.Parse(da.Rows[0].ItemArray[0].ToString());
        }
        public int getSachMuonThang(int thang, int nam)
        {
            string sql = "select COUNT(ID) from dbo.CHITIETPHIEUMUON where MONTH(NgayMuon) = '" + thang + "' AND YEAR(NgayMuon) = '" + nam + "'";
            DataTable da = dataConnect.GetTable(sql);
            return Int32.Parse(da.Rows[0].ItemArray[0].ToString());
        }
        public int getSachTraThang(int thang, int nam)
        {
            string sql = "select COUNT(ID) from dbo.CHITIETPHIEUMUON where MONTH(NgayTra) = '" + thang + "' AND YEAR(NgayTra) = '" + nam + "'";
            DataTable da = dataConnect.GetTable(sql);
            return Int32.Parse(da.Rows[0].ItemArray[0].ToString());
        }
    }
}
