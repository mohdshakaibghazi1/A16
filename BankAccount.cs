using System;

namespace A16
{
    public class BankAccount
    {
        public Double AN;
        public String Name;
        public Double AB;

        public BankAccount(Double AB)
        {
            this.AN = 55521;
            this.Name = "Avneesh";
            this.AB = 0;
        }

        public Double gAN { get { return AN; } }
        public string gName { get { return Name; } }
        public Double gAB { get { return AB; } } // Read-only property

        public void Deposit(Double amount)
        {
            AB += amount;
        }

        public void Withdraw(Double amount)
        {
            if (AB >= amount)
            {
                AB -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed.");
            }
        }

        public void PrintAccountBalance(string passcode)
        {
            if (passcode == "Qwert")
            {
                Console.WriteLine("Your Balance is " + AB);
            }
            else
            {
                Console.WriteLine("Invalid passcode. Access denied.");
            }
        }
    }
}
