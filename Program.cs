using System;

namespace A16
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO Oyes Bank");

            BankAccount Bk = new BankAccount(14);
        start:

            Console.WriteLine($"Account Number   :{Bk.gAN} \n" +
                              $"Holder Name      :{Bk.gName}\n");

            Console.WriteLine("Would you Like to Deposit New Balance,Press y for deposit\nPress m for withdraw amount\nWant to check bank Amount press b");

            string y = Console.ReadLine();
            switch (y)
            {
                case "y":
                    Console.WriteLine("How much Amount You want to enter");
                    double X = double.Parse(Console.ReadLine());
                    Bk.Deposit(X);
                    Console.WriteLine($"Your New Balance: {Bk.gAB}");
                    break;
                case "m":
                    Console.WriteLine("How much Amount You want to Withdraw");
                    double r = double.Parse(Console.ReadLine());
                    Bk.Withdraw(r);
                    Console.WriteLine($"Your New Balance: {Bk.gAB}");
                    break;
                case "b":
                    Console.WriteLine("ENTER LOGIN PASSWORD");
                    string passcode = Console.ReadLine();
                    Bk.PrintAccountBalance(passcode);
                    break;
                default:
                    Console.WriteLine("Invalid key");
                    goto start;
            }
            Console.WriteLine("Would You Like to Continue? Press 's' to continue");
            string s = Console.ReadLine();
            if (s == "s")
            {
                goto start;
            }
        }
    }
}
