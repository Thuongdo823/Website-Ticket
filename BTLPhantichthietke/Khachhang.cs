using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using System.Data.Common;

namespace BTLPhantichthietke
{
    public partial class trangchu : Form
    {
        public string ten;
        public trangchu(string tentk)
        {
            InitializeComponent();
            this.ten = tentk;
            tendangnhap.Text = ten.ToString();
        }
        
        
        
        

        private void button8_Click(object sender, EventArgs e)
        {

            if (cbbchuyendi.Text != "")
            {

                BangCD.DataSource = Enforce($"SELECT * FROM Ve WHERE PT = '{cbbphuongtien.Text}'and TenCD  = N'{cbbchuyendi.Text}'");
                int index = BangCD.CurrentCell.RowIndex;
                tbgiave.Text = BangCD.Rows[index].Cells[5].Value.ToString();
                tbmacd.Text = BangCD.Rows[index].Cells[0].Value.ToString();
            }
            else
            {
                string query = $"Select * from Ve";
            }

        }
        private void button4_Click_2(object sender, EventArgs e)
        {
            if (cbbphuongtien.Text != "")
            {

                BangCD.DataSource = Enforce($"SELECT * FROM Ve WHERE PT = '{cbbphuongtien.Text}'");
                cbbchuyendi.DataSource = Enforce($"SELECT * FROM Ve WHERE PT = '{cbbphuongtien.Text}'");
                cbbchuyendi.DisplayMember= "TenCD";
            }
            else
            {
                string query = $"Select * from Ve";
            }

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
        void loaddatagridview()
        {
            string query = "Select * from Ve";
            BangCD.DataSource = Enforce(query);
        }
        private void trangtru_Load(object sender, EventArgs e)
        {

            loaddatagridview();
            label3.Hide();
            numericUpDown1.Hide();
            xacnhan.Hide();
            Hoanve.Hide();
            Thanhtoan.Hide();

        }
        private void màuGiaoDiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            timkiem.BackColor = colorDialog1.Color;
            tabPage2.BackColor = colorDialog1.Color;
            tabPage3.BackColor = colorDialog1.Color;
            tabPage4.BackColor = colorDialog1.Color;

        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult chon;
            chon = MessageBox.Show(" Bạn chắc chắn muốn đăng xuất chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (chon == DialogResult.Yes)
            {
                Close();
            }
            else
            {

            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string giavea, TenCD, PT,Mv;
            Mv = tbmacd.Text;
            giavea = tbgiave.Text;
            TenCD = cbbchuyendi.Text;
            PT = cbbphuongtien.Text;
            DialogResult xacnhan;
            xacnhan = MessageBox.Show(" Xác nhận vé đã chọn ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (xacnhan == DialogResult.Yes)
            {
                Datve datve = new Datve(giavea,TenCD,PT,Mv);
                datve.ShowDialog();
            }
            else
            {

            }



        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Hoanve.Show();
            Thanhtoan.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Show();
            numericUpDown1.Show();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

            Hoten.Enabled = true;
            Ngaysinh.Enabled = true;
            Diachi.Enabled = true;
            Sodienthoai.Enabled = true;
            Hoten.Focus();
            xacnhan.Show();
        }

        private void xacnhan_Click(object sender, EventArgs e)
        {
            Hoten.Enabled = false;
            Ngaysinh.Enabled = false;
            Diachi.Enabled = false;
            Sodienthoai.Enabled = false;
            MessageBox.Show("Thay đổi thành công");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //Datve datve = new Datve(giavea, TenCD, PT);
            //datve.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        

        private void thiếtLậpGiaoDiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                   
        }

       




        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void BangCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            

        }

        private void cbbphuongtien_SelectedIndexChanged(object sender, EventArgs e)
        {
            




        }
        


        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void BangCD_Click(object sender, EventArgs e)
        {
            

            
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
             
        }
        
        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {
            
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            

        }

        private void xemSốDưTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        SqlCommand cmd;
        SqlDataReader DataReader;
        
        private void tabControl1_Click(object sender, EventArgs e)
        {   
            string query = $"Select * from TAIKHOAN where Tendangnhap = '{tendangnhap.Text}'";
            using (SqlConnection connectstr = Connection.GetSqlConnection())
            {
                connectstr.Open();
                cmd = new SqlCommand(query, connectstr);
                DataReader = cmd.ExecuteReader();
                DataReader.Read();
                Hoten.Text = DataReader["Hoten"].ToString() ;
                Ngaysinh.Text = DataReader["NgaySinh"].ToString();
                Diachi.Text = DataReader["Diachi"].ToString();
                Sodienthoai.Text = DataReader["Sodienthoai"].ToString();
                connectstr.Close();
            }
        }

        private void textBox2_TextChanged_3(object sender, EventArgs e)
        {

        }
    }
}
