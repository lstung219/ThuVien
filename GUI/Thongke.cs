using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Thongke : Form
    {

        private SachBLL sachBLL;
        public Thongke()
        {
            InitializeComponent();
            sachBLL = new SachBLL();
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SachMuonNhieuNhat> sachListt = sachBLL.GetBooksMostBorrowedFromDAL();

            reportViewer1.LocalReport.ReportPath = "Report2.rdlc"; // Đường dẫn đến file report
            reportViewer1.LocalReport.DataSources.Clear(); // Xóa dữ liệu nguồn cũ
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", sachListt));
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Sach> sachList = sachBLL.GetAllBooksFromDAL();

            reportViewer1.LocalReport.ReportPath = "Report1.rdlc"; // Đường dẫn đến file report
            reportViewer1.LocalReport.DataSources.Clear(); // Xóa dữ liệu nguồn cũ
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", sachList));
            reportViewer1.RefreshReport();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Docgiamuonsach> docGiaMuonSachList = sachBLL.GetAllDocgiamuonsach();
            reportViewer1.LocalReport.ReportPath = "Report3.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", docGiaMuonSachList));
            reportViewer1.RefreshReport();
        }
    }
}
