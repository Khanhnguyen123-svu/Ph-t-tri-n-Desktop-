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
    public partial class uscThongKe : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True");
        SqlCommand command;
        String str = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public uscThongKe()
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
                command.CommandText = "SELECT * FROM ThongKe";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvTongTien.DataSource = table;
                decimal totalAmount = 0;
                foreach (DataRow row in table.Rows)
                {
                    totalAmount += Convert.ToDecimal(row["DonGia"]);
                }
                txtTongTien.Text = totalAmount.ToString("N2");
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

        private void dgvTongTien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTongTien.AutoGenerateColumns = true;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM ThongKe WHERE NgayLap = @NgayLap";
                command.Parameters.AddWithValue("@NgayLap", selectedDate);  

                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvTongTien.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Thông báo");
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

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM ThongKe WHERE MaHoaDon LIKE @Keyword OR TenKhachHang LIKE @Keyword OR MaSanPham LIKE @Keyword";
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");  
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvTongTien.DataSource = table;
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

        private void pnlThongKe_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
