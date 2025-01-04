using System;

namespace WindowsFormsApp1
{
    partial class fHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHoaDon));
            this.pnlHoaDon = new System.Windows.Forms.Panel();
            this.pnlChuyenKhoan = new System.Windows.Forms.Panel();
            this.btnChuyenKhoan = new System.Windows.Forms.Button();
            this.btnTienMat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNgayMua = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTongThanhToan = new System.Windows.Forms.TextBox();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongThanhToan = new System.Windows.Forms.Label();
            this.lblChietKhau = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pnlHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHoaDon
            // 
            this.pnlHoaDon.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlHoaDon.Controls.Add(this.btnLuu);
            this.pnlHoaDon.Controls.Add(this.pnlChuyenKhoan);
            this.pnlHoaDon.Controls.Add(this.btnChuyenKhoan);
            this.pnlHoaDon.Controls.Add(this.btnTienMat);
            this.pnlHoaDon.Controls.Add(this.label2);
            this.pnlHoaDon.Controls.Add(this.label1);
            this.pnlHoaDon.Controls.Add(this.lblNgayMua);
            this.pnlHoaDon.Controls.Add(this.lblMaHoaDon);
            this.pnlHoaDon.Controls.Add(this.btnInHoaDon);
            this.pnlHoaDon.Controls.Add(this.btnThoat);
            this.pnlHoaDon.Controls.Add(this.txtTongThanhToan);
            this.pnlHoaDon.Controls.Add(this.txtChietKhau);
            this.pnlHoaDon.Controls.Add(this.txtTongTien);
            this.pnlHoaDon.Controls.Add(this.lblTongThanhToan);
            this.pnlHoaDon.Controls.Add(this.lblChietKhau);
            this.pnlHoaDon.Controls.Add(this.lblTongTien);
            this.pnlHoaDon.Controls.Add(this.txtTrangThai);
            this.pnlHoaDon.Controls.Add(this.txtSoDienThoai);
            this.pnlHoaDon.Controls.Add(this.txtTenKhachHang);
            this.pnlHoaDon.Controls.Add(this.dgvHoaDon);
            this.pnlHoaDon.Controls.Add(this.lblTrangThai);
            this.pnlHoaDon.Controls.Add(this.lblSDT);
            this.pnlHoaDon.Controls.Add(this.lblTenKH);
            this.pnlHoaDon.Controls.Add(this.lblHoaDon);
            this.pnlHoaDon.Location = new System.Drawing.Point(1, -1);
            this.pnlHoaDon.Name = "pnlHoaDon";
            this.pnlHoaDon.Size = new System.Drawing.Size(812, 832);
            this.pnlHoaDon.TabIndex = 0;
            this.pnlHoaDon.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHoaDon_Paint);
            // 
            // pnlChuyenKhoan
            // 
            this.pnlChuyenKhoan.Location = new System.Drawing.Point(74, 626);
            this.pnlChuyenKhoan.Name = "pnlChuyenKhoan";
            this.pnlChuyenKhoan.Size = new System.Drawing.Size(211, 192);
            this.pnlChuyenKhoan.TabIndex = 24;
            this.pnlChuyenKhoan.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChuyenKhoan_Paint);
            // 
            // btnChuyenKhoan
            // 
            this.btnChuyenKhoan.BackColor = System.Drawing.Color.DarkGray;
            this.btnChuyenKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenKhoan.Location = new System.Drawing.Point(203, 570);
            this.btnChuyenKhoan.Name = "btnChuyenKhoan";
            this.btnChuyenKhoan.Size = new System.Drawing.Size(141, 39);
            this.btnChuyenKhoan.TabIndex = 23;
            this.btnChuyenKhoan.Text = "Chuyển Khoản";
            this.btnChuyenKhoan.UseVisualStyleBackColor = false;
            this.btnChuyenKhoan.Click += new System.EventHandler(this.btnChuyenKhoan_Click);
            // 
            // btnTienMat
            // 
            this.btnTienMat.BackColor = System.Drawing.Color.DarkGray;
            this.btnTienMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienMat.Location = new System.Drawing.Point(26, 570);
            this.btnTienMat.Name = "btnTienMat";
            this.btnTienMat.Size = new System.Drawing.Size(133, 39);
            this.btnTienMat.TabIndex = 22;
            this.btnTienMat.Text = "Tiền Mặt";
            this.btnTienMat.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ngày Tạo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // lblNgayMua
            // 
            this.lblNgayMua.AutoSize = true;
            this.lblNgayMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayMua.Location = new System.Drawing.Point(362, 83);
            this.lblNgayMua.Name = "lblNgayMua";
            this.lblNgayMua.Size = new System.Drawing.Size(122, 18);
            this.lblNgayMua.TabIndex = 19;
            this.lblNgayMua.Text = "Tên Khách Hàng:";
            this.lblNgayMua.Click += new System.EventHandler(this.lblNgayMua_Click);
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(362, 51);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(122, 18);
            this.lblMaHoaDon.TabIndex = 18;
            this.lblMaHoaDon.Text = "Tên Khách Hàng:";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.DarkGray;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Location = new System.Drawing.Point(400, 747);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(116, 56);
            this.btnInHoaDon.TabIndex = 17;
            this.btnInHoaDon.Text = "Hoàn Thành";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkGray;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(669, 747);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 57);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTongThanhToan
            // 
            this.txtTongThanhToan.Location = new System.Drawing.Point(621, 691);
            this.txtTongThanhToan.Name = "txtTongThanhToan";
            this.txtTongThanhToan.Size = new System.Drawing.Size(180, 22);
            this.txtTongThanhToan.TabIndex = 14;
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Location = new System.Drawing.Point(621, 637);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new System.Drawing.Size(180, 22);
            this.txtChietKhau.TabIndex = 13;
            this.txtChietKhau.TextChanged += new System.EventHandler(this.txtChietKhau_TextChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(621, 587);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(180, 22);
            this.txtTongTien.TabIndex = 12;
            // 
            // lblTongThanhToan
            // 
            this.lblTongThanhToan.AutoSize = true;
            this.lblTongThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThanhToan.Location = new System.Drawing.Point(439, 691);
            this.lblTongThanhToan.Name = "lblTongThanhToan";
            this.lblTongThanhToan.Size = new System.Drawing.Size(144, 20);
            this.lblTongThanhToan.TabIndex = 11;
            this.lblTongThanhToan.Text = "Tổng Thanh Toán:";
            // 
            // lblChietKhau
            // 
            this.lblChietKhau.AutoSize = true;
            this.lblChietKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChietKhau.Location = new System.Drawing.Point(439, 637);
            this.lblChietKhau.Name = "lblChietKhau";
            this.lblChietKhau.Size = new System.Drawing.Size(96, 20);
            this.lblChietKhau.TabIndex = 10;
            this.lblChietKhau.Text = "Chiết Khấu:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(439, 587);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(88, 20);
            this.lblTongTien.TabIndex = 9;
            this.lblTongTien.Text = "Tống Tiền:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(203, 212);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(408, 22);
            this.txtTrangThai.TabIndex = 8;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(203, 165);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(408, 22);
            this.txtSoDienThoai.TabIndex = 7;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(203, 116);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(408, 22);
            this.txtTenKhachHang.TabIndex = 6;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(11, 254);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(790, 300);
            this.dgvHoaDon.TabIndex = 5;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(45, 212);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(94, 20);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = "Trạng Thái:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(45, 165);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(114, 20);
            this.lblSDT.TabIndex = 3;
            this.lblSDT.Text = "Số Điện Thoại";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(45, 116);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(139, 20);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên Khách Hàng:";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.Location = new System.Drawing.Point(333, 10);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(132, 32);
            this.lblHoaDon.TabIndex = 1;
            this.lblHoaDon.Text = "Hóa Đơn";
            this.lblHoaDon.Click += new System.EventHandler(this.lblHoaDon_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkGray;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(535, 748);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 56);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Xuất File";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // fHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 829);
            this.Controls.Add(this.pnlHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fHoaDon";
            this.Load += new System.EventHandler(this.fHoaDon_Load_1);
            this.pnlHoaDon.ResumeLayout(false);
            this.pnlHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }
        public event Action<string> OnQRCodeScanned;
        #endregion

        private System.Windows.Forms.Panel pnlHoaDon;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblChietKhau;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.TextBox txtTongThanhToan;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongThanhToan;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblNgayMua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlChuyenKhoan;
        private System.Windows.Forms.Button btnChuyenKhoan;
        private System.Windows.Forms.Button btnTienMat;
        private System.Windows.Forms.Button btnLuu;
    }
}