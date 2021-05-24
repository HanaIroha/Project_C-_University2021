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
    public partial class fAddSach : Form
    {
        fQuanLySach QuanLySach;
        bool hasPicture = false;
        public fAddSach()
        {
            InitializeComponent();
        }
        public fAddSach(fQuanLySach f)
        {
            InitializeComponent();
            QuanLySach = f;
            prepare();
        }

        public void prepare()
        {
            cbb_danhMuc.DataSource = new DanhMucBUS().GetDanhMuc();
            cbb_danhMuc.DisplayMember = "TenDanhMuc";
            cbb_danhMuc.ValueMember = "MaDanhMuc";
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
                    hasPicture = true ;
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
                if (!hasPicture)
                {
                    throw new Exception("Chưa có ảnh");
                }
                //int sl = new SachBUS().GetCountItem(txt_tenSach.Text);
                //if (sl > 0)
                //{
                //    throw new Exception("Tên đầu sách này đã tồn tại!");
                //}
                else
                {
                    SACH sach = new SACH();
                    sach.TenS = txt_tenSach.Text;
                    sach.TacGia = txt_tacGia.Text;
                    sach.TenNXB = txt_tenNXB.Text;
                    sach.MaDanhMuc = Int32.Parse(cbb_danhMuc.SelectedValue.ToString());
                    sach.NamXB = Int32.Parse(txt_namXB.Text);
                    sach.LanXB = Int32.Parse(txt_lanXB.Text);
                    sach.SoLuong = Int32.Parse(txt_sl.Text);
                    sach.GiaMuon = Int32.Parse(txt_giaMuon.Text);
                    sach.AnhS = new ImageConvert().ConvertImageToBytes(lbl_image.Image);
                    QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                    db.SACHes.InsertOnSubmit(sach);
                    db.SubmitChanges();
                    //new SachBUS().InsertItem(txt_tenSach.Text,
                    //    txt_tacGia.Text,
                    //    txt_tenNXB.Text,
                    //    Int32.Parse(cbb_danhMuc.SelectedValue.ToString()),
                    //    Int32.Parse(txt_namXB.Text),
                    //    Int32.Parse(txt_lanXB.Text),
                    //    Int32.Parse(txt_sl.Text),
                    //    Int32.Parse(txt_giaMuon.Text),
                    //    new ImageConvert().ConvertImageToBytes(lbl_image.Image)
                    //    );
                    QuanLySach.loadData();
                    this.Dispose();
                }
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
