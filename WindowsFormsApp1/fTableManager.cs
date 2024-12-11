using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class fTableManager : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String str = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public fTableManager()
        {
            InitializeComponent();
        }
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile Profile = new fAccountProfile();
            this.Hide();
            Profile.ShowDialog();
            this.Show();
        }


        private void TTCNToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAccountProfile TTCN = new fAccountProfile();
            this.Hide();
            TTCN.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {
            
            pnlMain.Controls.Clear();
            uscTrangChu uscTrangChu = new uscTrangChu();  
            pnlMain.Controls.Add(uscTrangChu);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            uscNhanVien uscNhanVien = new uscNhanVien();
            pnlMain.Controls.Add(uscNhanVien);
            


        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            uscKhachHang uscKhachHang = new uscKhachHang();
            pnlMain.Controls.Add(uscKhachHang);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            uscDoiTac uscDoiTac = new uscDoiTac();
            pnlMain.Controls.Add(uscDoiTac);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            uscSanPham uscSanPham = new uscSanPham();
            pnlMain.Controls.Add(uscSanPham);
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            uscTrangChu uscTrangChu = new uscTrangChu();
            pnlMain.Controls.Add(uscTrangChu);

        }
        private void btnThietLap_Click(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            uscThongKe uscThongKe = new uscThongKe();
            pnlMain.Controls.Add(uscThongKe);
        }
    }
}

    

