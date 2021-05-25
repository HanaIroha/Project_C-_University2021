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
using OfficeExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyThuVien.GUI.AdminForm.QuanLySach
{
    public partial class fQuanLySach : Form
    {
        int index = -1;
        public fQuanLySach()
        {
            InitializeComponent();
        }
        private void fQuanLySach_Load(object sender, EventArgs e)
        {
            loadData();
            cbb_search.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddSach f = new fAddSach(this);
            f.ShowDialog();
        }

        public void loadData()
        {
            QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
            var s = from p in db.SACHes
                    join k in db.DANHMUCs
                    on p.MaDanhMuc equals k.MaDanhMuc
                    select new { AnhS = p.AnhS.ToArray(), p.MaS, p.TenS, p.TacGia, p.TenNXB, k.TenDanhMuc, p.NamXB, p.LanXB, p.SoLuong, p.GiaMuon };
            dgvSach.DataSource = s.ToList();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fEditSach f = new fEditSach(this,Int32.Parse(dgvSach.Rows[index].Cells[1].Value.ToString()));
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
                    if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        new SachBUS().DeleteItem(Int32.Parse(dgvSach.Rows[index].Cells[1].Value.ToString()));
                        index = -1;
                        loadData();
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            fDanhMuc f = new fDanhMuc();
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                if (txtSearch.Text.Equals(""))
                {
                    loadData();
                }
                else if (cbb_search.SelectedIndex == 0)
                {
                    var s = from p in db.SACHes
                            join k in db.DANHMUCs
                            on p.MaDanhMuc equals k.MaDanhMuc
                            where SqlMethods.Like(p.TenS, "%" + txtSearch.Text + "%")
                            select new { AnhS = p.AnhS.ToArray(), p.MaS, p.TenS, p.TacGia, p.TenNXB, k.TenDanhMuc, p.NamXB, p.LanXB, p.SoLuong, p.GiaMuon };
                    dgvSach.DataSource = s;
                }
                else if (cbb_search.SelectedIndex == 1)
                {
                    var s = from p in db.SACHes
                            join k in db.DANHMUCs
                            on p.MaDanhMuc equals k.MaDanhMuc
                            where SqlMethods.Like(p.TacGia, "%" + txtSearch.Text + "%")
                            select new { AnhS = p.AnhS.ToArray(), p.MaS, p.TenS, p.TacGia, p.TenNXB, k.TenDanhMuc, p.NamXB, p.LanXB, p.SoLuong, p.GiaMuon };
                    dgvSach.DataSource = s;
                }
                else if (cbb_search.SelectedIndex == 2)
                {
                    var s = from p in db.SACHes
                            join k in db.DANHMUCs
                            on p.MaDanhMuc equals k.MaDanhMuc
                            where SqlMethods.Like(p.TenNXB, "%" + txtSearch.Text + "%")
                            select new { AnhS = p.AnhS.ToArray(), p.MaS, p.TenS, p.TacGia, p.TenNXB, k.TenDanhMuc, p.NamXB, p.LanXB, p.SoLuong, p.GiaMuon };
                    dgvSach.DataSource = s;
                }
                else if (cbb_search.SelectedIndex == 3)
                {
                    var s = from p in db.SACHes
                            join k in db.DANHMUCs
                            on p.MaDanhMuc equals k.MaDanhMuc
                            where SqlMethods.Like(k.TenDanhMuc, "%" + txtSearch.Text + "%")
                            select new { AnhS = p.AnhS.ToArray(), p.MaS, p.TenS, p.TacGia, p.TenNXB, k.TenDanhMuc, p.NamXB, p.LanXB, p.SoLuong, p.GiaMuon };
                    dgvSach.DataSource = s;
                }
                else if (cbb_search.SelectedIndex == 4)
                {
                    var s = from p in db.SACHes
                            join k in db.DANHMUCs
                            on p.MaDanhMuc equals k.MaDanhMuc
                            where p.NamXB == Int32.Parse(txtSearch.Text)
                            select new { AnhS = p.AnhS.ToArray(), p.MaS, p.TenS, p.TacGia, p.TenNXB, k.TenDanhMuc, p.NamXB, p.LanXB, p.SoLuong, p.GiaMuon };
                    dgvSach.DataSource = s;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "chọn chỗ lưu";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.Filter = "Excel files (*.xlsx) | *.xlsx";
            saveFileDialog1.FileName = "unname";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
                var s = from p in db.SACHes
                        join k in db.DANHMUCs
                        on p.MaDanhMuc equals k.MaDanhMuc
                        select new { p.MaS, p.TenS, p.TacGia, p.TenNXB, k.TenDanhMuc, p.NamXB, p.LanXB, p.SoLuong };
                DataTable table = new DataTable();
                table.Columns.Add("Mã sách", typeof(int));
                table.Columns.Add("Tên sách", typeof(string));
                table.Columns.Add("Tác giả", typeof(string));
                table.Columns.Add("Nhà xuất bản", typeof(string));
                table.Columns.Add("Danh mục", typeof(string));
                table.Columns.Add("Năm xuất bản", typeof(int));
                table.Columns.Add("Lần xuất bản", typeof(int));
                table.Columns.Add("Số lượng tồn kho", typeof(int));
                int tongsach = 0;
                foreach(var a in s)
                {
                    DataRow row = table.NewRow();
                    row["Mã sách"] = a.MaS;
                    row["Tên sách"] = a.TenS;
                    row["Tác giả"] = a.TacGia;
                    row["Nhà xuất bản"] = a.TenNXB;
                    row["Danh mục"] = a.TenDanhMuc;
                    row["Năm xuất bản"] = a.NamXB;
                    row["Lần xuất bản"] = a.LanXB;
                    row["Số lượng tồn kho"] = a.SoLuong;
                    tongsach += (int)a.SoLuong;
                    table.Rows.Add(row);
                }
                ExportDataSetToExcel(table, saveFileDialog1.FileName, tongsach);
            }
        }
        private void ExportDataSetToExcel(DataTable ds, string strPath, int tongSach)
        {
            int inHeaderLength = 3, inColumn = 0, inRow = 0;
            System.Reflection.Missing Default = System.Reflection.Missing.Value;
            //Tao file excel
            OfficeExcel.Application excelApp = new OfficeExcel.Application();
            OfficeExcel.Workbook excelWorkBook = excelApp.Workbooks.Add(1);
            //Tao sheet
            OfficeExcel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add(Default, excelWorkBook.Sheets[excelWorkBook.Sheets.Count], 1, Default);
            //excelWorkSheet.Name = ds.TableName;

            //Tao cot
            for (int i = 0; i < ds.Columns.Count; i++)
                excelWorkSheet.Cells[inHeaderLength + 1, i + 1] = ds.Columns[i].ColumnName.ToUpper();

            //Tao dong
            for (int m = 0; m < ds.Rows.Count; m++)
            {
                for (int n = 0; n < ds.Columns.Count; n++)
                {
                    inColumn = n + 1;
                    inRow = inHeaderLength + 2 + m;
                    excelWorkSheet.Cells[inRow, inColumn] = ds.Rows[m].ItemArray[n].ToString();
                    if (m % 2 == 0)
                        excelWorkSheet.get_Range("A" + inRow.ToString(), "H" + inRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.FromHtml("#FCE4D6");
                }
            }
            excelWorkSheet.Cells[ds.Rows.Count + inHeaderLength + 2, 8] = "Tổng sách: " + tongSach.ToString();
            excelWorkSheet.get_Range("H" + (ds.Rows.Count + inHeaderLength + 2).ToString(), "H" + (ds.Rows.Count + inHeaderLength + 2).ToString()).Interior.Color = System.Drawing.ColorTranslator.FromHtml("#FCE4D6");

            //Tieu de
            OfficeExcel.Range cellRang = excelWorkSheet.get_Range("A1", "H3");
            cellRang.Merge(false);
            cellRang.Interior.Color = System.Drawing.Color.White;
            cellRang.Font.Color = System.Drawing.Color.Gray;
            cellRang.HorizontalAlignment = OfficeExcel.XlHAlign.xlHAlignCenter;
            cellRang.VerticalAlignment = OfficeExcel.XlVAlign.xlVAlignCenter;
            cellRang.Font.Size = 16;
            excelWorkSheet.Cells[1, 1] = "Danh sách đầu sách trong kho";

            //Dinh dang cot
            cellRang = excelWorkSheet.get_Range("A4", "H4");
            cellRang.Font.Bold = true;
            cellRang.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            cellRang.Interior.Color = System.Drawing.ColorTranslator.FromHtml("#ED7D31");

            excelWorkSheet.Columns[1].ColumnWidth = 10;
            excelWorkSheet.Columns[2].ColumnWidth = 30;
            excelWorkSheet.Columns[3].ColumnWidth = 30;
            excelWorkSheet.Columns[4].ColumnWidth = 20;
            excelWorkSheet.Columns[5].ColumnWidth = 20;
            excelWorkSheet.Columns[6].ColumnWidth = 25;
            excelWorkSheet.Columns[7].ColumnWidth = 15;
            excelWorkSheet.Columns[8].ColumnWidth = 20;
            //excelWorkSheet.Columns.AutoFit();

            excelWorkBook.SaveAs(strPath, Default, Default, Default, false, Default, OfficeExcel.XlSaveAsAccessMode.xlNoChange, Default, Default, Default, Default, Default);
            excelWorkBook.Close();
            excelApp.Quit();

            MessageBox.Show("Tạo thành công file execel tại \n " + strPath);
        }
    }
}
