using BTLPhantichthietke;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLPhantichthietke
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
            tbmaso.Hide();
            lbma.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }
        Suadoi suadoi = new Suadoi();

        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = tendangnhap.Text;
            string mk = matkhau.Text;
            string mavip = tbmaso.Text;


            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên đăng nhập"); }
            else if (mk.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu"); }
            else
            {
                string query = "Select * From TAIKHOAN where Tendangnhap = '" + tentk + "' and Matkhau = '" + mk + "'";
                if (suadoi.taikhoans(query).Count > 0)
                {

                    string khachhang = cbbtucach.Text;
                    if (khachhang.Trim() == "Khách hàng")
                    {
                        trangchu trangchu = new trangchu(tentk);
                        trangchu.ShowDialog();
                    }
                    else if (mavip.Trim() != "211103")
                    {
                        if (mavip.Trim() == "")
                        {
                            MessageBox.Show("bạn chưa điền mã", "Thông Báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("sai mã", "Thông Báo", MessageBoxButtons.OK);

                        }


                    }
                    else if (khachhang.Trim() == "BP Thống kê")
                    {
                        FormBPthongke formBPthongke = new FormBPthongke();
                        formBPthongke.ShowDialog();
                    }
                    else if (khachhang.Trim() == "Quản Lý")
                    {
                        Formquanly formquanly = new Formquanly();
                        formquanly.ShowDialog();

                    }
                    else if (khachhang.Trim() == "Nhân Viên chăm sóc khách hàng")
                    {

                        Formnvchamsockhachhang formnvchamsockhachhang = new Formnvchamsockhachhang();
                        formnvchamsockhachhang.ShowDialog();
                    }
                    else
                    {
                        FormBPthongke formBPthongke = new FormBPthongke();
                        formBPthongke.ShowDialog();
                    }
                    //MessageBox.Show("Đăng nhập thành công","Thông Báo",MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu KHÔNG ĐÚNG !!", "Thông Báo", MessageBoxButtons.OK);


                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void enter(object sender, EventArgs e)
        {

        }

        private void tendangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btdangnhap_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cbbtucach.Text;
            if (a.Trim() == "Khách hàng")
            {
                tbmaso.Hide();
                lbma.Hide();
            }
            else if (a.Trim() == "Quản Lý")
            {
                lbma.Show();
                lbma.Text = "Nhập mã Quản Lý:";
                tbmaso.Show();

            }
            else if (a.Trim() == "Nhân Viên chăm sóc khách hàng")
            {
                lbma.Text = "Nhập mã nvcskh:";
                lbma.Show();
                tbmaso.Show();
            }
            else
            {
                lbma.Text = "Nhập mã BP Thông kê: ";
                lbma.Show();
                tbmaso.Show();
            }

        }

        private void tbmaso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
