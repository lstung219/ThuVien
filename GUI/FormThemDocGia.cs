using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class FormThemDocGia : Form
    {
        private BusinessLogic businessLogic;
        public string MaDG { get; private set; }
        public string HoTen { get; private set; }
        public string Sdt { get; private set; }
        public string Diachi { get; private set; }

        public FormThemDocGia()
        {
            InitializeComponent();
            businessLogic = new BusinessLogic();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                MaDG = textBox1.Text;
                HoTen = textBox2.Text;
                Sdt = textBox3.Text;
                Diachi = textBox4.Text;
                if (businessLogic.CheckMaDG(MaDG))
                {
                    MessageBox.Show("Mã độc giả đã tồn tại! Vui lòng nhập mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else {
                    businessLogic.InsertDG(MaDG, HoTen, Sdt, Diachi);
                    MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormThemDocGia_Load(object sender, EventArgs e)
        {

        }
    }
}
