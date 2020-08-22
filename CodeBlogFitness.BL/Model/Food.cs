using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFitness.BL.Model
{
    [Serializable]
    public class Food
    {
        public string Name { get; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public double Carbohydrates { get; }
        public double Calories { get; }
        public Food(string name) : this(name,0,0,0,0)
        { }
        public Food(string name,double calories,double proteins,double fats, double carbohydrates)
        {
            Name = name;
            Calories = calories / 100.0 ;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;
            // ?

        }
        public override string ToString()
        {
            return Name;
        }

    }
}
