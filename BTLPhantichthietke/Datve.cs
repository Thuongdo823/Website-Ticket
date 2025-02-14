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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BTLPhantichthietke
{
    public partial class Datve : Form
    {


        public string giavea;
        public string TenCD;
        public string PT;
        public string mave;
        
        public Datve(string giavea,string TenCD ,string PT,string mave)
        {
            



            InitializeComponent();
            this.TenCD = TenCD;
            this.PT = PT;
            this.giavea = giavea;
            this.mave = mave;
            TenCD1.Text = TenCD.ToString();
            PT1.Text = PT.ToString();
            tbgiave1.Text = giavea.ToString();
            mave1.Text = mave.ToString();
            

        }
        DataTable Enforce(string query)
        {
            DataTable table = new DataTable();
            using (SqlConnection connectstr = Connection.GetSqlConnection())
            {
                connectstr.Open();
                SqlCommand cmd = new SqlCommand(query, connectstr);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                table.Clear();
                adapter.Fill(table);
                connectstr.Close();

            }
            return table;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(soluongve.Value);
            int b = Convert.ToInt32(tbgiave1.Text);
            int c = a * b;
            txbthanhtien.Text = c.ToString();
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            using (SqlConnection connectstr = Connection.GetSqlConnection())
            {
                string q1 = $"Insert into HoaDon values (@Mave, @tenkhachhang, @sodienthoai, @PT, @Giatien, @Thanhtien, @NGKH, @NGKT ,  @tenchuyendi, @HangDT)";
                DataTable data = new DataTable();
                connectstr.Open();
                SqlCommand cmd = new SqlCommand(q1, connectstr);

                cmd.Parameters.AddWithValue("Mave",mave1.Text);
                cmd.Parameters.AddWithValue("tenkhachhang", textBox2.Text);
                cmd.Parameters.AddWithValue("sodienthoai", sdt.Text);
                cmd.Parameters.AddWithValue("PT", PT1.Text);
                cmd.Parameters.AddWithValue("Giatien", tbgiave1.Text);
                cmd.Parameters.AddWithValue("Thanhtien", txbthanhtien.Text);
                cmd.Parameters.AddWithValue("NGKH", DBNull.Value);
                cmd.Parameters.AddWithValue("NGKT", DBNull.Value);
                cmd.Parameters.AddWithValue("tenchuyendi", TenCD1.Text);
                cmd.Parameters.AddWithValue("HangDT", DBNull.Value);



                SqlDataAdapter adapter = new SqlDataAdapter(cmd);



                adapter.Fill(data);

                connectstr.Close();
                MessageBox.Show("Done");
            }




        }

        private void Datve_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (vocher.Text == "Tripvn")
            {
                int a, b;
                a = int.Parse(txbthanhtien.Text);
                b = a * 80 / 100;
                txbthanhtien.Text = b.ToString();
            }
            else
            {
                int a = Convert.ToInt32(soluongve.Value);
                int b = Convert.ToInt32(tbgiave1.Text);
                int c = a * b;
                txbthanhtien.Text = c.ToString();
            }
        }
    }
}
