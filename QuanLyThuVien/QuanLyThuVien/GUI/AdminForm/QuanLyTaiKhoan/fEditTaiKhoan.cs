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
    public partial class fEditTaiKhoan : Form
    {
        fQuanLyTaiKhoan QuanLyTaiKhoan;
        string TenTK;
        public fEditTaiKhoan()
        {
            InitializeComponent();
        }
        public fEditTaiKhoan(fQuanLyTaiKhoan f, string TenDangNhap)
        {
            InitializeComponent();
            QuanLyTaiKhoan = f;
            TenTK = TenDangNhap;
            prepare();
        }

        public void prepare()
        {
            TaiKhoanDTO tk = new TaiKhoanBUS().GetTaiKhoan(TenTK);
            txt_TenTaiKhoan.Text = tk.TenDangNhap;
            txt_TenNguoiDung.Text = tk.TenNguoiDung;
            txt_MatKhau.Text = tk.MatKhau;
            if (tk.TinhTrang)
                rd_KichHoat.Checked = true;
            else
                rd_VoHieuHoa.Checked = true;
            lbl_image.Image = new ImageConvert().ConvertBytesToImage(tk.AnhDaiDien);
        }

        private void btn_changeImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "chọn ảnh";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            Image img;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    img = Image.FromFile(openFileDialog1.FileName);
                    lbl_image.Image = img;
                }
                catch (FileNotFoundException x)
                {
                    MessageBox.Show(x.Message);
                }

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
                if (txt_TenTaiKhoan.Text.Equals(""))
                {
                    txt_TenTaiKhoan.Focus();
                    throw new Exception("Tên đăng nhập không được bỏ trống");
                }
                if (txt_MatKhau.Text.Equals(""))
                {
                    txt_MatKhau.Focus();
                    throw new Exception("Mật khẩu không được bỏ trống");
                }
                if (txt_TenNguoiDung.Text.Equals(""))
                {
                    txt_TenNguoiDung.Focus();
                    throw new Exception("Tên người dùng không được bỏ trống");
                }
                if (lbl_image.Image == null)
                {
                    throw new Exception("Chưa có ảnh đại diện");
                }
                else
                {
                    new TaiKhoanBUS().UpdateTaiKhoan(new ImageConvert().ConvertImageToBytes(lbl_image.Image),
                        txt_TenTaiKhoan.Text,
                        txt_MatKhau.Text,
                        txt_TenNguoiDung.Text,
                        rd_KichHoat.Checked ? true : false);
                    QuanLyTaiKhoan.prepare();
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
