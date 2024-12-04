using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class fDangKy : Form
    {
        public fDangKy()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
             string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            string xacNhanMatKhau = txtXacNhanMatKhau.Text;
            string email = txtEmail.Text;
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
           string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
           string.IsNullOrWhiteSpace(txtXacNhanMatKhau.Text) ||
           string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }   
            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            fDangNhap dangnhap = new fDangNhap();
            dangnhap.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            lblErrorName.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            lblErrorPassword.Text = "";
          
        }

        private void txtXNPassword_Click(object sender, EventArgs e)
        {
            lblErrorXNPassword.Text = "";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            lblErrorEmail.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblDki_Click(object sender, EventArgs e)
        {

        }
    }
}

