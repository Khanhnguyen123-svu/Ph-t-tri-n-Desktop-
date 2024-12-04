namespace WindowsFormsApp1
{
    partial class uscTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uscTrangChu));
            this.pnlTrangChu = new System.Windows.Forms.Panel();
            this.btnEmail = new System.Windows.Forms.Button();
            this.pnlTopSP = new System.Windows.Forms.Panel();
            this.pnlTopSPBanChay = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayTopSP = new System.Windows.Forms.DateTimePicker();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlBieuDoDoanhThu = new System.Windows.Forms.Panel();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lblTenBieuDo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTrangChu.SuspendLayout();
            this.pnlTopSP.SuspendLayout();
            this.pnlTopSPBanChay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.panel5.SuspendLayout();
            this.pnlBieuDoDoanhThu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTrangChu
            // 
            this.pnlTrangChu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTrangChu.Controls.Add(this.btnEmail);
            this.pnlTrangChu.Controls.Add(this.pnlTopSP);
            this.pnlTrangChu.Controls.Add(this.panel5);
            this.pnlTrangChu.Controls.Add(this.panel4);
            this.pnlTrangChu.Controls.Add(this.panel3);
            this.pnlTrangChu.Controls.Add(this.panel2);
            this.pnlTrangChu.Controls.Add(this.panel1);
            this.pnlTrangChu.Controls.Add(this.flowLayoutPanel1);
            this.pnlTrangChu.Location = new System.Drawing.Point(0, 0);
            this.pnlTrangChu.Name = "pnlTrangChu";
            this.pnlTrangChu.Size = new System.Drawing.Size(1031, 731);
            this.pnlTrangChu.TabIndex = 0;
            this.pnlTrangChu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTrangChu_Paint);
            // 
            // btnEmail
            // 
            this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
            this.btnEmail.Location = new System.Drawing.Point(936, 3);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(85, 47);
            this.btnEmail.TabIndex = 7;
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // pnlTopSP
            // 
            this.pnlTopSP.AccessibleName = "pnlBieuDo";
            this.pnlTopSP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTopSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopSP.Controls.Add(this.pnlTopSPBanChay);
            this.pnlTopSP.Location = new System.Drawing.Point(488, 198);
            this.pnlTopSP.Name = "pnlTopSP";
            this.pnlTopSP.Size = new System.Drawing.Size(540, 509);
            this.pnlTopSP.TabIndex = 6;
            // 
            // pnlTopSPBanChay
            // 
            this.pnlTopSPBanChay.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTopSPBanChay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopSPBanChay.Controls.Add(this.label1);
            this.pnlTopSPBanChay.Controls.Add(this.dtpNgayTopSP);
            this.pnlTopSPBanChay.Controls.Add(this.nudSoLuong);
            this.pnlTopSPBanChay.Location = new System.Drawing.Point(0, 0);
            this.pnlTopSPBanChay.Name = "pnlTopSPBanChay";
            this.pnlTopSPBanChay.Size = new System.Drawing.Size(544, 58);
            this.pnlTopSPBanChay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Top Sản Phẩm Bán Chạy";
            // 
            // dtpNgayTopSP
            // 
            this.dtpNgayTopSP.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTopSP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTopSP.Location = new System.Drawing.Point(355, 19);
            this.dtpNgayTopSP.Name = "dtpNgayTopSP";
            this.dtpNgayTopSP.Size = new System.Drawing.Size(166, 22);
            this.dtpNgayTopSP.TabIndex = 3;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(278, 19);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(45, 22);
            this.nudSoLuong.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.AccessibleName = "pnlBieuDo";
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pnlBieuDoDoanhThu);
            this.panel5.Location = new System.Drawing.Point(3, 198);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(479, 509);
            this.panel5.TabIndex = 5;
            // 
            // pnlBieuDoDoanhThu
            // 
            this.pnlBieuDoDoanhThu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlBieuDoDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBieuDoDoanhThu.Controls.Add(this.dtpNgayBD);
            this.pnlBieuDoDoanhThu.Controls.Add(this.lblTenBieuDo);
            this.pnlBieuDoDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.pnlBieuDoDoanhThu.Name = "pnlBieuDoDoanhThu";
            this.pnlBieuDoDoanhThu.Size = new System.Drawing.Size(479, 58);
            this.pnlBieuDoDoanhThu.TabIndex = 0;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(227, 15);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(186, 22);
            this.dtpNgayBD.TabIndex = 2;
            // 
            // lblTenBieuDo
            // 
            this.lblTenBieuDo.AutoSize = true;
            this.lblTenBieuDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBieuDo.Location = new System.Drawing.Point(18, 18);
            this.lblTenBieuDo.Name = "lblTenBieuDo";
            this.lblTenBieuDo.Size = new System.Drawing.Size(155, 18);
            this.lblTenBieuDo.TabIndex = 1;
            this.lblTenBieuDo.Text = "Biểu Đồ Doanh Thu";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(696, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 103);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(340, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 103);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 103);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblXinChao);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 80);
            this.panel1.TabIndex = 1;
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.Location = new System.Drawing.Point(18, 13);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(79, 18);
            this.lblXinChao.TabIndex = 0;
            this.lblXinChao.Text = "Xin chào:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1024, 355);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // uscTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTrangChu);
            this.Name = "uscTrangChu";
            this.Size = new System.Drawing.Size(1031, 731);
            this.pnlTrangChu.ResumeLayout(false);
            this.pnlTopSP.ResumeLayout(false);
            this.pnlTopSPBanChay.ResumeLayout(false);
            this.pnlTopSPBanChay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.panel5.ResumeLayout(false);
            this.pnlBieuDoDoanhThu.ResumeLayout(false);
            this.pnlBieuDoDoanhThu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTrangChu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.Panel pnlBieuDoDoanhThu;
        private System.Windows.Forms.Panel pnlTopSP;
        private System.Windows.Forms.Panel pnlTopSPBanChay;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label lblTenBieuDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.DateTimePicker dtpNgayTopSP;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
    }
}
