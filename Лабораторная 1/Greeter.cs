using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_1
{
    class Greeter
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Please, enter Your name, User!");
            myName = Console.ReadLine();
            Console.WriteLine("Hello, {0}", myName);
            //After entering name console just shuts without any tips
            Console.ReadKey();
        }
    }
}
