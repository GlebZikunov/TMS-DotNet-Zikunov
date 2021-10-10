using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Zikunov.Homework4.Interfaces
{
    interface IZooManager
    {
        List<Models.AnimalBase<int>> Animals { get; set; }

        void Show();
    }
}
