using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using DTO;

namespace GUI
{
    public partial class FormDanhSachDocGia : Form
    {
        private BusinessLogic businessLogic;

        public FormDanhSachDocGia()
        {
            InitializeComponent();
            businessLogic = new BusinessLogic();
        }

        private void FormDanhSachDocGia_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = businessLogic.GetDSDG();
            DinhDangLuoi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maDG = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(maDG))
            {
                DataTable dt = businessLogic.GetDSDG();
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("MaDG LIKE '%{0}%'", maDG);
                dataGridView1.DataSource = dv.ToTable();
                if (dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("Không tìm thấy độc giả có mã " + maDG, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = businessLogic.GetDSDG();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã độc giả cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = businessLogic.GetDSDG();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maDG = dataGridView1.SelectedRows[0].Cells["MaDG"].Value.ToString();
                string hoTen = dataGridView1.SelectedRows[0].Cells["HoTen"].Value.ToString();
                string sdt = dataGridView1.SelectedRows[0].Cells["Sdt"].Value.ToString();
                string diaChi = dataGridView1.SelectedRows[0].Cells["Diachi"].Value.ToString();
                FormSuaThongTin f = new FormSuaThongTin(maDG, hoTen, sdt, diaChi);
                f.ShowDialog();
                dataGridView1.DataSource = businessLogic.GetDSDG();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maDG = dataGridView1.SelectedRows[0].Cells["MaDG"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    businessLogic.DeleteDG(maDG);
                    MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = businessLogic.GetDSDG();
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
            dataGridView1.DataSource = businessLogic.GetDSDG();
        }

        private void DinhDangLuoi()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Mã Đọc Giả";
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[1].HeaderText = "Tên Độc Giả";
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].HeaderText = "SDT";
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].Width = 250;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
