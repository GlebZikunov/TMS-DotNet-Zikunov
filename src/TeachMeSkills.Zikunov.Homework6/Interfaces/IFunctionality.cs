using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Zikunov.Homework6.Models;

namespace TeachMeSkills.Zikunov.Homework6.Interfaces
{
    public interface IFunctionality
    {
        event Action<string, DateTime> Notification;

        DateTime Execute(string message);

        void ShowAll(User user);

        void ShowRuns(User user);

        void ShowExercises(User user);
    }
}
