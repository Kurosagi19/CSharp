using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    ArrayList listFullName = new ArrayList();

            //    // Index 0
            //    listFullName.Add("Thanh");
            //    // Index 1
            //    listFullName.Add("Duc Anh is gay");
            //    // Index 2
            //    listFullName.Add("Nam");
            //    // Index 3
            //    listFullName.Add(new DateTime());
            //    // Index 4
            //    listFullName.Add(true);
            //    listFullName.Add(10);

            //    // Xoá giá trị ở vị trí 0
            //    //listFullName.RemoveAt(0);

            //    // Xoá giá trị bắt đầu từ vị trí = 0, độ dài = 2
            //    //listFullName.RemoveRange(0, 2);

            //    // Đếm số bản ghi trong ArrayList
            //    // int quantity = listFullName.Count;

            //    // Console.WriteLine("Quantity = " + quantity);

            //    // Kiểm tra xem có "Nam" trong ArrayList không
            //    //bool isExists = false;
            //    //for(int i = 0; i < listFullName.Count; i++)
            //    //{
            //    //    string fullName = listFullName[i].ToString();

            //    //    if(fullName == "Nam")
            //    //    {
            //    //        isExists = true;
            //    //    }
            //    //}
            //    //if(isExists == true)
            //    //{
            //    //    Console.WriteLine("Nam exist !");
            //    //} else
            //    //{
            //    //    Console.WriteLine("Nam not exist !");
            //    //}
            //    //Console.WriteLine("Is Nam exist ? = " + isExists);

            //    // Kiểm tra xem có "Nam" trong ArrayList không
            //    //bool isExists = listFullName.Contains("Nam");
            //    //if (isExists == true)
            //    //{
            //    //    Console.WriteLine("Nam exist !");
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Nam not exist !");
            //    //}
            //    //Console.WriteLine("Is Nam exist ? " + isExists);

            //    // Hiển thị tất cả giá trị trong ArrayList
            //    for(int i = 0; i < listFullName.Count; i++)
            //    {
            //        string fullName = listFullName[i].ToString();
            //        Console.WriteLine("Fullname = " + fullName);
            //    }

            //    Console.Read();


            // List
            //List<int> nums = new List<int>();
            //nums.Add(1);
            //nums.Add(2);
            //nums.Add(3);
            //nums.Add(4);
            
            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();



            // Sử dụng List khai báo 5 quốc gia, in tất cả quốc gia
            List<string> region = new List<string>();
            region.Add("Vietnam");
            region.Add("Japan");
            region.Add("USA");
            region.Add("Korea");
            region.Add("China");

            Console.WriteLine("== All Regions ==");
            foreach (string s in region)
            {
                Console.WriteLine(s);
            }
            // In những quốc gia chứa chữ n
            Console.WriteLine("== All Regions with 'n' inside ==");
            foreach(string s in region)
            {
                if(s.Contains("n"))
                {
                    Console.WriteLine(s);
                }
            }

            // In 3 quốc gia đầu tiên
            Console.WriteLine("== Fisrt three Regions ==");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(region[i]);
            }

            // In 3 quốc gia cuối cùng
            Console.WriteLine("== Last three Regions ==");
            for(int i = 2; i < region.Count; i++)
            {
                Console.WriteLine(region[i]);
            }

            Console.Read();
        }
    }
}
