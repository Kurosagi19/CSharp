using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12_Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strCon = "Server = Kurosagi19; Database = C1302; Trusted_Connection = true";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            // Hiển thị bảng product
            string sql = "SELECT * FROM product";
            // Thêm vào bảng product
            //string query = "INSERT INTO product (prd_name) VALUES ('Airplane')";
            // Sửa product
            //string query = "UPDATE product SET prd_name = 'Spaceship' WHERE id = 5";
            // Xoá product
            //string query = "DELETE FROM product WHERE id = 5";

            //SqlCommand command = new SqlCommand(query, con);
            //command.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                string id = reader["id"].ToString();
                string prdName = reader["prd_name"].ToString();
                Console.WriteLine($"ID: { id }");
                Console.WriteLine($"Product Name: { prdName }");
            }
            Console.WriteLine("~ Connect Successfully ~");
            Console.Read();
        }
    }
}
