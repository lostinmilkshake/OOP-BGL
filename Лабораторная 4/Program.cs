using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_4
{
    public class Utils
    {
        public static int Greater (int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static bool Factorial(int n, out int answer)
        {
            int f=1;
            bool ok = true;
            try
            {
                if (n <= 0)
                {
                    throw new ArgumentOutOfRangeException("n", "Invalid argument");
                }
                checked
                {
                    for (int i = 2; i <= n; i++)
                    {
                        f *= i;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
            }
            answer = f;
            return ok;
        }

        public static int RecursiveFactorial(int n)
        {
            if (n <=0) return 1;
            return n * RecursiveFactorial(n - 1);
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            int x, y, greater;
            string line;
            Console.WriteLine("Please enter the first number");
            line = Console.ReadLine();
            x = Convert.ToInt32(line);
            Console.WriteLine("Please enter the second number");
            line = Console.ReadLine();
            y = int.Parse(line);
            greater = Utils.Greater(x, y);
            Console.WriteLine("Maximum value is {0}", greater);

            //excersise 2
            Console.WriteLine("First number is {0}, second number is {1}", x, y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("First number is {0}, second number is {1}", x, y);
            //Console.ReadKey();

            //excercise 3 and 4
            bool ok;
            Console.WriteLine("Enter the number for factorial");
            line = Console.ReadLine();
            int n = int.Parse(line);
            ok = Utils.Factorial(n, out int f);
            if (ok)
            {
                try
                {
                    Console.WriteLine("Factorial of {0} is {1}", n, f);
                    int answer = Utils.RecursiveFactorial(n);
                    Console.WriteLine("Recursive method of computing {0}-factorial is {1}", n, answer);
                }
                catch (ArgumentOutOfRangeException error)
                {
                    Console.WriteLine("{0}", error.Message);
                }
            }
            else
                Console.WriteLine("Cannot compute this Factorial");
            Console.ReadKey();
        }
    }
}
