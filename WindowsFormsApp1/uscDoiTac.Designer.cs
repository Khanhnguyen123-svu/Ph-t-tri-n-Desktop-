using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class uscDoiTac
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
            this.pnlDoiTac = new System.Windows.Forms.Panel();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.pnlTacVuNV = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongMua = new System.Windows.Forms.TextBox();
            this.txtNoCanTra = new System.Windows.Forms.TextBox();
            this.lblSoNo = new System.Windows.Forms.Label();
            this.lblTongMua = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblSoLuongSP = new System.Windows.Forms.Label();
            this.dtpNCC = new System.Windows.Forms.DateTimePicker();
            this.lblHSD = new System.Windows.Forms.Label();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.pnlHienThi = new System.Windows.Forms.Panel();
            this.pnlDoiTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.pnlTacVuNV.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlThongTin.SuspendLayout();
            this.pnlHienThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDoiTac
            // 
            this.pnlDoiTac.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlDoiTac.Controls.Add(this.pnlHienThi);
            this.pnlDoiTac.Controls.Add(this.pnlTacVuNV);
            this.pnlDoiTac.Controls.Add(this.panel2);
            this.pnlDoiTac.Controls.Add(this.pnlThongTin);
            this.pnlDoiTac.Location = new System.Drawing.Point(0, 0);
            this.pnlDoiTac.Name = "pnlDoiTac";
            this.pnlDoiTac.Size = new System.Drawing.Size(1043, 793);
            this.pnlDoiTac.TabIndex = 0;
            this.pnlDoiTac.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDoiTac_Paint);
            // 
            // dgvNCC
            // 
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvNCC.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNCC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNCC.Location = new System.Drawing.Point(0, 3);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 60;
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.Size = new System.Drawing.Size(1016, 442);
            this.dgvNCC.TabIndex = 40;
            this.dgvNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellContentClick_1);
            // 
            // pnlTacVuNV
            // 
            this.pnlTacVuNV.Controls.Add(this.btnSave);
            this.pnlTacVuNV.Controls.Add(this.btnEdit);
            this.pnlTacVuNV.Controls.Add(this.btnDelete);
            this.pnlTacVuNV.Controls.Add(this.btnAdd);
            this.pnlTacVuNV.Location = new System.Drawing.Point(579, 191);
            this.pnlTacVuNV.Name = "pnlTacVuNV";
            this.pnlTacVuNV.Size = new System.Drawing.Size(461, 62);
            this.pnlTacVuNV.TabIndex = 39;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(360, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 49);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkGray;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(248, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 49);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(135, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 49);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(24, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 49);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(3, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 62);
            this.panel2.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(369, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 49);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearch.Location = new System.Drawing.Point(23, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(329, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.Controls.Add(this.txtMaNCC);
            this.pnlThongTin.Controls.Add(this.lblMaNCC);
            this.pnlThongTin.Controls.Add(this.txtEmail);
            this.pnlThongTin.Controls.Add(this.label1);
            this.pnlThongTin.Controls.Add(this.txtTongMua);
            this.pnlThongTin.Controls.Add(this.txtNoCanTra);
            this.pnlThongTin.Controls.Add(this.lblSoNo);
            this.pnlThongTin.Controls.Add(this.lblTongMua);
            this.pnlThongTin.Controls.Add(this.txtDiaChi);
            this.pnlThongTin.Controls.Add(this.txtSDT);
            this.pnlThongTin.Controls.Add(this.lblSDT);
            this.pnlThongTin.Controls.Add(this.lblSoLuongSP);
            this.pnlThongTin.Controls.Add(this.dtpNCC);
            this.pnlThongTin.Controls.Add(this.lblHSD);
            this.pnlThongTin.Controls.Add(this.txtNCC);
            this.pnlThongTin.Controls.Add(this.lblTenNCC);
            this.pnlThongTin.Controls.Add(this.lblNhaCungCap);
            this.pnlThongTin.Location = new System.Drawing.Point(3, 0);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(1037, 185);
            this.pnlThongTin.TabIndex = 1;
            this.pnlThongTin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThongTin_Paint);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaNCC.Location = new System.Drawing.Point(173, 93);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(195, 22);
            this.txtMaNCC.TabIndex = 42;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMaNCC.Location = new System.Drawing.Point(20, 98);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(134, 18);
            this.lblMaNCC.TabIndex = 41;
            this.lblMaNCC.Text = "Mã Nhà Cung Cấp:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.Location = new System.Drawing.Point(824, 49);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 22);
            this.txtEmail.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(731, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Email:";
            // 
            // txtTongMua
            // 
            this.txtTongMua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTongMua.Location = new System.Drawing.Point(520, 47);
            this.txtTongMua.Name = "txtTongMua";
            this.txtTongMua.Size = new System.Drawing.Size(195, 22);
            this.txtTongMua.TabIndex = 38;
            // 
            // txtNoCanTra
            // 
            this.txtNoCanTra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNoCanTra.Location = new System.Drawing.Point(520, 93);
            this.txtNoCanTra.Name = "txtNoCanTra";
            this.txtNoCanTra.Size = new System.Drawing.Size(195, 22);
            this.txtNoCanTra.TabIndex = 37;
            // 
            // lblSoNo
            // 
            this.lblSoNo.AutoSize = true;
            this.lblSoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSoNo.Location = new System.Drawing.Point(399, 93);
            this.lblSoNo.Name = "lblSoNo";
            this.lblSoNo.Size = new System.Drawing.Size(112, 18);
            this.lblSoNo.TabIndex = 36;
            this.lblSoNo.Text = "Số Nợ Cần Trả:";
            // 
            // lblTongMua
            // 
            this.lblTongMua.AutoSize = true;
            this.lblTongMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongMua.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTongMua.Location = new System.Drawing.Point(399, 48);
            this.lblTongMua.Name = "lblTongMua";
            this.lblTongMua.Size = new System.Drawing.Size(79, 18);
            this.lblTongMua.TabIndex = 32;
            this.lblTongMua.Text = "Tổng Mua:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDiaChi.Location = new System.Drawing.Point(520, 142);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(195, 22);
            this.txtDiaChi.TabIndex = 35;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSDT.Location = new System.Drawing.Point(173, 142);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(195, 22);
            this.txtSDT.TabIndex = 34;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSDT.Location = new System.Drawing.Point(20, 142);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(98, 18);
            this.lblSDT.TabIndex = 33;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblSoLuongSP
            // 
            this.lblSoLuongSP.AutoSize = true;
            this.lblSoLuongSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongSP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSoLuongSP.Location = new System.Drawing.Point(399, 146);
            this.lblSoLuongSP.Name = "lblSoLuongSP";
            this.lblSoLuongSP.Size = new System.Drawing.Size(60, 18);
            this.lblSoLuongSP.TabIndex = 23;
            this.lblSoLuongSP.Text = "Địa Chỉ:";
            // 
            // dtpNCC
            // 
            this.dtpNCC.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNCC.CustomFormat = "dd/MM/yyyy";
            this.dtpNCC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNCC.Location = new System.Drawing.Point(824, 98);
            this.dtpNCC.Name = "dtpNCC";
            this.dtpNCC.Size = new System.Drawing.Size(195, 22);
            this.dtpNCC.TabIndex = 26;
            // 
            // lblHSD
            // 
            this.lblHSD.AutoSize = true;
            this.lblHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSD.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHSD.Location = new System.Drawing.Point(731, 102);
            this.lblHSD.Name = "lblHSD";
            this.lblHSD.Size = new System.Drawing.Size(76, 18);
            this.lblHSD.TabIndex = 25;
            this.lblHSD.Text = "Ngày Tạo:";
            // 
            // txtNCC
            // 
            this.txtNCC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNCC.Location = new System.Drawing.Point(173, 49);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(195, 22);
            this.txtNCC.TabIndex = 29;
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNCC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTenNCC.Location = new System.Drawing.Point(17, 50);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(138, 18);
            this.lblTenNCC.TabIndex = 24;
            this.lblTenNCC.Text = "Tên Nhà Cung Cấp:";
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCungCap.Location = new System.Drawing.Point(16, 0);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(141, 22);
            this.lblNhaCungCap.TabIndex = 0;
            this.lblNhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // pnlHienThi
            // 
            this.pnlHienThi.Controls.Add(this.dgvNCC);
            this.pnlHienThi.Location = new System.Drawing.Point(3, 259);
            this.pnlHienThi.Name = "pnlHienThi";
            this.pnlHienThi.Size = new System.Drawing.Size(1019, 449);
            this.pnlHienThi.TabIndex = 41;
            // 
            // uscDoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDoiTac);
            this.Name = "uscDoiTac";
            this.Size = new System.Drawing.Size(1043, 792);
            this.pnlDoiTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.pnlTacVuNV.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            this.pnlHienThi.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel pnlDoiTac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlTacVuNV;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.TextBox txtTongMua;
        private System.Windows.Forms.TextBox txtNoCanTra;
        private System.Windows.Forms.Label lblSoNo;
        private System.Windows.Forms.Label lblTongMua;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblSoLuongSP;
        private System.Windows.Forms.DateTimePicker dtpNCC;
        private System.Windows.Forms.Label lblHSD;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblNhaCungCap;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtMaNCC;
        private Label lblMaNCC;
        private Panel pnlHienThi;
    }
}
