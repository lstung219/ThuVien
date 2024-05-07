using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GUI
{
    public partial class fSach : Form
    {
        BindingSource sach = new BindingSource();
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

        private void button4_Click(object sender, EventArgs e)
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {   
            SachBLL sachBLL = new SachBLL();
            sach.DataSource = sachBLL.timsach(textBox9.Text);
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
    }
}
