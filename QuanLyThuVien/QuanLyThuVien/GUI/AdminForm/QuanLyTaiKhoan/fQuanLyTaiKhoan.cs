using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BUS;

namespace QuanLyThuVien.GUI.AdminForm.QuanLyTaiKhoan
{
    public partial class fQuanLyTaiKhoan : Form
    {
        int index = -1;
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            prepare();
        }
        public void prepare()
        {
            loadData(new TaiKhoanBUS().GetTableTaiKhoan());
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            cbb_search.SelectedIndex = 0;
        }

        public void loadData(DataTable dt)
        {
            dgvTaiKhoan.Rows.Clear();
            foreach(DataRow a in dt.Rows)
            {
                dgvTaiKhoan.Rows.Add((byte[])a.ItemArray[1],
                    (string)a.ItemArray[2],
                    (string)a.ItemArray[3],
                    (string)a.ItemArray[4],
                    Int32.Parse(a.ItemArray[5].ToString()) == 1 ? "Người quản trị" : "Nhân viên",
                    (bool)a.ItemArray[6] ? "Kích hoạt" : "Vô hiệu hoá",
                    Int32.Parse(a.ItemArray[5].ToString())
                    );
            }
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddTaiKhoan f = new fAddTaiKhoan(this);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fEditTaiKhoan f = new fEditTaiKhoan(this, dgvTaiKhoan.Rows[index].Cells[1].Value.ToString());
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (index < 0)
                {
                    MessageBox.Show("Vui lòng chọn đối tượng cần xoá!");
                }
                else
                {
                    if(MessageBox.Show("Bạn có chắc chắn muốn xoá tài khoản "+ dgvTaiKhoan.Rows[index].Cells[1].Value.ToString() + " không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                    {
                        new TaiKhoanBUS().DeleteTaiKhoan(dgvTaiKhoan.Rows[index].Cells[1].Value.ToString());
                        index = -1;
                        prepare();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    loadData(new TaiKhoanBUS().SearchTenDangNhap(txtSearch.Text));
                }
                else if (cbb_search.SelectedIndex == 1)
                {
                    loadData(new TaiKhoanBUS().SearchTenNguoiDung(txtSearch.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
