using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_2._1
{
    
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    public enum AccountType { Checking, Deposit };
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accNo = 731495;
            goldAccount.accBal = 1000000000;
            goldAccount.accType = AccountType.Checking;
            Console.WriteLine("Account number is {0}", goldAccount.accNo);
            Console.WriteLine("Account ballance is {0} $", goldAccount.accBal);
            Console.WriteLine("Account type is {0}", goldAccount.accType);
            Console.ReadKey();
        }
    }
}
