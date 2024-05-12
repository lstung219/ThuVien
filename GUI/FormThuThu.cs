using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormThuThu : Form
    {
        UserBLL userBLL = new UserBLL();
        public FormThuThu()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string pass = textBox2.Text; // Giả sử textbox chứa tên người dùng
            string newPassword = textBox1.Text;

            if (string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng và mật khẩu mới.");
                return;
            }

            User user = new User { PASSWORD = pass,}; // Tạo đối tượng User với tên người dùng
            if (userBLL.ChangePassword(user, newPassword))
            {
                MessageBox.Show("Mật khẩu đã được thay đổi thành công.");
                // Xử lý sau khi thay đổi mật khẩu thành công (nếu cần)
            }
            else
            {
                MessageBox.Show("Thay đổi mật khẩu không thành công. Vui lòng thử lại sau.");
            }
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
