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
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True");
        SqlCommand command;
        String str = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
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
            string vaiTro = "";
            if (rdbQuanLi.Checked)
            {
                vaiTro = "Quản lý";
            }
            else if (rdbNhanVien.Checked)
            {
                vaiTro = "Nhân viên";
            }

            if (string.IsNullOrEmpty(vaiTro))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, XacNhanMatKhau, VaiTro) VALUES (@TenDangNhap, @MatKhau, @XacNhanMatKhau, @VaiTro)";

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);
                        command.Parameters.AddWithValue("@XacNhanMatKhau", xacNhanMatKhau);
                        command.Parameters.AddWithValue("@VaiTro", vaiTro);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký tài khoản: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            fDangNhap dangnhap = new fDangNhap();
            dangnhap.Show();

            
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

