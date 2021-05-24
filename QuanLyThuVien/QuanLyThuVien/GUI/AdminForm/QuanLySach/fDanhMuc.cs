using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI.AdminForm.QuanLySach
{
    public partial class fDanhMuc : Form
    {
        int index = -1;
        public fDanhMuc()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
            var dm = from p in db.DANHMUCs
                     select p;
            dgvDanhMuc.DataSource = dm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
            txt_TenDanhMuc.Clear();
            txt_TenDanhMuc.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_TenDanhMuc.Text.Equals(""))
                {
                    txt_TenDanhMuc.Focus();
                    throw new Exception("Không được để trống tên danh mục!");
                }
                QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                var dm = from p in db.DANHMUCs
                         where p.TenDanhMuc == txt_TenDanhMuc.Text
                         select p;
                if (dm.Count() > 0)
                {
                    throw new Exception("Tên danh mục này đã tồn tại!");
                }
                DANHMUC them = new DANHMUC();
                them.TenDanhMuc = txt_TenDanhMuc.Text;

                db.DANHMUCs.InsertOnSubmit(them);
                db.SubmitChanges();
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btn_save.Enabled = false;
                btn_cancel.Enabled = false;
                txt_TenDanhMuc.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            loadData();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
            txt_TenDanhMuc.Clear();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                txt_TenDanhMuc.Text = dgvDanhMuc.Rows[index].Cells[1].Value.ToString();
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                var dm = from p in db.DANHMUCs
                         where p.TenDanhMuc == txt_TenDanhMuc.Text
                         select p;
                if (dm.Count() > 0)
                {
                    throw new Exception("Tên danh mục này đã tồn tại!");
                }
                var capnhat = db.DANHMUCs.Single(sp => sp.MaDanhMuc == Int32.Parse(dgvDanhMuc.Rows[index].Cells[0].Value.ToString()));
                capnhat.TenDanhMuc = txt_TenDanhMuc.Text;
                db.SubmitChanges();
                txt_TenDanhMuc.Clear();
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                {
                    QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                    var xoa = from p in db.DANHMUCs
                              where p.MaDanhMuc == Int32.Parse(dgvDanhMuc.Rows[index].Cells[0].Value.ToString())
                              select p;
                    foreach (var i in xoa)
                    {
                        db.DANHMUCs.DeleteOnSubmit(i);
                        db.SubmitChanges();
                    }
                    txt_TenDanhMuc.Clear();
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    loadData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
