using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Zikunov.Homework4.Models
{
    abstract class AnimalBase<T>
    {
        public string Name { get; set; }

        public T Age { get; set; }
    }
}
