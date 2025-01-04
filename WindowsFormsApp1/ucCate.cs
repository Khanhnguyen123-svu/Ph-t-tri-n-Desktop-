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
    public partial class ucCate : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True");
        SqlCommand command;
        String str = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private int gia;

        public string TenSanPham { get; set; }
        public int Gia { get; set; }
        public string HinhAnh { get; set; }
        public string MaSanPham { get; set; }
        public ucCate()
        {
            InitializeComponent();
        }
        public event EventHandler OnProductClick;
        public ucCate(string pic, string catename, string masanPham, int gia)
        {
            InitializeComponent();
            lblCate.Text = catename;
            picCate.Load(pic);
            TenSanPham = catename;
            Gia = gia;
            MaSanPham = masanPham;

            picCate.Click -= picCate_Click;
            picCate.Click += picCate_Click;
        }

        private void ucCate_Load(object sender, EventArgs e)
        {

        }

        private void picCate_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            var parentForm = this.FindForm() as fBanHang;

            // Kiểm tra nếu parentForm là fBanHang
            if (parentForm != null)
            {
                // Gọi phương thức ShowProductInfo trong fBanHang
                parentForm.AddProductToBill(MaSanPham, TenSanPham, Gia, HinhAnh);
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy form cha!", "Thông báo");
            }
        }

        private void lblCate_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

    }
}
