using System;
using System.Threading;
using TeachMeSkills.Zikunov.Homework6.Enums;
using TeachMeSkills.Zikunov.Homework6.Interfaces;
using TeachMeSkills.Zikunov.Homework6.Managers;
using TeachMeSkills.Zikunov.Homework6.Models;
using TeachMeSkills.Zikunov.Homework6.Services;

namespace TeachMeSkills.Zikunov.Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            IStatistic statistic = new Statistics();
            IFunctionality functionality = new Functionality();
            functionality.Notification += NotificationManager.Show;
            var user = new User("FULL NAME", 80, 187, 24, Gender.Male);

            Console.BackgroundColor = ConsoleColor.Green;
            var run = new Run
            {
                Name = "Marathon of TMS!",
                Speed = 15,
            };

            var firstTime = 10000;
            run.Start = functionality.Execute($"Start {run.Name}");
            Thread.Sleep(firstTime);
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Red;
            run.End = functionality.Execute($"End {run.Name}");
            Console.ResetColor();

            user.Runs.Add(run);
            functionality.ShowRuns(user);

            Console.BackgroundColor = ConsoleColor.Green;
            var exercise = new Exercise
            {
                Name = "Deadlift",
                Count = 12,
            };

            var secondTime = 30000;
            exercise.Start = functionality.Execute($"\n\nStart {exercise.Name}");
            Thread.Sleep(secondTime);
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Red;
            exercise.End = functionality.Execute($"End {exercise.Name}: ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Blue;
            user.Exercises.Add(exercise);
            functionality.ShowAll(user);
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
