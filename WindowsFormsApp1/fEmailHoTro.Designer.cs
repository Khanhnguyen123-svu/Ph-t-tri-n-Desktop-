namespace WindowsFormsApp1
{
    partial class fEmailHoTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEmailHoTro));
            this.pnlEmailHoTro = new System.Windows.Forms.Panel();
            this.pnlThongTinLienHe = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblHoTro = new System.Windows.Forms.Label();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.lblTenEmail = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoHotline = new System.Windows.Forms.Label();
            this.lblHotline = new System.Windows.Forms.Label();
            this.lblThongTinLienHe = new System.Windows.Forms.Label();
            this.pnlEmailHoTro.SuspendLayout();
            this.pnlThongTinLienHe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmailHoTro
            // 
            this.pnlEmailHoTro.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlEmailHoTro.Controls.Add(this.pnlThongTinLienHe);
            this.pnlEmailHoTro.Location = new System.Drawing.Point(-1, -2);
            this.pnlEmailHoTro.Name = "pnlEmailHoTro";
            this.pnlEmailHoTro.Size = new System.Drawing.Size(698, 517);
            this.pnlEmailHoTro.TabIndex = 0;
            // 
            // pnlThongTinLienHe
            // 
            this.pnlThongTinLienHe.Controls.Add(this.btnSend);
            this.pnlThongTinLienHe.Controls.Add(this.txtMessage);
            this.pnlThongTinLienHe.Controls.Add(this.lblHoTro);
            this.pnlThongTinLienHe.Controls.Add(this.lsvMessage);
            this.pnlThongTinLienHe.Controls.Add(this.lblTenEmail);
            this.pnlThongTinLienHe.Controls.Add(this.lblEmail);
            this.pnlThongTinLienHe.Controls.Add(this.lblSoHotline);
            this.pnlThongTinLienHe.Controls.Add(this.lblHotline);
            this.pnlThongTinLienHe.Controls.Add(this.lblThongTinLienHe);
            this.pnlThongTinLienHe.Location = new System.Drawing.Point(0, 3);
            this.pnlThongTinLienHe.Name = "pnlThongTinLienHe";
            this.pnlThongTinLienHe.Size = new System.Drawing.Size(695, 514);
            this.pnlThongTinLienHe.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(471, 313);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(83, 42);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(17, 313);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(436, 42);
            this.txtMessage.TabIndex = 7;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // lblHoTro
            // 
            this.lblHoTro.AutoSize = true;
            this.lblHoTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTro.Location = new System.Drawing.Point(13, 129);
            this.lblHoTro.Name = "lblHoTro";
            this.lblHoTro.Size = new System.Drawing.Size(155, 20);
            this.lblHoTro.TabIndex = 6;
            this.lblHoTro.Text = "Hỗ Trợ Trực Tuyến:";
            // 
            // lsvMessage
            // 
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(17, 152);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(641, 155);
            this.lsvMessage.TabIndex = 5;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // lblTenEmail
            // 
            this.lblTenEmail.AutoSize = true;
            this.lblTenEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenEmail.Location = new System.Drawing.Point(75, 90);
            this.lblTenEmail.Name = "lblTenEmail";
            this.lblTenEmail.Size = new System.Drawing.Size(197, 20);
            this.lblTenEmail.TabIndex = 4;
            this.lblTenEmail.Text = "handymart@gmai.com.vn";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 90);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblSoHotline
            // 
            this.lblSoHotline.AutoSize = true;
            this.lblSoHotline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHotline.Location = new System.Drawing.Point(99, 50);
            this.lblSoHotline.Name = "lblSoHotline";
            this.lblSoHotline.Size = new System.Drawing.Size(99, 20);
            this.lblSoHotline.TabIndex = 2;
            this.lblSoHotline.Text = "0853230904";
            // 
            // lblHotline
            // 
            this.lblHotline.AutoSize = true;
            this.lblHotline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotline.Location = new System.Drawing.Point(13, 50);
            this.lblHotline.Name = "lblHotline";
            this.lblHotline.Size = new System.Drawing.Size(67, 20);
            this.lblHotline.TabIndex = 1;
            this.lblHotline.Text = "Hotline:";
            // 
            // lblThongTinLienHe
            // 
            this.lblThongTinLienHe.AutoSize = true;
            this.lblThongTinLienHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinLienHe.Location = new System.Drawing.Point(10, 8);
            this.lblThongTinLienHe.Name = "lblThongTinLienHe";
            this.lblThongTinLienHe.Size = new System.Drawing.Size(164, 20);
            this.lblThongTinLienHe.TabIndex = 0;
            this.lblThongTinLienHe.Text = "Thông Tin Liên Hệ";
            // 
            // fEmailHoTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 516);
            this.Controls.Add(this.pnlEmailHoTro);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fEmailHoTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEmailHoTro";
            this.Load += new System.EventHandler(this.fEmailHoTro_Load);
            this.pnlEmailHoTro.ResumeLayout(false);
            this.pnlThongTinLienHe.ResumeLayout(false);
            this.pnlThongTinLienHe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmailHoTro;
        private System.Windows.Forms.Panel pnlThongTinLienHe;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblHoTro;
        private System.Windows.Forms.ListView lsvMessage;
        private System.Windows.Forms.Label lblTenEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSoHotline;
        private System.Windows.Forms.Label lblHotline;
        private System.Windows.Forms.Label lblThongTinLienHe;
    }
}