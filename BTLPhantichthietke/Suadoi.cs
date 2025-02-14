using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace  BTLPhantichthietke
{
    internal class Suadoi
    {
        public Suadoi()
        {

        }
        SqlCommand sqlCommand;  //dùng để truy vấn các câu lệnh insert , update,dele...
        SqlDataReader dataReader; // dùng để đọc dữ liệu trong bảng
        public List<taikhoan> taikhoans(string query) // check tk
        {
            List<taikhoan> taikhoans= new List<taikhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query,sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taikhoans.Add(new taikhoan(dataReader.GetString(0), dataReader.GetString(1)));
                     
                }
                sqlConnection.Close();



                sqlConnection.Close();
            }
            return taikhoans;
        
        }
        public void Command(string query)//dung để đăng ký tài khoản
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection()) 
            {
                sqlConnection.Open();
                sqlCommand= new SqlCommand(query,sqlConnection);
                sqlCommand.ExecuteNonQuery(); // thực thi câu truy vấn
                sqlConnection.Close();
            }
        }

    }
}
