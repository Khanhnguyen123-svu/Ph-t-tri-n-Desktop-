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
    public partial class uscNhanVien : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True");
        SqlCommand command;
        String str = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public uscNhanVien()
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
                command.CommandText = "SELECT * FROM NhanVien";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: ", "Thông báo" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string query = "SELECT * FROM NhanVien WHERE MaNhanVien LIKE @keyword OR TenNhanVien LIKE @keyword";
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

                        dgvNhanVien.DataSource = searchTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thực thi truy vấn SQL: ", "Thông báo" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: ", "Thông báo" + ex.Message);
            }
        }
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvNhanVien.AutoGenerateColumns = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO NhanVien (MaNhanVien, TenNhanVien, SoDienThoai, Email, DiaChi, NgaySinh, GioiTinh, VaiTro) " +
                  "VALUES (@MaNhanVien, @TenNhanVien, @SoDienThoai, @Email, @DiaChi, @NgaySinh, @GioiTinh, @VaiTro)";
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
                        command.Parameters.AddWithValue("@GioiTinh", rdbNam.Checked ? "Nam" : "Nữ");
                        command.Parameters.AddWithValue("@VaiTro", rdbNhanVien.Checked ? "Nhân viên" : "Quản lý");
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: ", "Thông báo" + ex.Message);
            }
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            rdbNhanVien.Checked = false;
            rdbQuanLi.Checked = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string query = "UPDATE NhanVien SET TenNhanVien = @TenNhanVien, SoDienThoai = @SoDienThoai, " +
                   "Email = @Email, DiaChi = @DiaChi, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, VaiTro = @VaiTro " +
                   "WHERE MaNhanVien = @MaNhanVien";
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
                        command.Parameters.AddWithValue("@GioiTinh", rdbNam.Checked ? "Nam" : "Nữ");
                        command.Parameters.AddWithValue("@VaiTro", rdbNhanVien.Checked ? "Nhân viên" : "Quản lý");
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa nhân viên: ", "Thông báo" + ex.Message);
            }
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            rdbNhanVien.Checked = false;
            rdbQuanLi.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa từ bảng!", "Thông báo");
                return;
            }
            string maNhanVien = dgvNhanVien.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            string query = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên để xóa!", "Thông báo");
                        }
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: ", "Thông báo" + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
