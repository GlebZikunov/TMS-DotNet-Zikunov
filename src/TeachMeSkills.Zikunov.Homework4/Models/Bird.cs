using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Zikunov.Homework4.Models
{
    class Bird : AnimalBase<int>
    {
        public void Fly()
        {
            Console.WriteLine($"Bird is flying!\n");
            Console.WriteLine("ЧЫК ЧЫРЫК! ЧЫК ЧЫРЫК!");
        }
    }
}
