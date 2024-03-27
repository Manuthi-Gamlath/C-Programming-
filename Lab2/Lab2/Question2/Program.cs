using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Q2
{
    internal class BankAccount 
    {
        public string Account number
        public decimal Balance

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.Write("Enter the account number: ");
            account.AccountNumber=int.Parse(Console.ReadLine());

            Console.Write("Enter the deposit amount:");
            double amount=double.Parse(Console.ReadLine());

            account.deposit(amount);

            Console.WriteLine("Account number:"+account.AccountNumber);
            Console.WriteLine()
        }
    }
}
