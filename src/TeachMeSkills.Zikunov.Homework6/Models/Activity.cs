using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Zikunov.Homework6.Models
{
    public abstract class Activity<T> where T: struct
    {
        public string Name { get; set; }

        public DateTime Start { get; set; }
 
        public DateTime End { get; set; }

        public T Data { get; set; }
    }
}
