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

namespace QuanLyThuVien.GUI.MainForm
{
    public partial class fLogin : Form
    {
        int id;
        public fLogin()
        {
            InitializeComponent();
        }

        public int setIDUser()
        {
            return id;
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát chương trình không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string error = "";
            if (txtAccount.Text == "")
            {
                error = "Tài khoản không được để trống";
            }
            else if (txtPassword.Text == "")
            {
                error = "Mật khẩu không được để trống";
            }
            //users.getUsernamPassword(txtAccount.Text, txtPassword.Text) != null
            if (error == "")
            {
                string username = txtAccount.Text;
                string password = txtPassword.Text;
                if (new TaiKhoanBUS().CheckVoHH(txtAccount.Text, txtPassword.Text))
                {
                    MessageBox.Show("Tài khoản bị vô hiệu hóa!");
                }
                else if (!new TaiKhoanBUS().CheckDangNhap(txtAccount.Text, txtPassword.Text))
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không tồn tại!");
                }
                else
                {
                    fMainForm f = new fMainForm(txtAccount.Text);
                    this.Hide();
                    f.ShowDialog();
                    resetAcc();
                    try
                    {
                        this.Show();
                    }
                    catch
                    {

                    }
                }

            }
            else
            {
                MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void resetAcc()
        {
            txtAccount.Clear();
            txtPassword.Clear();
            txtAccount.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
