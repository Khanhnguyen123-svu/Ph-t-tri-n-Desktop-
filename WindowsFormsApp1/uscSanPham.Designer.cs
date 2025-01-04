namespace WindowsFormsApp1
{
    partial class uscSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMANCC = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.btnChonTep = new System.Windows.Forms.Button();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.lblAnhSanPham = new System.Windows.Forms.Label();
            this.txtDanhMuc = new System.Windows.Forms.TextBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.nudSoLuongSP = new System.Windows.Forms.NumericUpDown();
            this.dtpHSDSP = new System.Windows.Forms.DateTimePicker();
            this.dtpNNSP = new System.Windows.Forms.DateTimePicker();
            this.lblHSD = new System.Windows.Forms.Label();
            this.lblNgayNhapSP = new System.Windows.Forms.Label();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.lblGiaSP = new System.Windows.Forms.Label();
            this.lblQuanLiSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblSoLuongSP = new System.Windows.Forms.Label();
            this.pnlSearchSP = new System.Windows.Forms.Panel();
            this.btnSearchSP = new System.Windows.Forms.Button();
            this.txtSearchSP = new System.Windows.Forms.TextBox();
            this.pnlTacVuSP = new System.Windows.Forms.Panel();
            this.btnUpDateSP = new System.Windows.Forms.Button();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.btnDeleteSP = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.pnlHienThi = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongSP)).BeginInit();
            this.pnlSearchSP.SuspendLayout();
            this.pnlTacVuSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.pnlHienThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.lblMANCC);
            this.panel4.Controls.Add(this.txtMaNCC);
            this.panel4.Controls.Add(this.btnChonTep);
            this.panel4.Controls.Add(this.picHinhAnh);
            this.panel4.Controls.Add(this.txtHinhAnh);
            this.panel4.Controls.Add(this.lblAnhSanPham);
            this.panel4.Controls.Add(this.txtDanhMuc);
            this.panel4.Controls.Add(this.lblDanhMuc);
            this.panel4.Controls.Add(this.nudSoLuongSP);
            this.panel4.Controls.Add(this.dtpHSDSP);
            this.panel4.Controls.Add(this.dtpNNSP);
            this.panel4.Controls.Add(this.lblHSD);
            this.panel4.Controls.Add(this.lblNgayNhapSP);
            this.panel4.Controls.Add(this.txtGiaSP);
            this.panel4.Controls.Add(this.lblGiaSP);
            this.panel4.Controls.Add(this.lblQuanLiSP);
            this.panel4.Controls.Add(this.txtTenSP);
            this.panel4.Controls.Add(this.lblTenSP);
            this.panel4.Controls.Add(this.lblMaSP);
            this.panel4.Controls.Add(this.txtMaSP);
            this.panel4.Controls.Add(this.lblSoLuongSP);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1009, 210);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblMANCC
            // 
            this.lblMANCC.AutoSize = true;
            this.lblMANCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMANCC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMANCC.Location = new System.Drawing.Point(402, 75);
            this.lblMANCC.Name = "lblMANCC";
            this.lblMANCC.Size = new System.Drawing.Size(134, 18);
            this.lblMANCC.TabIndex = 29;
            this.lblMANCC.Text = "Mã Nhà Cung Cấp:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaNCC.Location = new System.Drawing.Point(566, 75);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(154, 22);
            this.txtMaNCC.TabIndex = 30;
            // 
            // btnChonTep
            // 
            this.btnChonTep.BackColor = System.Drawing.Color.DarkGray;
            this.btnChonTep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonTep.Location = new System.Drawing.Point(897, 103);
            this.btnChonTep.Name = "btnChonTep";
            this.btnChonTep.Size = new System.Drawing.Size(88, 45);
            this.btnChonTep.TabIndex = 28;
            this.btnChonTep.Text = "Chọn Tệp";
            this.btnChonTep.UseVisualStyleBackColor = false;
            this.btnChonTep.Click += new System.EventHandler(this.btnChonTep_Click);
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picHinhAnh.Location = new System.Drawing.Point(741, 74);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(139, 112);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 27;
            this.picHinhAnh.TabStop = false;
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Location = new System.Drawing.Point(827, 34);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(170, 22);
            this.txtHinhAnh.TabIndex = 26;
            // 
            // lblAnhSanPham
            // 
            this.lblAnhSanPham.AutoSize = true;
            this.lblAnhSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnhSanPham.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAnhSanPham.Location = new System.Drawing.Point(738, 35);
            this.lblAnhSanPham.Name = "lblAnhSanPham";
            this.lblAnhSanPham.Size = new System.Drawing.Size(71, 18);
            this.lblAnhSanPham.TabIndex = 25;
            this.lblAnhSanPham.Text = "Hình Ảnh:";
            // 
            // txtDanhMuc
            // 
            this.txtDanhMuc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDanhMuc.Location = new System.Drawing.Point(566, 35);
            this.txtDanhMuc.Name = "txtDanhMuc";
            this.txtDanhMuc.Size = new System.Drawing.Size(154, 22);
            this.txtDanhMuc.TabIndex = 24;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMuc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDanhMuc.Location = new System.Drawing.Point(402, 34);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(80, 18);
            this.lblDanhMuc.TabIndex = 23;
            this.lblDanhMuc.Text = "Danh Mục:";
            // 
            // nudSoLuongSP
            // 
            this.nudSoLuongSP.Location = new System.Drawing.Point(189, 164);
            this.nudSoLuongSP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSoLuongSP.Name = "nudSoLuongSP";
            this.nudSoLuongSP.Size = new System.Drawing.Size(90, 22);
            this.nudSoLuongSP.TabIndex = 22;
            this.nudSoLuongSP.ValueChanged += new System.EventHandler(this.nudSoLuongSP_ValueChanged);
            // 
            // dtpHSDSP
            // 
            this.dtpHSDSP.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dtpHSDSP.CustomFormat = "dd/MM/yyyy";
            this.dtpHSDSP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHSDSP.Location = new System.Drawing.Point(576, 164);
            this.dtpHSDSP.Name = "dtpHSDSP";
            this.dtpHSDSP.Size = new System.Drawing.Size(117, 22);
            this.dtpHSDSP.TabIndex = 21;
            // 
            // dtpNNSP
            // 
            this.dtpNNSP.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNNSP.CustomFormat = "dd/MM/yyyy";
            this.dtpNNSP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNNSP.Location = new System.Drawing.Point(576, 123);
            this.dtpNNSP.Name = "dtpNNSP";
            this.dtpNNSP.Size = new System.Drawing.Size(117, 22);
            this.dtpNNSP.TabIndex = 20;
            // 
            // lblHSD
            // 
            this.lblHSD.AutoSize = true;
            this.lblHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSD.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHSD.Location = new System.Drawing.Point(402, 167);
            this.lblHSD.Name = "lblHSD";
            this.lblHSD.Size = new System.Drawing.Size(100, 18);
            this.lblHSD.TabIndex = 19;
            this.lblHSD.Text = "Hạn Sử Dụng:";
            // 
            // lblNgayNhapSP
            // 
            this.lblNgayNhapSP.AutoSize = true;
            this.lblNgayNhapSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhapSP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNgayNhapSP.Location = new System.Drawing.Point(402, 126);
            this.lblNgayNhapSP.Name = "lblNgayNhapSP";
            this.lblNgayNhapSP.Size = new System.Drawing.Size(158, 18);
            this.lblNgayNhapSP.TabIndex = 17;
            this.lblNgayNhapSP.Text = "Ngày Nhập Sản Phẩm:";
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGiaSP.Location = new System.Drawing.Point(160, 112);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(187, 22);
            this.txtGiaSP.TabIndex = 16;
            // 
            // lblGiaSP
            // 
            this.lblGiaSP.AutoSize = true;
            this.lblGiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaSP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblGiaSP.Location = new System.Drawing.Point(21, 112);
            this.lblGiaSP.Name = "lblGiaSP";
            this.lblGiaSP.Size = new System.Drawing.Size(108, 18);
            this.lblGiaSP.TabIndex = 15;
            this.lblGiaSP.Text = "Giá Sản Phẩm:";
            // 
            // lblQuanLiSP
            // 
            this.lblQuanLiSP.AutoSize = true;
            this.lblQuanLiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLiSP.Location = new System.Drawing.Point(6, 0);
            this.lblQuanLiSP.Name = "lblQuanLiSP";
            this.lblQuanLiSP.Size = new System.Drawing.Size(170, 20);
            this.lblQuanLiSP.TabIndex = 14;
            this.lblQuanLiSP.Text = "Quản Lý Sản Phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTenSP.Location = new System.Drawing.Point(160, 71);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(187, 22);
            this.txtTenSP.TabIndex = 3;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTenSP.Location = new System.Drawing.Point(21, 71);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(110, 18);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "Tên Sản Phẩm:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.BackColor = System.Drawing.Color.Transparent;
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaSP.Location = new System.Drawing.Point(21, 28);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(106, 18);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã Sản Phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaSP.Location = new System.Drawing.Point(160, 29);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(187, 22);
            this.txtMaSP.TabIndex = 1;
            // 
            // lblSoLuongSP
            // 
            this.lblSoLuongSP.AutoSize = true;
            this.lblSoLuongSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongSP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSoLuongSP.Location = new System.Drawing.Point(21, 168);
            this.lblSoLuongSP.Name = "lblSoLuongSP";
            this.lblSoLuongSP.Size = new System.Drawing.Size(149, 18);
            this.lblSoLuongSP.TabIndex = 4;
            this.lblSoLuongSP.Text = "Số Lượng Sản Phẩm:";
            // 
            // pnlSearchSP
            // 
            this.pnlSearchSP.Controls.Add(this.btnSearchSP);
            this.pnlSearchSP.Controls.Add(this.txtSearchSP);
            this.pnlSearchSP.Location = new System.Drawing.Point(3, 219);
            this.pnlSearchSP.Name = "pnlSearchSP";
            this.pnlSearchSP.Size = new System.Drawing.Size(481, 62);
            this.pnlSearchSP.TabIndex = 6;
            // 
            // btnSearchSP
            // 
            this.btnSearchSP.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearchSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchSP.Location = new System.Drawing.Point(373, 5);
            this.btnSearchSP.Name = "btnSearchSP";
            this.btnSearchSP.Size = new System.Drawing.Size(93, 49);
            this.btnSearchSP.TabIndex = 12;
            this.btnSearchSP.Text = "Tìm kiếm";
            this.btnSearchSP.UseVisualStyleBackColor = false;
            this.btnSearchSP.Click += new System.EventHandler(this.btnSearchSP_Click);
            // 
            // txtSearchSP
            // 
            this.txtSearchSP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchSP.Location = new System.Drawing.Point(18, 19);
            this.txtSearchSP.Name = "txtSearchSP";
            this.txtSearchSP.Size = new System.Drawing.Size(329, 22);
            this.txtSearchSP.TabIndex = 2;
            // 
            // pnlTacVuSP
            // 
            this.pnlTacVuSP.Controls.Add(this.btnUpDateSP);
            this.pnlTacVuSP.Controls.Add(this.btnAddSP);
            this.pnlTacVuSP.Controls.Add(this.btnDeleteSP);
            this.pnlTacVuSP.Location = new System.Drawing.Point(530, 219);
            this.pnlTacVuSP.Name = "pnlTacVuSP";
            this.pnlTacVuSP.Size = new System.Drawing.Size(482, 62);
            this.pnlTacVuSP.TabIndex = 8;
            // 
            // btnUpDateSP
            // 
            this.btnUpDateSP.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpDateSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpDateSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpDateSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpDateSP.Location = new System.Drawing.Point(335, 5);
            this.btnUpDateSP.Name = "btnUpDateSP";
            this.btnUpDateSP.Size = new System.Drawing.Size(98, 49);
            this.btnUpDateSP.TabIndex = 12;
            this.btnUpDateSP.Text = "Sửa";
            this.btnUpDateSP.UseVisualStyleBackColor = false;
            this.btnUpDateSP.Click += new System.EventHandler(this.btnUpDateSP_Click);
            // 
            // btnAddSP
            // 
            this.btnAddSP.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddSP.Location = new System.Drawing.Point(49, 5);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(94, 49);
            this.btnAddSP.TabIndex = 11;
            this.btnAddSP.Text = "Thêm";
            this.btnAddSP.UseVisualStyleBackColor = false;
            this.btnAddSP.Click += new System.EventHandler(this.btnAddSP_Click);
            // 
            // btnDeleteSP
            // 
            this.btnDeleteSP.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteSP.Location = new System.Drawing.Point(196, 5);
            this.btnDeleteSP.Name = "btnDeleteSP";
            this.btnDeleteSP.Size = new System.Drawing.Size(95, 49);
            this.btnDeleteSP.TabIndex = 12;
            this.btnDeleteSP.Text = "Xóa";
            this.btnDeleteSP.UseVisualStyleBackColor = false;
            this.btnDeleteSP.Click += new System.EventHandler(this.btnDeleteSP_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 60;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(1009, 415);
            this.dgvSanPham.TabIndex = 9;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // pnlHienThi
            // 
            this.pnlHienThi.Controls.Add(this.dgvSanPham);
            this.pnlHienThi.Location = new System.Drawing.Point(3, 287);
            this.pnlHienThi.Name = "pnlHienThi";
            this.pnlHienThi.Size = new System.Drawing.Size(1009, 415);
            this.pnlHienThi.TabIndex = 10;
            // 
            // uscSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.pnlHienThi);
            this.Controls.Add(this.pnlTacVuSP);
            this.Controls.Add(this.pnlSearchSP);
            this.Controls.Add(this.panel4);
            this.Name = "uscSanPham";
            this.Size = new System.Drawing.Size(1034, 731);
            this.Load += new System.EventHandler(this.uscSanPham_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongSP)).EndInit();
            this.pnlSearchSP.ResumeLayout(false);
            this.pnlSearchSP.PerformLayout();
            this.pnlTacVuSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.pnlHienThi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpNNSP;
        private System.Windows.Forms.Label lblHSD;
        private System.Windows.Forms.Label lblNgayNhapSP;
        private System.Windows.Forms.TextBox txtGiaSP;
        private System.Windows.Forms.Label lblGiaSP;
        private System.Windows.Forms.Label lblQuanLiSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblSoLuongSP;
        private System.Windows.Forms.DateTimePicker dtpHSDSP;
        private System.Windows.Forms.NumericUpDown nudSoLuongSP;
        private System.Windows.Forms.Panel pnlSearchSP;
        private System.Windows.Forms.Button btnSearchSP;
        private System.Windows.Forms.TextBox txtSearchSP;
        private System.Windows.Forms.Panel pnlTacVuSP;
        private System.Windows.Forms.Button btnUpDateSP;
        private System.Windows.Forms.Button btnAddSP;
        private System.Windows.Forms.Button btnDeleteSP;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel pnlHienThi;
        private System.Windows.Forms.TextBox txtDanhMuc;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.Label lblAnhSanPham;
        private System.Windows.Forms.Button btnChonTep;
        private System.Windows.Forms.Label lblMANCC;
        private System.Windows.Forms.TextBox txtMaNCC;
    }
}
