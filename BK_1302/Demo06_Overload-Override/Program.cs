using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Demo06_Overload_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Student student = new Student();

            //int total = person.sum(4, 5);
            //Console.WriteLine("Total: " + total);

            //int total2 = person.sum(4, 5, 6);
            //Console.WriteLine("Total2: " + total2);

            //string total3 = person.sum("To Lan Thanh", 20);
            //Console.WriteLine("Total3: " + total3);

            person.showInfo("Thanh");
            student.showInfo("Thanh");

            Console.Read();
        }
    }
}
