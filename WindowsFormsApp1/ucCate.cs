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
        //String str = "Data Source=DESKTOP-O8QHN7N;Initial Catalog=QLCH;Integrated Security=True";
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
        public ucCate(string pic, string catename)
        {
            InitializeComponent();
            lblCate.Text = catename;
            picCate.Load(pic);
            


        }

        private void ucCate_Load(object sender, EventArgs e)
        {

        }

        private void picCate_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblCate_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

    }
}
