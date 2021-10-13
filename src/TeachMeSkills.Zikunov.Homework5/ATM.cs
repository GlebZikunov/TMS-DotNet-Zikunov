using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Zikunov.Homework5
{
    class ATM
    {
        public event Action<decimal, string> BalanceHandler;

        private decimal _balance = 0m;

        public void WithdrawalMoney(decimal money)
        {
            _balance -= money;
            BalanceHandler?.Invoke(_balance, "withdrawal");
        }

        public void TopUp(decimal money)
        {
            _balance += money;
            BalanceHandler?.Invoke(_balance, "top-up");
        }

        public void DisplayBalance()
        {
            var eventName = "display";
            BalanceHandler?.Invoke(_balance, eventName);
        }

        public void Menu()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the ATM of 'TeachMeSkills'!\n");
            Console.ResetColor();

            var stopword = false;

            while (!stopword)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("-----------------------");
                Console.ResetColor();

                Console.WriteLine("   Choose operation: ");
                Console.WriteLine("1) Top-up account.");
                Console.WriteLine("2) Withdrawal of funds.");
                Console.WriteLine("3) Display balance.");
                Console.WriteLine("4) Exit.");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("-----------------------\n");
                Console.ResetColor();

                try
                {
                    int choose = Convert.ToInt32(Console.ReadLine());
                    Operations(choose);
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error. Try again.\n");
                    Console.ResetColor();

                    int choose = Convert.ToInt32(Console.ReadLine());
                    Operations(choose);
                }

                stopword = StopInput();
                Console.Clear();
            }
        }

        public void Operations(int Choose)
        {
            switch(Choose)
            {
                case 1:
                {
                    Console.WriteLine("Enter amount of money: ");
                    decimal money = Convert.ToDecimal(Console.ReadLine());
                    TopUp(money);
                }break;

                case 2:
                {
                    Console.WriteLine("Enter amount of money: ");
                    decimal money = Convert.ToDecimal(Console.ReadLine());

                    if (_balance - money <= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error. You dont have enough money.Try again.\n");
                        Console.ResetColor();

                        Console.WriteLine("Enter amount of money: ");
                        money = Convert.ToDecimal(Console.ReadLine());
                        WithdrawalMoney(money);
                    }
                    else
                        WithdrawalMoney(money);
                }break;

                case 3:
                {
                    DisplayBalance();
                }break;

                case 4:
                {
                    Exit();
                }break;
            }
        }

        private static bool StopInput()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\nStop? (Press 'Y' or 'y'): ");
            Console.ResetColor();

            var key = Console.ReadKey().Key;
            Console.WriteLine();
            return key == ConsoleKey.Y;
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}