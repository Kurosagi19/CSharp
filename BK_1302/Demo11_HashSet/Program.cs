using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setFullName = new HashSet<string>();
            Console.WriteLine("Count: " + setFullName.Count);

            // List HAshSet: no duplicate value
            setFullName.Add("Thanh");
            setFullName.Add("Ngoc Anh");
            setFullName.Add("Thanh");

            setFullName.Remove("Ngoc Anh");

            Console.WriteLine("Count: " + setFullName.Count);

            Console.Read();
        }
    }
}
