using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Zikunov.Homework4.Models
{
    class Zebra : AnimalBase<int>
    {
        public void Walk()
        {
            Console.WriteLine("Zebra is walking across the lawn!");
        }
    }
}
