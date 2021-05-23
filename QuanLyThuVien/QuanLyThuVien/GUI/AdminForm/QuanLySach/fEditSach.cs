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

namespace QuanLyThuVien.GUI.AdminForm.QuanLySach
{
    public partial class fEditSach : Form
    {
        fQuanLySach QuanLySach;
        int MaSach;
        public fEditSach()
        {
            InitializeComponent();
        }
        public fEditSach(fQuanLySach f, int MaS)
        {
            InitializeComponent();
            QuanLySach = f;
            MaSach = MaS;
            prepare();
        }

        public void prepare()
        {
            cbb_danhMuc.DataSource = new DanhMucBUS().GetDanhMuc();
            cbb_danhMuc.DisplayMember = "TenDanhMuc";
            cbb_danhMuc.ValueMember = "MaDanhMuc";
            QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
            var chon = db.SACHes.Single(s => s.MaS == MaSach);
            txt_tenSach.Text = chon.TenS;
            txt_tacGia.Text = chon.TacGia;
            txt_tenNXB.Text = chon.TenNXB;
            txt_namXB.Text = chon.NamXB.ToString();
            txt_lanXB.Text = chon.LanXB.ToString();
            txt_sl.Text = chon.SoLuong.ToString();
            txt_giaMuon.Text = chon.GiaMuon.ToString();
            lbl_image.Image = new ImageConvert().ConvertBytesToImage((byte[])chon.AnhS.ToArray());
            cbb_danhMuc.SelectedValue = chon.MaDanhMuc;

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
                if (cbb_danhMuc.SelectedIndex == -1)
                {
                    throw new Exception("Vui lòng chọn danh mục");
                }
                if (txt_tenSach.Text.Equals(""))
                {
                    txt_tenSach.Focus();
                    throw new Exception("Tên sách không được bỏ trống");
                }
                if (txt_tenNXB.Text.Equals(""))
                {
                    txt_tenNXB.Focus();
                    throw new Exception("Tên nhà xuất bản không được bỏ trống");
                }
                if (txt_tacGia.Text.Equals(""))
                {
                    txt_tacGia.Focus();
                    throw new Exception("Tên tác giả không được bỏ trống");
                }
                if (txt_namXB.Text.Equals(""))
                {
                    txt_namXB.Focus();
                    throw new Exception("Năm xuất bản không được bỏ trống");
                }
                if (txt_giaMuon.Text.Equals(""))
                {
                    txt_giaMuon.Focus();
                    throw new Exception("Giá mượn không được bỏ trống");
                }
                if (lbl_image.Image == null)
                {
                    throw new Exception("Chưa có ảnh đại diện");
                }
                QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                var sach = db.SACHes.Single(s => s.MaS == MaSach);
                sach.TenS = txt_tenSach.Text;
                sach.TacGia = txt_tacGia.Text;
                sach.TenNXB = txt_tenNXB.Text;
                sach.MaDanhMuc = Int32.Parse(cbb_danhMuc.SelectedValue.ToString());
                sach.NamXB = Int32.Parse(txt_namXB.Text);
                sach.LanXB = Int32.Parse(txt_lanXB.Text);
                sach.SoLuong = Int32.Parse(txt_sl.Text);
                sach.GiaMuon = Int32.Parse(txt_giaMuon.Text);
                sach.AnhS = new ImageConvert().ConvertImageToBytes(lbl_image.Image);
                db.SubmitChanges();
                QuanLySach.loadData();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void txt_namXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_giaMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
