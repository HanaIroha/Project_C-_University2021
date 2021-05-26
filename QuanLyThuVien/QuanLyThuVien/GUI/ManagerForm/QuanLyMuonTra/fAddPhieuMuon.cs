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
    public partial class fAddPhieuMuon : Form
    {
        int index = -1;
        string tenDangNhap;
        fQuanLyMuonTra QuanLyMuonTra;
        public fAddPhieuMuon(fQuanLyMuonTra f, string ten)
        {
            InitializeComponent();
            this.tenDangNhap = ten;
            QuanLyMuonTra = f;
            prepare();
        }

        private void prepare()
        {
            QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
            var s = (from p in db.PHIEUMUONs
                     orderby p.SoPhieuMuon descending
                    select p).FirstOrDefault();
            
            lbl_chiTietPhieu.Text = "Thông tin chi tiết phiếu mượn #" + (s==null?1:s.SoPhieuMuon);
            loadComBoSach();
        }
        
        private void loadComBoSach()
        {
            QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
            var s = from p in db.SACHes
                    select new { Ten = p.MaS + " - " + p.TenS, p.MaS };
            cbb_sach.DataSource = s;
            cbb_sach.DisplayMember = "Ten";
            cbb_sach.ValueMember = "MaS";
            cbb_sach.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_sach.Text.Contains("-"))
                {
                    QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                    var s = (from p in db.SACHes
                             where p.MaS == Int32.Parse(cbb_sach.SelectedValue.ToString())
                             select new { p.MaS, p.TenS, p.GiaMuon, p.SoLuong }).FirstOrDefault();
                    int slThuc = Int32.Parse(txt_sl.Text);
                    if (dgvSachMuon.Rows.Count > 0)
                    {
                        for (int z = 0; z < dgvSachMuon.Rows.Count; z++)
                        {
                            if (dgvSachMuon.Rows[z].Cells[0].Value.ToString().Equals(cbb_sach.SelectedValue.ToString()))
                                slThuc++;
                        }
                    }
                    if (s.SoLuong < slThuc)
                    {
                        throw new Exception("Không đủ sách để cho mượn!");
                    }
                    for (int i = 0; i < Int32.Parse(txt_sl.Text); i++)
                    {
                        dgvSachMuon.Rows.Add(s.MaS, s.TenS, s.GiaMuon);
                        txt_tongtien.Text = (Int32.Parse(txt_tongtien.Text) + s.GiaMuon).ToString();
                    }
                }
                else
                {
                    if (cbb_sach.Text.Equals(""))
                    {
                        cbb_sach.Focus();
                        throw new Exception("Vui lòng nhập mã sách");
                    }
                    if (!cbb_sach.Text.All(char.IsDigit))
                    {
                        cbb_sach.Focus();
                        throw new Exception("Mã sách phải là số");
                    }
                    QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                    var s = (from p in db.SACHes
                             where p.MaS == Int32.Parse(cbb_sach.Text)
                             select new { p.MaS, p.TenS, p.GiaMuon, p.SoLuong }).FirstOrDefault();
                    if (s == null)
                    {
                        throw new Exception("Mã sách không tồn tại");
                    }
                    int slThuc = Int32.Parse(txt_sl.Text);
                    if (dgvSachMuon.Rows.Count > 0)
                    {
                        for (int z = 0; z < dgvSachMuon.Rows.Count; z++)
                        {
                            if (dgvSachMuon.Rows[z].Cells[0].Value.ToString().Equals(cbb_sach.Text))
                                slThuc++;
                        }
                    }
                    if (s.SoLuong < slThuc)
                    {
                        throw new Exception("Không đủ sách để cho mượn!");
                    }
                    for (int i = 0; i < Int32.Parse(txt_sl.Text); i++)
                    {
                        dgvSachMuon.Rows.Add(s.MaS, s.TenS, s.GiaMuon);
                        txt_tongtien.Text = (Int32.Parse(txt_tongtien.Text) + s.GiaMuon).ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                txt_tongtien.Text = (Int32.Parse(txt_tongtien.Text) - Int32.Parse(dgvSachMuon.Rows[index].Cells[2].Value.ToString())).ToString();
                dgvSachMuon.Rows.RemoveAt(index);
                index = -1;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xoá!", "Lỗi");
            }
        }

        private void dgvSachMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
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
                if (txt_nguoimuon.Text.Equals(""))
                {
                    txt_nguoimuon.Focus();
                    throw new Exception("Vui lòng nhập mã sinh viên người mượn!");
                }
                if (dgvSachMuon.RowCount <= 0)
                {
                    throw new Exception("Danh sách mượn không được để trống!");
                }
                if (dgvSachMuon.RowCount > 10)
                {
                    throw new Exception("Mỗi lần không được mượn quá 10 quyển!");
                }
                QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                PHIEUMUON phieu = new PHIEUMUON();
                phieu.TenDangNhap = tenDangNhap;
                phieu.MaSinhVien = txt_nguoimuon.Text;
                db.PHIEUMUONs.InsertOnSubmit(phieu);
                db.SubmitChanges();
                var s = (from p in db.PHIEUMUONs
                         orderby p.SoPhieuMuon descending
                         select p).First();
                DateTime localDate = DateTime.Now;
                string currentDate = localDate.Date.ToString(new CultureInfo("en-GB")).Split(' ')[0];
                string ngay = currentDate.Substring(0, 2);
                string thang = currentDate.Substring(3, 2);
                string nam = currentDate.Substring(6);
                for (int i = 0; i < dgvSachMuon.RowCount; i++)
                {
                    CHITIETPHIEUMUON a = new CHITIETPHIEUMUON();
                    a.SoPhieuMuon = s.SoPhieuMuon;
                    a.MaS = Int32.Parse(dgvSachMuon.Rows[i].Cells[0].Value.ToString());
                    a.TinhTrang = 0;
                    a.NgayMuon = DateTime.ParseExact(thang + "/" + ngay + "/" + nam,"MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    a.NgayTra = null;
                    db.CHITIETPHIEUMUONs.InsertOnSubmit(a);
                    var updatesl = db.SACHes.Single(sp => sp.MaS == Int32.Parse(dgvSachMuon.Rows[i].Cells[0].Value.ToString()));
                    updatesl.SoLuong = updatesl.SoLuong - 1;
                    db.SubmitChanges();
                }
                QuanLyMuonTra.prepare();
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void txt_nguoimuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            string currentDate = localDate.Date.ToString(new CultureInfo("en-GB")).Split(' ')[0];
            string ngay = currentDate.Substring(0, 2);
            string thang = currentDate.Substring(3, 2);
            string nam = currentDate.Substring(6);
            string NgayMuon = thang + "/" + ngay + "/" + nam;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("AnhS");
            dt.Columns.Add("GiaMuon");
            dt.Columns.Add("LanXB");
            dt.Columns.Add("MaDanhMuc");
            dt.Columns.Add("MaS");
            dt.Columns.Add("NamXB");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("TacGia");
            dt.Columns.Add("TenNXB");
            dt.Columns.Add("TenS");
            for(int i=0; i< dgvSachMuon.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["MaS"] = dgvSachMuon.Rows[i].Cells[0].Value.ToString();
                dr["TenS"] = dgvSachMuon.Rows[i].Cells[1].Value.ToString();
                dr["GiaMuon"] = dgvSachMuon.Rows[i].Cells[2].Value.ToString();
                dt.Rows.Add(dr);
            }
            ds.Tables.Add(dt);
            BillViewer f = new BillViewer(ds, txt_nguoimuon.Text, lbl_chiTietPhieu.Text.Split('#')[1], txt_tongtien.Text, NgayMuon, tenDangNhap);
            f.ShowDialog();
        }
    }
}
