using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Inheritance
{
    internal class Person
    {
        public int id;
        public String fullname;

        public void showInfo()
        {
            Console.WriteLine("show data");
        }

        public int sum(int a, int b)
        {
            return a + b;
        }
    }
}
