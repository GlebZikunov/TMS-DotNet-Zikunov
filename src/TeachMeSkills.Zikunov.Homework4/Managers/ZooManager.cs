using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Zikunov.Homework4.Managers
{
    class ZooManager : Interfaces.IZooManager
    {
        public List<Models.AnimalBase<int>> Animals { get; set; } = new List<Models.AnimalBase<int>>();

        public void Show()
        {
            foreach(var animal in Animals)
            {
                Console.WriteLine($"\nAnimal:\t{animal.Name}\nAge:\t{animal.Age}\n");
            }
        }
    }
}
