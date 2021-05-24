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
using Newtonsoft.Json;
using System.IO;
using QuanLyThuVien.DTO;
using OfficeExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyThuVien.GUI.AdminForm.ThongKe
{
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
        }
        private void fThongKe_Load(object sender, EventArgs e)
        {
            prepare();
        }
        public void prepare()
        {
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i>=currentYear - 5; i--)
            {
                cbb_year.Items.Add(i);
            }
            cbb_year.SelectedIndex = 0;
            cbb_month.SelectedIndex = 0;
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            int month;
            int year;
            if (cbb_month.SelectedIndex == 0)
                month = 0;
            else
                month = Int32.Parse(cbb_month.SelectedItem.ToString().Split(' ')[1]);
            year = Int32.Parse(cbb_year.SelectedItem.ToString());
            DataTable table = new DataTable();
            if (month != 0)
            {
                table.Columns.Add("Ngày", typeof(string));
                table.Columns.Add("Số sách được mượn", typeof(int));
                table.Columns.Add("Số sách được trả", typeof(int));
                table.Columns.Add("Số độc giả đến thư viện", typeof(string));
                int days = DateTime.DaysInMonth(year, month);
                for (int i = 1; i <= days; i++)
                {
                    ThongKeBUS thongKe = new ThongKeBUS();
                    string date = year + "-" + (month < 10 ? "0" + month.ToString() : month.ToString()) + "-" + (i < 10 ? "0" + i.ToString() : i.ToString());
                    DataRow row = table.NewRow();
                    row["Ngày"] = "Ngày " + i + "/" + month + "/" + year;
                    row["Số sách được mượn"] = thongKe.getSachMuonNgay(date);
                    row["Số sách được trả"] = thongKe.getSachTraNgay(date);
                    if (File.Exists(@"LichSuDocGia/" + date.Substring(0, 4) + date.Substring(5, 2) + date.Substring(8, 2) + ".txt"))
                    {
                        int slDocGia = 0;
                        using (StreamReader r = new StreamReader(@"LichSuDocGia/" + date.Substring(0, 4) + date.Substring(5, 2) + date.Substring(8, 2) + ".txt"))
                        {
                            string json = r.ReadToEnd();
                            List<DocGia> items = JsonConvert.DeserializeObject<List<DocGia>>(json);
                            if (items != null)
                            {
                                slDocGia = items.Count;
                            }
                        }
                        row["Số độc giả đến thư viện"] = slDocGia.ToString();
                    }
                    else
                    {
                        row["Số độc giả đến thư viện"] = "Không có dữ liệu";
                    }
                    table.Rows.Add(row);
                }
            }
            else
            {
                table.Columns.Add("Tháng", typeof(string));
                table.Columns.Add("Số sách được mượn", typeof(int));
                table.Columns.Add("Số sách được trả", typeof(int));
                table.Columns.Add("Số độc giả đến thư viện", typeof(string));
                for (int i = 1; i <= 12; i++)
                {
                    ThongKeBUS thongKe = new ThongKeBUS();
                    DataRow row = table.NewRow();
                    row["Tháng"] = "Tháng " + i;
                    row["Số sách được mượn"] = thongKe.getSachMuonThang(i, year);
                    row["Số sách được trả"] = thongKe.getSachTraThang(i, year);
                    int slDocGia = 0;
                    int days = DateTime.DaysInMonth(year, i);
                    for (int dayIndex = 1; dayIndex <= days; dayIndex++)
                    {
                        string date = year + "-" + (i < 10 ? "0" + i.ToString() : i.ToString()) + "-" + (dayIndex < 10 ? "0" + dayIndex.ToString() : dayIndex.ToString());
                        if (File.Exists(@"LichSuDocGia/" + date.Substring(0, 4) + date.Substring(5, 2) + date.Substring(8, 2) + ".txt"))
                        {
                            using (StreamReader r = new StreamReader(@"LichSuDocGia/" + date.Substring(0, 4) + date.Substring(5, 2) + date.Substring(8, 2) + ".txt"))
                            {
                                string json = r.ReadToEnd();
                                List<DocGia> items = JsonConvert.DeserializeObject<List<DocGia>>(json);
                                if (items != null)
                                {
                                    slDocGia += items.Count;
                                }
                            }
                        }
                    }
                    row["Số độc giả đến thư viện"] = slDocGia;
                    table.Rows.Add(row);
                }
            }
            dgvThongKe.DataSource = table;
        }
        private void ExportDataSetToExcel(DataTable ds, string strPath, string tieuDe)
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
                        excelWorkSheet.get_Range("A" + inRow.ToString(), "D" + inRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.FromHtml("#FCE4D6");
                }
            }

            //Tieu de
            OfficeExcel.Range cellRang = excelWorkSheet.get_Range("A1", "D3");
            cellRang.Merge(false);
            cellRang.Interior.Color = System.Drawing.Color.White;
            cellRang.Font.Color = System.Drawing.Color.Gray;
            cellRang.HorizontalAlignment = OfficeExcel.XlHAlign.xlHAlignCenter;
            cellRang.VerticalAlignment = OfficeExcel.XlVAlign.xlVAlignCenter;
            cellRang.Font.Size = 16;
            excelWorkSheet.Cells[1, 1] = tieuDe;

            //Dinh dang cot
            cellRang = excelWorkSheet.get_Range("A4", "D4");
            cellRang.Font.Bold = true;
            cellRang.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            cellRang.Interior.Color = System.Drawing.ColorTranslator.FromHtml("#ED7D31");

            excelWorkSheet.Columns[1].ColumnWidth = 30;
            excelWorkSheet.Columns[2].ColumnWidth = 30;
            excelWorkSheet.Columns[3].ColumnWidth = 30;
            excelWorkSheet.Columns[4].ColumnWidth = 30;
            //excelWorkSheet.Columns.AutoFit();

            excelWorkBook.SaveAs(strPath, Default, Default, Default, false, Default, OfficeExcel.XlSaveAsAccessMode.xlNoChange, Default, Default, Default, Default, Default);
            excelWorkBook.Close();
            excelApp.Quit();

            MessageBox.Show("Tạo thành công file execel tại \n " + strPath);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "chọn chỗ lưu";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.Filter = "Excel files (*.xlsx) | *.xlsx";
            saveFileDialog1.FileName = "unname";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int month;
                int year;
                if (cbb_month.SelectedIndex == 0)
                    month = 0;
                else
                    month = Int32.Parse(cbb_month.SelectedItem.ToString().Split(' ')[1]);
                year = Int32.Parse(cbb_year.SelectedItem.ToString());
                DataTable table = new DataTable();
                if (month != 0)
                {
                    table.Columns.Add("Ngày", typeof(string));
                    table.Columns.Add("Số sách được mượn", typeof(int));
                    table.Columns.Add("Số sách được trả", typeof(int));
                    table.Columns.Add("Số độc giả đến thư viện", typeof(string));
                    int days = DateTime.DaysInMonth(year, month);
                    for (int i = 1; i <= days; i++)
                    {
                        ThongKeBUS thongKe = new ThongKeBUS();
                        string date = year + "-" + (month < 10 ? "0" + month.ToString() : month.ToString()) + "-" + (i < 10 ? "0" + i.ToString() : i.ToString());
                        DataRow row = table.NewRow();
                        row["Ngày"] = "Ngày " + i + "/" + month + "/" + year;
                        row["Số sách được mượn"] = thongKe.getSachMuonNgay(date);
                        row["Số sách được trả"] = thongKe.getSachTraNgay(date);
                        if (File.Exists(@"LichSuDocGia/" + date.Substring(0, 4) + date.Substring(5, 2) + date.Substring(8, 2) + ".txt"))
                        {
                            int slDocGia = 0;
                            using (StreamReader r = new StreamReader(@"LichSuDocGia/" + date.Substring(0, 4) + date.Substring(5, 2) + date.Substring(8, 2) + ".txt"))
                            {
                                string json = r.ReadToEnd();
                                List<DocGia> items = JsonConvert.DeserializeObject<List<DocGia>>(json);
                                if (items != null)
                                {
                                    slDocGia = items.Count;
                                }
                            }
                            row["Số độc giả đến thư viện"] = slDocGia.ToString();
                        }
                        else
                        {
                            row["Số độc giả đến thư viện"] = "Không có dữ liệu";
                        }
                        table.Rows.Add(row);
                    }
                }
                else
                {
                    table.Columns.Add("Tháng", typeof(string));
                    table.Columns.Add("Số sách được mượn", typeof(int));
                    table.Columns.Add("Số sách được trả", typeof(int));
                    table.Columns.Add("Số độc giả đến thư viện", typeof(string));
                    for (int i = 1; i <= 12; i++)
                    {
                        ThongKeBUS thongKe = new ThongKeBUS();
                        DataRow row = table.NewRow();
                        row["Tháng"] = "Tháng " + i;
                        row["Số sách được mượn"] = thongKe.getSachMuonThang(i, year);
                        row["Số sách được trả"] = thongKe.getSachTraThang(i, year);
                        int slDocGia = 0;
                        int days = DateTime.DaysInMonth(year, i);
                        for (int dayIndex = 1; dayIndex <= days; dayIndex++)
                        {
                            string date = year + "-" + (i < 10 ? "0" + i.ToString() : i.ToString()) + "-" + (dayIndex < 10 ? "0" + dayIndex.ToString() : dayIndex.ToString());
                            if (File.Exists(@"LichSuDocGia/" + date.Substring(0, 4) + date.Substring(5, 2) + date.Substring(8, 2) + ".txt"))
                            {
                                using (StreamReader r = new StreamReader(@"LichSuDocGia/" + date.Substring(0, 4) + date.Substring(5, 2) + date.Substring(8, 2) + ".txt"))
                                {
                                    string json = r.ReadToEnd();
                                    List<DocGia> items = JsonConvert.DeserializeObject<List<DocGia>>(json);
                                    if (items != null)
                                    {
                                        slDocGia += items.Count;
                                    }
                                }
                            }
                        }
                        row["Số độc giả đến thư viện"] = slDocGia;
                        table.Rows.Add(row);
                    }
                }
                ExportDataSetToExcel(table, saveFileDialog1.FileName, "Thống kê thư viện năm " + year);
            }
        }
    }
}
