using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Zikunov.Homework6.Interfaces;
using TeachMeSkills.Zikunov.Homework6.Models;

namespace TeachMeSkills.Zikunov.Homework6.Services
{
    public class Functionality : IFunctionality
    {
        public event Action<string, DateTime> Notification;

        public DateTime Execute(string message)
        {
            var currentTime = DateTime.Now;
            Notification?.Invoke(message, currentTime);
            return currentTime;
        }

        public void ShowExercises(User user)
        {
            foreach(var run in user.Exercises)
            {
                Console.WriteLine($"{run.Name}, {run.End - run.Start}");
            }
        }

        public void ShowRuns(User user)
        {
            foreach (var run in user.Runs)
            {
                Console.WriteLine($"{run.Name}, {run.End - run.Start}");
            }
        }

        public void ShowAll(User user)
        {
            Console.WriteLine("\n---------------------------------------");
 
            var activities = user.Runs.Select(x => new
            {
                x.Name,
                Data = $"{x.Data} - {x.Speed}",
                Date = x.Start,
            })
            .Concat(user.Exercises
                .Select(x => new
                {
                    x.Name,
                    Data = $"{x.Data} - {x.Count}",
                    Date = x.Start,
                }))
            .OrderBy(x => x.Date);

            foreach (var activity in activities)
            {
                Console.WriteLine($"{activity.Name}, {activity.Date}: {activity.Data}");
            }

            Console.WriteLine("---------------------------------------\n");
        }
    }
}
