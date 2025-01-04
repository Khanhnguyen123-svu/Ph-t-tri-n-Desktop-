namespace WindowsFormsApp1
{
    partial class uscNhanVien
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
            this.pnlNhanVien = new System.Windows.Forms.Panel();
            this.pnlTacVuNV = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlVaiTro = new System.Windows.Forms.Panel();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.rdbNhanVien = new System.Windows.Forms.RadioButton();
            this.rdbQuanLi = new System.Windows.Forms.RadioButton();
            this.pnlGioiTinh = new System.Windows.Forms.Panel();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblQuanLiNhanVien = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlNhanVien.SuspendLayout();
            this.pnlTacVuNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlVaiTro.SuspendLayout();
            this.pnlGioiTinh.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNhanVien
            // 
            this.pnlNhanVien.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlNhanVien.Controls.Add(this.pnlTacVuNV);
            this.pnlNhanVien.Controls.Add(this.dgvNhanVien);
            this.pnlNhanVien.Controls.Add(this.panel4);
            this.pnlNhanVien.Controls.Add(this.panel2);
            this.pnlNhanVien.Location = new System.Drawing.Point(0, 0);
            this.pnlNhanVien.Name = "pnlNhanVien";
            this.pnlNhanVien.Size = new System.Drawing.Size(1043, 730);
            this.pnlNhanVien.TabIndex = 7;
            this.pnlNhanVien.Tag = "";
            this.pnlNhanVien.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNhanVien_Paint);
            // 
            // pnlTacVuNV
            // 
            this.pnlTacVuNV.Controls.Add(this.btnEdit);
            this.pnlTacVuNV.Controls.Add(this.btnDelete);
            this.pnlTacVuNV.Controls.Add(this.btnAdd);
            this.pnlTacVuNV.Location = new System.Drawing.Point(554, 166);
            this.pnlTacVuNV.Name = "pnlTacVuNV";
            this.pnlTacVuNV.Size = new System.Drawing.Size(464, 62);
            this.pnlTacVuNV.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkGray;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(323, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 49);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(185, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 49);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(46, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 49);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.Location = new System.Drawing.Point(28, 249);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 60;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(990, 445);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlVaiTro);
            this.panel4.Controls.Add(this.pnlGioiTinh);
            this.panel4.Controls.Add(this.dtpNgaySinh);
            this.panel4.Controls.Add(this.lblNgaySinh);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.lblEmail);
            this.panel4.Controls.Add(this.txtSDT);
            this.panel4.Controls.Add(this.lblSDT);
            this.panel4.Controls.Add(this.lblQuanLiNhanVien);
            this.panel4.Controls.Add(this.txtTenNV);
            this.panel4.Controls.Add(this.lblTenNV);
            this.panel4.Controls.Add(this.lblMaNV);
            this.panel4.Controls.Add(this.txtMaNV);
            this.panel4.Controls.Add(this.lblDiaChi);
            this.panel4.Controls.Add(this.txtDiaChi);
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1015, 165);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pnlVaiTro
            // 
            this.pnlVaiTro.Controls.Add(this.lblVaiTro);
            this.pnlVaiTro.Controls.Add(this.rdbNhanVien);
            this.pnlVaiTro.Controls.Add(this.rdbQuanLi);
            this.pnlVaiTro.Location = new System.Drawing.Point(708, 78);
            this.pnlVaiTro.Name = "pnlVaiTro";
            this.pnlVaiTro.Size = new System.Drawing.Size(298, 43);
            this.pnlVaiTro.TabIndex = 22;
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaiTro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblVaiTro.Location = new System.Drawing.Point(6, 11);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(54, 18);
            this.lblVaiTro.TabIndex = 3;
            this.lblVaiTro.Text = "Vai trò:";
            // 
            // rdbNhanVien
            // 
            this.rdbNhanVien.AutoSize = true;
            this.rdbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNhanVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbNhanVien.Location = new System.Drawing.Point(103, 9);
            this.rdbNhanVien.Name = "rdbNhanVien";
            this.rdbNhanVien.Size = new System.Drawing.Size(94, 22);
            this.rdbNhanVien.TabIndex = 7;
            this.rdbNhanVien.TabStop = true;
            this.rdbNhanVien.Text = "Nhân viên";
            this.rdbNhanVien.UseVisualStyleBackColor = true;
            // 
            // rdbQuanLi
            // 
            this.rdbQuanLi.AutoSize = true;
            this.rdbQuanLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbQuanLi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbQuanLi.Location = new System.Drawing.Point(213, 9);
            this.rdbQuanLi.Name = "rdbQuanLi";
            this.rdbQuanLi.Size = new System.Drawing.Size(99, 28);
            this.rdbQuanLi.TabIndex = 6;
            this.rdbQuanLi.TabStop = true;
            this.rdbQuanLi.Text = "Quản lý";
            this.rdbQuanLi.UseVisualStyleBackColor = true;
            // 
            // pnlGioiTinh
            // 
            this.pnlGioiTinh.Controls.Add(this.lblGioiTinh);
            this.pnlGioiTinh.Controls.Add(this.rdbNu);
            this.pnlGioiTinh.Controls.Add(this.rdbNam);
            this.pnlGioiTinh.Location = new System.Drawing.Point(708, 34);
            this.pnlGioiTinh.Name = "pnlGioiTinh";
            this.pnlGioiTinh.Size = new System.Drawing.Size(298, 34);
            this.pnlGioiTinh.TabIndex = 21;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblGioiTinh.Location = new System.Drawing.Point(6, 5);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(66, 18);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbNu.Location = new System.Drawing.Point(213, 5);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(48, 22);
            this.rdbNu.TabIndex = 10;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbNam.Location = new System.Drawing.Point(103, 3);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(61, 22);
            this.rdbNam.TabIndex = 9;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(481, 75);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(195, 22);
            this.dtpNgaySinh.TabIndex = 20;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNgaySinh.Location = new System.Drawing.Point(388, 78);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(79, 18);
            this.lblNgaySinh.TabIndex = 19;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.Location = new System.Drawing.Point(484, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEmail.Location = new System.Drawing.Point(388, 124);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 18);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSDT.Location = new System.Drawing.Point(145, 119);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(195, 22);
            this.txtSDT.TabIndex = 16;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSDT.Location = new System.Drawing.Point(24, 123);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(98, 18);
            this.lblSDT.TabIndex = 15;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblQuanLiNhanVien
            // 
            this.lblQuanLiNhanVien.AutoSize = true;
            this.lblQuanLiNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLiNhanVien.Location = new System.Drawing.Point(6, 0);
            this.lblQuanLiNhanVien.Name = "lblQuanLiNhanVien";
            this.lblQuanLiNhanVien.Size = new System.Drawing.Size(159, 20);
            this.lblQuanLiNhanVien.TabIndex = 14;
            this.lblQuanLiNhanVien.Text = "Quản lý nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTenNV.Location = new System.Drawing.Point(145, 74);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(195, 22);
            this.txtTenNV.TabIndex = 3;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTenNV.Location = new System.Drawing.Point(24, 78);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(103, 18);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Tên nhân viên:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaNV.Location = new System.Drawing.Point(22, 37);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(99, 18);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaNV.Location = new System.Drawing.Point(145, 35);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(195, 22);
            this.txtMaNV.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDiaChi.Location = new System.Drawing.Point(388, 38);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 18);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDiaChi.Location = new System.Drawing.Point(484, 34);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(195, 22);
            this.txtDiaChi.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(3, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 62);
            this.panel2.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(373, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 49);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearch.Location = new System.Drawing.Point(27, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(329, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // uscNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlNhanVien);
            this.Name = "uscNhanVien";
            this.Size = new System.Drawing.Size(1043, 730);
            this.pnlNhanVien.ResumeLayout(false);
            this.pnlTacVuNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlVaiTro.ResumeLayout(false);
            this.pnlVaiTro.PerformLayout();
            this.pnlGioiTinh.ResumeLayout(false);
            this.pnlGioiTinh.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNhanVien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlVaiTro;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.RadioButton rdbNhanVien;
        private System.Windows.Forms.RadioButton rdbQuanLi;
        private System.Windows.Forms.Panel pnlGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblQuanLiNhanVien;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlTacVuNV;
    }
}
