using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.GUI.AdminForm.QuanLyTaiKhoan
{
    public partial class fDoiMatKhau : Form
    {
        string TenTK;
        public fDoiMatKhau()
        {
            InitializeComponent();
        }
        public fDoiMatKhau(string TenDangNhap)
        {
            InitializeComponent();
            TenTK = TenDangNhap;
            prepare();
        }

        public void prepare()
        {
            TaiKhoanDTO tk = new TaiKhoanBUS().GetTaiKhoan(TenTK);
            txt_TenTaiKhoan.Text = tk.TenDangNhap;
            txt_TenNguoiDung.Text = tk.TenNguoiDung;
            lbl_image.Image = new ImageConvert().ConvertBytesToImage(tk.AnhDaiDien);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoanDTO tk = new TaiKhoanBUS().GetTaiKhoan(TenTK);
                if (txt_MatKhau.Text.Equals(""))
                {
                    txt_MatKhau.Focus();
                    throw new Exception("Mật khẩu không được bỏ trống");
                }
                if (txt_matKhauMoi.Text.Equals(""))
                {
                    txt_matKhauMoi.Focus();
                    throw new Exception("Mật khẩu mới không được bỏ trống");
                }
                if (!new TaiKhoanBUS().CheckDangNhap(TenTK, txt_MatKhau.Text))
                {
                    txt_MatKhau.Focus();
                    throw new Exception("Mật khẩu cũ không đúng!");
                }
                else
                {
                    new TaiKhoanBUS().UpdateMatKhau(txt_TenTaiKhoan.Text, txt_matKhauMoi.Text);
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
