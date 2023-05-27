using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Overload_Override
{
    internal class Person
    {
        // Overload
        public int sum(int a, int b)
        {
            return a + b;
        }
        public int sum(int a, int b, int c)
        {
            return a + b * c;
        }
        public string sum(string a, int b)
        {
            return a + b;
        }

        // Override
        // Super class: class cha
        public void showInfo(string fullName)
        {
            Console.WriteLine("Fullname (class Person): " + fullName);
        }
    }
}
