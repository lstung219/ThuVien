namespace GUI
{
    partial class FormChuongTrinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChuongTrinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pannel_body = new System.Windows.Forms.Panel();
            this.btn_phieu = new System.Windows.Forms.Button();
            this.btn_docgia = new System.Windows.Forms.Button();
            this.btn_sach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.pannel_body);
            this.panel1.Controls.Add(this.btn_phieu);
            this.panel1.Controls.Add(this.btn_docgia);
            this.panel1.Controls.Add(this.btn_sach);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 953);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_thongke);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 525);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 124);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btn_thongke
            // 
            this.btn_thongke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thongke.FlatAppearance.BorderSize = 0;
            this.btn_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thongke.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_thongke.Image = ((System.Drawing.Image)(resources.GetObject("btn_thongke.Image")));
            this.btn_thongke.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_thongke.Location = new System.Drawing.Point(3, 3);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(197, 124);
            this.btn_thongke.TabIndex = 4;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(3, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sách được mượn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(3, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 61);
            this.button2.TabIndex = 6;
            this.button2.Text = "Số lượng sách";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(3, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 61);
            this.button3.TabIndex = 7;
            this.button3.Text = "Độc giả";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pannel_body
            // 
            this.pannel_body.Location = new System.Drawing.Point(200, 106);
            this.pannel_body.Name = "pannel_body";
            this.pannel_body.Size = new System.Drawing.Size(1282, 847);
            this.pannel_body.TabIndex = 2;
            // 
            // btn_phieu
            // 
            this.btn_phieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_phieu.FlatAppearance.BorderSize = 0;
            this.btn_phieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_phieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_phieu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_phieu.Image = ((System.Drawing.Image)(resources.GetObject("btn_phieu.Image")));
            this.btn_phieu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_phieu.Location = new System.Drawing.Point(0, 401);
            this.btn_phieu.Name = "btn_phieu";
            this.btn_phieu.Size = new System.Drawing.Size(200, 124);
            this.btn_phieu.TabIndex = 3;
            this.btn_phieu.Text = "Phiếu mượn/trả";
            this.btn_phieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_phieu.UseVisualStyleBackColor = true;
            // 
            // btn_docgia
            // 
            this.btn_docgia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_docgia.FlatAppearance.BorderSize = 0;
            this.btn_docgia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_docgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_docgia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_docgia.Image = ((System.Drawing.Image)(resources.GetObject("btn_docgia.Image")));
            this.btn_docgia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_docgia.Location = new System.Drawing.Point(0, 277);
            this.btn_docgia.Name = "btn_docgia";
            this.btn_docgia.Size = new System.Drawing.Size(200, 124);
            this.btn_docgia.TabIndex = 2;
            this.btn_docgia.Text = "Quản Lý Độc Giả";
            this.btn_docgia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_docgia.UseVisualStyleBackColor = true;
            // 
            // btn_sach
            // 
            this.btn_sach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sach.FlatAppearance.BorderSize = 0;
            this.btn_sach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_sach.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_sach.Image = ((System.Drawing.Image)(resources.GetObject("btn_sach.Image")));
            this.btn_sach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sach.Location = new System.Drawing.Point(0, 153);
            this.btn_sach.Name = "btn_sach";
            this.btn_sach.Size = new System.Drawing.Size(200, 124);
            this.btn_sach.TabIndex = 1;
            this.btn_sach.Text = "Quản Lý Sách";
            this.btn_sach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sach.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 100);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1282, 853);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // FormChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChuongTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thư viện";
            this.Load += new System.EventHandler(this.FormChuongTrinh_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sach;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_phieu;
        private System.Windows.Forms.Button btn_docgia;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Panel pannel_body;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer menuTransition;
    }
}