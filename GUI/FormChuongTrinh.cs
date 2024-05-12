using System;
using DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FormChuongTrinh : Form
    {
        private Timer timer;
        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            // Khởi tạo Timer
            timer = new Timer();
            // Thiết lập thời gian cho Tick, 1000ms = 1 giây
            timer.Interval = 1000;
            // Đăng ký phương thức xử lý sự kiện cho sự kiện Tick của Timer
            timer.Tick += timer_Tick;
            // Bắt đầu Timer
            timer.Start();
        }
        private Form currentFormChild;
        public void OpenChildForm(Form ChildForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(ChildForm);
            panel3.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }


        private void btn_thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Thongke());
            label1.Text = btn_thongke.Text;
            pictureBox2.Image = btn_thongke.Image;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        //bool menuExpand = false;

        // Đảm bảo dừng Timer khi form được đóng
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Dừng Timer
            timer.Stop();
            // Giải phóng tài nguyên của Timer
            timer.Dispose();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                label1.Text = "Home";
                pictureBox2.Image = pictureBox1.Image;
            }
        }

        private void btn_sach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fSach());
            label1.Text = btn_sach.Text;
            pictureBox2.Image = btn_sach.Image;
        }
            private void btn_docgia_Click(object sender, EventArgs e)
            {
                OpenChildForm(new FormDanhSachDocGia());
                label1.Text = btn_docgia.Text;
                pictureBox2.Image = btn_docgia.Image;
            }

            private void btn_phieu_Click(object sender, EventArgs e)
            {
                OpenChildForm(new frmPhieu());
                label1.Text = btn_phieu.Text;
                pictureBox2.Image = btn_phieu.Image;
            }

            private void label3_Click(object sender, EventArgs e)
            {

            }
            private void timer_Tick(object sender, EventArgs e)
            {
                label3.Text = DateTime.Now.ToString("dd/MM/yy hh:mm:ss tt");
            }
            User user = new User();
            private void btn_quanly_Click(object sender, EventArgs e)
            {
                if (user.Type == "QUANTHU")
                {
                    MessageBox.Show("Bạn không có quyền truy cập.", "Thông báo");
                }
                else
                {
                    FormThuThu f = new FormThuThu();
                    f.Show();
                    this.Hide();
                }
            }

        private void btn_phieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhieu());
            label1.Text = btn_phieu.Text;
            pictureBox2.Image = btn_phieu.Image;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("dd/MM/yy hh:mm:ss tt");
        }
        
        private void btn_quanly_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThuThu());
            label1.Text = btn_quanly.Text;
            pictureBox2.Image = btn_quanly.Image;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 }
