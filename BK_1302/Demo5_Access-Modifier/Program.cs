using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5_Access_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.id = 1;
            
            person.showData();
        }
    }
}
