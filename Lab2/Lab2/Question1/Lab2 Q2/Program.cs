using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static double balance = 1000; // Initial balance
            static void Main(string[] args)
            {
                int pin;
                Console.Write("Enter your PIN: ");
                pin = int.Parse(Console.ReadLine());

                if (pin == 1234) // Replace with a secure authentication mechanism
                {
                    bool exit = false;
                    while (!exit)
                    {
                        DisplayMenu();
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                CheckBalance();
                                break;
                            case 2:
                                Deposit();
                                break;
                            case 3:
                                Withdraw();
                                break;
                            case 4:
                                exit = true;
                                Console.WriteLine("Thank you for using the ATM.");
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }

    }
}
