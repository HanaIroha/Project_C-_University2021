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

namespace QuanLyThuVien.GUI.ManagerForm.QuanLyDocGia
{
    public partial class fDeleteEntry : Form
    {
        fQuanLyDocGia QuanLyDocGia;
        public fDeleteEntry(fQuanLyDocGia f)
        {
            InitializeComponent();
            QuanLyDocGia = f;
            cbb_ngayxoa.SelectedIndex = 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int sl = 0;
                if (cbb_ngayxoa.SelectedIndex == 0)
                    sl = 7;
                else if (cbb_ngayxoa.SelectedIndex == 1)
                    sl = 30;
                DirectoryInfo d = new DirectoryInfo(@"LichSuDocGia");
                FileInfo[] Files = d.GetFiles("*.txt");
                if (sl == 0)
                {
                    if (Files.Length > 1)
                        for(int i = 0; i < Files.Length - 1; i++)
                        {
                            File.Delete(@"LichSuDocGia\" + Files[i].Name);
                        }
                }
                else
                {
                    if (sl > Files.Length - 1)
                        sl = Files.Length - 1;
                    if (Files.Length > 1)
                        for (int i = 0; i < sl; i++)
                        {
                            File.Delete(@"LichSuDocGia\" + Files[i].Name);
                        }
                }
                QuanLyDocGia.Prepare();
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
