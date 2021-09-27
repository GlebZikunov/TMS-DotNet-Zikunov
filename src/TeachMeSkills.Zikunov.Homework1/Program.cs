using System;

namespace TeachMeSkills.Zikunov.Homework1
{
    class Program
    {
        public static int numberOfTheDay(int DD, int MM, int YY)
        {
            int a, y, m, R;
            a = (14 - MM) / 12;
            y = YY - a;
            m = MM + 12 * a - 2;
            R = 7000 + (DD + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12);

            return R % 7;
        }
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Sunday", "Monday", "Tuersday",
            "Wednesday", "Thirsday", "Friday", "Saturday" };

            Console.WriteLine("Enter day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n\nDay of the week is {daysOfWeek[numberOfTheDay(day, month, year)]}");
            Console.ReadKey();
    }
}
