using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class uscKhachHang : UserControl
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True");
        SqlCommand command;
        String str = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public uscKhachHang()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM KhachHang";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvKhachHang.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: ","Thông báo" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void pnlKhachHang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string query = "SELECT * FROM KhachHang WHERE MaKhachHang LIKE @keyword OR TenNhanVien LIKE @keyword";
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        SqlDataAdapter searchAdapter = new SqlDataAdapter(command);
                        DataTable searchTable = new DataTable();
                        searchAdapter.Fill(searchTable);

                        dgvKhachHang.DataSource = searchTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thực thi truy vấn SQL: ","Thông báo" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: ","Thông báo" + ex.Message);
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = true;
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO KhachHang (MaKhachHang, TenKhachHang, SoDienThoai, Email, DiaChi, NgaySinh, GioiTinh) " +
                  "VALUES (@MaKhachHang, @TenKhachHang, @SoDienThoai, @Email, @DiaChi, @NgaySinh, @GioiTinh)";
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNhanVien", txtMaNV.Text);
                        command.Parameters.AddWithValue("@TenNhanVien", txtTenNV.Text);
                        command.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        command.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        command.Parameters.AddWithValue("@GioiTinh", rdbKHNam.Checked ? "Nam" : "Nữ");
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: ", "Thông báo" + ex.Message);
            }
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdbKHNam.Checked = false;
            rdbKHNu.Checked = false;
        }

        private void btnEditKH_Click(object sender, EventArgs e)
        {
            string query = "UPDATE KhachHang SET TenKhachHang = @TenKhachHang, SoDienThoai = @SoDienThoai, " +
                   "Email = @Email, DiaChi = @DiaChi, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh " +
                   "WHERE MaKhachHang = @MaKhachHang";
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNhanVien", txtMaNV.Text);
                        command.Parameters.AddWithValue("@TenNhanVien", txtTenNV.Text);
                        command.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        command.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        command.Parameters.AddWithValue("@GioiTinh", rdbKHNam.Checked ? "Nam" : "Nữ");
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Sửa thông tin khách hàng thành công!", "Thông báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa khách hàng: ", "Thông báo" + ex.Message);
            }
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdbKHNam.Checked = false;
            rdbKHNu.Checked = false;
        }

        private void btnDeleteKH_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa từ bảng!", "Thông báo");
                return;
            }
            string maKhachHang = dgvKhachHang.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            string query = "DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang";

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng để xóa!", "Thông báo");
                        }
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: ", "Thông báo" + ex.Message);
            }
        }

        private void btnSaveKH_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
