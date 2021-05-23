using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.GUI.AdminForm.QuanLySach;
using QuanLyThuVien.BUS;
using System.Data.Linq.SqlClient;

namespace QuanLyThuVien.GUI.AdminForm.QuanLySach
{
    public partial class fQuanLySach : Form
    {
        int index = -1;
        public fQuanLySach()
        {
            InitializeComponent();
        }
        private void fQuanLySach_Load(object sender, EventArgs e)
        {
            loadData();
            cbb_search.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddSach f = new fAddSach(this);
            f.ShowDialog();
        }

        public void loadData()
        {
            QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
            var s = from p in db.SACHes
                    join k in db.DANHMUCs
                    on p.MaDanhMuc equals k.MaDanhMuc
                    select new { AnhS = p.AnhS.ToArray(), p.MaS, p.TenS, p.TacGia, p.TenNXB, k.TenDanhMuc, p.NamXB, p.LanXB, p.SoLuong, p.GiaMuon };
            dgvSach.DataSource = s;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fEditSach f = new fEditSach(this,Int32.Parse(dgvSach.Rows[index].Cells[1].Value.ToString()));
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn đối tượng cần xoá!");
            }
            else
            {
                new SachBUS().DeleteItem(Int32.Parse(dgvSach.Rows[index].Cells[1].Value.ToString()));
                index = -1;
                loadData();
            }
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            fDanhMuc f = new fDanhMuc();
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                if (txtSearch.Text.Equals(""))
                {
                    loadData();
                }
                else if (cbb_search.SelectedIndex == 0)
                {
                    var s = from p in db.SACHes
                            join k in db.DANHMUCs
                            on p.MaDanhMuc equals k.MaDanhMuc
                            where SqlMethods.Like(p.TenS, "%" + txtSearch.Text + "%")
                            select new { AnhS = p.AnhS.ToArray(), p.MaS, p.TenS, p.TacGia, p.TenNXB, k.TenDanhMuc, p.NamXB, p.LanXB, p.SoLuong, p.GiaMuon };
                    dgvSach.DataSource = s;
                }
                else if (cbb_search.SelectedIndex == 1)
                {
                    var s = from p in db.SACHes
                            join k in db.DANHMUCs
                            on p.MaDanhMuc equals k.MaDanhMuc
                            where SqlMethods.Like(p.TacGia, "%" + txtSearch.Text + "%")
                            select new { AnhS = p.AnhS.ToArray(), p.MaS, p.TenS, p.TacGia, p.TenNXB, k.TenDanhMuc, p.NamXB, p.LanXB, p.SoLuong, p.GiaMuon };
                    dgvSach.DataSource = s;
                }
                else if (cbb_search.SelectedIndex == 2)
                {
                    var s = from p in db.SACHes
                            join k in db.DANHMUCs
                            on p.MaDanhMuc equals k.MaDanhMuc
                            where SqlMethods.Like(p.TenNXB, "%" + txtSearch.Text + "%")
                            select new { AnhS = p.AnhS.ToArray(), p.MaS, p.TenS, p.TacGia, p.TenNXB, k.TenDanhMuc, p.NamXB, p.LanXB, p.SoLuong, p.GiaMuon };
                    dgvSach.DataSource = s;
                }
                else if (cbb_search.SelectedIndex == 3)
                {
                    var s = from p in db.SACHes
                            join k in db.DANHMUCs
                            on p.MaDanhMuc equals k.MaDanhMuc
                            where SqlMethods.Like(k.TenDanhMuc, "%" + txtSearch.Text + "%")
                            select new { AnhS = p.AnhS.ToArray(), p.MaS, p.TenS, p.TacGia, p.TenNXB, k.TenDanhMuc, p.NamXB, p.LanXB, p.SoLuong, p.GiaMuon };
                    dgvSach.DataSource = s;
                }
                else if (cbb_search.SelectedIndex == 4)
                {
                    var s = from p in db.SACHes
                            join k in db.DANHMUCs
                            on p.MaDanhMuc equals k.MaDanhMuc
                            where p.NamXB == Int32.Parse(txtSearch.Text)
                            select new { AnhS = p.AnhS.ToArray(), p.MaS, p.TenS, p.TacGia, p.TenNXB, k.TenDanhMuc, p.NamXB, p.LanXB, p.SoLuong, p.GiaMuon };
                    dgvSach.DataSource = s;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
