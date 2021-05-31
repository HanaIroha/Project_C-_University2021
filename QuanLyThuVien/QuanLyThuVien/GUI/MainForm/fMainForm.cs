using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using QuanLyThuVien.GUI.AdminForm.QuanLyTaiKhoan;
using QuanLyThuVien.GUI.AdminForm.QuanLySach;
using QuanLyThuVien.GUI.AdminForm.ThongKe;
using QuanLyThuVien.GUI.ManagerForm.QuanLyMuonTra;
using QuanLyThuVien.GUI.ManagerForm.QuanLyDocGia;
using QuanLyThuVien.GUI.ManagerForm.XemSach;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.GUI.MainForm
{
    public partial class fMainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        TaiKhoanDTO tk;
        bool userMenu = false;
        public fMainForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public fMainForm(string tenDangNhap)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            tk = new TaiKhoanBUS().GetTaiKhoan(tenDangNhap);
            IconUser.Text = tk.TenNguoiDung;
            if(tk.LoaiTaiKhoan == 1)
            {
                btn_xemSach.Visible = false;
            }
            else
            {
                btn_quanLySach.Visible = false;
                btn_quanLyTaiKhoan.Visible = false;
                btn_thongKe.Visible = false;
            }
            OpenChildForm(new WelcomeForm());
            lbl_currentChildForm.Text = "Home";
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lbl_currentChildForm.Text = childForm.Text;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 255 ,255);
            public static Color color2 = Color.FromArgb(0, 48, 96);
            public static Color color3 = Color.FromArgb(24, 154, 180);
            public static Color color4 = Color.FromArgb(0, 0, 0);
            public static Color color5 = Color.FromArgb(0, 0, 0);
            public static Color color6 = Color.FromArgb(0, 0, 0);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(14, 134, 212);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = RGBColors.color2;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = RGBColors.color3;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                icon_currentChildForm.IconChar = currentBtn.IconChar;
                icon_currentChildForm.IconColor = Color.White;
                lbl_currentChildForm.Text = currentBtn.Text;
            }
        }
        
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(5, 92, 157);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void btn_xemSach_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new fXemSach());
        }

        private void btn_quanLySach_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new fQuanLySach());
        }

        private void btn_baoTriDocGia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new fQuanLyDocGia());
        }

        private void btn_quanLyMuonTra_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new fQuanLyMuonTra(tk.TenDangNhap));
        }

        private void btn_thongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new fThongKe());
        }

        private void btn_quanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new fQuanLyTaiKhoan());
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WelcomeForm());
            lbl_currentChildForm.Text = "Home";
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            icon_currentChildForm.IconChar = IconChar.Home;
            icon_currentChildForm.IconColor = Color.White;
            lbl_currentChildForm.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void IconUser_Click(object sender, EventArgs e)
        {
            if (!userMenu)
            {
                btn_profile.Visible = true;
                btn_logout.Visible = true;
                userMenu = true;
            }
            else
            {
                btn_profile.Visible = false;
                btn_logout.Visible = false;
                userMenu = false;
            }
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau(tk.TenDangNhap);
            f.ShowDialog();
            btn_profile.Visible = false;
            btn_logout.Visible = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            btn_profile.Visible = false;
            btn_logout.Visible = false;
            this.Close();
        }
    }
}
