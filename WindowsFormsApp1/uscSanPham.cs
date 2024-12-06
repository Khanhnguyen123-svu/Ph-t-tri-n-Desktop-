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

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSanPham.AutoGenerateColumns = true;
        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
             
        }
    }
}
