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

        void LoadData_Cate()
        {

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string query = "SELECT MaDM, TenDM FROM DanhMuc";
                SqlDataAdapter categoryAdapter = new SqlDataAdapter(query, connection);
                DataTable categoryTable = new DataTable();
                categoryAdapter.Fill(categoryTable);
                cbLocSP.DataSource = categoryTable;
                cbLocSP.DisplayMember = "TenDM";
                cbLocSP.ValueMember = "MaDM";
                cbLocSP.SelectedIndex = -1;

                command = connection.CreateCommand();
                command.CommandText = "SELECT  * FROM BanHang";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                foreach (DataRow r in table.Rows)
                {
                    ucCate item = new ucCate(r["HinhAnh"].ToString(), r["MaSanPham"].ToString());
                    flpCate.Controls.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: ", "Thông báo");
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

                // Câu lệnh SQL để lấy sản phẩm theo danh mục
                string query = "SELECT * FROM BanHang WHERE MaDM = @MaDM";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaDM", maDanhMuc);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable sanPhamTable = new DataTable();
                adapter.Fill(sanPhamTable);

                // Xóa các sản phẩm cũ trong FlowLayoutPanel
                flpCate.Controls.Clear();

                // Thêm các sản phẩm mới vào FlowLayoutPanel
                foreach (DataRow row in sanPhamTable.Rows)
                {
                    ucCate item = new ucCate(row["HinhAnh"].ToString(), row["MaSanPham"].ToString());
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

        public fBanHang()
        {
            InitializeComponent();
            LoadData_Cate();
            cbLocSP.SelectedIndexChanged += cbLocSP_SelectedIndexChanged;
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

                // Truy vấn SQL tìm kiếm sản phẩm
                string query = "SELECT * FROM BanHang WHERE TenSanPham LIKE @keyword OR MaSanPham LIKE @keyword";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable searchTable = new DataTable();
                adapter.Fill(searchTable);

                // Xóa các sản phẩm cũ trong FlowLayoutPanel
                flpCate.Controls.Clear();

                if (searchTable.Rows.Count > 0)
                {
                    // Thêm các sản phẩm mới vào FlowLayoutPanel
                    foreach (DataRow row in searchTable.Rows)
                    {
                        ucCate item = new ucCate(row["HinhAnh"].ToString(), row["MaSanPham"].ToString());
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
