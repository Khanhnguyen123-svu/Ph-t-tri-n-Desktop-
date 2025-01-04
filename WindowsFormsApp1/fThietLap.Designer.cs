namespace WindowsFormsApp1
{
    partial class fThietLap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThietLap));
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbNhanVien = new System.Windows.Forms.RadioButton();
            this.rdbQuanLi = new System.Windows.Forms.RadioButton();
            this.lblCHucVu = new System.Windows.Forms.Label();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblMKM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.pnlThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlThongTin.Controls.Add(this.txtMatKhau);
            this.pnlThongTin.Controls.Add(this.lblMK);
            this.pnlThongTin.Controls.Add(this.btnThoat);
            this.pnlThongTin.Controls.Add(this.btnCapNhat);
            this.pnlThongTin.Controls.Add(this.panel1);
            this.pnlThongTin.Controls.Add(this.txtNhapLaiMatKhau);
            this.pnlThongTin.Controls.Add(this.txtMatKhauMoi);
            this.pnlThongTin.Controls.Add(this.lblMKM);
            this.pnlThongTin.Controls.Add(this.label1);
            this.pnlThongTin.Controls.Add(this.txtSDT);
            this.pnlThongTin.Controls.Add(this.lblSDT);
            this.pnlThongTin.Controls.Add(this.txtTenDangNhap);
            this.pnlThongTin.Controls.Add(this.lblTen);
            this.pnlThongTin.Controls.Add(this.lblThongTin);
            this.pnlThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTin.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(540, 526);
            this.pnlThongTin.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(226, 123);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(247, 22);
            this.txtMatKhau.TabIndex = 14;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.Location = new System.Drawing.Point(50, 122);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(75, 18);
            this.lblMK.TabIndex = 13;
            this.lblMK.Text = "Mật Khẩu:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkGray;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(411, 437);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 46);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Location = new System.Drawing.Point(290, 437);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(87, 46);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbNhanVien);
            this.panel1.Controls.Add(this.rdbQuanLi);
            this.panel1.Controls.Add(this.lblCHucVu);
            this.panel1.Location = new System.Drawing.Point(43, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 56);
            this.panel1.TabIndex = 10;
            // 
            // rdbNhanVien
            // 
            this.rdbNhanVien.AutoSize = true;
            this.rdbNhanVien.Location = new System.Drawing.Point(318, 16);
            this.rdbNhanVien.Name = "rdbNhanVien";
            this.rdbNhanVien.Size = new System.Drawing.Size(90, 20);
            this.rdbNhanVien.TabIndex = 11;
            this.rdbNhanVien.TabStop = true;
            this.rdbNhanVien.Text = "Nhân Viên";
            this.rdbNhanVien.UseVisualStyleBackColor = true;
            // 
            // rdbQuanLi
            // 
            this.rdbQuanLi.AutoSize = true;
            this.rdbQuanLi.Location = new System.Drawing.Point(190, 16);
            this.rdbQuanLi.Name = "rdbQuanLi";
            this.rdbQuanLi.Size = new System.Drawing.Size(73, 20);
            this.rdbQuanLi.TabIndex = 10;
            this.rdbQuanLi.TabStop = true;
            this.rdbQuanLi.Text = "Quản Lí";
            this.rdbQuanLi.UseVisualStyleBackColor = true;
            // 
            // lblCHucVu
            // 
            this.lblCHucVu.AutoSize = true;
            this.lblCHucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHucVu.Location = new System.Drawing.Point(14, 16);
            this.lblCHucVu.Name = "lblCHucVu";
            this.lblCHucVu.Size = new System.Drawing.Size(68, 18);
            this.lblCHucVu.TabIndex = 9;
            this.lblCHucVu.Text = "Chức Vụ:";
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(226, 241);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(247, 22);
            this.txtNhapLaiMatKhau.TabIndex = 8;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(226, 177);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(247, 22);
            this.txtMatKhauMoi.TabIndex = 7;
            // 
            // lblMKM
            // 
            this.lblMKM.AutoSize = true;
            this.lblMKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKM.Location = new System.Drawing.Point(50, 178);
            this.lblMKM.Name = "lblMKM";
            this.lblMKM.Size = new System.Drawing.Size(104, 18);
            this.lblMKM.TabIndex = 6;
            this.lblMKM.Text = "Mật Khẩu Mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập Lại Mật Khẩu:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(226, 303);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(247, 22);
            this.txtSDT.TabIndex = 4;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(50, 304);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(106, 18);
            this.lblSDT.TabIndex = 3;
            this.lblSDT.Text = "Số Điện Thoại:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(226, 62);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(247, 22);
            this.txtTenDangNhap.TabIndex = 2;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(50, 62);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(115, 18);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên Đăng Nhập:";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(12, 9);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(170, 20);
            this.lblThongTin.TabIndex = 0;
            this.lblThongTin.Text = "Thông Tin Cá Nhân";
            // 
            // fThietLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 526);
            this.Controls.Add(this.pnlThongTin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThietLap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết Lập";
            this.Load += new System.EventHandler(this.fThietLap_Load);
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCHucVu;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblMKM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.RadioButton rdbNhanVien;
        private System.Windows.Forms.RadioButton rdbQuanLi;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtMatKhau;
    }
}