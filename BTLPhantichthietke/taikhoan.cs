using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLPhantichthietke
{
    internal class taikhoan
    {
        private string tendangnhap;
        private string matkhau;


        public taikhoan()
        {

        }
        public taikhoan(string tendangnhap, string matkhau)
        {
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
        }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }

        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
