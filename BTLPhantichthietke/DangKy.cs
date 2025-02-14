using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // sytem thêm

namespace BTLPhantichthietke
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public bool Checktaikhoan(string ac) //check mk va tk
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool Checksdt(string sdt)//check sdt
        {
            return Regex.IsMatch(sdt, "^[0-9]{8,12}$");
        }
        Suadoi suadoi= new Suadoi();

        private void btdangky_Click(object sender, EventArgs e)
        {
            string tentk = Tendangnhap1.Text;
            string mk = matkhau1.Text;
            string xacnhanmk = xnmatkhau1.Text;
            string hoten = tbhoten.Text;
            string ngaysinh = Ngaysinh.Text;
            string diachi = tbdiachi.Text;
            string sodienthoai = sdt.Text;
            if(!Checktaikhoan(tentk) ) { MessageBox.Show("Vui Lòng Nhập Tên Tài Khoảng dài 6 đến 24 ký tự");return; }
            if(!Checktaikhoan(mk)) { MessageBox.Show("Vui Lòng Nhập mật khẩu Khoảng dài 6 đến 24 ký tự"); return; }
            if(mk != xacnhanmk) { MessageBox.Show("Xác nhận mật khẩu không trùng");return; }
            if(!Checksdt(sodienthoai)) { MessageBox.Show("Số điện thoại sai!"); return; }
            if(suadoi.taikhoans("Select * from TaiKhoan where Sodienthoai = '" + sdt + "'").Count != 0) {
                MessageBox.Show("Số điện thoại đã đc đăng ký vui lòng đăng ký sdt khác");return; }
            try
            {
                string query = $"Insert into TaiKhoan values ('" + tentk + "','" + mk + "','" + sodienthoai + "','" + hoten + "','" + ngaysinh + "','" + diachi + "')";

                suadoi.Command(query);
                if(MessageBox.Show("Đăng ký thành công !","Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã đc sử dụng !");
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sdt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
