using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_2
{
    enum AccountType {checking, deposit};
    class Program
    {
        static void Main(string[] args)
        {
            AccountType goldAccount = AccountType.checking;
            AccountType platinumAccount = AccountType.deposit;
            Console.WriteLine("Platinum Account is {0}", goldAccount);
            Console.WriteLine("Platinum Account is {0}", platinumAccount);
            Console.ReadKey();
        }
    }
}
