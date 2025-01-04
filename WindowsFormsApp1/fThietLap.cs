using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fThietLap : Form
    {
        SqlConnection connection =  new SqlConnection("Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True");
        SqlCommand command;
        String str = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public fThietLap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThietLap_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhauHienTai = txtMatKhau.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text.Trim();
            string sodienthoai = txtSDT.Text.Trim();

            if (matKhauMoi != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không khớp!", "Thông báo");
                return;
            }

            try
            {
                connection.Open();
                string queryCheck = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                SqlCommand cmdCheck = new SqlCommand(queryCheck, connection);
                cmdCheck.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmdCheck.Parameters.AddWithValue("@MatKhau", matKhauHienTai);

                int count = (int)cmdCheck.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu hiện tại không đúng!", "Thông báo");
                    return;
                }
                string queryUpdate = "UPDATE TaiKhoan SET MatKhau = @MatKhauMoi WHERE TenDangNhap = @TenDangNhap";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, connection);
                cmdUpdate.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmdUpdate.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);

                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo");
                ClearThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
            finally
            {
                connection.Close();
            }
       
    }
        private void ClearThongTin()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtMatKhauMoi.Clear();
            txtNhapLaiMatKhau.Clear();
            txtSDT.Clear();
        }
    }
}
