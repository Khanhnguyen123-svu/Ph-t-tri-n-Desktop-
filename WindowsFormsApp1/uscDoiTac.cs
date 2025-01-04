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
using DocumentFormat.OpenXml.Office2010.Drawing;

namespace WindowsFormsApp1
{
    public partial class uscDoiTac : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True");
        SqlCommand command;
        String str = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public uscDoiTac()
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
                command.CommandText = "SELECT * FROM DoiTac";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNCC.DataSource = table;

                if (dgvNCC.Columns["TongMua"] != null)
                {
                    dgvNCC.Columns["TongMua"].DefaultCellStyle.Format = "N0";
                    dgvNCC.Columns["TongMua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvNCC.Columns["NoCanTra"] != null)
                {
                    dgvNCC.Columns["NoCanTra"].DefaultCellStyle.Format = "N0";
                    dgvNCC.Columns["NoCanTra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
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
            string query = "SELECT * FROM NhaCungCap WHERE TenNCC LIKE @keyword";

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvNCC.DataSource = table;
                        if (dgvNCC.Columns["TongMua"] != null)
                        {
                            dgvNCC.Columns["TongMua"].DefaultCellStyle.Format = "N0";
                            dgvNCC.Columns["TongMua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        }
                        if (dgvNCC.Columns["NoCanTra"] != null)
                        {
                            dgvNCC.Columns["NoCanTra"].DefaultCellStyle.Format = "N0";
                            dgvNCC.Columns["NoCanTra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Thông báo");
            }
        }
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvNCC.AutoGenerateColumns = true;

        }

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNCC = dgvNCC.SelectedRows[0].Cells["MaNCC"].Value.ToString();
            string query = @"UPDATE DoiTac SET 
                             TenNCC = @TenNCC, SoDienThoai = @SoDienThoai, Email = @Email, DiaChi = @DiaChi, 
                             NgayTao = @NgayTao, NoCanTra = @NoCanTra, TongMua = @TongMua 
                             WHERE MaNCC = @MaNCC";

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNCC", maNCC);
                        command.Parameters.AddWithValue("@TenNCC", txtNCC.Text.Trim());
                        command.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text.Trim());
                        command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                        command.Parameters.AddWithValue("@NgayTao", dtpNCC.Value);
                        command.Parameters.AddWithValue("@NoCanTra", int.Parse(txtNoCanTra.Text.Trim()));
                        command.Parameters.AddWithValue("@TongMua", int.Parse(txtTongMua.Text.Trim()));
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Sửa thông tin nhà cung cấp thành công!", "Thông báo");
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa nhà cung cấp: " + ex.Message, "Thông báo");
            }


            txtNCC.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            dtpNCC.Value = DateTime.Now;
            txtNoCanTra.Clear();
            txtTongMua.Clear();
        }


        private void pnlThongTin_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dgvNCC_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dgvNCC.AutoGenerateColumns = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNCC.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                txtNCC.Text = row.Cells["TenNCC"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                dtpNCC.Text = row.Cells["NgayTao"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtNoCanTra.Text = row.Cells["NoCanTra"].Value.ToString();
                txtTongMua.Text = row.Cells["TongMua"].Value.ToString();
                dgvNCC.Columns["TongMua"].DefaultCellStyle.Format = "N0";
                dgvNCC.Columns["NoCanTra"].DefaultCellStyle.Format = "N0";

            }
        }
        private void pnlDoiTac_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string query = @"INSERT INTO DoiTac (TenNCC, SoDienThoai, Email, DiaChi, NgayTao, NoCanTra, TongMua, MaNCC) 
                             VALUES (@TenNCC, @SoDienThoai, @Email, @DiaChi, @NgayTao, @NoCanTra, @TongMua,@MaNCC)";
            if (txtMaNCC.Text == "" && txtDiaChi.Text == "" && txtEmail.Text == "" && txtSDT.Text == "" && txtNCC.Text == ""&&txtNoCanTra.Text ==""&&txtTongMua.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(str))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text.Trim());
                            command.Parameters.AddWithValue("@TenNCC", txtNCC.Text.Trim());
                            command.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text.Trim());
                            command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                            command.Parameters.AddWithValue("@NgayTao", dtpNCC.Value);
                            command.Parameters.AddWithValue("@NoCanTra", int.Parse(txtNoCanTra.Text.Trim()));
                            command.Parameters.AddWithValue("@TongMua", int.Parse(txtTongMua.Text.Trim()));
                            command.ExecuteNonQuery();

                        }
                    }
                        MessageBox.Show("Thêm đối tác thành công!", "Thông báo");
                        LoadData();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm nhân viên: ", "Thông báo" + ex.Message);
                }
            }

            txtNCC.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            dtpNCC.Value = DateTime.Now;
            txtNoCanTra.Clear();
            txtTongMua.Clear();

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string query = "SELECT * FROM DoiTac WHERE MaNCC LIKE @keyword OR TenNCC LIKE @keyword";
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

                        dgvNCC.DataSource = searchTable;
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

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            string query = "UPDATE DoiTac " +
                   "SET TenNCC = @TenNCC, SoDienThoai = @SoDienThoai, Email = @Email, " +
                   "DiaChi = @DiaChi, NgayTao = @NgayTao, NoCanTra = @NoCanTra, TongMua = @TongMua " +
                   "WHERE MaNCC = @MaNCC";
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text.Trim());
                        command.Parameters.AddWithValue("@TenNCC", txtNCC.Text.Trim());
                        command.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text.Trim());
                        command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                        command.Parameters.AddWithValue("@NgayTao", dtpNCC.Value);
                        command.Parameters.AddWithValue("@NoCanTra", int.Parse(txtNoCanTra.Text.Trim()));
                        command.Parameters.AddWithValue("@TongMua", int.Parse(txtTongMua.Text.Trim()));
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
            txtNCC.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            dtpNCC.Value = DateTime.Now;
            txtNoCanTra.Clear();
            txtTongMua.Clear();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa từ bảng!", "Thông báo");
                return;
            }
            string maNCC = dgvNCC.SelectedRows[0].Cells["MaNCC"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            string query = "DELETE FROM DoiTac WHERE MaNCC = @MaNCC";

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNCC", maNCC);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhà cung cấp để xóa!", "Thông báo");
                        }
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhà cung cấp: ", "Thông báo" + ex.Message);
            }
        }
    }
    }

