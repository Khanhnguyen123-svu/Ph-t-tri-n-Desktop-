namespace WindowsFormsApp1
{
    partial class uscThongKe
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
            this.pnlThongKe = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblLoc = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlDoanhThu = new System.Windows.Forms.Panel();
            this.dgvTongTien = new System.Windows.Forms.DataGridView();
            this.pnlThongKe.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlThongKe.Controls.Add(this.pnlDoanhThu);
            this.pnlThongKe.Controls.Add(this.panel1);
            this.pnlThongKe.Location = new System.Drawing.Point(0, 0);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(1043, 732);
            this.pnlThongKe.TabIndex = 0;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(744, 48);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(74, 18);
            this.lblTongTien.TabIndex = 5;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTongTien);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.lblLoc);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblThongKe);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 94);
            this.panel1.TabIndex = 0;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(848, 47);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(174, 22);
            this.txtTongTien.TabIndex = 4;
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.Location = new System.Drawing.Point(406, 48);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(109, 18);
            this.lblLoc.TabIndex = 3;
            this.lblLoc.Text = "Lọc Theo Ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(542, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Location = new System.Drawing.Point(281, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 46);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKe.Location = new System.Drawing.Point(16, 0);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(185, 20);
            this.lblThongKe.TabIndex = 1;
            this.lblThongKe.Text = "Thống Kê Doanh Thu";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(238, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlDoanhThu
            // 
            this.pnlDoanhThu.Controls.Add(this.dgvTongTien);
            this.pnlDoanhThu.Location = new System.Drawing.Point(3, 100);
            this.pnlDoanhThu.Name = "pnlDoanhThu";
            this.pnlDoanhThu.Size = new System.Drawing.Size(1010, 604);
            this.pnlDoanhThu.TabIndex = 1;
            // 
            // dgvTongTien
            // 
            this.dgvTongTien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTongTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongTien.Location = new System.Drawing.Point(3, 3);
            this.dgvTongTien.Name = "dgvTongTien";
            this.dgvTongTien.RowHeadersWidth = 51;
            this.dgvTongTien.RowTemplate.Height = 24;
            this.dgvTongTien.Size = new System.Drawing.Size(1004, 598);
            this.dgvTongTien.TabIndex = 0;
            this.dgvTongTien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTongTien_CellContentClick);
            // 
            // uscThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlThongKe);
            this.Name = "uscThongKe";
            this.Size = new System.Drawing.Size(1043, 732);
            this.pnlThongKe.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Panel pnlDoanhThu;
        private System.Windows.Forms.DataGridView dgvTongTien;
    }
}
