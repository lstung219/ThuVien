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
    public partial class FormDangNhap : Form
    {
        User user=new User();
        UserBLL userBLL = new UserBLL();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            user.USERNAME = txbtk.Text;
            user.PASSWORD = txbmk.Text;
            string getuser = userBLL.Checklogin(user);
            switch (getuser)
            {
                case "tk_trong":
                    MessageBox.Show("Tài khoản không được để trống!");
                    break;
                case "mk_trong":
                    MessageBox.Show("Mật khẩu không được để trống!");
                    break;
                case "khong_dung":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                    break;
            }
            MessageBox.Show("Đăng nhập thành công vào hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormChuongTrinh f = new FormChuongTrinh();
            f.Show();
            this.Hide();

        }
    }
}
