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
    }
}
