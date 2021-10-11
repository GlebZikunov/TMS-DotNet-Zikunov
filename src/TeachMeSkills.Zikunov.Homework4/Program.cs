using System;
using TeachMeSkills.Zikunov.Homework4.Interfaces;
using TeachMeSkills.Zikunov.Homework4.Managers;
using TeachMeSkills.Zikunov.Homework4.Models;

namespace TeachMeSkills.Zikunov.Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            var stopWord = false;

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Welcome to the Zoo of 'TeachMeSkills'!");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();

            while (!stopWord)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nWhich animal do you want to see: \n");
                Console.ResetColor();

                Console.WriteLine("1) Zebra");
                Console.WriteLine("2) Rare bird");
                Console.WriteLine("3) Show info about animals");
                Console.WriteLine("4) Exit Zoo\n");

                try
                {
                    int Choose = Convert.ToInt32(Console.ReadLine());
                    ChoosingAnimal(Choose, stopWord);
                }
                catch(FormatException)
                { 
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error. Input integer value.\n");
                    Console.ResetColor();

                    int Choose = Convert.ToInt32(Console.ReadLine());
                    ChoosingAnimal(Choose, stopWord);
                }

                stopWord = StopInput();
                Console.Clear();
            }
        }

        private static void ChoosingAnimal(int choose, bool stopWord)
        {
            var Marti = new Zebra
            {
                Name = "Marti",
                Age = 13,
            };

            var MrChikChirik = new Bird
            {
                Name = "Mr ChikChirik",
                Age = 67,
            };

            IZooManager zooManager = new ZooManager();
            zooManager.Animals.Add(MrChikChirik);
            zooManager.Animals.Add(Marti);

            switch (choose)
            {
                case 1:
                    {
                        Console.Clear();
                        Marti.Walk();
                    }
                    break;

                case 2:
                    {
                        Console.Clear();
                        MrChikChirik.Fly();
                    }
                    break;

                case 3:
                    {
                        Console.Clear();
                        zooManager.Show();
                    }
                    break;

                case 4:
                    {
                        Environment.Exit(0);
                    }break;

                default:
                    {
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error.Try again.\n\n");
                        Console.ResetColor();

                        Console.ReadKey();

                        Console.Clear();
                        Menu();
                    }break;
            }
        }

        private static bool StopInput()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\nExit Zoo? (Press 'Y' or 'y'): ");
            Console.ResetColor();

            var key = Console.ReadKey().Key;
            Console.WriteLine();
            return key == ConsoleKey.Y;
        }
    }
}
