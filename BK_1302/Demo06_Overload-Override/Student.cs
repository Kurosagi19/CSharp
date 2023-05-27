using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Overload_Override
{
    // Sub class, Derived class: class con
    internal class Student : Person
    {
        private string surname = "Van ";
        public void showInfo(String fullName)
        {
            Console.WriteLine("Fullname (class Student): " + surname + fullName);
        }
    }
}
