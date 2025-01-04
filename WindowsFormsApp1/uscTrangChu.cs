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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class uscTrangChu : UserControl
    {
        
        private string connectionString = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
        public uscTrangChu()
        {
            InitializeComponent();
            CreateChart();
            ConfigurePanelAndLabel();
            

        }
       

        private void btnEmail_Click(object sender, EventArgs e)
        {
            this.Hide();
            {
                fEmailHoTro ffEmailHoTro = new fEmailHoTro();
                ffEmailHoTro.ShowDialog();
                this.Show();
            
            }
        }
        private void HienThiSoLuongSanPhamDaBan()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT SUM(SoLuong) AS TongSoLuong FROM ChiTietHoaDon";
                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();
                    int tongSoLuong = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    lblTongDaBan.Text = $"{tongSoLuong} Sản Phẩm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HienThiSoLuongDoanhThu()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT SUM(ThanhTien) AS TongDoanhThu FROM ChiTietHoaDon";
                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();

                    
                    int tongDoanhThu = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    lblTongDoanhThu.Text = $"{tongDoanhThu.ToString("N0")} VNĐ"; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HienThiSoLuongKhachHang()
        {
            string connectionString = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
            string queryKhachHang = "SELECT COUNT(DISTINCT MaKhachHang) AS SoLuongKhachHang FROM HoaDon";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdKhachHang = new SqlCommand(queryKhachHang, connection);
                    object resultKhachHang = cmdKhachHang.ExecuteScalar();
                    int soLuongKhachHang = resultKhachHang != null ? Convert.ToInt32(resultKhachHang) : 0;
                    lblKH.Text = $"{soLuongKhachHang} Khách Hàng"; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thông tin thống kê: " + ex.Message);
                }
            }
      
        }

        private void pnlTrangChu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cBieuDo_Click(object sender, EventArgs e)
        {
            
        }
        private void LoadDataFromDatabase()
        {
            try
            {
                string query = "SELECT NgayLap, SUM(DonGia * SoLuong) AS TongTien FROM ThongKe GROUP BY NgayLap ORDER BY NgayLap";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();

                    connection.Open();
                    adapter.Fill(table);
                    connection.Close();

                    cBieuDo.Series["Doanh Thu"].Points.Clear();

                    foreach (DataRow row in table.Rows)
                    {
                        string date = Convert.ToDateTime(row["NgayLap"]).ToString("dd/MM/yyyy");
                        decimal tongTien = Convert.ToDecimal(row["TongTien"]);
                        cBieuDo.Series["Doanh Thu"].Points.AddXY(date, tongTien);
                    }
                }

                cBieuDo.Titles.Clear();
                cBieuDo.Titles.Add("Biểu đồ Doanh Thu theo Ngày");
                cBieuDo.ChartAreas[0].AxisX.Title = "Ngày";
                cBieuDo.ChartAreas[0].AxisY.Title = "Doanh Thu (VNĐ)";
                cBieuDo.ChartAreas[0].AxisY.LabelStyle.Format = "N0"; 
                foreach (var point in cBieuDo.Series["Doanh Thu"].Points)
                {
                    point.Label = Convert.ToDecimal(point.YValues[0]).ToString("N0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void CreateChart()
        {
            try
            {
                cBieuDo.Series.Clear();
                var series = new Series
                {
                    Name = "Doanh Thu",
                    IsValueShownAsLabel = true, 
                    ChartType = SeriesChartType.Column
                };
                cBieuDo.Series.Add(series);

                string query = "SELECT NgayLap, SUM(DonGia * SoLuong) AS TongTien FROM ThongKe GROUP BY NgayLap ORDER BY NgayLap";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();

                    connection.Open();
                    adapter.Fill(table);
                    connection.Close();

                    foreach (DataRow row in table.Rows)
                    {
                        string date = Convert.ToDateTime(row["NgayLap"]).ToString("dd/MM/yyyy");
                        decimal tongTien = Convert.ToDecimal(row["TongTien"]);
                        series.Points.AddXY(date, tongTien);
                        cBieuDo.Width = 490;
                        cBieuDo.Height = 400;
                    }
                }

                cBieuDo.Titles.Clear();
                cBieuDo.Titles.Add("Biểu đồ Doanh Thu theo Ngày");
                cBieuDo.ChartAreas[0].AxisX.Title = "Ngày";
                cBieuDo.ChartAreas[0].AxisY.Title = "Doanh Thu (VNĐ)";
                cBieuDo.ChartAreas[0].AxisY.LabelStyle.Format = "N0"; // Định dạng trục Y

                foreach (var point in series.Points)
                {
                    point.Label = Convert.ToDecimal(point.YValues[0]).ToString("N0"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo biểu đồ: " + ex.Message);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpNgayBD.Value;
            DateTime endDate = dtpNgayKT.Value;
            FilterDataByDateRange(startDate, endDate);
            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FilterDataByDateRange(startDate, endDate);
        }
        private void FilterDataByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                cBieuDo.Series.Clear();
                var series = new Series
                {
                    Name = "Doanh Thu",
                    IsValueShownAsLabel = true,
                    ChartType = SeriesChartType.Column
                };
                cBieuDo.Series.Add(series);

                string query = @"
            SELECT NgayLap, SUM(DonGia * SoLuong) AS TongTien 
            FROM ThongKe 
            WHERE NgayLap BETWEEN @StartDate AND @EndDate 
            GROUP BY NgayLap 
            ORDER BY NgayLap";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();

                    connection.Open();
                    adapter.Fill(table);
                    connection.Close();

                    foreach (DataRow row in table.Rows)
                    {
                        string date = Convert.ToDateTime(row["NgayLap"]).ToString("dd/MM/yyyy");
                        decimal tongTien = Convert.ToDecimal(row["TongTien"]);
                        series.Points.AddXY(date, tongTien);
                    }
                }

                cBieuDo.Titles.Clear();
                cBieuDo.Titles.Add("Biểu đồ Doanh Thu theo Ngày");
                cBieuDo.ChartAreas[0].AxisX.Title = "Ngày";
                cBieuDo.ChartAreas[0].AxisY.Title = "Doanh Thu (VNĐ)";
                foreach (var point in series.Points)
                {
                    point.Label = Convert.ToDecimal(point.YValues[0]).ToString("N0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message);
            }
        }
        
        private void pnlBieuDoDoanhThu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTongDaBan_Click(object sender, EventArgs e)
        {

        }

        private void uscTrangChu_Load(object sender, EventArgs e)
        {
            HienThiSoLuongSanPhamDaBan();
            HienThiSoLuongDoanhThu();
            HienThiSoLuongKhachHang();
            DisplayTopSellingProducts();
        }
       
        private void btnLocTopSP_Click(object sender, EventArgs e)
        {

        }

        private void pnlTopSP_Paint(object sender, PaintEventArgs e)
        {
            DisplayTopSellingProducts();
            DateTime selectedDate = dtpNgayTopSP.Value.Date;
        }
        private void DisplayTopSellingProducts()
        {
            try
            {
        
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT TOP 10 
                    sp.TenSanPham, 
                    SUM(cthd.SoLuong) AS TongSoLuong
                FROM 
                    ChiTietHoaDon cthd
                JOIN 
                    SanPham sp ON cthd.MaSanPham = sp.MaSanPham
                GROUP BY 
                    sp.TenSanPham
                ORDER BY 
                    TongSoLuong DESC;
            ";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();

                    connection.Open();
                    adapter.Fill(table);
                    connection.Close();
                    StringBuilder resultText = new StringBuilder();
                    resultText.AppendLine("Top 10 Sản Phẩm Bán Chạy:\n");
                    foreach (DataRow row in table.Rows)
                    {
                        string productName = row["TenSanPham"].ToString();
                        int quantity = Convert.ToInt32(row["TongSoLuong"]);
                        resultText.AppendLine($"{productName}: {quantity} sản phẩm\n");

                    }

                   
                    lblTopSanPham.Text = resultText.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sản phẩm bán chạy: " + ex.Message);
            }
        }
            private void ConfigurePanelAndLabel()
            {
           
            pnlTopSP.AutoScroll = true; 
            pnlTopSP.BorderStyle = BorderStyle.FixedSingle;


            lblTopSanPham.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            lblTopSanPham.AutoSize = true;
            lblTopSanPham.MaximumSize = new Size(pnlTopSP.Width - 20, 0); 
            }

        private void lblTongDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }
    }
    }

