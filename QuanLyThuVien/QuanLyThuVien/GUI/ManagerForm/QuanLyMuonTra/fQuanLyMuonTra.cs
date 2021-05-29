using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.GUI.ManagerForm.QuanLyMuonTra;
using System.Data.Linq.SqlClient;

namespace QuanLyThuVien.GUI.ManagerForm.QuanLyMuonTra
{
    public partial class fQuanLyMuonTra : Form
    {
        int index = -1;
        string tenDN;
        public fQuanLyMuonTra(string TenDangNhap)
        {
            InitializeComponent();
            tenDN = TenDangNhap;
        }

        private void fQuanLyMuonTra_Load(object sender, EventArgs e)
        {
            prepare();
            cbb_search.SelectedIndex = 0;
        }

        public void prepare()
        {
            QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
            var p = from z in db.PHIEUMUONs
                    select new {z.SoPhieuMuon, z.TenDangNhap, z.MaSinhVien};
            dgvPhieu.DataSource = p;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddPhieuMuon f = new fAddPhieuMuon(this, tenDN);
            f.ShowDialog();
        }
        public void hienthi()
        {
        }

        private void dgvPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void dgvPhieu_DoubleClick(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                fEditPhieuMuon f = new fEditPhieuMuon(this, Int32.Parse(dgvPhieu.Rows[index].Cells[0].Value.ToString()));
                f.ShowDialog();
                index = -1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                if (txtSearch.Text.Equals(""))
                {
                    prepare();
                }
                else if (cbb_search.SelectedIndex == 0)
                {
                    var p = from z in db.PHIEUMUONs
                            where SqlMethods.Equals(z.SoPhieuMuon.ToString(), txtSearch.Text)
                            select new { z.SoPhieuMuon, z.TenDangNhap, z.MaSinhVien };
                    dgvPhieu.DataSource = p;
                }
                else if (cbb_search.SelectedIndex == 1)
                {
                    var p = from z in db.PHIEUMUONs
                            where SqlMethods.Like(z.TenDangNhap, "%" + txtSearch.Text + "%")
                            select new { z.SoPhieuMuon, z.TenDangNhap, z.MaSinhVien };
                    dgvPhieu.DataSource = p;
                }
                else if (cbb_search.SelectedIndex == 2)
                {
                    var p = from z in db.PHIEUMUONs
                            where SqlMethods.Like(z.MaSinhVien, "%" + txtSearch.Text + "%")
                            select new { z.SoPhieuMuon, z.TenDangNhap, z.MaSinhVien };
                    dgvPhieu.DataSource = p;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
