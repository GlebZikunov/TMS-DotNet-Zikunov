using System;

namespace TeachMeSkills.Zikunov.Homework2
{
    class Program
    {
        public enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }

        static void Main(string[] args)
        {
            inputDay();
        }

        static void inputDay()
        {
            var stopWord = "Yes";
            while (stopWord != "No")
            {
                Console.Clear();

                Console.WriteLine("\nInput day of week: ");
                var dayInput = Console.ReadLine();

                switch (dayInput)
                {
                    case "Monday":
                        {
                            Console.WriteLine("\n\nDay of week is Monday.\n\n");
                            var dates = getDates();
                            showDates(dates, Week.Monday);

                            Console.WriteLine("\n\nDo you want to find another dates? (Type Yes or No) \n\n");
                            stopWord = Console.ReadLine();
                            break;
                        }

                    case "Tuesday":
                        {
                            Console.WriteLine("\n\nDay of week is Tuesday.\n\n");
                            var dates = getDates();
                            showDates(dates, Week.Tuesday);

                            Console.WriteLine("\n\nDo you want to find another dates? (Type Yes or No) \n\n");
                            stopWord = Console.ReadLine();
                            break;
                        }

                    case "Wednesday":
                        {
                            Console.WriteLine("\n\nDay of week is Wednesday.\n\n");
                            var dates = getDates();
                            showDates(dates, Week.Wednesday);

                            Console.WriteLine("\n\nDo you want to find another dates? (Type Yes or No) \n\n");
                            stopWord = Console.ReadLine();
                            break;
                        }

                    case "Thursday":
                        {
                            Console.WriteLine("\n\nDay of week is Thursday.\n\n");
                            var dates = getDates();
                            showDates(dates, Week.Thursday);

                            Console.WriteLine("\n\nDo you want to find another dates? (Type Yes or No) \n\n");
                            stopWord = Console.ReadLine();
                            break;
                        }

                    case "Friday":
                        {
                            Console.WriteLine("\n\nDay of week is Friday.\n\n");
                            var dates = getDates();
                            showDates(dates, Week.Friday);

                            Console.WriteLine("\n\nDo you want to find another dates? (Type Yes or No) \n\n");
                            stopWord = Console.ReadLine();
                            break;
                        }

                    case "Saturday":
                        {
                            Console.WriteLine("\n\nDay of week is Saturday.\n\n");
                            var dates = getDates();
                            showDates(dates, Week.Saturday);

                            Console.WriteLine("\n\nDo you want to find another dates? (Type Yes or No) \n\n");
                            stopWord = Console.ReadLine();
                            break;
                        }

                    case "Sunday":
                        {
                            Console.WriteLine("\n\nDay of week is Sunday.\n\n");
                            var dates = getDates();
                            showDates(dates, Week.Sunday);

                            Console.WriteLine("\n\nDo you want to find another dates? (Type Yes or No) \n\n");
                            stopWord = Console.ReadLine();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Error. Incorrect day of week.");
                            Console.WriteLine("\n\nDo you want to find another dates? (Type Yes or No) \n\n");
                            stopWord = Console.ReadLine();
                            break;
                        }
                }
            }
        }

        static DateTime[] getDates()
        {
            var currentMonth = DateTime.Now.Date.Month;
            var currentYear = DateTime.Now.Date.Year;
            var daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);

            var dates = new DateTime[31];
            for (int i = 1; i < daysInMonth + 1; i++)
            {
                dates[i] = new DateTime(currentYear, currentMonth, i);
            }

            return dates;
        }

        static void showDates(DateTime[] dates, Week day)
        {
            foreach (var date in dates)
            {
                if (date != DateTime.MinValue && date.DayOfWeek.ToString() == day.ToString())
                {
                    Console.WriteLine(date);
                }
            }
        }
    }
}
