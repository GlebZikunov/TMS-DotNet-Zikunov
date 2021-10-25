using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Zikunov.Homework6.Models;

namespace TeachMeSkills.Zikunov.Homework6.Interfaces
{
    public interface IStatistic
    {
        Statistic Get(User user);
    }
}
