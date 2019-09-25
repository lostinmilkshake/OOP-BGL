using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_6__упражнение_2_
{
    enum AccountType
    {
        Checking,
        Deposit
    }
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;

        public void Populate(decimal balance) //add long number
        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
        }
        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
        public string Type()
        {
            return accType.ToString();
        }
        private static long NextNumber()
        {
            return nextAccNo++;
        }

        public decimal Deposit(decimal amount)
        {
            accBal += amount;
            return accBal;
        }
        public bool Withdraw(decimal amount)
        {
            bool success = accBal >= amount;
            if (success)
            {
                accBal -= amount;
            }
            return success;
        }
    }
    class Program
    {
        public static void TestDeposit(BankAccount acc)
        {
            Console.WriteLine("Enter amount to deposit:");
            string line = Console.ReadLine();
            decimal amount = int.Parse(line);
            acc.Deposit(amount);
        }

        public static void TestWithdraw(BankAccount acc)
        {
            Console.WriteLine("Enter amount to withdraw:");
            string line = Console.ReadLine();
            decimal amount = int.Parse(line);
            if (!acc.Withdraw(amount))
            {
                Console.WriteLine("Too much for this account");
            }
        }
        static void Main()
        {
            BankAccount berts = NewBankAccount();
            Write(berts);
            TestDeposit(berts);
            Write(berts);
            TestWithdraw(berts);
            Write(berts);

            BankAccount freds = NewBankAccount();
            Write(freds);
            TestDeposit(freds);
            Write(freds);
            TestWithdraw(freds);
            Write(freds);
            Console.ReadKey();
        }

        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            //Console.Write("Enter the account number: ");
            //long number = long.Parse(Console.ReadLine());
            //long number = BankAccount.NextNumber();             //uncomment it to show teacher
            Console.Write("Enter the account balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());
            created.Populate(balance); //add balance without incapsulatiob
                                       /*created.accNo = number;
                                       created.accBal = balance;
                                       created.accType = AccountType.Checking;*/

            return created;
        }

        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }
    }
}
