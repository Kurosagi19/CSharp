using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo5_Access_Modifier
{
    internal class Person
    {
        public int id;
        private String fullname;
        protected int age;
        internal String address;

        public void showData()
        {
            id = 100;
            fullname = "To Lan Thanh";
            age = 20;
            address = "Hanoi";

            Console.WriteLine(id);
            Console.WriteLine(fullname);
            Console.Read();
        }
    }
}
