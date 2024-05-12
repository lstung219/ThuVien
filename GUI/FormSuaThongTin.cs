using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BLL;
using DTO;

namespace GUI
{
    public partial class FormSuaThongTin : Form
    {
        //private BusinessLogic businessLogic;
        private string maDG;

        public FormSuaThongTin(string maDG, string hoTen, string sdt, string diaChi)
        {
            InitializeComponent();
            this.maDG = maDG;
            textBox1.Text = maDG;
            textBox2.Text = hoTen;
            textBox3.Text = sdt;
            //textBox4.Text = diaChi;
            //businessLogic = new BusinessLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string newHoTen = textBox2.Text;
            string newSdt = textBox3.Text;
            string newDiaChi = textBox4.Text;

            try
            {
                //businessLogic.UpdateDGInfo(maDG, newHoTen, newSdt, newDiaChi);
                MessageBox.Show("Sửa thông tin độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
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

        private void FormSuaThongTin_Load(object sender, EventArgs e)
        {

        }
    }
}
