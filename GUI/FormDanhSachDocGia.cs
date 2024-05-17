using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using BLL;
using DTO;

namespace GUI
{
    public partial class FormDanhSachDocGia : Form
    {
        private DocGiaBLL docgiaBLL;
        public FormDanhSachDocGia()
        {
            InitializeComponent();
            docgiaBLL = new DocGiaBLL();
        }
        public string MaDG { get; set; }
        public string TenDG { get; set; }
        public string LoaiPhieu { get; set; }

        private void FormDanhSachDocGia_Load(object sender, EventArgs e)
        {
            //DinhDangLuoi();
            if (dgvDGSearch.RowCount > 1)
            {
                btnXemChiTiet.Show();
                btnLapPhieMuon.Show();
                btnLapPhieuTra.Show();
                btnXoaDocGia.Show();

            }
            textBox1.Enabled = false;
            textBox1.Text = docgiaBLL.TimMaDocGiaTiepTheo();
            Hide_ChiTietDG();
            btnLuu.Hide();
            btnHuy.Hide();
            btnChinhSua.Hide();
        }

        private void btnXemAllDocGia_Click(object sender, EventArgs e)
        {
            Hide_ChiTietDG();
            btnLuu.Hide();
            btnHuy.Hide();
            btnChinhSua.Hide();

            btnXemChiTiet.Show();
            btnXoaDocGia.Show();
            btnLapPhieMuon.Show();
            btnLapPhieuTra.Show();


            dgvDGSearch.DataSource = docgiaBLL.GetDSDG();
            dgvDGSearch.ReadOnly = true;
            dgvDGSearch.Columns[0].ReadOnly = true;
            dgvDGSearch.Columns[0].HeaderText = "Mã Độc Giả";
            dgvDGSearch.Columns[1].HeaderText = "Họ Tên";

        }
        void ReadOnly_ChiTietDG()
        {


            dtkCTNgaySinhDG.Enabled = false;
            rdNam.Enabled = false;
            rdNu.Enabled = false;
            txtCTDiaChiDG.ReadOnly = true;
            txtCTEmailDG.ReadOnly = true;
            txtCTMaDG.ReadOnly = true;
            txtCTPhoneDG.ReadOnly = true;
            txtCTTenDG.ReadOnly = true;

        }
        void UnReadOnly_ChiTietDG()
        {
            dtkCTNgaySinhDG.Enabled = true;


            txtCTDiaChiDG.ReadOnly = false;
            txtCTEmailDG.ReadOnly = false;
            txtCTMaDG.ReadOnly = true;
            txtCTPhoneDG.ReadOnly = false;
            txtCTTenDG.ReadOnly = false;
            rdNam.Enabled = true;
            rdNu.Enabled = true;
        }
        void Hide_ChiTietDG()
        {

            lbCTDiaChiDG.Hide();
            lbCTEmailDG.Hide();
            lbCTGioiTinhDG.Hide();
            lbCTMaDG.Hide();
            lbCTNgaySinhDG.Hide();
            lbCTPhoneDG.Hide();
            lbCTTenDG.Hide();
            rdNam.Hide();
            rdNu.Hide();

            dtkCTNgaySinhDG.Hide();

            txtCTDiaChiDG.Hide();
            txtCTEmailDG.Hide();
            txtCTMaDG.Hide();
            txtCTPhoneDG.Hide();
            txtCTTenDG.Hide();

            dgvDGSearch.Show();
        }
        void Show_ChiTietDG()
        {

            lbCTGioiTinhDG.Show();
            lbCTDiaChiDG.Show();
            lbCTEmailDG.Show();
            lbCTMaDG.Show();
            lbCTNgaySinhDG.Show();
            lbCTPhoneDG.Show();
            lbCTTenDG.Show();

            rdNam.Show();
            rdNu.Show();

            dtkCTNgaySinhDG.Show();
            txtCTDiaChiDG.Show();
            txtCTEmailDG.Show();
            txtCTMaDG.Show();
            txtCTPhoneDG.Show();
            txtCTTenDG.Show();

            dgvDGSearch.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string maDG = txtSearchDG.Text.Trim();
            string filterExpression = "";

            if (rdMaDGSearch.Checked)
            {
                if (!string.IsNullOrEmpty(maDG))
                {
                    filterExpression = string.Format("MaDG LIKE '%{0}%'", maDG);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã độc giả cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (rdHoTenSearch.Checked)
            {
                string hoTen = txtSearchDG.Text.Trim();
                if (!string.IsNullOrEmpty(hoTen))
                {
                    filterExpression = string.Format("HoTen LIKE '%{0}%'", hoTen);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập họ tên độc giả cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = docgiaBLL.GetDSDG();
            DataView dv = dt.DefaultView;
            dv.RowFilter = filterExpression;
            dgvDGSearch.DataSource = dv.ToTable();

            if (dgvDGSearch.Rows.Count == 1)
            {
                MessageBox.Show("Không tìm thấy độc giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDGSearch.DataSource = docgiaBLL.GetDSDG();
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvDGSearch.SelectedRows.Count > 0)
            {
                string maDG = dgvDGSearch.SelectedRows[0].Cells["MaDG"].Value.ToString();
                string hoTen = dgvDGSearch.SelectedRows[0].Cells["HoTen"].Value.ToString();
                string sdt = dgvDGSearch.SelectedRows[0].Cells["Sdt"].Value.ToString();
                string diaChi = dgvDGSearch.SelectedRows[0].Cells["Diachi"].Value.ToString();
                FormSuaThongTin f = new FormSuaThongTin(maDG, hoTen, sdt, diaChi);
                f.ShowDialog();
                dgvDGSearch.DataSource = docgiaBLL.GetDSDG();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvDGSearch.SelectedRows.Count > 0)
            {
                string maDG = dgvDGSearch.SelectedRows[0].Cells["MaDG"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    docgiaBLL.DeleteDG(maDG);
                    MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDGSearch.DataSource = docgiaBLL.GetDSDG();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormThemDocGia g = new FormThemDocGia();
            g.ShowDialog();
            dgvDGSearch.DataSource = docgiaBLL.GetDSDG();
        }

        private void DinhDangLuoi()
        {
            dgvDGSearch.ReadOnly = true;
            dgvDGSearch.Columns[0].HeaderText = "Mã Đọc Giả";
            dgvDGSearch.Columns[0].Width = 250;
            dgvDGSearch.Columns[1].HeaderText = "Tên Độc Giả";
            dgvDGSearch.Columns[1].Width = 250;
            dgvDGSearch.Columns[2].HeaderText = "SDT";
            dgvDGSearch.Columns[2].Width = 250;
            dgvDGSearch.Columns[3].HeaderText = "Địa chỉ";
            dgvDGSearch.Columns[3].Width = 250;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                textBox1.Enabled = false;
                string MaDG = textBox1.Text;
                string HoTen = textBox2.Text;
                string Sdt = textBox3.Text;
                string Diachi = textBox4.Text;
                DateTime ngaySinh = dateTimePicker1.Value;
                string gioiTinh = string.Empty;
                string email = txtEmail.Text;


                if (rdThemNam.Checked)
                {
                    gioiTinh = "Nam";
                }
                else if (rdThemNu.Checked)
                {
                    gioiTinh = "Nữ";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (docgiaBLL.CheckMaDG(MaDG))
                {
                    MessageBox.Show("Mã độc giả đã tồn tại! Vui lòng nhập mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    docgiaBLL.InsertDG(MaDG, HoTen, Sdt, Diachi, ngaySinh, gioiTinh, email);
                    MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = txtEmail.Text = string.Empty;
                    dateTimePicker1.Value = DateTime.Now;
                    rdThemNam.Checked = rdThemNu.Checked = false;
                    textBox1.Text = docgiaBLL.TimMaDocGiaTiepTheo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdMaDGSearch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            DocGiaBLL busDocGia = new DocGiaBLL();
            DataGridView dgvTemp = new DataGridView();
            string secondCellValue = dgvDGSearch[0, dgvDGSearch.CurrentRow.Index].Value.ToString();
            dgvDGSearch.DataSource = busDocGia.XemChiTietDocGia(secondCellValue);
            txtCTMaDG.Text = dgvDGSearch[0, dgvDGSearch.CurrentRow.Index].Value.ToString().Trim();
            txtCTTenDG.Text = dgvDGSearch[1, dgvDGSearch.CurrentRow.Index].Value.ToString().Trim();
            dtkCTNgaySinhDG.Text = dgvDGSearch[2, dgvDGSearch.CurrentRow.Index].Value.ToString();
            txtCTDiaChiDG.Text = dgvDGSearch[5, dgvDGSearch.CurrentRow.Index].Value.ToString().Trim();
            txtCTPhoneDG.Text = dgvDGSearch[4, dgvDGSearch.CurrentRow.Index].Value.ToString().Trim();
            txtCTEmailDG.Text = dgvDGSearch[6, dgvDGSearch.CurrentRow.Index].Value.ToString().Trim();
            string gioiTinh = dgvDGSearch[3, dgvDGSearch.CurrentRow.Index].Value.ToString().Trim();
            if (gioiTinh == "Nam")
            {
                rdNam.Checked = true;
            }
            else rdNu.Checked = true;


            Show_ChiTietDG();

            btnXemChiTiet.Hide();
            btnXoaDocGia.Hide();
            btnLapPhieMuon.Hide();
            btnLapPhieuTra.Hide();

            ReadOnly_ChiTietDG();

            btnHuy.Show();
            btnLuu.Show();
            btnChinhSua.Show();
        }

        private void btnXoaDocGia_Click(object sender, EventArgs e)
        {
            DocGiaBLL DocGiabll = new DocGiaBLL();
            string madocgia = dgvDGSearch[0, dgvDGSearch.CurrentRow.Index].Value.ToString();
            if (MessageBox.Show(string.Format("Xác nhận xóa độc giả {0}", madocgia), "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DocGiabll.DeleteDG(madocgia))
                {
                    MessageBox.Show("Xóa Độc Giả Thành Công!!!");
                    btnXemAllDocGia_Click(sender, e);
                }
                    
                else
                    MessageBox.Show("Không thể Xóa Độc Giả Này!!!");
            }

        }
        public event EventHandler<DocGiaEventArgs> DocGiaSelected;
        public class DocGiaEventArgs : EventArgs
        {
            public string MaDocGia { get; }
            public string TenDocGia { get; }

            public DocGiaEventArgs(string maDocGia, string tenDocGia)
            {
                MaDocGia = maDocGia;
                TenDocGia = tenDocGia;
            }
        }

        private void btnLapPhieMuon_Click(object sender, EventArgs e)
        {
            string maDocGia = dgvDGSearch[0, dgvDGSearch.CurrentRow.Index].Value.ToString().Trim();
            string tenDG = dgvDGSearch[1, dgvDGSearch.CurrentRow.Index].Value.ToString();

            // Gán giá trị cho hai thuộc tính MaDG và TenDG của FormDanhSachDocGia
            MaDG = maDocGia;
            TenDG = tenDG;
            LoaiPhieu = "PhieuMuon";

            // Mở frmPhieu thông qua panel childform của formChuongTrinh
            FormChuongTrinh formChuongTrinh = (FormChuongTrinh)Application.OpenForms["FormChuongTrinh"];
            if (formChuongTrinh != null)
            {
                formChuongTrinh.OpenChildForm(new frmPhieu());
            }
        }

        private void btnLapPhieuTra_Click(object sender, EventArgs e)
        {
            string maDocGia = dgvDGSearch[0, dgvDGSearch.CurrentRow.Index].Value.ToString().Trim();
            MaDG = maDocGia;
            LoaiPhieu = "PhieuTra";
            FormChuongTrinh formChuongTrinh = (FormChuongTrinh)Application.OpenForms["FormChuongTrinh"];
            if (formChuongTrinh != null)
            {
                formChuongTrinh.OpenChildForm(new frmPhieu());
            }

        }

        private void lbCTEmailDG_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnXemChiTiet.Hide();
            btnXoaDocGia.Hide();
            btnLapPhieMuon.Hide();
            btnLapPhieuTra.Hide();
            btnHuy.Hide();
            btnLuu.Hide();
            btnChinhSua.Hide();
            Hide_ChiTietDG();

            dgvDGSearch.DataSource = docgiaBLL.GetDSDG();
            btnXemAllDocGia_Click(sender, e);
            ReadOnly_ChiTietDG();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            dgvDGSearch.ReadOnly = false;
            dgvDGSearch.Columns[0].ReadOnly = true;
            UnReadOnly_ChiTietDG();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ReadOnly_ChiTietDG();
            try
            {

                string tendocgia = txtCTTenDG.Text;
                string ngaysinh = "";
                string diachi = txtCTDiaChiDG.Text;
                string sdt = txtCTPhoneDG.Text;
                string email = txtCTEmailDG.Text;

                ngaysinh = dtkCTNgaySinhDG.Value.ToString();
                DateTime dt2 = Convert.ToDateTime(ngaysinh);

                string gioiTinh;
                if (rdNam.Checked == true)
                    gioiTinh = "Nam";
                else
                    gioiTinh = "Nữ";


                
                docgiaBLL.UpdateDGInfo(txtCTMaDG.Text,tendocgia, sdt, diachi, dt2, gioiTinh, email);
                MessageBox.Show("Cập Nhật Độc Giả Thành Công!!!");
                btnHuy.Text = "Thoát";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cập Nhật Thất Bại :(");
                return;
                throw ex;
            }
        }
    }
}

