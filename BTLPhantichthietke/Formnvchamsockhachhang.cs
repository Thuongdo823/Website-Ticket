using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace BTLPhantichthietke
{
    public partial class Formnvchamsockhachhang : Form
    {
        

        public Formnvchamsockhachhang()
        {
            InitializeComponent();
        }
        DataTable Enforce(string query)
        {
            DataTable table = new DataTable();
            using (SqlConnection connectstr = Connection.GetSqlConnection())
            {
                connectstr.Open();
                SqlCommand cmd = new SqlCommand(query, connectstr);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                connectstr.Close();
            }
            return table;
        }
        void insert(string query, SqlParameter[] parameter = null)
        {
            using (SqlConnection connectstr = Connection.GetSqlConnection())
            {
                connectstr.Open();
                SqlCommand cmd = new SqlCommand(query, connectstr);

                if(parameter != null)
                    cmd.Parameters.AddRange(parameter);

                cmd.ExecuteNonQuery();
                    
                connectstr.Close();

            }
        }
        void editdata(string query)
        {
            using (SqlConnection connectstr = Connection.GetSqlConnection())
            {
                connectstr.Open();
                SqlCommand suaCMD = new SqlCommand(query, connectstr);
                suaCMD.ExecuteNonQuery();
                suaCMD.CommandType = CommandType.Text;

                connectstr.Close();

            }
        }
        void deletedata(string query)
        {
            using (SqlConnection connectionstr = Connection.GetSqlConnection())
            {
                connectionstr.Open();
                SqlCommand xoaCMD = new SqlCommand(query, connectionstr);
                xoaCMD.ExecuteNonQuery();
                connectionstr.Close();
            }
        }
        void loaddatagridview()
        {
            string query = $"select MaKH as N'Mã khách hàng', TenKhachHang as N'Tên khách hàng', SoDienThoai as N'Số điện thoại', DiaChi as N'Địa chỉ' from KhachHang";
            dgvKhachHang.DataSource = Enforce(query);
        }
        private void loaddata()
        {
            
        }
        private void Formnvchamsockhachhang_Load(object sender, EventArgs e)
        {
            loaddatagridview();
        }

        private void dgvKhachHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int a = dgvKhachHang.CurrentCell.RowIndex;
            txbMaKH.Text = dgvKhachHang.Rows[a].Cells[0].Value.ToString();
            txbTenKhachHang.Text = dgvKhachHang.Rows[a].Cells[1].Value.ToString();
            txbSoDienThoai.Text = dgvKhachHang.Rows[a].Cells[2].Value.ToString();
            txbDiaChi.Text = dgvKhachHang.Rows[a].Cells[3].Value.ToString();

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string makh = txbMaKH.Text;
            string tenkhachhang = txbTenKhachHang.Text;
            string sodienthoai = txbSoDienThoai.Text;
            string diachi = txbDiaChi.Text;
            




            string query = $"UPDATE KhachHang  SET " +
                $"makh = '{makh}', tenkhachhang = '{tenkhachhang}',sodienthoai = '{sodienthoai}', diachi ='{diachi}' " +
                $"Where makh = '{makh}';";
            
            editdata(query);
            MessageBox.Show("ok ");
            loaddatagridview();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = $"Delete from KhachHang  Where makh = '{txbMaKH.Text}';";
            deletedata(query);
            loaddatagridview();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = $"select MaKH as N'Mã khách hàng', TenKhachHang as N'Tên khách hàng', SoDienThoai as N'Số điện thoại', DiaChi as N'Địa chỉ' from KhachHang where sodienthoai = '{txbMaCanTim.Text}'";

            dgvKhachHang.DataSource = Enforce(query);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = $"Select * from KhachHang ";
            loaddatagridview();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = $"insert into KhachHang values (@MaKH, @TenKH, @SDT, @DiaChi, @LichSuDatVe, @NHLienKet)";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("MaKH", txbMaKH.Text),
                new SqlParameter("TenKH", txbTenKhachHang.Text),
                new SqlParameter("SDT", txbSoDienThoai.Text),
                new SqlParameter("DiaChi", txbDiaChi.Text),
                new SqlParameter("LichSuDatVe", DBNull.Value),
                new SqlParameter("NHLienKet", DBNull.Value),
            };
           
            insert(query, parameter);
            loaddatagridview();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DDia_Click(object sender, EventArgs e)
        {

        }
    }
}
