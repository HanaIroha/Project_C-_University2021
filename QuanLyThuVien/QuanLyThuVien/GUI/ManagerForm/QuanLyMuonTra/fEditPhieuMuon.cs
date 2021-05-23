using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLyThuVien.GUI.ManagerForm.QuanLyMuonTra
{
    public partial class fEditPhieuMuon : Form
    {
        int index = -1;
        int MaPhieuMuon;
        fQuanLyMuonTra QuanLyMuonTra;
        public fEditPhieuMuon()
        {
            InitializeComponent();
        }

        public fEditPhieuMuon(fQuanLyMuonTra f, int ma)
        {
            InitializeComponent();
            QuanLyMuonTra = f;
            this.MaPhieuMuon = ma;
        }

        private void fEditPhieuMuon_Load(object sender, EventArgs e)
        {
            prepare();
        }

        private void prepare()
        {
            QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
            lbl_soPhieuMuon.Text = "Số phiếu mượn: " + MaPhieuMuon.ToString();
            var s = (from p in db.PHIEUMUONs
                     where p.SoPhieuMuon == MaPhieuMuon
                     select p).FirstOrDefault();
            txt_nguoimuon.Text = s.MaSinhVien;
            var a = (from p in db.CHITIETPHIEUMUONs
                     where p.SoPhieuMuon == MaPhieuMuon
                     select p).FirstOrDefault();
            txt_ngaymuon.Text = ((DateTime)a.NgayMuon).ToString("MM/dd/yyyy");
            var sachmuon = from p in db.CHITIETPHIEUMUONs
                           join k in db.SACHes
                           on p.MaS equals k.MaS
                           where p.SoPhieuMuon == MaPhieuMuon
                           select new { p.ID,
                               p.MaS,
                               k.TenS,
                               TinhTrang = p.TinhTrang == 0 ? "Chưa trả" : "Đã trả",
                               NgayTra = p.NgayTra.HasValue?p.NgayTra.Value.ToShortDateString():null
                           };
            foreach(var u in sachmuon)
            {
                dgvSachMuon.Rows.Add(u.ID, u.MaS, u.TenS, u.TinhTrang, u.NgayTra);
            }
            var z = from p in db.CHITIETPHIEUMUONs
                    where p.SoPhieuMuon == MaPhieuMuon && p.TinhTrang == 0
                    select p;
            if (z.Count()>0)
            {
                lb_stt.Text = "Tình trạng: Chưa trả đủ";
                lb_stt.ForeColor = Color.Red;
            }
            else
            {
                lb_stt.Text = "Tình trạng: Đã trả đủ";
                lb_stt.ForeColor = Color.Green;
            }
        }

        private void dgvSachMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                dgvSachMuon.Rows[index].Cells[3].Value = "Đã trả";
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                DateTime localDate = DateTime.Now;
                string currentDate = localDate.Date.ToString(new CultureInfo("en-GB")).Split(' ')[0];
                string ngay = currentDate.Substring(0, 2);
                string thang = currentDate.Substring(3, 2);
                string nam = currentDate.Substring(6);
                for (int i = 0; i < dgvSachMuon.RowCount; i++)
                {
                    var capnhap = db.CHITIETPHIEUMUONs.Single(sp => sp.ID == Int32.Parse(dgvSachMuon.Rows[i].Cells[0].Value.ToString()));
                    if(capnhap.TinhTrang == 0 && dgvSachMuon.Rows[i].Cells[3].Value.ToString().Equals("Đã trả"))
                    {
                        capnhap.TinhTrang = 1;
                        capnhap.NgayTra = DateTime.ParseExact(thang + "/" + ngay + "/" + nam, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        var updatesl = db.SACHes.Single(sp => sp.MaS == Int32.Parse(dgvSachMuon.Rows[i].Cells[1].Value.ToString()));
                        updatesl.SoLuong = updatesl.SoLuong + 1;
                        db.SubmitChanges();
                    }
                }
                QuanLyMuonTra.prepare();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
