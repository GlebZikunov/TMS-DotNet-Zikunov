using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Zikunov.Homework3
{
    /// <summary>
    /// ToDo Class
    /// </summary>
    class ToDo
    {
        private readonly DateTime _dateTime = DateTime.Now;
        private ToDoStatus _status = ToDoStatus.Empty;

        /// <summary>
        /// Unknown
        /// </summary>
        public string NameOfTask { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// SetStatus
        /// </summary>
        /// <param name="Status">Status</param>
        public void SetStatus(ToDoStatus Status)
        {
            _status = Status;
        }

        /// <summary>
        /// GetInformation
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine($"Name: {NameOfTask}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Status: {_status}");
            Console.WriteLine($"DateTime: {_dateTime}");
            Console.WriteLine();
        }

        /// <summary>
        /// Convert status.
        /// </summary>
        /// <param name="status">Before changing</param>
        /// <returns>After changing.</returns>
        public ToDoStatus ChangeStatus(string status)
        {
            return status switch
            {
                "Backlog" => ToDoStatus.Empty,
                "InProgress" => ToDoStatus.InProgress,
                "Done" => ToDoStatus.Done,
                "Canceled" => ToDoStatus.Canceled,
                _ => ToDoStatus.Unknown,
            };
        }
    }
}
