namespace WindowsFormsApp1
{
    partial class ucCate
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
            this.picCate = new System.Windows.Forms.PictureBox();
            this.lblCate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCate)).BeginInit();
            this.SuspendLayout();
            // 
            // picCate
            // 
            this.picCate.BackColor = System.Drawing.SystemColors.Control;
            this.picCate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCate.Location = new System.Drawing.Point(3, 0);
            this.picCate.Name = "picCate";
            this.picCate.Size = new System.Drawing.Size(150, 88);
            this.picCate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCate.TabIndex = 0;
            this.picCate.TabStop = false;
            this.picCate.Click += new System.EventHandler(this.picCate_Click);
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(62, 100);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(16, 16);
            this.lblCate.TabIndex = 1;
            this.lblCate.Text = "...";
            this.lblCate.Click += new System.EventHandler(this.lblCate_Click);
            // 
            // ucCate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCate);
            this.Controls.Add(this.picCate);
            this.Name = "ucCate";
            this.Size = new System.Drawing.Size(156, 150);
            this.Load += new System.EventHandler(this.ucCate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCate;
        private System.Windows.Forms.Label lblCate;
    }
}
