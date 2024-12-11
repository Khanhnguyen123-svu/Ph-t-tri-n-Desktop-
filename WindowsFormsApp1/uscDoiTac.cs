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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNCC = dgvNCC.SelectedRows[0].Cells["MaNCC"].Value.ToString();
            string query = "DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC";

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNCC", maNCC);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhà cung cấp: " + ex.Message, "Thông báo");
            }
        }


       
       

        private void pnlThongTin_Paint(object sender, PaintEventArgs e)
        {

        }
   
      

        private void dgvNCC_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dgvNCC.AutoGenerateColumns = true;

        }

        private void pnlDoiTac_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string query = @"INSERT INTO DoiTac (TenNCC, SoDienThoai, Email, DiaChi, NgayTao, NoCanTra, TongMua, MaNCC) 
                             VALUES (@TenNCC, @SoDienThoai, @Email, @DiaChi, @NgayTao, @NoCanTra, @TongMua,@MaNCC)";
            if (dgvNCC.SelectedRows.Count > 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin nhân viên cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                        LoadData();
                    }
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
    }
}
