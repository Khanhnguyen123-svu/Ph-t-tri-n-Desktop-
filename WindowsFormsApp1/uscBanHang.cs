using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class uscBanHang : UserControl
    {
        public uscBanHang()
        {
            InitializeComponent();
        }
        private int trangHienTai = 1; 
        private int soSanPhamMoiTrang = 6; 
        private int tongSoTrang;
        private void TinhTongSoTrang()
        {
            int tongSoSanPham = danhSachSanPham.Count;
            tongSoTrang = (int)Math.Ceiling((double)tongSoSanPham / soSanPhamMoiTrang);
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flpSanPham_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public class SanPham
        {
            public string TenSP { get; set; }
            public int Gia { get; set; }
            public string HinhAnh { get; set; }
        }
        

        
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTongHD_Click(object sender, EventArgs e)
        {

        }

        List<SanPham> danhSachSanPham = new List<SanPham>()
        {
            new SanPham() { TenSP = "Nước Ép Cherry", Gia = 25000, HinhAnh = "cherry.png" },
            new SanPham() { TenSP = "Combo 2 Pin", Gia = 5400, HinhAnh = "pincombo.png" },
            new SanPham() { TenSP = "Khăn Tắm", Gia = 17500, HinhAnh = "khantam.png" }
        };

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTrangTruoc_Click(object sender, EventArgs e)
        {
        }
    }
}
