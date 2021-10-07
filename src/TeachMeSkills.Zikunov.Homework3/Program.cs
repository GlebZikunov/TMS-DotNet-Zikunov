using System;
using System.Collections.Generic;

namespace TeachMeSkills.Zikunov.Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListOfTasks = new List<ToDo>();
            bool stopWord = false;
            
            InputInfo(ListOfTasks, stopWord);
            ShowInfo(ListOfTasks);
            
            ChangeInfo(ListOfTasks, stopWord);
            Console.Clear();

            ShowInfo(ListOfTasks);
            Console.ReadLine();
        }

        private static void InputInfo(List<ToDo> List, bool stopWord)
        {
            while (!stopWord)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter name of task: ");
                Console.ResetColor();
                var nameOfTask = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter Description of task: ");
                Console.ResetColor();
                var descriptionOfTask = Console.ReadLine();

                var Task = new ToDo
                {
                    NameOfTask = nameOfTask,
                    Description = descriptionOfTask,
                };

                List.Add(Task);

                stopWord = StopInput();
                Console.WriteLine();
            }
        }

        private static void ShowInfo(List<ToDo> List)
        {
            Console.WriteLine("=======================================");
            foreach (var todo in List)
            {
                todo.GetInfo();
            }
            Console.WriteLine("=======================================\n");
        }

        private static void ChangeInfo(List<ToDo> List, bool stopWord)
        {
            while(!stopWord)
            {                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter name of task: ");
                Console.ResetColor();

                var userInput = Console.ReadLine();

                foreach(var Task in List)
                {
                    
                    if(Task.NameOfTask == userInput)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Task found. Enter a new status(InProgress, Done, Canceled): ");
                        Console.ResetColor();

                        var newStatus = Console.ReadLine();
                        Task.SetStatus(Task.ChangeStatus(newStatus));
                    }
                }

                stopWord = StopInput();
                Console.WriteLine();
            }
        }

        private static bool StopInput()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\nDo you want to stop? (If yes type 'Y' or 'y'): ");
            Console.ResetColor();

            var key = Console.ReadKey().Key;
            Console.WriteLine();
            return key == ConsoleKey.Y;
        }
    }
}
