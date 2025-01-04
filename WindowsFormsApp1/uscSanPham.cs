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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class uscSanPham : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True");
        SqlCommand command;
        String str = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public uscSanPham()
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
                command.CommandText = "SELECT * FROM SanPham";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvSanPham.DataSource = table;
                if (dgvSanPham.Columns["Gia"] != null)
                {
                    dgvSanPham.Columns["Gia"].DefaultCellStyle.Format = "N0"; 
                    dgvSanPham.Columns["Gia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
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


        private void uscSanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.AutoGenerateColumns = true;
            if (dgvSanPham.Columns["Gia"] != null)
            {
                dgvSanPham.Columns["Gia"].DefaultCellStyle.Format = "N0";
                dgvSanPham.Columns["Gia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSanPham.AutoGenerateColumns = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                txtDanhMuc.Text = row.Cells["MaDM"].Value.ToString();
                txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSanPham"].Value.ToString();
                txtMaSP.Text = row.Cells["MaSanPham"].Value.ToString();
                txtHinhAnh.Text = row.Cells["HinhAnh"].Value.ToString();
                txtGiaSP.Text = row.Cells["Gia"].Value.ToString();
                dtpNNSP.Text = row.Cells["NgayNhapHang"].Value.ToString();
                dtpHSDSP.Text = row.Cells["HanSuDung"].Value.ToString();
                nudSoLuongSP.Text = row.Cells["SoLuong"].Value.ToString();
                
                string imagePath = row.Cells["HinhAnh"].Value?.ToString();
                    try
                    {
                     
                        if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                        {
                            picHinhAnh.Image = System.Drawing.Image.FromFile(imagePath);
                            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage; 
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hình ảnh tại đường dẫn được cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            picHinhAnh.Image = null; 
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Không thể tải hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        picHinhAnh.Image = null; 
                    }
                }
            }            
        
        private void btnAddSP_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO SanPham (MaDM,TenSanPham, MaSanPham, Gia, SoLuong, NgayNhapHang, HanSuDung, MaNCC, HinhAnh) " +
                 "VALUES (@MaDM, @TenSanPham, @MaSanPham, @Gia, @SoLuong, @NgayNhapHang, @HanSuDung, @MaNCC, @HinhAnh)";
            if (txtDanhMuc.Text == "" && txtMaSP.Text == "" && txtTenSP.Text == "" && txtGiaSP.Text == "" && txtGiaSP.Text == ""  && nudSoLuongSP.Text == "" && txtMaNCC.Text == "" && txtHinhAnh.Text == "")
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
                            command.Parameters.AddWithValue("@MaDM", txtDanhMuc.Text);
                            command.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text);
                            command.Parameters.AddWithValue("@TenSanPham", txtTenSP.Text);
                            command.Parameters.AddWithValue("@MaSanPham", txtMaSP.Text);
                            command.Parameters.AddWithValue("@Gia", decimal.Parse(txtGiaSP.Text));
                            command.Parameters.AddWithValue("@SoLuong", int.Parse(nudSoLuongSP.Text));
                            command.Parameters.AddWithValue("@HinhAnh", txtHinhAnh.Text);
                            command.Parameters.AddWithValue("@NgayNhapHang", dtpNNSP.Value);
                            command.Parameters.AddWithValue("@HanSuDung", dtpHSDSP.Value);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm sản phẩm: ", "Thông báo" + ex.Message);
                }
            }

            txtTenSP.Clear();
            txtMaNCC.Clear();
            txtMaSP.Clear();
            txtGiaSP.Clear();
            txtDanhMuc.Clear();
            txtHinhAnh.Clear();
            nudSoLuongSP.Value = 0;
            dtpNNSP.Value = DateTime.Now;
            dtpHSDSP.Value = DateTime.Now;
            picHinhAnh.Image = null;
        }

        private void btnDeleteSP_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa từ bảng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            string maSanPham = dgvSanPham.SelectedRows[0].Cells["MaSanPham"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            string query = "DELETE FROM SanPham WHERE MaSanPham = @MaSanPham";

            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSanPham", maSanPham);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: ", "Thông báo" + ex.Message);
            }
        }

        private void btnSearchSP_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchSP.Text.Trim();
            string query = "SELECT * FROM SanPham WHERE MaSanPham LIKE @keyword OR TenSanPham LIKE @keyword";
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

                        dgvSanPham.DataSource = searchTable;
                        if (dgvSanPham.Columns["Gia"] != null)
                        {
                            dgvSanPham.Columns["Gia"].DefaultCellStyle.Format = "N0"; 
                            dgvSanPham.Columns["Gia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        }
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

        private void btnChonTep_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = openFileDialog1.Filter = "PNG files (*.png)|*.png|All flies(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.ImageLocation = openFileDialog1.FileName;
                txtHinhAnh.Text = openFileDialog1.FileName;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nudSoLuongSP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpDateSP_Click(object sender, EventArgs e)
        {
            string query = "UPDATE SanPham SET MaDM = @MaDM, TenSanPham = @TenSanPham, " +
                   "Gia = @Gia, SoLuong = @SoLuong, NgayNhapHang = @NgayNhapHang, MaNCC = @MaNCC, " +
                   "HanSuDung = @HanSuDung, HinhAnh = @HinhAnh WHERE MaSanPham = @MaSanPham";
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin sản phẩm cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                            command.Parameters.AddWithValue("@MaDM", txtDanhMuc.Text);
                            command.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text);
                            command.Parameters.AddWithValue("@TenSanPham", txtTenSP.Text);
                            command.Parameters.AddWithValue("@MaSanPham", txtMaSP.Text);
                            command.Parameters.AddWithValue("@Gia", decimal.Parse(txtGiaSP.Text));
                            command.Parameters.AddWithValue("@SoLuong", int.Parse(nudSoLuongSP.Text));
                            
                            command.Parameters.AddWithValue("@NgayNhapHang", dtpNNSP.Value);
                            command.Parameters.AddWithValue("@HanSuDung", dtpHSDSP.Value);
                            string hinhAnh = string.IsNullOrEmpty(txtHinhAnh.Text) ? DBNull.Value.ToString() : txtHinhAnh.Text;
                            command.Parameters.AddWithValue("@HinhAnh", hinhAnh);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Sửa thông tin sản phẩm thành công!", "Thông báo");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa sản phẩm: ", "Thông báo" + ex.Message);
                }
            }

            txtTenSP.Clear();
            txtMaNCC.Clear();
            txtMaSP.Clear();
            txtGiaSP.Clear();
            txtDanhMuc.Clear();
            txtHinhAnh.Clear();
            nudSoLuongSP.Value = 0;
            dtpNNSP.Value = DateTime.Now;
            dtpHSDSP.Value = DateTime.Now;
            picHinhAnh.Image = null;
        }
    }
    }

