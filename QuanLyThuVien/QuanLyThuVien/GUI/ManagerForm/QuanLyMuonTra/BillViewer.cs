using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI.ManagerForm.QuanLyMuonTra
{
    public partial class BillViewer : Form
    {
        DataSet ds;
        string MaSinhVien;
        string SoPhieuMuon;
        string TongTien;
        string NgayLapPhieu;
        string NguoiLapPhieu;
        public BillViewer(DataSet data, string MaSinhVien, string SoPhieuMuon, string TongTien, string NgayLapPhieu, string NguoiLapPhieu)
        {
            this.MaSinhVien = MaSinhVien;
            this.SoPhieuMuon = SoPhieuMuon;
            this.TongTien = TongTien;
            this.NgayLapPhieu = NgayLapPhieu;
            this.NguoiLapPhieu = NguoiLapPhieu;
            this.ds = data;
            InitializeComponent();
            prepare();
        }
        private void prepare()
        {
            
        }

        private void BillViewer_Load(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.GUI.ManagerForm.QuanLyMuonTra.PhieuMuon.rdlc";

            ReportParameter prmMaSinhVien = new ReportParameter("MaSinhVien");
            prmMaSinhVien.Values.Add(MaSinhVien);
            this.reportViewer1.LocalReport.SetParameters(prmMaSinhVien);

            ReportParameter prmSoPhieuMuon = new ReportParameter("SoPhieuMuon");
            prmSoPhieuMuon.Values.Add(SoPhieuMuon);
            this.reportViewer1.LocalReport.SetParameters(prmSoPhieuMuon);

            ReportParameter prmTongTien = new ReportParameter("TongTien");
            prmTongTien.Values.Add(TongTien);
            this.reportViewer1.LocalReport.SetParameters(prmTongTien);

            ReportParameter prmNgayLapPhieu = new ReportParameter("NgayLapPhieu");
            prmNgayLapPhieu.Values.Add(NgayLapPhieu);
            this.reportViewer1.LocalReport.SetParameters(prmNgayLapPhieu);

            ReportParameter prmTaiKhoanLap = new ReportParameter("TaiKhoanLap");
            prmTaiKhoanLap.Values.Add(NguoiLapPhieu);
            this.reportViewer1.LocalReport.SetParameters(prmTaiKhoanLap);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsSach";
                rds.Value = ds.Tables[0];

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

            }
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
        }
    }
}
