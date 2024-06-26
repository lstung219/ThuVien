﻿using BLL;
using Demo3Layer.BUS.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GUI
{
    public partial class fSach : Form
    {
        BindingSource sach = new BindingSource();
        MailHelper mailHelper = new MailHelper();
        public fSach()
        {
            InitializeComponent();
            dataGridView1.DataSource = sach;
            Showlistsach();
            addsach();
        }
        void Showlistsach()
        {
            //string query = "SELECT MASP AS [Mã sản phẩm], TENSP AS [Tên sản phẩm], KIEU AS [Loại sản phẩm], GIA AS [Giá cả] FROM SANPHAM";
            SachBLL sachBLL = new SachBLL();

            sach.DataSource = sachBLL.GetAllBooksFromDAL();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DinhDangLuoi();
        }
        void addsach()
        {
            textBox1.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "MASACH",true,DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "TENSACH", true, DataSourceUpdateMode.Never));
            textBox3.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "TACGIA", true, DataSourceUpdateMode.Never));
            textBox4.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "NHAXB", true, DataSourceUpdateMode.Never));
            textBox5.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "NXB", true, DataSourceUpdateMode.Never));
            textBox6.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "THELOAI", true, DataSourceUpdateMode.Never));
            textBox7.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "NGONNGU", true, DataSourceUpdateMode.Never));
            textBox8.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "SLTON", true, DataSourceUpdateMode.Never));
        }
        private void DinhDangLuoi()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Mã Sách";
            dataGridView1.Columns[1].HeaderText = "Tên Sách";
            dataGridView1.Columns[2].HeaderText = "Tác Giả";
            dataGridView1.Columns[3].HeaderText = "NXB";
            dataGridView1.Columns[4].HeaderText = "Năm Xuất Bản";
            dataGridView1.Columns[5].HeaderText = "Thể Loại";
            dataGridView1.Columns[6].HeaderText = "Ngôn Ngữ";
            dataGridView1.Columns[7].HeaderText = "Số Lượng";

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 1;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 50;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SachBLL sachBLL = new SachBLL();
                string masach = textBox1.Text;
                string tensach = textBox2.Text;
                string tacgia = textBox3.Text;
                string nxb = textBox4.Text;
                int nam = Convert.ToInt32(textBox5.Text);
                string theloai = textBox6.Text;
                string ngonngu = textBox7.Text;
                int soluong = Convert.ToInt32(textBox8.Text);
                sach.DataSource = sachBLL.timsach(textBox9.Text);
                if (sachBLL.them(masach, tensach, tacgia, nxb, nam, theloai, ngonngu, soluong))
                {
                    MessageBox.Show("Thêm thành công");
                    Showlistsach();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm");
                }
            }
            catch(Exception ex) { MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message); }

        }

        private void fSach_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Showlistsach();
        }

        

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            SachBLL sachBLL = new SachBLL();
            string masach = textBox1.Text;
            string tensach = textBox2.Text;
            string tacgia = textBox3.Text;
            string nxb = textBox4.Text;
            int nam = Convert.ToInt32(textBox5.Text);
            string theloai = textBox6.Text;
            string ngonngu = textBox7.Text;
            int soluong = Convert.ToInt32(textBox8.Text);
            sach.DataSource = sachBLL.timsach(textBox9.Text);
            if (sachBLL.sua(masach, tensach, tacgia, nxb, nam, theloai, ngonngu, soluong))
            {
                MessageBox.Show("Sửa thành công");
                Showlistsach();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SachBLL sachBLL = new SachBLL();
            string masach = textBox1.Text;
            sach.DataSource = sachBLL.timsach(textBox9.Text);
            if (sachBLL.xoa(masach))
            {
                MessageBox.Show("Xóa thành công");
                Showlistsach();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SachBLL sachBLL = new SachBLL();
            sach.DataSource = sachBLL.timsach(textBox9.Text);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {
            SachBLL sachBLL = new SachBLL();
            sach.DataSource = sachBLL.timsach(textBox9.Text);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Showlistsach();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SachBLL sachBLL = new SachBLL();
            string masach = textBox1.Text;
            string tensach = textBox2.Text;
            string tacgia = textBox3.Text;
            string nxb = textBox4.Text;
            int nam = Convert.ToInt32(textBox5.Text);
            string theloai = textBox6.Text;
            string ngonngu = textBox7.Text;
            int soluong = Convert.ToInt32(textBox8.Text);
            sach.DataSource = sachBLL.timsach(textBox9.Text);
            if (sachBLL.sua(masach, tensach, tacgia, nxb, nam, theloai, ngonngu, soluong))
            {
                MessageBox.Show("Sửa thành công");
                Showlistsach();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            SachBLL sachBLL = new SachBLL();
            string masach = textBox1.Text;
            sach.DataSource = sachBLL.timsach(textBox9.Text);
            if (sachBLL.xoa(masach))
            {
                MessageBox.Show("Xóa thành công");
                Showlistsach();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                SachBLL sachBLL = new SachBLL();
                string masach = textBox1.Text;
                string tensach = textBox2.Text;
                string tacgia = textBox3.Text;
                string nxb = textBox4.Text;
                int nam = Convert.ToInt32(textBox5.Text);
                string theloai = textBox6.Text;
                string ngonngu = textBox7.Text;
                int soluong = Convert.ToInt32(textBox8.Text);
                sach.DataSource = sachBLL.timsach(textBox9.Text);
                if (sachBLL.them(masach, tensach, tacgia, nxb, nam, theloai, ngonngu, soluong))
                {
                    MessageBox.Show("Thêm thành công");
                    Showlistsach();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message); }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(txtFrom.Text);
            message.Subject = txtSubject.Text;
            var mails = txtTo.Text?.Split(';');
            if (mails == null || mails.Count() <= 0)
            {
                return;
            }
            foreach (var item in mails)
            {
                message.To.Add(new MailAddress(item?.Trim()));
            }

            message.Body = htmlEditControl1.DocumentHTML;
            message.IsBodyHtml = true;

            
            if (mailHelper.SendMail(message))
            {
                MessageBox.Show("Đã gửi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel4_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
