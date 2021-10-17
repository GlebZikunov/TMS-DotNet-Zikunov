using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Zikunov.Homework6.Managers
{
    class NotificationManager 
    {
        public static void Show(string message, DateTime dateTime)
        {
            Console.WriteLine($"{message}\t{dateTime}");
        }
    }
}
