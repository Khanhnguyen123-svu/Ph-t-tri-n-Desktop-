using System;

namespace WindowsFormsApp1
{
    partial class uscKhachHang
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
            this.pnlKhachHang = new System.Windows.Forms.Panel();
            this.pnlTacVuKH = new System.Windows.Forms.Panel();
            this.btnEditKH = new System.Windows.Forms.Button();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.btnDeleteKH = new System.Windows.Forms.Button();
            this.pnlHienThi = new System.Windows.Forms.Panel();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.pnlSearchKH = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlQuanLiKH = new System.Windows.Forms.Panel();
            this.rdbKHNu = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdbKHNam = new System.Windows.Forms.RadioButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblThongTinKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.pnlKhachHang.SuspendLayout();
            this.pnlTacVuKH.SuspendLayout();
            this.pnlHienThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.pnlSearchKH.SuspendLayout();
            this.pnlQuanLiKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKhachHang
            // 
            this.pnlKhachHang.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlKhachHang.Controls.Add(this.pnlTacVuKH);
            this.pnlKhachHang.Controls.Add(this.pnlHienThi);
            this.pnlKhachHang.Controls.Add(this.pnlSearchKH);
            this.pnlKhachHang.Controls.Add(this.pnlQuanLiKH);
            this.pnlKhachHang.Location = new System.Drawing.Point(0, 0);
            this.pnlKhachHang.Name = "pnlKhachHang";
            this.pnlKhachHang.Size = new System.Drawing.Size(1043, 723);
            this.pnlKhachHang.TabIndex = 0;
            this.pnlKhachHang.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKhachHang_Paint);
            // 
            // pnlTacVuKH
            // 
            this.pnlTacVuKH.Controls.Add(this.btnEditKH);
            this.pnlTacVuKH.Controls.Add(this.btnAddKH);
            this.pnlTacVuKH.Controls.Add(this.btnDeleteKH);
            this.pnlTacVuKH.Location = new System.Drawing.Point(530, 116);
            this.pnlTacVuKH.Name = "pnlTacVuKH";
            this.pnlTacVuKH.Size = new System.Drawing.Size(482, 62);
            this.pnlTacVuKH.TabIndex = 7;
            // 
            // btnEditKH
            // 
            this.btnEditKH.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditKH.Location = new System.Drawing.Point(337, 5);
            this.btnEditKH.Name = "btnEditKH";
            this.btnEditKH.Size = new System.Drawing.Size(100, 49);
            this.btnEditKH.TabIndex = 12;
            this.btnEditKH.Text = "Sửa";
            this.btnEditKH.UseVisualStyleBackColor = false;
            this.btnEditKH.Click += new System.EventHandler(this.btnEditKH_Click);
            // 
            // btnAddKH
            // 
            this.btnAddKH.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddKH.Location = new System.Drawing.Point(55, 5);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(97, 49);
            this.btnAddKH.TabIndex = 11;
            this.btnAddKH.Text = "Thêm";
            this.btnAddKH.UseVisualStyleBackColor = false;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // btnDeleteKH
            // 
            this.btnDeleteKH.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteKH.Location = new System.Drawing.Point(193, 5);
            this.btnDeleteKH.Name = "btnDeleteKH";
            this.btnDeleteKH.Size = new System.Drawing.Size(99, 49);
            this.btnDeleteKH.TabIndex = 12;
            this.btnDeleteKH.Text = "Xóa";
            this.btnDeleteKH.UseVisualStyleBackColor = false;
            this.btnDeleteKH.Click += new System.EventHandler(this.btnDeleteKH_Click);
            // 
            // pnlHienThi
            // 
            this.pnlHienThi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlHienThi.Controls.Add(this.dgvKhachHang);
            this.pnlHienThi.Location = new System.Drawing.Point(2, 184);
            this.pnlHienThi.Name = "pnlHienThi";
            this.pnlHienThi.Size = new System.Drawing.Size(1010, 519);
            this.pnlHienThi.TabIndex = 6;
            this.pnlHienThi.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.Location = new System.Drawing.Point(3, 3);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 60;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(1007, 513);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            // 
            // pnlSearchKH
            // 
            this.pnlSearchKH.Controls.Add(this.btnSearch);
            this.pnlSearchKH.Controls.Add(this.txtSearch);
            this.pnlSearchKH.Location = new System.Drawing.Point(3, 116);
            this.pnlSearchKH.Name = "pnlSearchKH";
            this.pnlSearchKH.Size = new System.Drawing.Size(481, 62);
            this.pnlSearchKH.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(373, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 49);
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
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlQuanLiKH
            // 
            this.pnlQuanLiKH.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlQuanLiKH.Controls.Add(this.rdbKHNu);
            this.pnlQuanLiKH.Controls.Add(this.lblGioiTinh);
            this.pnlQuanLiKH.Controls.Add(this.rdbKHNam);
            this.pnlQuanLiKH.Controls.Add(this.txtSDT);
            this.pnlQuanLiKH.Controls.Add(this.lblSDT);
            this.pnlQuanLiKH.Controls.Add(this.lblThongTinKH);
            this.pnlQuanLiKH.Controls.Add(this.txtTenKH);
            this.pnlQuanLiKH.Controls.Add(this.lblTenKH);
            this.pnlQuanLiKH.Controls.Add(this.lblMaKH);
            this.pnlQuanLiKH.Controls.Add(this.txtMaKH);
            this.pnlQuanLiKH.Location = new System.Drawing.Point(3, 3);
            this.pnlQuanLiKH.Name = "pnlQuanLiKH";
            this.pnlQuanLiKH.Size = new System.Drawing.Size(1009, 107);
            this.pnlQuanLiKH.TabIndex = 4;
            this.pnlQuanLiKH.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // rdbKHNu
            // 
            this.rdbKHNu.AutoSize = true;
            this.rdbKHNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKHNu.Location = new System.Drawing.Point(809, 66);
            this.rdbKHNu.Name = "rdbKHNu";
            this.rdbKHNu.Size = new System.Drawing.Size(48, 22);
            this.rdbKHNu.TabIndex = 1;
            this.rdbKHNu.TabStop = true;
            this.rdbKHNu.Text = "Nữ";
            this.rdbKHNu.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(524, 68);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(71, 18);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // rdbKHNam
            // 
            this.rdbKHNam.AutoSize = true;
            this.rdbKHNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKHNam.Location = new System.Drawing.Point(690, 66);
            this.rdbKHNam.Name = "rdbKHNam";
            this.rdbKHNam.Size = new System.Drawing.Size(61, 22);
            this.rdbKHNam.TabIndex = 0;
            this.rdbKHNam.TabStop = true;
            this.rdbKHNam.Text = "Nam";
            this.rdbKHNam.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSDT.Location = new System.Drawing.Point(690, 28);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(187, 22);
            this.txtSDT.TabIndex = 16;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSDT.Location = new System.Drawing.Point(524, 29);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(98, 18);
            this.lblSDT.TabIndex = 15;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblThongTinKH
            // 
            this.lblThongTinKH.AutoSize = true;
            this.lblThongTinKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinKH.Location = new System.Drawing.Point(6, 0);
            this.lblThongTinKH.Name = "lblThongTinKH";
            this.lblThongTinKH.Size = new System.Drawing.Size(187, 20);
            this.lblThongTinKH.TabIndex = 14;
            this.lblThongTinKH.Text = "Quản Lý Khách Hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTenKH.Location = new System.Drawing.Point(160, 64);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(187, 22);
            this.txtTenKH.TabIndex = 3;
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
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaKH.Location = new System.Drawing.Point(160, 29);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(187, 22);
            this.txtMaKH.TabIndex = 1;
            // 
            // uscKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlKhachHang);
            this.Name = "uscKhachHang";
            this.Size = new System.Drawing.Size(1044, 723);
            this.pnlKhachHang.ResumeLayout(false);
            this.pnlTacVuKH.ResumeLayout(false);
            this.pnlHienThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.pnlSearchKH.ResumeLayout(false);
            this.pnlSearchKH.PerformLayout();
            this.pnlQuanLiKH.ResumeLayout(false);
            this.pnlQuanLiKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKhachHang;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.Button btnDeleteKH;
        private System.Windows.Forms.Button btnEditKH;
        private System.Windows.Forms.Panel pnlSearchKH;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlHienThi;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Panel pnlTacVuKH;
        private readonly EventHandler USCKhachHang_Load;
        private System.Windows.Forms.Panel pnlQuanLiKH;
        private System.Windows.Forms.RadioButton rdbKHNu;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdbKHNam;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblThongTinKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtMaKH;
    }
}
