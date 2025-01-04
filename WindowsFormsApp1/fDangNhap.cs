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
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class fDangNhap : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True");
        SqlCommand command;
        String str = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public string VaiTro { get; set; }
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
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT VaiTro FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);

                        object result = command.ExecuteScalar();

                        if (result != null) 
                        {
                            string vaiTro = result.ToString();

                            if (vaiTro == "Quản lý")
                            {
                                MessageBox.Show("Đăng nhập thành công với vai trò Quản lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                
                                fTableManager formQL = new fTableManager(vaiTro)
                                {
                                    VaiTro = vaiTro
                                };
                                formQL.Show();
                                
                                this.Hide();
                            }
                            else if (vaiTro == "Nhân viên")
                            {
                                MessageBox.Show("Đăng nhập thành công với vai trò Nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                fTableManager formNV = new fTableManager(vaiTro)
                                {
                                    VaiTro = vaiTro
                                };
                                formNV.Show();
                               
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Vai trò không được hỗ trợ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else 
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            string query = "SELECT VaiTro FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);

                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            string vaiTro = result.ToString();

                            if (vaiTro == "Nhân viên" || vaiTro == "Quản lý")
                            {
                                MessageBox.Show("Đăng nhập thành công vào hệ thống bán hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fBanHang formBH = new fBanHang();
                                formBH.Show();
                                this.Hide();  
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập đúng tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}


