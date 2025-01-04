namespace WindowsFormsApp1
{
    partial class fDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangKy));
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblDki = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblXacNhan = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorXNPassword = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlChucVu = new System.Windows.Forms.Panel();
            this.rdbQuanLi = new System.Windows.Forms.RadioButton();
            this.rdbNhanVien = new System.Windows.Forms.RadioButton();
            this.lblChucVu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlChucVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(33, 90);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(115, 18);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "Tên Đăng Nhập:";
            this.lblTenDangNhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDki
            // 
            this.lblDki.AutoSize = true;
            this.lblDki.BackColor = System.Drawing.Color.Transparent;
            this.lblDki.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDki.Location = new System.Drawing.Point(246, 28);
            this.lblDki.Name = "lblDki";
            this.lblDki.Size = new System.Drawing.Size(270, 36);
            this.lblDki.TabIndex = 2;
            this.lblDki.Text = "Đăng ký tài khoản";
            this.lblDki.Click += new System.EventHandler(this.lblDki_Click);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(33, 144);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(75, 18);
            this.lblMatKhau.TabIndex = 3;
            this.lblMatKhau.Text = "Mật Khẩu:";
            // 
            // lblXacNhan
            // 
            this.lblXacNhan.AutoSize = true;
            this.lblXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXacNhan.Location = new System.Drawing.Point(33, 199);
            this.lblXacNhan.Name = "lblXacNhan";
            this.lblXacNhan.Size = new System.Drawing.Size(144, 18);
            this.lblXacNhan.TabIndex = 4;
            this.lblXacNhan.Text = "Xác Nhận Mật Khẩu:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(33, 249);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(106, 18);
            this.lblSDT.TabIndex = 5;
            this.lblSDT.Text = "Số Điện Thoại:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenDangNhap.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtTenDangNhap.Location = new System.Drawing.Point(197, 86);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(367, 22);
            this.txtTenDangNhap.TabIndex = 6;
            this.txtTenDangNhap.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtMatKhau.Location = new System.Drawing.Point(197, 140);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(367, 22);
            this.txtMatKhau.TabIndex = 7;
            this.txtMatKhau.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(197, 195);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '*';
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(367, 22);
            this.txtXacNhanMatKhau.TabIndex = 8;
            this.txtXacNhanMatKhau.Click += new System.EventHandler(this.txtXNPassword_Click);
            this.txtXacNhanMatKhau.TextChanged += new System.EventHandler(this.txtXacNhanMatKhau_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEmail.Location = new System.Drawing.Point(197, 245);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(367, 22);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Location = new System.Drawing.Point(343, 348);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(94, 35);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(468, 348);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 35);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Quay lại ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(194, 86);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(0, 16);
            this.lblErrorName.TabIndex = 12;
            this.lblErrorName.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(194, 157);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(0, 16);
            this.lblErrorPassword.TabIndex = 12;
            this.lblErrorPassword.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(194, 304);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(0, 16);
            this.lblErrorEmail.TabIndex = 12;
            this.lblErrorEmail.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblErrorXNPassword
            // 
            this.lblErrorXNPassword.AutoSize = true;
            this.lblErrorXNPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorXNPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorXNPassword.Location = new System.Drawing.Point(194, 232);
            this.lblErrorXNPassword.Name = "lblErrorXNPassword";
            this.lblErrorXNPassword.Size = new System.Drawing.Size(0, 16);
            this.lblErrorXNPassword.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-13, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pnlChucVu
            // 
            this.pnlChucVu.Controls.Add(this.rdbQuanLi);
            this.pnlChucVu.Controls.Add(this.rdbNhanVien);
            this.pnlChucVu.Controls.Add(this.lblChucVu);
            this.pnlChucVu.Location = new System.Drawing.Point(29, 273);
            this.pnlChucVu.Name = "pnlChucVu";
            this.pnlChucVu.Size = new System.Drawing.Size(535, 56);
            this.pnlChucVu.TabIndex = 16;
            // 
            // rdbQuanLi
            // 
            this.rdbQuanLi.AutoSize = true;
            this.rdbQuanLi.Location = new System.Drawing.Point(314, 19);
            this.rdbQuanLi.Name = "rdbQuanLi";
            this.rdbQuanLi.Size = new System.Drawing.Size(73, 20);
            this.rdbQuanLi.TabIndex = 19;
            this.rdbQuanLi.TabStop = true;
            this.rdbQuanLi.Text = "Quản Lí";
            this.rdbQuanLi.UseVisualStyleBackColor = true;
            // 
            // rdbNhanVien
            // 
            this.rdbNhanVien.AutoSize = true;
            this.rdbNhanVien.Location = new System.Drawing.Point(168, 19);
            this.rdbNhanVien.Name = "rdbNhanVien";
            this.rdbNhanVien.Size = new System.Drawing.Size(90, 20);
            this.rdbNhanVien.TabIndex = 18;
            this.rdbNhanVien.TabStop = true;
            this.rdbNhanVien.Text = "Nhân Viên";
            this.rdbNhanVien.UseVisualStyleBackColor = true;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(4, 21);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(68, 18);
            this.lblChucVu.TabIndex = 17;
            this.lblChucVu.Text = "Chức Vụ:";
            // 
            // fDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(602, 399);
            this.Controls.Add(this.pnlChucVu);
            this.Controls.Add(this.lblErrorXNPassword);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblXacNhan);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblDki);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký thông tin";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlChucVu.ResumeLayout(false);
            this.pnlChucVu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblDki;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblXacNhan;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorXNPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlChucVu;
        private System.Windows.Forms.RadioButton rdbQuanLi;
        private System.Windows.Forms.RadioButton rdbNhanVien;
        private System.Windows.Forms.Label lblChucVu;
    }
}