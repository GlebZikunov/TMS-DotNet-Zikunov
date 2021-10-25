using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachMeSkills.Zikunov.Homework6.Enums;

namespace TeachMeSkills.Zikunov.Homework6.Models
{
    public class User
    {
        public User()
        {
        
        }

        public User(
            string fullName,
            double weight,
            int height,
            int age,
            Gender gender)
        {
            FullName = fullName;
            Weight = weight;
            Height = height;
            Age = age;
            Gender = gender;
        }

        public string FullName { get; set; }
        
        public double Weight { get; set; }

        public int Height { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public List<Run> Runs { get; set; } = new List<Run>();

        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}
