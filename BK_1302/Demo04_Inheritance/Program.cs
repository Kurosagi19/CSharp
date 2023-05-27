using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.id = 1;
            person.fullname = "Nguyen Duc Anh";

            Student student = new Student();
            student.studentCode = "BKC13127";
            student.id = 2;
            student.fullname = "To Lan Thanh";

            Employee employee = new Employee();
            employee.id = 3;
            employee.fullname = "Nam";
            employee.salary = 100000000;

            employee.showInfo();
            int total = employee.sum(4, 5);

            //Console.WriteLine(person.id);
            //Console.WriteLine(person.fullname);

            //Console.WriteLine(student.studentCode);
            //Console.WriteLine(student.id);
            //Console.WriteLine(student.fullname);

            Console.WriteLine(employee.id);
            Console.WriteLine(employee.fullname);
            Console.WriteLine(employee.salary);
            Console.WriteLine(total);

            Console.Read();
        }
    }
}
