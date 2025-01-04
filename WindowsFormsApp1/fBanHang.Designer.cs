namespace WindowsFormsApp1
{
    partial class fBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBanHang));
            this.pnlBanHang = new System.Windows.Forms.Panel();
            this.pnlThongTinKH = new System.Windows.Forms.Panel();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.pnlTenThongTin = new System.Windows.Forms.Panel();
            this.lblTTKH = new System.Windows.Forms.Label();
            this.txtThongTinHD = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.pnlTenHoaDon = new System.Windows.Forms.Panel();
            this.lblTTHD = new System.Windows.Forms.Label();
            this.txtTongHoaDon = new System.Windows.Forms.TextBox();
            this.lblTongHD = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.pnlTenDanhMuc = new System.Windows.Forms.Panel();
            this.lblDMSP = new System.Windows.Forms.Label();
            this.pnlTenBoLoc = new System.Windows.Forms.Panel();
            this.lblBoLoc = new System.Windows.Forms.Label();
            this.pnlDanhMucSP = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.flpCate = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBoLoc = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnApDung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLocSP = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.pnlBanHang.SuspendLayout();
            this.pnlThongTinKH.SuspendLayout();
            this.pnlTenThongTin.SuspendLayout();
            this.txtThongTinHD.SuspendLayout();
            this.pnlTenHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.pnlTenDanhMuc.SuspendLayout();
            this.pnlTenBoLoc.SuspendLayout();
            this.pnlDanhMucSP.SuspendLayout();
            this.pnlBoLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanHang
            // 
            this.pnlBanHang.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlBanHang.Controls.Add(this.pnlThongTinKH);
            this.pnlBanHang.Controls.Add(this.txtThongTinHD);
            this.pnlBanHang.Controls.Add(this.pnlTenDanhMuc);
            this.pnlBanHang.Controls.Add(this.pnlTenBoLoc);
            this.pnlBanHang.Controls.Add(this.pnlDanhMucSP);
            this.pnlBanHang.Controls.Add(this.pnlBoLoc);
            this.pnlBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBanHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlBanHang.Location = new System.Drawing.Point(0, 0);
            this.pnlBanHang.Name = "pnlBanHang";
            this.pnlBanHang.Size = new System.Drawing.Size(1205, 746);
            this.pnlBanHang.TabIndex = 10;
            // 
            // pnlThongTinKH
            // 
            this.pnlThongTinKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlThongTinKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThongTinKH.Controls.Add(this.txtTenKhachHang);
            this.pnlThongTinKH.Controls.Add(this.lblSDT);
            this.pnlThongTinKH.Controls.Add(this.txtSoDienThoai);
            this.pnlThongTinKH.Controls.Add(this.lblTenKH);
            this.pnlThongTinKH.Controls.Add(this.pnlTenThongTin);
            this.pnlThongTinKH.Location = new System.Drawing.Point(4, 3);
            this.pnlThongTinKH.Name = "pnlThongTinKH";
            this.pnlThongTinKH.Size = new System.Drawing.Size(520, 149);
            this.pnlThongTinKH.TabIndex = 11;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(188, 67);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(245, 22);
            this.txtTenKhachHang.TabIndex = 4;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(13, 111);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(119, 20);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "Số Điện Thoại:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(188, 111);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(245, 22);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(13, 69);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(139, 20);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên Khách Hàng:";
            // 
            // pnlTenThongTin
            // 
            this.pnlTenThongTin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTenThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTenThongTin.Controls.Add(this.lblTTKH);
            this.pnlTenThongTin.Location = new System.Drawing.Point(-6, -1);
            this.pnlTenThongTin.Name = "pnlTenThongTin";
            this.pnlTenThongTin.Size = new System.Drawing.Size(521, 52);
            this.pnlTenThongTin.TabIndex = 0;
            // 
            // lblTTKH
            // 
            this.lblTTKH.AutoSize = true;
            this.lblTTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTKH.Location = new System.Drawing.Point(122, 24);
            this.lblTTKH.Name = "lblTTKH";
            this.lblTTKH.Size = new System.Drawing.Size(217, 22);
            this.lblTTKH.TabIndex = 0;
            this.lblTTKH.Text = "Thông Tin Khách Hàng";
            // 
            // txtThongTinHD
            // 
            this.txtThongTinHD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtThongTinHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThongTinHD.Controls.Add(this.btnDelete);
            this.txtThongTinHD.Controls.Add(this.btnThanhToan);
            this.txtThongTinHD.Controls.Add(this.pnlTenHoaDon);
            this.txtThongTinHD.Controls.Add(this.txtTongHoaDon);
            this.txtThongTinHD.Controls.Add(this.lblTongHD);
            this.txtThongTinHD.Controls.Add(this.dgvHoaDon);
            this.txtThongTinHD.Location = new System.Drawing.Point(3, 158);
            this.txtThongTinHD.Name = "txtThongTinHD";
            this.txtThongTinHD.Size = new System.Drawing.Size(521, 576);
            this.txtThongTinHD.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(292, 498);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa Sản Phẩm";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Location = new System.Drawing.Point(139, 498);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(130, 40);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // pnlTenHoaDon
            // 
            this.pnlTenHoaDon.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTenHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTenHoaDon.Controls.Add(this.lblTTHD);
            this.pnlTenHoaDon.Location = new System.Drawing.Point(-6, -1);
            this.pnlTenHoaDon.Name = "pnlTenHoaDon";
            this.pnlTenHoaDon.Size = new System.Drawing.Size(526, 57);
            this.pnlTenHoaDon.TabIndex = 1;
            this.pnlTenHoaDon.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTenHoaDon_Paint);
            // 
            // lblTTHD
            // 
            this.lblTTHD.AutoSize = true;
            this.lblTTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTHD.Location = new System.Drawing.Point(136, 16);
            this.lblTTHD.Name = "lblTTHD";
            this.lblTTHD.Size = new System.Drawing.Size(186, 22);
            this.lblTTHD.TabIndex = 1;
            this.lblTTHD.Text = "Thông Tin Hóa Đơn";
            // 
            // txtTongHoaDon
            // 
            this.txtTongHoaDon.Location = new System.Drawing.Point(265, 437);
            this.txtTongHoaDon.Name = "txtTongHoaDon";
            this.txtTongHoaDon.Size = new System.Drawing.Size(197, 22);
            this.txtTongHoaDon.TabIndex = 4;
            // 
            // lblTongHD
            // 
            this.lblTongHD.AutoSize = true;
            this.lblTongHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongHD.Location = new System.Drawing.Point(119, 441);
            this.lblTongHD.Name = "lblTongHD";
            this.lblTongHD.Size = new System.Drawing.Size(110, 18);
            this.lblTongHD.TabIndex = 3;
            this.lblTongHD.Text = "Tổng Hóa Đơn:";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(8, 62);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(497, 350);
            this.dgvHoaDon.TabIndex = 2;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // pnlTenDanhMuc
            // 
            this.pnlTenDanhMuc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTenDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTenDanhMuc.Controls.Add(this.lblDMSP);
            this.pnlTenDanhMuc.Location = new System.Drawing.Point(526, 158);
            this.pnlTenDanhMuc.Name = "pnlTenDanhMuc";
            this.pnlTenDanhMuc.Size = new System.Drawing.Size(676, 57);
            this.pnlTenDanhMuc.TabIndex = 2;
            this.pnlTenDanhMuc.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTenDanhMuc_Paint);
            // 
            // lblDMSP
            // 
            this.lblDMSP.AutoSize = true;
            this.lblDMSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMSP.Location = new System.Drawing.Point(268, 16);
            this.lblDMSP.Name = "lblDMSP";
            this.lblDMSP.Size = new System.Drawing.Size(196, 22);
            this.lblDMSP.TabIndex = 3;
            this.lblDMSP.Text = "Danh Mục Sản Phẩm";
            // 
            // pnlTenBoLoc
            // 
            this.pnlTenBoLoc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTenBoLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTenBoLoc.Controls.Add(this.lblBoLoc);
            this.pnlTenBoLoc.Location = new System.Drawing.Point(526, 3);
            this.pnlTenBoLoc.Name = "pnlTenBoLoc";
            this.pnlTenBoLoc.Size = new System.Drawing.Size(679, 52);
            this.pnlTenBoLoc.TabIndex = 1;
            // 
            // lblBoLoc
            // 
            this.lblBoLoc.AutoSize = true;
            this.lblBoLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoLoc.Location = new System.Drawing.Point(246, 24);
            this.lblBoLoc.Name = "lblBoLoc";
            this.lblBoLoc.Size = new System.Drawing.Size(72, 22);
            this.lblBoLoc.TabIndex = 1;
            this.lblBoLoc.Text = "Bộ Lọc";
            // 
            // pnlDanhMucSP
            // 
            this.pnlDanhMucSP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDanhMucSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDanhMucSP.Controls.Add(this.btnThoat);
            this.pnlDanhMucSP.Controls.Add(this.flpCate);
            this.pnlDanhMucSP.Location = new System.Drawing.Point(526, 158);
            this.pnlDanhMucSP.Name = "pnlDanhMucSP";
            this.pnlDanhMucSP.Size = new System.Drawing.Size(676, 576);
            this.pnlDanhMucSP.TabIndex = 12;
            this.pnlDanhMucSP.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDanhMucSP_Paint);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(573, 519);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 42);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // flpCate
            // 
            this.flpCate.Location = new System.Drawing.Point(12, 62);
            this.flpCate.Name = "flpCate";
            this.flpCate.Size = new System.Drawing.Size(654, 451);
            this.flpCate.TabIndex = 3;
            this.flpCate.Paint += new System.Windows.Forms.PaintEventHandler(this.flpCate_Paint);
            // 
            // pnlBoLoc
            // 
            this.pnlBoLoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBoLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBoLoc.Controls.Add(this.btnLamMoi);
            this.pnlBoLoc.Controls.Add(this.btnApDung);
            this.pnlBoLoc.Controls.Add(this.label1);
            this.pnlBoLoc.Controls.Add(this.cbLocSP);
            this.pnlBoLoc.Controls.Add(this.txtSearch);
            this.pnlBoLoc.Controls.Add(this.lblTenSP);
            this.pnlBoLoc.Location = new System.Drawing.Point(526, 3);
            this.pnlBoLoc.Name = "pnlBoLoc";
            this.pnlBoLoc.Size = new System.Drawing.Size(679, 149);
            this.pnlBoLoc.TabIndex = 13;
            this.pnlBoLoc.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBoLoc_Paint);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(222, 111);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(105, 27);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnApDung
            // 
            this.btnApDung.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnApDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApDung.Location = new System.Drawing.Point(75, 111);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new System.Drawing.Size(106, 27);
            this.btnApDung.TabIndex = 8;
            this.btnApDung.Text = "Áp Dụng";
            this.btnApDung.UseVisualStyleBackColor = false;
            this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại Sản Phẩm";
            // 
            // cbLocSP
            // 
            this.cbLocSP.FormattingEnabled = true;
            this.cbLocSP.Location = new System.Drawing.Point(397, 77);
            this.cbLocSP.Name = "cbLocSP";
            this.cbLocSP.Size = new System.Drawing.Size(121, 24);
            this.cbLocSP.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(75, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(71, 54);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(119, 20);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "Tên Sản Phẩm";
            // 
            // fBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 746);
            this.Controls.Add(this.pnlBanHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.fBanHang_Load);
            this.pnlBanHang.ResumeLayout(false);
            this.pnlThongTinKH.ResumeLayout(false);
            this.pnlThongTinKH.PerformLayout();
            this.pnlTenThongTin.ResumeLayout(false);
            this.pnlTenThongTin.PerformLayout();
            this.txtThongTinHD.ResumeLayout(false);
            this.txtThongTinHD.PerformLayout();
            this.pnlTenHoaDon.ResumeLayout(false);
            this.pnlTenHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.pnlTenDanhMuc.ResumeLayout(false);
            this.pnlTenDanhMuc.PerformLayout();
            this.pnlTenBoLoc.ResumeLayout(false);
            this.pnlTenBoLoc.PerformLayout();
            this.pnlDanhMucSP.ResumeLayout(false);
            this.pnlBoLoc.ResumeLayout(false);
            this.pnlBoLoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanHang;
        private System.Windows.Forms.Panel pnlTenDanhMuc;
        private System.Windows.Forms.Label lblDMSP;
        private System.Windows.Forms.Panel pnlTenBoLoc;
        private System.Windows.Forms.Label lblBoLoc;
        private System.Windows.Forms.Panel pnlDanhMucSP;
        private System.Windows.Forms.FlowLayoutPanel flpCate;
        private System.Windows.Forms.Panel pnlBoLoc;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnApDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLocSP;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Panel txtThongTinHD;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel pnlTenHoaDon;
        private System.Windows.Forms.Label lblTTHD;
        private System.Windows.Forms.TextBox txtTongHoaDon;
        private System.Windows.Forms.Label lblTongHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Panel pnlThongTinKH;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Panel pnlTenThongTin;
        private System.Windows.Forms.Label lblTTKH;
        private System.Windows.Forms.Button btnThoat;
    }
}