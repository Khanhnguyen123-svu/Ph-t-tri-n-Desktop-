using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{
    public partial class fDangNhap : Form
    {


        public fDangNhap()
        {
            InitializeComponent();


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
          fTableManager trangchu = new fTableManager();
            
            string tenDangNhap = txtAccount.Text;
            string matKhau = txtPassword.Text;

            
            fTableManager f = new fTableManager();

            if (txtAccount.Text == "")
                MessageBox.Show("Vui lòng nhập thông tin tài khoản", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error  );
            else
            {

                
                f.ShowDialog();
                this.Show();
            }
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDangKy dangki = new fDangKy();
            dangki.ShowDialog();
            this.Show();
            
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void cbLuuMK_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtAccount.Text;
            string matKhau = txtPassword.Text;
            fBanHang BanHang = new fBanHang();
             if (txtAccount.Text == "")
                MessageBox.Show("Vui lòng nhập thông tin tài khoản", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            else
            {
                BanHang.ShowDialog();
                this.Show();
                this.Hide();
            }

        }
    }
}


