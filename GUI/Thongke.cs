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
            List<Sach> sachList = sachBLL.GetAllBooks();

            reportViewer1.LocalReport.ReportPath = "Report1.rdlc"; // Đường dẫn đến file report
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", sachList));
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
