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
    public partial class fBanHang : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True");
        SqlCommand command;
        String str = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

      


        private int trangHienTai = 1;
        private int soSanPhamMoiTrang = 6;
        private int tongSoTrang;

        public void AddProductToBill(string maSanPham, string tenSanPham, int gia, string hinhAnh)
        {
            bool isExist = false;
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells["MaSanPham"].Value?.ToString() == maSanPham)
                {
                    int currentQty = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    row.Cells["SoLuong"].Value = currentQty + 1; 
                    row.Cells["ThanhTien"].Value = (currentQty + 1) * gia; 
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                dgvHoaDon.Rows.Add(maSanPham, tenSanPham, gia, 1, gia);
            }
            UpdateTotal();
        }
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }
            txtTongHoaDon.Text = total.ToString("N0"); 
        }



        void LoadData_Cate()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string queryDanhMuc = "SELECT MaDM, TenDM FROM DanhMuc";
                SqlDataAdapter categoryAdapter = new SqlDataAdapter(queryDanhMuc, connection);
                DataTable categoryTable = new DataTable();
                categoryAdapter.Fill(categoryTable);
                cbLocSP.DataSource = categoryTable;
                cbLocSP.DisplayMember = "TenDM";
                cbLocSP.ValueMember = "MaDM";
                cbLocSP.SelectedIndex = -1;
                string querySanPham = @"
            SELECT 
                SanPham.MaSanPham, 
                SanPham.TenSanPham, 
                SanPham.Gia, 
                SanPham.HinhAnh
            FROM 
                BanHang 
            INNER JOIN 
                SanPham 
            ON 
                BanHang.MaSanPham = SanPham.MaSanPham 
            INNER JOIN 
                DanhMuc 
            ON 
                SanPham.MaDM = DanhMuc.MaDM";

                SqlCommand cmd = new SqlCommand(querySanPham, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable productTable = new DataTable();
                adapter.Fill(productTable);
                flpCate.Controls.Clear();
                foreach (DataRow row in productTable.Rows)
                {
                    string maSanPham = row["MaSanPham"].ToString();
                    string tenSanPham = row["TenSanPham"].ToString();
                    int gia = Convert.ToInt32(row["Gia"]);
                    string hinhAnh = row["HinhAnh"].ToString();

                    ucCate item = new ucCate(hinhAnh, tenSanPham, maSanPham, gia);
                    flpCate.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void cbLocSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocSP.SelectedValue != null)
            {
                string maDanhMuc = cbLocSP.SelectedValue.ToString();
                LoadSPTDM(maDanhMuc);
            }
            else
            {

            }
        }
        void LoadSPTDM(string maDanhMuc)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string query = @"
            SELECT 
                SanPham.MaSanPham, 
                SanPham.TenSanPham, 
                SanPham.Gia, 
                SanPham.HinhAnh
            FROM 
                BanHang 
            INNER JOIN 
                SanPham 
            ON 
                BanHang.MaSanPham = SanPham.MaSanPham 
            INNER JOIN 
                DanhMuc 
            ON 
                SanPham.MaDM = DanhMuc.MaDM 
            WHERE 
                DanhMuc.MaDM = @MaDM";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaDM", maDanhMuc);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable sanPhamTable = new DataTable();
                adapter.Fill(sanPhamTable);
                flpCate.Controls.Clear();
                foreach (DataRow row in sanPhamTable.Rows)
                {
                    string hinhAnh = row["HinhAnh"].ToString();
                    string tenSanPham = row["TenSanPham"].ToString();
                    string maSanPham = row["MaSanPham"].ToString();
                    int gia = Convert.ToInt32(row["Gia"]);

                    ucCate item = new ucCate(hinhAnh, tenSanPham, maSanPham, gia); 
                    flpCate.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải sản phẩm: " + ex.Message, "Thông báo");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void InitializeHoaDonColumns()
        {
            dgvHoaDon.Columns.Clear();

            dgvHoaDon.Columns.Add("MaSanPham", "Mã Sản Phẩm");
            dgvHoaDon.Columns.Add("TenSanPham", "Tên Sản Phẩm");
            dgvHoaDon.Columns.Add("Gia", "Giá");
            dgvHoaDon.Columns.Add("SoLuong", "Số Lượng");
            dgvHoaDon.Columns.Add("ThanhTien", "Thành Tiền");
            dgvHoaDon.Columns["Gia"].ValueType = typeof(int);
            dgvHoaDon.Columns["SoLuong"].ValueType = typeof(int);
            dgvHoaDon.Columns["ThanhTien"].ValueType = typeof(int);
            dgvHoaDon.Columns["Gia"].DefaultCellStyle.Format = "N0"; 
            dgvHoaDon.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
        }


        public fBanHang()
        {
            InitializeComponent();
            LoadData_Cate();
            cbLocSP.SelectedIndexChanged += cbLocSP_SelectedIndexChanged;
            InitializeHoaDonColumns();
            btnDelete.Click += btnDelete_Click;
        }

        private void pnlTenDanhMuc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDanhMucSP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            fDangNhap dangNhapForm = new fDangNhap();  
            dangNhapForm.Show(); 
            this.Close(); 
        }

        private void flpCate_Paint(object sender, PaintEventArgs e)
        {
            flpCate.AutoScroll = true;
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo");
                return;
            }

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string query = @"
            SELECT 
                SanPham.MaSanPham, 
                SanPham.TenSanPham, 
                SanPham.Gia, 
                SanPham.HinhAnh
            FROM 
                BanHang 
            INNER JOIN 
                SanPham 
            ON 
                BanHang.MaSanPham = SanPham.MaSanPham 
            WHERE 
                SanPham.TenSanPham LIKE @keyword 
                OR SanPham.MaSanPham LIKE @keyword";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable searchTable = new DataTable();
                adapter.Fill(searchTable);
                flpCate.Controls.Clear();

                if (searchTable.Rows.Count > 0)
                {
                    foreach (DataRow row in searchTable.Rows)
                    {
                        string maSanPham = row["MaSanPham"].ToString();
                        string tenSanPham = row["TenSanPham"].ToString();
                        int gia = Convert.ToInt32(row["Gia"]);
                        string hinhAnh = row["HinhAnh"].ToString();

                        ucCate item = new ucCate(hinhAnh, tenSanPham, maSanPham, gia);
                        flpCate.Controls.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Thông báo");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public void ShowProductInfo(string productName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT SanPham.TenSanPham, SanPham.Gia, SanPham.Soluong FROM SanPham WHERE SanPham.TenSanPham = @ProductName";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ProductName", productName);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable productTable = new DataTable();
                adapter.Fill(productTable);
                if (productTable.Rows.Count > 0)
                {
                    DataRow row = productTable.Rows[0];
                    dgvHoaDon.Rows.Clear();
                    dgvHoaDon.Rows.Add(row["TenSanPham"].ToString(), row["Gia"].ToString(), row["Soluong"].ToString());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin sản phẩm!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin sản phẩm: " + ex.Message, "Thông báo");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void pnlTenHoaDon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhachHang.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtSoDienThoai.Text, @"^(\+84|0)\d{9,10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }
            if (dgvHoaDon.Rows.Count == 0 || dgvHoaDon.Rows.Cast<DataGridViewRow>().All(row => row.IsNewRow))
            {
                MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm vào hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maHoaDon = GenerateNewMaHoaDon();
            DateTime ngayMua = DateTime.Now;
            DataTable chiTietHoaDon = new DataTable();
            chiTietHoaDon.Columns.Add("Mã Sản Phẩm");
            chiTietHoaDon.Columns.Add("Tên Sản Phẩm");
            chiTietHoaDon.Columns.Add("Số Lượng", typeof(int));
            chiTietHoaDon.Columns.Add("Đơn Giá", typeof(decimal));
            chiTietHoaDon.Columns.Add("Thành Tiền", typeof(decimal));

            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells["MaSanPham"].Value != null)
                {
                    DataRow newRow = chiTietHoaDon.NewRow();
                    newRow["Mã Sản Phẩm"] = row.Cells["MaSanPham"].Value.ToString();
                    newRow["Tên Sản Phẩm"] = row.Cells["TenSanPham"].Value.ToString();
                    newRow["Số Lượng"] = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    newRow["Đơn Giá"] = Convert.ToDecimal(row.Cells["Gia"].Value);
                    newRow["Thành Tiền"] = Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                    chiTietHoaDon.Rows.Add(newRow);
                }
            }
            this.Hide();
            fHoaDon hoaDonForm = new fHoaDon(maHoaDon, ngayMua, txtTenKhachHang.Text, txtSoDienThoai.Text, chiTietHoaDon);
            hoaDonForm.ShowDialog();
        
        }
        private string GenerateNewMaHoaDon()
        {
            string newMaHoaDon = "HD006"; 

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT TOP 1 MaHoaDon FROM HoaDon ORDER BY MaHoaDon DESC";
                SqlCommand cmd = new SqlCommand(query, connection);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string currentMaHoaDon = result.ToString();
                    int numericPart = int.Parse(currentMaHoaDon.Substring(2)); 
                    numericPart++;
                    newMaHoaDon = "HD" + numericPart.ToString("D3"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return newMaHoaDon;
        }

        private void fBanHang_Load(object sender, EventArgs e)
        {

        }

        private void pnlBoLoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvHoaDon.SelectedRows[0];
                dgvHoaDon.Rows.Remove(selectedRow);
                UpdateTotal();

                MessageBox.Show("Sản phẩm đã được xóa khỏi hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
    
}
