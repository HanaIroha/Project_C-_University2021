using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class ChiTieuPhieuMuonDTO
    {
        public int ID { get; set; }
        public int SoPhieuMuon { get; set; }
        public int MaS { get; set; }
        public int TinhTrang { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
    }
}
