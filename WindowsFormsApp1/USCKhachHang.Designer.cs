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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlKhachHang = new System.Windows.Forms.Panel();
            this.pnlTacVuKH = new System.Windows.Forms.Panel();
            this.btnEditKH = new System.Windows.Forms.Button();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.btnDeleteKH = new System.Windows.Forms.Button();
            this.btnSaveKH = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.pnlSearchKH = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblThongTinSP = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rdbKHNam = new System.Windows.Forms.RadioButton();
            this.rdbKHNu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGioiTinhKH = new System.Windows.Forms.Panel();
            this.lblSDT = new System.Windows.Forms.Label();
            this.pnlKhachHang.SuspendLayout();
            this.pnlTacVuKH.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.pnlSearchKH.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlGioiTinhKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKhachHang
            // 
            this.pnlKhachHang.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlKhachHang.Controls.Add(this.pnlTacVuKH);
            this.pnlKhachHang.Controls.Add(this.panel3);
            this.pnlKhachHang.Controls.Add(this.pnlSearchKH);
            this.pnlKhachHang.Controls.Add(this.panel4);
            this.pnlKhachHang.Location = new System.Drawing.Point(0, 0);
            this.pnlKhachHang.Name = "pnlKhachHang";
            this.pnlKhachHang.Size = new System.Drawing.Size(1030, 706);
            this.pnlKhachHang.TabIndex = 0;
            this.pnlKhachHang.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKhachHang_Paint);
            // 
            // pnlTacVuKH
            // 
            this.pnlTacVuKH.Controls.Add(this.btnEditKH);
            this.pnlTacVuKH.Controls.Add(this.btnAddKH);
            this.pnlTacVuKH.Controls.Add(this.btnDeleteKH);
            this.pnlTacVuKH.Controls.Add(this.btnSaveKH);
            this.pnlTacVuKH.Location = new System.Drawing.Point(530, 149);
            this.pnlTacVuKH.Name = "pnlTacVuKH";
            this.pnlTacVuKH.Size = new System.Drawing.Size(497, 62);
            this.pnlTacVuKH.TabIndex = 7;
            // 
            // btnEditKH
            // 
            this.btnEditKH.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditKH.Location = new System.Drawing.Point(267, 5);
            this.btnEditKH.Name = "btnEditKH";
            this.btnEditKH.Size = new System.Drawing.Size(83, 49);
            this.btnEditKH.TabIndex = 12;
            this.btnEditKH.Text = "Sửa";
            this.btnEditKH.UseVisualStyleBackColor = false;
            this.btnEditKH.Click += new System.EventHandler(this.btnEditKH_Click);
            // 
            // btnAddKH
            // 
            this.btnAddKH.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddKH.Location = new System.Drawing.Point(53, 5);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(83, 49);
            this.btnAddKH.TabIndex = 11;
            this.btnAddKH.Text = "Thêm";
            this.btnAddKH.UseVisualStyleBackColor = false;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // btnDeleteKH
            // 
            this.btnDeleteKH.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteKH.Location = new System.Drawing.Point(164, 5);
            this.btnDeleteKH.Name = "btnDeleteKH";
            this.btnDeleteKH.Size = new System.Drawing.Size(83, 49);
            this.btnDeleteKH.TabIndex = 12;
            this.btnDeleteKH.Text = "Xóa";
            this.btnDeleteKH.UseVisualStyleBackColor = false;
            this.btnDeleteKH.Click += new System.EventHandler(this.btnDeleteKH_Click);
            // 
            // btnSaveKH
            // 
            this.btnSaveKH.BackColor = System.Drawing.Color.DarkGray;
            this.btnSaveKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveKH.Location = new System.Drawing.Point(372, 5);
            this.btnSaveKH.Name = "btnSaveKH";
            this.btnSaveKH.Size = new System.Drawing.Size(83, 49);
            this.btnSaveKH.TabIndex = 13;
            this.btnSaveKH.Text = "Lưu";
            this.btnSaveKH.UseVisualStyleBackColor = false;
            this.btnSaveKH.Click += new System.EventHandler(this.btnSaveKH_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.dgvKhachHang);
            this.panel3.Location = new System.Drawing.Point(2, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 463);
            this.panel3.TabIndex = 6;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvKhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKhachHang.Location = new System.Drawing.Point(1, 3);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 60;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(1024, 177);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            // 
            // pnlSearchKH
            // 
            this.pnlSearchKH.Controls.Add(this.btnSearch);
            this.pnlSearchKH.Controls.Add(this.txtSearch);
            this.pnlSearchKH.Location = new System.Drawing.Point(3, 149);
            this.pnlSearchKH.Name = "pnlSearchKH";
            this.pnlSearchKH.Size = new System.Drawing.Size(481, 62);
            this.pnlSearchKH.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(373, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 49);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearch.Location = new System.Drawing.Point(18, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(329, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.pnlGioiTinhKH);
            this.panel4.Controls.Add(this.dtpNgaySinh);
            this.panel4.Controls.Add(this.lblNgaySinh);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.lblEmail);
            this.panel4.Controls.Add(this.txtSDT);
            this.panel4.Controls.Add(this.lblSDT);
            this.panel4.Controls.Add(this.lblThongTinSP);
            this.panel4.Controls.Add(this.txtTenNV);
            this.panel4.Controls.Add(this.lblTenKH);
            this.panel4.Controls.Add(this.lblMaKH);
            this.panel4.Controls.Add(this.txtMaNV);
            this.panel4.Controls.Add(this.lblDiaChi);
            this.panel4.Controls.Add(this.txtDiaChi);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1025, 140);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(510, 64);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(202, 22);
            this.dtpNgaySinh.TabIndex = 20;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNgaySinh.Location = new System.Drawing.Point(399, 64);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(79, 18);
            this.lblNgaySinh.TabIndex = 19;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEmail.Location = new System.Drawing.Point(399, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 18);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSDT.Location = new System.Drawing.Point(160, 101);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(187, 22);
            this.txtSDT.TabIndex = 16;
            // 
            // lblThongTinSP
            // 
            this.lblThongTinSP.AutoSize = true;
            this.lblThongTinSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinSP.Location = new System.Drawing.Point(6, 0);
            this.lblThongTinSP.Name = "lblThongTinSP";
            this.lblThongTinSP.Size = new System.Drawing.Size(170, 20);
            this.lblThongTinSP.TabIndex = 14;
            this.lblThongTinSP.Text = "Quản Lý Sản Phẩm";
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTenNV.Location = new System.Drawing.Point(160, 64);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(187, 22);
            this.txtTenNV.TabIndex = 3;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTenKH.Location = new System.Drawing.Point(21, 64);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(117, 18);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaKH.Location = new System.Drawing.Point(21, 29);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(113, 18);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã khách hàng:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaNV.Location = new System.Drawing.Point(160, 29);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(187, 22);
            this.txtMaNV.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDiaChi.Location = new System.Drawing.Point(399, 30);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 18);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDiaChi.Location = new System.Drawing.Point(510, 28);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(202, 22);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.Location = new System.Drawing.Point(510, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // rdbKHNam
            // 
            this.rdbKHNam.AutoSize = true;
            this.rdbKHNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKHNam.Location = new System.Drawing.Point(27, 43);
            this.rdbKHNam.Name = "rdbKHNam";
            this.rdbKHNam.Size = new System.Drawing.Size(61, 22);
            this.rdbKHNam.TabIndex = 0;
            this.rdbKHNam.TabStop = true;
            this.rdbKHNam.Text = "Nam";
            this.rdbKHNam.UseVisualStyleBackColor = true;
            // 
            // rdbKHNu
            // 
            this.rdbKHNu.AutoSize = true;
            this.rdbKHNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKHNu.Location = new System.Drawing.Point(109, 43);
            this.rdbKHNu.Name = "rdbKHNu";
            this.rdbKHNu.Size = new System.Drawing.Size(48, 22);
            this.rdbKHNu.TabIndex = 1;
            this.rdbKHNu.TabStop = true;
            this.rdbKHNu.Text = "Nữ";
            this.rdbKHNu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giới Tính:";
            // 
            // pnlGioiTinhKH
            // 
            this.pnlGioiTinhKH.Controls.Add(this.label1);
            this.pnlGioiTinhKH.Controls.Add(this.rdbKHNu);
            this.pnlGioiTinhKH.Controls.Add(this.rdbKHNam);
            this.pnlGioiTinhKH.Location = new System.Drawing.Point(767, 19);
            this.pnlGioiTinhKH.Name = "pnlGioiTinhKH";
            this.pnlGioiTinhKH.Size = new System.Drawing.Size(200, 100);
            this.pnlGioiTinhKH.TabIndex = 21;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSDT.Location = new System.Drawing.Point(21, 101);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(98, 18);
            this.lblSDT.TabIndex = 15;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // uscSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlKhachHang);
            this.Name = "uscSanPham";
            this.Size = new System.Drawing.Size(1032, 723);
            this.Load += new System.EventHandler(this.uscSanPham_Load);
            this.pnlKhachHang.ResumeLayout(false);
            this.pnlTacVuKH.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.pnlSearchKH.ResumeLayout(false);
            this.pnlSearchKH.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlGioiTinhKH.ResumeLayout(false);
            this.pnlGioiTinhKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKhachHang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblThongTinSP;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.Button btnDeleteKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Button btnEditKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnSaveKH;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Panel pnlSearchKH;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Panel pnlTacVuKH;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlGioiTinhKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbKHNu;
        private System.Windows.Forms.RadioButton rdbKHNam;
        private System.Windows.Forms.Label lblSDT;
    }
}
