namespace GUI
{
    partial class FormDanhSachDocGia
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnXemAllDocGia = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.lbCTGioiTinhDG = new System.Windows.Forms.Label();
            this.txtCTPhoneDG = new System.Windows.Forms.TextBox();
            this.txtCTMaDG = new System.Windows.Forms.TextBox();
            this.txtCTEmailDG = new System.Windows.Forms.TextBox();
            this.txtCTDiaChiDG = new System.Windows.Forms.TextBox();
            this.txtCTTenDG = new System.Windows.Forms.TextBox();
            this.txtSearchDG = new System.Windows.Forms.TextBox();
            this.dtkCTNgaySinhDG = new System.Windows.Forms.DateTimePicker();
            this.lbCTPhoneDG = new System.Windows.Forms.Label();
            this.lbCTEmailDG = new System.Windows.Forms.Label();
            this.lbCTDiaChiDG = new System.Windows.Forms.Label();
            this.lbCTNgaySinhDG = new System.Windows.Forms.Label();
            this.lbCTMaDG = new System.Windows.Forms.Label();
            this.lbCTTenDG = new System.Windows.Forms.Label();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLapPhieuTra = new System.Windows.Forms.Button();
            this.btnLapPhieMuon = new System.Windows.Forms.Button();
            this.btnXoaDocGia = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.dgvDGSearch = new System.Windows.Forms.DataGridView();
            this.rdHoTenSearch = new System.Windows.Forms.RadioButton();
            this.rdMaDGSearch = new System.Windows.Forms.RadioButton();
            this.label30 = new System.Windows.Forms.Label();
            this.tbcPhieuMuon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rdThemNu = new System.Windows.Forms.RadioButton();
            this.rdThemNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDGSearch)).BeginInit();
            this.tbcPhieuMuon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(748, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXemAllDocGia
            // 
            this.btnXemAllDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemAllDocGia.Location = new System.Drawing.Point(955, 67);
            this.btnXemAllDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXemAllDocGia.Name = "btnXemAllDocGia";
            this.btnXemAllDocGia.Size = new System.Drawing.Size(164, 64);
            this.btnXemAllDocGia.TabIndex = 4;
            this.btnXemAllDocGia.Text = "Xem tất cả";
            this.btnXemAllDocGia.UseVisualStyleBackColor = true;
            this.btnXemAllDocGia.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage7.Controls.Add(this.rdNu);
            this.tabPage7.Controls.Add(this.rdNam);
            this.tabPage7.Controls.Add(this.lbCTGioiTinhDG);
            this.tabPage7.Controls.Add(this.button1);
            this.tabPage7.Controls.Add(this.btnXemAllDocGia);
            this.tabPage7.Controls.Add(this.txtCTPhoneDG);
            this.tabPage7.Controls.Add(this.txtCTMaDG);
            this.tabPage7.Controls.Add(this.txtCTEmailDG);
            this.tabPage7.Controls.Add(this.txtCTDiaChiDG);
            this.tabPage7.Controls.Add(this.txtCTTenDG);
            this.tabPage7.Controls.Add(this.txtSearchDG);
            this.tabPage7.Controls.Add(this.dtkCTNgaySinhDG);
            this.tabPage7.Controls.Add(this.lbCTPhoneDG);
            this.tabPage7.Controls.Add(this.lbCTEmailDG);
            this.tabPage7.Controls.Add(this.lbCTDiaChiDG);
            this.tabPage7.Controls.Add(this.lbCTNgaySinhDG);
            this.tabPage7.Controls.Add(this.lbCTMaDG);
            this.tabPage7.Controls.Add(this.lbCTTenDG);
            this.tabPage7.Controls.Add(this.btnChinhSua);
            this.tabPage7.Controls.Add(this.btnHuy);
            this.tabPage7.Controls.Add(this.btnLuu);
            this.tabPage7.Controls.Add(this.btnLapPhieuTra);
            this.tabPage7.Controls.Add(this.btnLapPhieMuon);
            this.tabPage7.Controls.Add(this.btnXoaDocGia);
            this.tabPage7.Controls.Add(this.btnXemChiTiet);
            this.tabPage7.Controls.Add(this.dgvDGSearch);
            this.tabPage7.Controls.Add(this.rdHoTenSearch);
            this.tabPage7.Controls.Add(this.rdMaDGSearch);
            this.tabPage7.Controls.Add(this.label30);
            this.tabPage7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage7.Location = new System.Drawing.Point(4, 32);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage7.Size = new System.Drawing.Size(1234, 783);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Tìm Kiếm Độc Giả";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(390, 408);
            this.rdNu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(69, 33);
            this.rdNu.TabIndex = 79;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(228, 404);
            this.rdNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(89, 33);
            this.rdNam.TabIndex = 78;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // lbCTGioiTinhDG
            // 
            this.lbCTGioiTinhDG.AutoSize = true;
            this.lbCTGioiTinhDG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCTGioiTinhDG.Location = new System.Drawing.Point(76, 412);
            this.lbCTGioiTinhDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCTGioiTinhDG.Name = "lbCTGioiTinhDG";
            this.lbCTGioiTinhDG.Size = new System.Drawing.Size(85, 23);
            this.lbCTGioiTinhDG.TabIndex = 76;
            this.lbCTGioiTinhDG.Text = "Giới Tính";
            // 
            // txtCTPhoneDG
            // 
            this.txtCTPhoneDG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCTPhoneDG.Location = new System.Drawing.Point(781, 342);
            this.txtCTPhoneDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCTPhoneDG.Name = "txtCTPhoneDG";
            this.txtCTPhoneDG.Size = new System.Drawing.Size(371, 31);
            this.txtCTPhoneDG.TabIndex = 37;
            // 
            // txtCTMaDG
            // 
            this.txtCTMaDG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCTMaDG.Location = new System.Drawing.Point(228, 206);
            this.txtCTMaDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCTMaDG.Name = "txtCTMaDG";
            this.txtCTMaDG.ReadOnly = true;
            this.txtCTMaDG.Size = new System.Drawing.Size(314, 31);
            this.txtCTMaDG.TabIndex = 33;
            // 
            // txtCTEmailDG
            // 
            this.txtCTEmailDG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCTEmailDG.Location = new System.Drawing.Point(782, 278);
            this.txtCTEmailDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCTEmailDG.Name = "txtCTEmailDG";
            this.txtCTEmailDG.Size = new System.Drawing.Size(372, 31);
            this.txtCTEmailDG.TabIndex = 32;
            // 
            // txtCTDiaChiDG
            // 
            this.txtCTDiaChiDG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCTDiaChiDG.Location = new System.Drawing.Point(782, 208);
            this.txtCTDiaChiDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCTDiaChiDG.Name = "txtCTDiaChiDG";
            this.txtCTDiaChiDG.Size = new System.Drawing.Size(370, 31);
            this.txtCTDiaChiDG.TabIndex = 31;
            // 
            // txtCTTenDG
            // 
            this.txtCTTenDG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCTTenDG.Location = new System.Drawing.Point(228, 275);
            this.txtCTTenDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCTTenDG.Name = "txtCTTenDG";
            this.txtCTTenDG.Size = new System.Drawing.Size(314, 31);
            this.txtCTTenDG.TabIndex = 29;
            // 
            // txtSearchDG
            // 
            this.txtSearchDG.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDG.Location = new System.Drawing.Point(404, 74);
            this.txtSearchDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchDG.Name = "txtSearchDG";
            this.txtSearchDG.Size = new System.Drawing.Size(301, 35);
            this.txtSearchDG.TabIndex = 1;
            // 
            // dtkCTNgaySinhDG
            // 
            this.dtkCTNgaySinhDG.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtkCTNgaySinhDG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtkCTNgaySinhDG.Location = new System.Drawing.Point(228, 340);
            this.dtkCTNgaySinhDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtkCTNgaySinhDG.Name = "dtkCTNgaySinhDG";
            this.dtkCTNgaySinhDG.Size = new System.Drawing.Size(314, 35);
            this.dtkCTNgaySinhDG.TabIndex = 75;
            // 
            // lbCTPhoneDG
            // 
            this.lbCTPhoneDG.AutoSize = true;
            this.lbCTPhoneDG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCTPhoneDG.Location = new System.Drawing.Point(630, 340);
            this.lbCTPhoneDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCTPhoneDG.Name = "lbCTPhoneDG";
            this.lbCTPhoneDG.Size = new System.Drawing.Size(84, 23);
            this.lbCTPhoneDG.TabIndex = 35;
            this.lbCTPhoneDG.Text = "Phone  ";
            // 
            // lbCTEmailDG
            // 
            this.lbCTEmailDG.AutoSize = true;
            this.lbCTEmailDG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCTEmailDG.Location = new System.Drawing.Point(630, 281);
            this.lbCTEmailDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCTEmailDG.Name = "lbCTEmailDG";
            this.lbCTEmailDG.Size = new System.Drawing.Size(62, 23);
            this.lbCTEmailDG.TabIndex = 27;
            this.lbCTEmailDG.Text = "Email";
            this.lbCTEmailDG.Click += new System.EventHandler(this.lbCTEmailDG_Click);
            // 
            // lbCTDiaChiDG
            // 
            this.lbCTDiaChiDG.AutoSize = true;
            this.lbCTDiaChiDG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCTDiaChiDG.Location = new System.Drawing.Point(630, 214);
            this.lbCTDiaChiDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCTDiaChiDG.Name = "lbCTDiaChiDG";
            this.lbCTDiaChiDG.Size = new System.Drawing.Size(82, 23);
            this.lbCTDiaChiDG.TabIndex = 26;
            this.lbCTDiaChiDG.Text = "Địa Chỉ";
            // 
            // lbCTNgaySinhDG
            // 
            this.lbCTNgaySinhDG.AutoSize = true;
            this.lbCTNgaySinhDG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCTNgaySinhDG.Location = new System.Drawing.Point(71, 345);
            this.lbCTNgaySinhDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCTNgaySinhDG.Name = "lbCTNgaySinhDG";
            this.lbCTNgaySinhDG.Size = new System.Drawing.Size(106, 23);
            this.lbCTNgaySinhDG.TabIndex = 25;
            this.lbCTNgaySinhDG.Text = "Ngày Sinh";
            // 
            // lbCTMaDG
            // 
            this.lbCTMaDG.AutoSize = true;
            this.lbCTMaDG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCTMaDG.Location = new System.Drawing.Point(71, 211);
            this.lbCTMaDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCTMaDG.Name = "lbCTMaDG";
            this.lbCTMaDG.Size = new System.Drawing.Size(120, 23);
            this.lbCTMaDG.TabIndex = 24;
            this.lbCTMaDG.Text = "Mã Độc Giả";
            // 
            // lbCTTenDG
            // 
            this.lbCTTenDG.AutoSize = true;
            this.lbCTTenDG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCTTenDG.Location = new System.Drawing.Point(66, 278);
            this.lbCTTenDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCTTenDG.Name = "lbCTTenDG";
            this.lbCTTenDG.Size = new System.Drawing.Size(122, 23);
            this.lbCTTenDG.TabIndex = 23;
            this.lbCTTenDG.Text = "Tên Độc Giả";
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnChinhSua.Location = new System.Drawing.Point(180, 531);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(207, 66);
            this.btnChinhSua.TabIndex = 21;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHuy.Location = new System.Drawing.Point(829, 531);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(199, 68);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(514, 534);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(207, 66);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLapPhieuTra
            // 
            this.btnLapPhieuTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.btnLapPhieuTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieuTra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieuTra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLapPhieuTra.Location = new System.Drawing.Point(891, 531);
            this.btnLapPhieuTra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLapPhieuTra.Name = "btnLapPhieuTra";
            this.btnLapPhieuTra.Size = new System.Drawing.Size(194, 62);
            this.btnLapPhieuTra.TabIndex = 16;
            this.btnLapPhieuTra.Text = "Lập Phiếu Trả";
            this.btnLapPhieuTra.UseVisualStyleBackColor = false;
            this.btnLapPhieuTra.Click += new System.EventHandler(this.btnLapPhieuTra_Click);
            // 
            // btnLapPhieMuon
            // 
            this.btnLapPhieMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.btnLapPhieMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieMuon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieMuon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLapPhieMuon.Location = new System.Drawing.Point(584, 535);
            this.btnLapPhieMuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLapPhieMuon.Name = "btnLapPhieMuon";
            this.btnLapPhieMuon.Size = new System.Drawing.Size(213, 62);
            this.btnLapPhieMuon.TabIndex = 15;
            this.btnLapPhieMuon.Text = "Lập Phiếu Mượn";
            this.btnLapPhieMuon.UseVisualStyleBackColor = false;
            this.btnLapPhieMuon.Click += new System.EventHandler(this.btnLapPhieMuon_Click);
            // 
            // btnXoaDocGia
            // 
            this.btnXoaDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.btnXoaDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDocGia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDocGia.ForeColor = System.Drawing.Color.White;
            this.btnXoaDocGia.Location = new System.Drawing.Point(270, 532);
            this.btnXoaDocGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaDocGia.Name = "btnXoaDocGia";
            this.btnXoaDocGia.Size = new System.Drawing.Size(176, 62);
            this.btnXoaDocGia.TabIndex = 14;
            this.btnXoaDocGia.Text = "Xóa";
            this.btnXoaDocGia.UseVisualStyleBackColor = false;
            this.btnXoaDocGia.Click += new System.EventHandler(this.btnXoaDocGia_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXemChiTiet.Location = new System.Drawing.Point(45, 532);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(176, 62);
            this.btnXemChiTiet.TabIndex = 13;
            this.btnXemChiTiet.Text = "Xem Chi Tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // dgvDGSearch
            // 
            this.dgvDGSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDGSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDGSearch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDGSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDGSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDGSearch.Location = new System.Drawing.Point(12, 189);
            this.dgvDGSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDGSearch.Name = "dgvDGSearch";
            this.dgvDGSearch.RowHeadersWidth = 51;
            this.dgvDGSearch.Size = new System.Drawing.Size(1304, 306);
            this.dgvDGSearch.TabIndex = 9;
            // 
            // rdHoTenSearch
            // 
            this.rdHoTenSearch.AutoSize = true;
            this.rdHoTenSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHoTenSearch.Location = new System.Drawing.Point(216, 100);
            this.rdHoTenSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdHoTenSearch.Name = "rdHoTenSearch";
            this.rdHoTenSearch.Size = new System.Drawing.Size(110, 31);
            this.rdHoTenSearch.TabIndex = 4;
            this.rdHoTenSearch.TabStop = true;
            this.rdHoTenSearch.Text = "Họ Tên";
            this.rdHoTenSearch.UseVisualStyleBackColor = true;
            // 
            // rdMaDGSearch
            // 
            this.rdMaDGSearch.AutoSize = true;
            this.rdMaDGSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaDGSearch.Location = new System.Drawing.Point(216, 44);
            this.rdMaDGSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdMaDGSearch.Name = "rdMaDGSearch";
            this.rdMaDGSearch.Size = new System.Drawing.Size(168, 31);
            this.rdMaDGSearch.TabIndex = 2;
            this.rdMaDGSearch.TabStop = true;
            this.rdMaDGSearch.Text = "Mã Độc Giả";
            this.rdMaDGSearch.UseVisualStyleBackColor = true;
            this.rdMaDGSearch.CheckedChanged += new System.EventHandler(this.rdMaDGSearch_CheckedChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(24, 74);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(183, 27);
            this.label30.TabIndex = 0;
            this.label30.Text = "Tìm Kiếm Theo :";
            // 
            // tbcPhieuMuon
            // 
            this.tbcPhieuMuon.Controls.Add(this.tabPage7);
            this.tbcPhieuMuon.Controls.Add(this.tabPage1);
            this.tbcPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPhieuMuon.ItemSize = new System.Drawing.Size(110, 28);
            this.tbcPhieuMuon.Location = new System.Drawing.Point(0, 0);
            this.tbcPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcPhieuMuon.Name = "tbcPhieuMuon";
            this.tbcPhieuMuon.SelectedIndex = 0;
            this.tbcPhieuMuon.Size = new System.Drawing.Size(1242, 819);
            this.tbcPhieuMuon.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1234, 783);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Thêm Độc Giả";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rdThemNu);
            this.groupBox1.Controls.Add(this.rdThemNam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1071, 400);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin độc giả";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(662, 182);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 46);
            this.txtEmail.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(545, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 85;
            this.label8.Text = "Địa chỉ:";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(804, 311);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(153, 62);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(662, 131);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(314, 35);
            this.dateTimePicker1.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(544, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 83;
            this.label7.Text = "Ngày Sinh";
            // 
            // rdThemNu
            // 
            this.rdThemNu.AutoSize = true;
            this.rdThemNu.Location = new System.Drawing.Point(747, 64);
            this.rdThemNu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdThemNu.Name = "rdThemNu";
            this.rdThemNu.Size = new System.Drawing.Size(54, 24);
            this.rdThemNu.TabIndex = 82;
            this.rdThemNu.TabStop = true;
            this.rdThemNu.Text = "Nữ";
            this.rdThemNu.UseVisualStyleBackColor = true;
            // 
            // rdThemNam
            // 
            this.rdThemNam.AutoSize = true;
            this.rdThemNam.Location = new System.Drawing.Point(662, 61);
            this.rdThemNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdThemNam.Name = "rdThemNam";
            this.rdThemNam.Size = new System.Drawing.Size(67, 24);
            this.rdThemNam.TabIndex = 81;
            this.rdThemNam.TabStop = true;
            this.rdThemNam.Text = "Nam";
            this.rdThemNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(544, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 80;
            this.label6.Text = "Giới Tính";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(173, 245);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(343, 46);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 182);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(343, 46);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 116);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 46);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 46);
            this.textBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sdt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên độc giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÔNG TIN ĐỘC GIẢ";
            // 
            // FormDanhSachDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 819);
            this.Controls.Add(this.tbcPhieuMuon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDanhSachDocGia";
            this.Text = "Danh Sách Độc Giả";
            this.Load += new System.EventHandler(this.FormDanhSachDocGia_Load);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDGSearch)).EndInit();
            this.tbcPhieuMuon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXemAllDocGia;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox txtCTPhoneDG;
        private System.Windows.Forms.TextBox txtCTMaDG;
        private System.Windows.Forms.TextBox txtCTEmailDG;
        private System.Windows.Forms.TextBox txtCTDiaChiDG;
        private System.Windows.Forms.TextBox txtCTTenDG;
        private System.Windows.Forms.TextBox txtSearchDG;
        private System.Windows.Forms.DateTimePicker dtkCTNgaySinhDG;
        private System.Windows.Forms.Label lbCTPhoneDG;
        private System.Windows.Forms.Label lbCTEmailDG;
        private System.Windows.Forms.Label lbCTDiaChiDG;
        private System.Windows.Forms.Label lbCTNgaySinhDG;
        private System.Windows.Forms.Label lbCTMaDG;
        private System.Windows.Forms.Label lbCTTenDG;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLapPhieuTra;
        private System.Windows.Forms.Button btnLapPhieMuon;
        private System.Windows.Forms.Button btnXoaDocGia;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.DataGridView dgvDGSearch;
        private System.Windows.Forms.RadioButton rdHoTenSearch;
        private System.Windows.Forms.RadioButton rdMaDGSearch;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TabControl tbcPhieuMuon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbCTGioiTinhDG;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdThemNu;
        private System.Windows.Forms.RadioButton rdThemNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
    }
}