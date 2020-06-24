using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessDiets.Models
{
    public class Calc
    {
        public Calc()
        {
            Height = 0;
            Weight = 0;
            Age = 0;
            Sex = "";
            Activity = 0.0;
            WeightWeek = new double[] {0,0,0};
            WeightMonth = new double[] {0,0,0};
            Kilocalories = new double[] {0,0,0};
        }

        public Calc(int height, int weight, int age, string sex, double activity, double[] weightWeek, double[] weightMonth, double[] kilocalories)
        {
            Height = height;
            Weight = weight;
            Age = age;
            Sex = sex;
            Activity = activity;
            WeightWeek = weightWeek;
            WeightMonth = weightMonth;
            Kilocalories = kilocalories;
        }

        public int Height { get; private set; }
        public int Weight { get; private set; }
        public int Age { get; private set; }
        public string Sex { get; private set; }
        public double Activity { get; private set; }
        public double[] WeightWeek { get; private set; }
        public double[] WeightMonth { get; private set; }
        public double[] Kilocalories { get; private set; }
 
    }
}
