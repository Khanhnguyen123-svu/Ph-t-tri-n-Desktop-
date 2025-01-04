using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApp1
{
    public partial class fHoaDon : Form
    {
        private string connectionString = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";

        public string MaHoaDon { get; set; } 
        public string TenKhachHang { get; set; } 
        public string SoDienThoai { get; set; } 
        public string TrangThai { get; set; } = "Chờ Xử Lý"; 
        public decimal TongTien { get; set; } 
        public decimal GiamGia { get; set; } 
        public decimal TongThanhToan { get; set; } 
        public DataTable ChiTietHoaDon { get; set; } 
        private string maHoaDon;
        private DateTime ngayMua;


        public fHoaDon()
        {
            InitializeComponent();
        }
        private void fHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                lblMaHoaDon.Text = $"Mã Hóa Đơn: {MaHoaDon}";
                lblNgayMua.Text = $"Ngày Tạo: {ngayMua:dd/MM/yyyy}";
                txtTenKhachHang.Text = TenKhachHang;
                txtSoDienThoai.Text = SoDienThoai;
                txtTrangThai.Text = TrangThai;
                dgvHoaDon.DataSource = ChiTietHoaDon;
                TinhTongTien(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public fHoaDon(string maHoaDon, DateTime ngayMua, string tenKhachHang, string soDienThoai, DataTable chiTietHoaDon)
        {
            InitializeComponent();

            this.MaHoaDon = maHoaDon;
            this.ngayMua = ngayMua;
            this.TenKhachHang = tenKhachHang;
            this.SoDienThoai = soDienThoai;
            this.ChiTietHoaDon = chiTietHoaDon;
            LoadData(); 
        }
        private void LoadData()
        {
            lblMaHoaDon.Text = $"Mã Hóa Đơn: {MaHoaDon}";
            lblNgayMua.Text = $"Ngày Tạo: {ngayMua:dd/MM/yyyy}";

            lblMaHoaDon.Text = MaHoaDon;
            lblNgayMua.Text = ngayMua.ToString("dd/MM/yyyy");
            txtTenKhachHang.Text = TenKhachHang;
            txtSoDienThoai.Text = SoDienThoai;
            txtTrangThai.Text = TrangThai;
            if (ChiTietHoaDon != null && ChiTietHoaDon.Rows.Count > 0)
            {
                dgvHoaDon.DataSource = ChiTietHoaDon;
            }
            else
            {
                MessageBox.Show("Chi tiết hóa đơn trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            TinhTongTien(0);
        }
        private void TinhTongTien(decimal chietKhau)
        {
            decimal tongTien = 0;
            if (ChiTietHoaDon == null || ChiTietHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Chi tiết hóa đơn trống hoặc chưa được khởi tạo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataRow row in ChiTietHoaDon.Rows)
            {
                if (row["Thành Tiền"] != DBNull.Value)
                {
                    tongTien += Convert.ToDecimal(row["Thành Tiền"]);
                }
            }
            decimal tienChietKhau = tongTien * chietKhau / 100;
            decimal tongThanhToan = tongTien - tienChietKhau;
            txtTongTien.Text = tongTien.ToString("N0") + " VNĐ"; 
            txtTongThanhToan.Text = tongThanhToan.ToString("N0") + " VNĐ"; 
            txtChietKhau.Text = $"{chietKhau}%";
        }

        private void lblHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void pnlHoaDon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
           


            MessageBox.Show("Hóa đơn đã hoàn thành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
           
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fBanHang banHang = new fBanHang();
            banHang.ShowDialog();
        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            string input = txtChietKhau.Text.Replace("%", "").Trim(); 
            if (decimal.TryParse(input, out decimal chietKhau) && chietKhau >= 0 && chietKhau <= 100)
            {
                TinhTongTien(chietKhau); 
            }
            else
            {
                txtChietKhau.Text = "0%";
                TinhTongTien(0);
            }
        }

        private void lblNgayMua_Click(object sender, EventArgs e)
        {

        }

        private void pnlChuyenKhoan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChuyenKhoan_Click(object sender, EventArgs e)
        {
            pnlChuyenKhoan.Controls.Clear();
            uscChuyenKhoan uscChuyenkhoan = new uscChuyenKhoan();
            pnlChuyenKhoan.Controls.Add(uscChuyenkhoan);
        }

        private void fHoaDon_Load_1(object sender, EventArgs e)
        {

        }
        private void ExportToExcel(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                var workbook = excelApp.Workbooks.Add();
                var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

                
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                
                worksheet.Columns.AutoFit();

                
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = "HoaDon.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                workbook.Close(false);
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvHoaDon);
        }
    }      
}
