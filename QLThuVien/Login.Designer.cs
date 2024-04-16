namespace QLST
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label3 = new Label();
            btexit = new Button();
            btlogin = new Button();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            textBoxusname = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tomato;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btexit);
            panel1.Controls.Add(btlogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            panel1.Location = new Point(15, 19);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 872);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Microsoft Sans Serif", 22F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(160, 55);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(856, 54);
            label3.TabIndex = 1;
            label3.Text = "Chào Mừng Bạn Đến Với Thư Viện Điện Tử";
            label3.Click += label3_Click;
            // 
            // btexit
            // 
            btexit.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btexit.ForeColor = Color.Black;
            btexit.Location = new Point(814, 594);
            btexit.Margin = new Padding(4, 5, 4, 5);
            btexit.Name = "btexit";
            btexit.Size = new Size(196, 52);
            btexit.TabIndex = 4;
            btexit.Text = "Thoát";
            btexit.UseVisualStyleBackColor = true;
            btexit.Click += btexit_Click;
            // 
            // btlogin
            // 
            btlogin.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btlogin.ForeColor = Color.Black;
            btlogin.Location = new Point(610, 594);
            btlogin.Margin = new Padding(4, 5, 4, 5);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(196, 52);
            btlogin.TabIndex = 3;
            btlogin.Text = "Đăng nhập";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(251, 450);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(762, 134);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 39);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(532, 35);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 29);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(textBoxusname);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(251, 331);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(762, 109);
            panel2.TabIndex = 0;
            // 
            // textBoxusname
            // 
            textBoxusname.Location = new Point(226, 39);
            textBoxusname.Margin = new Padding(4, 5, 4, 5);
            textBoxusname.Name = "textBoxusname";
            textBoxusname.Size = new Size(532, 35);
            textBoxusname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 29);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1242, 909);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thư Viện Điện Tử";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxusname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Label label3;
    }
}

