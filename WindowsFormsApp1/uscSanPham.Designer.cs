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
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.dtpHSDSP = new System.Windows.Forms.DateTimePicker();
            this.nudSoLuongSP = new System.Windows.Forms.NumericUpDown();
            this.pnlSearchSP = new System.Windows.Forms.Panel();
            this.btnSearchSP = new System.Windows.Forms.Button();
            this.txtSearchSP = new System.Windows.Forms.TextBox();
            this.pnlTacVuSP = new System.Windows.Forms.Panel();
            this.btnUpDateSP = new System.Windows.Forms.Button();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.btnDeleteSP = new System.Windows.Forms.Button();
            this.btnSaveSP = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongSP)).BeginInit();
            this.pnlSearchSP.SuspendLayout();
            this.pnlTacVuSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
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
            this.panel4.Size = new System.Drawing.Size(1009, 162);
            this.panel4.TabIndex = 5;
            // 
            // dtpNNSP
            // 
            this.dtpNNSP.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNNSP.CustomFormat = "dd/MM/yyyy";
            this.dtpNNSP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNNSP.Location = new System.Drawing.Point(667, 71);
            this.dtpNNSP.Name = "dtpNNSP";
            this.dtpNNSP.Size = new System.Drawing.Size(202, 22);
            this.dtpNNSP.TabIndex = 20;
            // 
            // lblHSD
            // 
            this.lblHSD.AutoSize = true;
            this.lblHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSD.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHSD.Location = new System.Drawing.Point(470, 112);
            this.lblHSD.Name = "lblHSD";
            this.lblHSD.Size = new System.Drawing.Size(125, 23);
            this.lblHSD.TabIndex = 19;
            this.lblHSD.Text = "Hạn Sử Dụng:";
            // 
            // lblNgayNhapSP
            // 
            this.lblNgayNhapSP.AutoSize = true;
            this.lblNgayNhapSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhapSP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNgayNhapSP.Location = new System.Drawing.Point(470, 71);
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
            this.lblQuanLiSP.Size = new System.Drawing.Size(213, 25);
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
            this.lblSoLuongSP.Location = new System.Drawing.Point(470, 30);
            this.lblSoLuongSP.Name = "lblSoLuongSP";
            this.lblSoLuongSP.Size = new System.Drawing.Size(186, 23);
            this.lblSoLuongSP.TabIndex = 4;
            this.lblSoLuongSP.Text = "Số Lượng Sản Phẩm:";
            // 
            // dtpHSDSP
            // 
            this.dtpHSDSP.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dtpHSDSP.CustomFormat = "dd/MM/yyyy";
            this.dtpHSDSP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHSDSP.Location = new System.Drawing.Point(667, 112);
            this.dtpHSDSP.Name = "dtpHSDSP";
            this.dtpHSDSP.Size = new System.Drawing.Size(202, 22);
            this.dtpHSDSP.TabIndex = 21;
            // 
            // nudSoLuongSP
            // 
            this.nudSoLuongSP.Location = new System.Drawing.Point(667, 28);
            this.nudSoLuongSP.Name = "nudSoLuongSP";
            this.nudSoLuongSP.Size = new System.Drawing.Size(90, 22);
            this.nudSoLuongSP.TabIndex = 22;
            // 
            // pnlSearchSP
            // 
            this.pnlSearchSP.Controls.Add(this.btnSearchSP);
            this.pnlSearchSP.Controls.Add(this.txtSearchSP);
            this.pnlSearchSP.Location = new System.Drawing.Point(3, 171);
            this.pnlSearchSP.Name = "pnlSearchSP";
            this.pnlSearchSP.Size = new System.Drawing.Size(481, 62);
            this.pnlSearchSP.TabIndex = 6;
            // 
            // btnSearchSP
            // 
            this.btnSearchSP.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearchSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchSP.Location = new System.Drawing.Point(373, 5);
            this.btnSearchSP.Name = "btnSearchSP";
            this.btnSearchSP.Size = new System.Drawing.Size(83, 49);
            this.btnSearchSP.TabIndex = 12;
            this.btnSearchSP.Text = "Tìm kiếm";
            this.btnSearchSP.UseVisualStyleBackColor = false;
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
            this.pnlTacVuSP.Controls.Add(this.btnSaveSP);
            this.pnlTacVuSP.Location = new System.Drawing.Point(530, 171);
            this.pnlTacVuSP.Name = "pnlTacVuSP";
            this.pnlTacVuSP.Size = new System.Drawing.Size(482, 62);
            this.pnlTacVuSP.TabIndex = 8;
            // 
            // btnUpDateSP
            // 
            this.btnUpDateSP.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpDateSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpDateSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpDateSP.Location = new System.Drawing.Point(267, 5);
            this.btnUpDateSP.Name = "btnUpDateSP";
            this.btnUpDateSP.Size = new System.Drawing.Size(83, 49);
            this.btnUpDateSP.TabIndex = 12;
            this.btnUpDateSP.Text = "Sửa";
            this.btnUpDateSP.UseVisualStyleBackColor = false;
            // 
            // btnAddSP
            // 
            this.btnAddSP.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddSP.Location = new System.Drawing.Point(53, 5);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(83, 49);
            this.btnAddSP.TabIndex = 11;
            this.btnAddSP.Text = "Thêm";
            this.btnAddSP.UseVisualStyleBackColor = false;
            this.btnAddSP.Click += new System.EventHandler(this.btnAddSP_Click);
            // 
            // btnDeleteSP
            // 
            this.btnDeleteSP.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteSP.Location = new System.Drawing.Point(164, 5);
            this.btnDeleteSP.Name = "btnDeleteSP";
            this.btnDeleteSP.Size = new System.Drawing.Size(83, 49);
            this.btnDeleteSP.TabIndex = 12;
            this.btnDeleteSP.Text = "Xóa";
            this.btnDeleteSP.UseVisualStyleBackColor = false;
            // 
            // btnSaveSP
            // 
            this.btnSaveSP.BackColor = System.Drawing.Color.DarkGray;
            this.btnSaveSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveSP.Location = new System.Drawing.Point(372, 5);
            this.btnSaveSP.Name = "btnSaveSP";
            this.btnSaveSP.Size = new System.Drawing.Size(83, 49);
            this.btnSaveSP.TabIndex = 13;
            this.btnSaveSP.Text = "Lưu";
            this.btnSaveSP.UseVisualStyleBackColor = false;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSanPham.Location = new System.Drawing.Point(21, 239);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 60;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(997, 220);
            this.dgvSanPham.TabIndex = 9;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // uscSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.pnlTacVuSP);
            this.Controls.Add(this.pnlSearchSP);
            this.Controls.Add(this.panel4);
            this.Name = "uscSanPham";
            this.Size = new System.Drawing.Size(1034, 731);
            this.Load += new System.EventHandler(this.uscSanPham_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongSP)).EndInit();
            this.pnlSearchSP.ResumeLayout(false);
            this.pnlSearchSP.PerformLayout();
            this.pnlTacVuSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
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
        private System.Windows.Forms.Button btnSaveSP;
        private System.Windows.Forms.DataGridView dgvSanPham;
    }
}
