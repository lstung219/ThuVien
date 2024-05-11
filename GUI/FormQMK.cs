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
    public partial class FormQMK : Form
    {
        private PasswordResetLogic passwordResetLogic;

        User user = new User();
        public FormQMK()
        {
            InitializeComponent();
            passwordResetLogic = new PasswordResetLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email = textBox1.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email.");
                return;
            }

            // Khởi tạo đối tượng User
            user.GMAIL = email;

            // Tiến hành đặt lại mật khẩu
            bool resetSuccess = passwordResetLogic.ResetPassword(user);

            if (resetSuccess)
            {
                MessageBox.Show("Mật khẩu đã được cập nhật thành: 123","Thông báo");
            }
            else
            {
                MessageBox.Show("Email không tồn tại trong hệ thống.","Thông báo");
            }
        }


        private void FormQMK_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Hide();
        }
    }
}
