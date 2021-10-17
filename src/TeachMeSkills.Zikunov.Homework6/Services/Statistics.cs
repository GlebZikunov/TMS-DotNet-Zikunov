using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Zikunov.Homework6.Interfaces;
using TeachMeSkills.Zikunov.Homework6.Models;

namespace TeachMeSkills.Zikunov.Homework6.Services
{
    public class Statistics : IStatistic
    {
        public Statistic Get(User user)
        {
            return new Statistic
            { 
                AverageCount = GetAverageCount(user),
                AverageSpeed = GetAverageSpeed(user),
            };
        }

        private double GetAverageSpeed(User user)
        {
            return user.Runs.Average(run => run.Speed);
        }

        private double GetAverageCount(User user)
        {
            return user.Exercises.Average(exercise => exercise.Count);
        }
    }
}