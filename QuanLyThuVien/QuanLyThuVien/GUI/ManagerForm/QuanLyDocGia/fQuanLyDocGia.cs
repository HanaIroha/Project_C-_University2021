using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Newtonsoft.Json;
using System.IO;
using OfficeExcel = Microsoft.Office.Interop.Excel;
using FastMember;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.GUI.ManagerForm.QuanLyDocGia
{
    public partial class fQuanLyDocGia : Form
    {
        string currentDate;
        List<DocGia> items;
        int index = -1;
        bool isCurrent;
        int i = 0;
        public fQuanLyDocGia()
        {
            InitializeComponent();
            Prepare();
        }

        public void Prepare()
        {
            timer.Start();
            DateTime localDate = DateTime.Now;
            currentDate = localDate.Date.ToString(new CultureInfo("en-GB")).Split(' ')[0];
            Directory.CreateDirectory("LichSuDocGia");
            string ngay = currentDate.Substring(0, 2);
            string thang = currentDate.Substring(3, 2);
            string nam = currentDate.Substring(6);
            using (StreamWriter w = File.AppendText(@"LichSuDocGia/" + nam + thang + ngay + ".txt")) ;
            loadCombo();
            cbb_ngay.SelectedIndex = 0;
            cbb_search.SelectedIndex = 0;
        }

        private void loadCombo()
        {
            cbb_ngay.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(@"LichSuDocGia");
            FileInfo[] Files = d.GetFiles("*.txt");
            for (int i = Files.Length - 1; i >= 0; i--)
            {
                var file = Files[i];
                string nam = file.Name.Substring(0, 4);
                string thang = file.Name.Substring(4, 2);
                string ngay = file.Name.Substring(6, 2);
                cbb_ngay.Items.Add(ngay + "/" + thang + "/" + nam);
            }
        }

        private void loadDanhSach()
        {
            i = 0;
            string currentDayChoose = cbb_ngay.SelectedItem.ToString();
            string ngay = currentDayChoose.Substring(0, 2);
            string thang = currentDayChoose.Substring(3, 2);
            string nam = currentDayChoose.Substring(6);
            using (StreamReader r = new StreamReader(@"LichSuDocGia/" + nam + thang + ngay + ".txt"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<DocGia>>(json);
                if (items != null)
                {
                    dgvDanhSach.DataSource = items;
                }
                else
                {
                    items = new List<DocGia>();
                    dgvDanhSach.DataSource = items;
                }
            }
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void searchTen()
        {
            i = 1;
            string currentDayChoose = cbb_ngay.SelectedItem.ToString();
            string ngay = currentDayChoose.Substring(0, 2);
            string thang = currentDayChoose.Substring(3, 2);
            string nam = currentDayChoose.Substring(6);
            using (StreamReader r = new StreamReader(@"LichSuDocGia/" + nam + thang + ngay + ".txt"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<DocGia>>(json);
                List<DocGia> newList = new List<DocGia>();
                foreach (var a in items)
                {
                    if (a.hoTen.Contains(txtSearch.Text))
                        newList.Add(a);
                }
                if (newList != null)
                {
                    dgvDanhSach.DataSource = newList;
                }
                else
                {
                    newList = new List<DocGia>();
                    dgvDanhSach.DataSource = newList;
                }
            }
        }
        private void searchMaSinhVien()
        {
            i = 2;
            string currentDayChoose = cbb_ngay.SelectedItem.ToString();
            string ngay = currentDayChoose.Substring(0, 2);
            string thang = currentDayChoose.Substring(3, 2);
            string nam = currentDayChoose.Substring(6);
            using (StreamReader r = new StreamReader(@"LichSuDocGia/" + nam + thang + ngay + ".txt"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<DocGia>>(json);
                List<DocGia> newList = new List<DocGia>();
                foreach (var a in items)
                {
                    if (a.maSV.Contains(txtSearch.Text))
                        newList.Add(a);
                }
                if (newList != null)
                {
                    dgvDanhSach.DataSource = newList;
                }
                else
                {
                    newList = new List<DocGia>();
                    dgvDanhSach.DataSource = newList;
                }
            }
        }

        private void addDocGia(string TenDocGia, string MaSV, string ngayNhap)
        {
            string currentDayChoose = cbb_ngay.SelectedItem.ToString();
            string ngay = currentDayChoose.Substring(0, 2);
            string thang = currentDayChoose.Substring(3, 2);
            string nam = currentDayChoose.Substring(6);
            //List<DocGia> items = new List<DocGia>();
            //using (StreamReader r = new StreamReader(@"LichSuDocGia/" + nam + thang + ngay + ".txt"))
            //{
            //    string json = r.ReadToEnd();
            //    items = JsonConvert.DeserializeObject<List<DocGia>>(json);
            //    items.Add(new DocGia()
            //    {
            //        hoTen = TenDocGia,
            //        maSV = MaSV,
            //        thoiGian = ngay
            //    });
            //}
            items.Add(new DocGia()
            {
                hoTen = TenDocGia,
                maSV = MaSV,
                thoiGian = DateTime.Now.ToString("h:mm:ss tt")
            });

            string jsonOut = JsonConvert.SerializeObject(items.ToArray(), Formatting.Indented);

            //write string to file
            File.WriteAllText(@"LichSuDocGia/" + ngayNhap + ".txt", jsonOut);

            txt_hoten.Clear();
            txt_masv.Clear();
            txt_hoten.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_masv.Text.Equals(""))
                {
                    txt_masv.Focus();
                    throw new Exception("Mã sinh viên không được để trống");
                }
                if (txt_hoten.Text.Equals(""))
                {
                    txt_hoten.Focus();
                    throw new Exception("Họ tên không được để trống");
                }
                string currentDayChoose = cbb_ngay.SelectedItem.ToString();
                string ngay = currentDayChoose.Substring(0, 2);
                string thang = currentDayChoose.Substring(3, 2);
                string nam = currentDayChoose.Substring(6);
                addDocGia(txt_hoten.Text, txt_masv.Text, nam + thang + ngay);
                loadDanhSach();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn đối tượng cần sửa!");
            }
            else
            {
                string currentDayChoose = cbb_ngay.SelectedItem.ToString();
                string ngay = currentDayChoose.Substring(0, 2);
                string thang = currentDayChoose.Substring(3, 2);
                string nam = currentDayChoose.Substring(6);
                if (i == 0)
                {
                    items[index].hoTen = txt_hoten.Text;
                    items[index].maSV = txt_masv.Text;
                }
                else if (i == 1)
                {
                    int realindex = -1;
                    foreach (var a in items)
                    {
                        realindex++;
                        if (a.hoTen.Contains(txtSearch.Text))
                            i--;
                        if (i == 0)
                            break;
                    }
                    items[realindex].hoTen = txt_hoten.Text;
                    items[realindex].maSV = txt_masv.Text;
                }
                else if (i == 2)
                {
                    int realindex = -1;
                    foreach (var a in items)
                    {
                        realindex++;
                        if (a.maSV.Contains(txtSearch.Text))
                            i--;
                        if (i == 0)
                            break;
                    }
                    items[realindex].hoTen = txt_hoten.Text;
                    items[realindex].maSV = txt_masv.Text;
                }

                string jsonOut = JsonConvert.SerializeObject(items.ToArray(), Formatting.Indented);

                //write string to file
                File.WriteAllText(@"LichSuDocGia/" + nam + thang + ngay + ".txt", jsonOut);
            }
            loadDanhSach();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSach.CurrentCell.RowIndex;
                if (index < 0)
                {
                    MessageBox.Show("Vui lòng chọn đối tượng cần sửa!");
                }
                else
                {
                    if(MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                    {
                        string currentDayChoose = cbb_ngay.SelectedItem.ToString();
                        string ngay = currentDayChoose.Substring(0, 2);
                        string thang = currentDayChoose.Substring(3, 2);
                        string nam = currentDayChoose.Substring(6);
                        if (i == 0)
                        {
                            items.RemoveAt(index);
                        }
                        else if (i == 1)
                        {
                            int realindex = -1;
                            foreach (var a in items)
                            {
                                realindex++;
                                if (a.hoTen.Contains(txtSearch.Text))
                                    i--;
                                if (i == 0)
                                    break;
                            }
                            items.RemoveAt(realindex);
                        }
                        else if (i == 2)
                        {
                            int realindex = -1;
                            foreach (var a in items)
                            {
                                realindex++;
                                if (a.maSV.Contains(txtSearch.Text))
                                    i--;
                                if (i == 0)
                                    break;
                            }
                            items.RemoveAt(realindex);
                        }
                        string jsonOut = JsonConvert.SerializeObject(items.ToArray(), Formatting.Indented);

                        //write string to file
                        File.WriteAllText(@"LichSuDocGia/" + nam + thang + ngay + ".txt", jsonOut);
                        index = -1;
                    }
                    txt_hoten.Clear();
                    txt_masv.Clear();
                    loadDanhSach();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                txt_hoten.Text = dgvDanhSach.Rows[index].Cells[0].Value.ToString();
                txt_masv.Text = dgvDanhSach.Rows[index].Cells[1].Value.ToString();
                if (isCurrent)
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void cbb_ngay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbb_ngay.SelectedItem.Equals(currentDate))
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                isCurrent = false;
            }
            else
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                isCurrent = true;
            }
            loadDanhSach();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void txt_masv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Equals(""))
                    loadCombo();
                else if (cbb_search.SelectedIndex == 0)
                {
                    searchTen();
                }
                else if (cbb_search.SelectedIndex == 1)
                {
                    searchMaSinhVien();
                }
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnDeleteHistory_Click(object sender, EventArgs e)
        {
            fDeleteEntry f = new fDeleteEntry(this);
            f.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "chọn chỗ lưu";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.Filter = "Excel files (*.xlsx) | *.xlsx";
            saveFileDialog1.FileName = "unname";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string currentDayChoose = cbb_ngay.SelectedItem.ToString();
                string ngay = currentDayChoose.Substring(0, 2);
                string thang = currentDayChoose.Substring(3, 2);
                string nam = currentDayChoose.Substring(6);
                using (StreamReader r = new StreamReader(@"LichSuDocGia/" + nam + thang + ngay + ".txt"))
                {
                    string json = r.ReadToEnd();
                    items = JsonConvert.DeserializeObject<List<DocGia>>(json);
                    if (items == null)
                    {
                        items = new List<DocGia>();
                    }
                }
                DataTable table = new DataTable();
                using (var reader = ObjectReader.Create((List<DocGia>)dgvDanhSach.DataSource))
                {
                    table.Load(reader);
                }
                ExportDataSetToExcel(table, saveFileDialog1.FileName);
            }
        }

        private void ExportDataSetToExcel(DataTable ds, string strPath)
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
            excelWorkSheet.Cells[inHeaderLength + 1, 1] = "Họ và tên";
            excelWorkSheet.Cells[inHeaderLength + 1, 2] = "Mã sinh viên";
            excelWorkSheet.Cells[inHeaderLength + 1, 3] = "Thời gian đến";

            //Tao dong
            for (int m = 0; m < ds.Rows.Count; m++)
            {
                for (int n = 0; n < ds.Columns.Count; n++)
                {
                    inColumn = n + 1;
                    inRow = inHeaderLength + 2 + m;
                    excelWorkSheet.Cells[inRow, inColumn] = ds.Rows[m].ItemArray[n].ToString();
                    if (m % 2 == 0)
                        excelWorkSheet.get_Range("A" + inRow.ToString(), "C" + inRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.FromHtml("#FCE4D6");
                }
            }

            //Tieu de
            OfficeExcel.Range cellRang = excelWorkSheet.get_Range("A1", "C3");
            cellRang.Merge(false);
            cellRang.Interior.Color = System.Drawing.Color.White;
            cellRang.Font.Color = System.Drawing.Color.Gray;
            cellRang.HorizontalAlignment = OfficeExcel.XlHAlign.xlHAlignCenter;
            cellRang.VerticalAlignment = OfficeExcel.XlVAlign.xlVAlignCenter;
            cellRang.Font.Size = 16;
            excelWorkSheet.Cells[1, 1] = "Danh sách đến thư viện ngày " + cbb_ngay.SelectedItem.ToString();

            //Dinh dang cot
            cellRang = excelWorkSheet.get_Range("A4", "C4");
            cellRang.Font.Bold = true;
            cellRang.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            cellRang.Interior.Color = System.Drawing.ColorTranslator.FromHtml("#ED7D31");

            for (int i = 1; i <= 3; i++)
            {
                excelWorkSheet.Columns[i].ColumnWidth = 30;
            }
            //excelWorkSheet.Columns.AutoFit();

            excelWorkBook.SaveAs(strPath, Default, Default, Default, false, Default, OfficeExcel.XlSaveAsAccessMode.xlNoChange, Default, Default, Default, Default, Default);
            excelWorkBook.Close();
            excelApp.Quit();

            MessageBox.Show("Tạo thành công file execel tại \n " + strPath);
        }
    }
}
