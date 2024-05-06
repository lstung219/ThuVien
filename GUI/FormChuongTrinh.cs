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
    public partial class FormChuongTrinh : Form
    {
        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {

        }
        private Form currentFormChild;
        private void OpenChildForm(Form ChildForm)
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
            label1.Text=btn_thongke.Text;
            pictureBox2.Image = btn_thongke.Image;
            
        }
        
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        bool menuExpand = false;
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        
    }
}
