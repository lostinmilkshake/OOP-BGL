using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_1._1
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            int i, j;
            string temp;
            Console.WriteLine("Please enter the first integer number");
            temp = Console.ReadLine();
            i = Convert.ToInt32(temp);
            Console.WriteLine("Please enter the second integer number");
            temp = Console.ReadLine();
            j = Convert.ToInt32(temp);
            int k;
            try
            {
                k = i / j;
                Console.WriteLine("Result of dividing your two numbers is {0}", k);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero");
            }
            Console.ReadKey();
        }
    }
}
