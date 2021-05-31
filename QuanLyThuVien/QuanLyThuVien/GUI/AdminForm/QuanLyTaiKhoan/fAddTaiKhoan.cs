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
    public partial class fAddTaiKhoan : Form
    {
        fQuanLyTaiKhoan QuanLyTaiKhoan;
        bool hasPicture = false;
        public fAddTaiKhoan()
        {
            InitializeComponent();
        }
        public fAddTaiKhoan(fQuanLyTaiKhoan f)
        {
            InitializeComponent();
            QuanLyTaiKhoan = f;
            prepare();
        }

        public void prepare()
        {
            rd_KichHoat.Checked = true;
            openFileDialog1.FileName = null;
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
                    hasPicture = true;
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
                if (txt_TenNguoiDung.Text.Equals(""))
                {
                    txt_TenNguoiDung.Focus();
                    throw new Exception("Tên người dùng không được bỏ trống");
                }
                if (!hasPicture)
                {
                    throw new Exception("Chưa có ảnh đại diện");
                }
                else
                {
                    new TaiKhoanBUS().AddTaiKhoan(new ImageConvert().ConvertImageToBytes(lbl_image.Image),
                        txt_TenTaiKhoan.Text,
                        "123",
                        txt_TenNguoiDung.Text,
                        0,
                        rd_KichHoat.Checked ? true : false);
                    QuanLyTaiKhoan.prepare();
                    MessageBox.Show("Thêm tài khoản thành công!");
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
