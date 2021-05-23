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

namespace QuanLyThuVien.GUI.ManagerForm.XemSach
{
    public partial class fXemSach : Form
    {
        public fXemSach()
        {
            InitializeComponent();
        }
        private void fQuanLySach_Load(object sender, EventArgs e)
        {
            loadData(new SachBUS().GetTableSachTenDM());
            cbb_search.SelectedIndex = 0;
        }

        public void loadData(DataTable dt)
        {
            dgvSach.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                if (txtSearch.Text.Equals(""))
                {
                    loadData(new SachBUS().GetTableSachTenDM());
                }
                else if (cbb_search.SelectedIndex == 0)
                {
                    loadData(new SachBUS().SearchTen(txtSearch.Text));
                }
                else if (cbb_search.SelectedIndex == 1)
                {
                    loadData(new SachBUS().SearchTacGia(txtSearch.Text));
                }
                else if (cbb_search.SelectedIndex == 2)
                {
                    loadData(new SachBUS().SearchNXB(txtSearch.Text));
                }
                else if (cbb_search.SelectedIndex == 3)
                {
                    loadData(new SachBUS().SearchDanhMuc(txtSearch.Text));
                }
                else if (cbb_search.SelectedIndex == 4)
                {
                    loadData(new SachBUS().SearchNamXB(txtSearch.Text));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
