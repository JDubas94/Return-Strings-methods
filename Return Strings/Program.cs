using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Strings
{
    class Program
    {
        static string GetHello(string name)
        {
            return "Hello, " + name + " ,how are you doing today?";

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");

            var name = Console.ReadLine();

            Console.WriteLine(GetHello(name));

            Console.ReadLine();

        }
    }
}
