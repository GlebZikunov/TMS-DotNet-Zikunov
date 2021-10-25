using System;

namespace TeachMeSkills.Zikunov.Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM Atm = new ATM();
            Atm.BalanceHandler += GetInfo;

            Atm.Menu();
        }
        private static void GetInfo(decimal amount, string operation)
        {
            Console.WriteLine($"\nOperation {operation}. Current balance: {amount}");
        }
    }
}
