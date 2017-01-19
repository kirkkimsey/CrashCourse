using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    public class Cat : Animal
    {

        //// Atribute / Properties


        // Constructor
        public string Breed { get; set; }
        public double AvgWeight { get; set; }
        public string Temperament { get; set; }
 
       
        public Cat(string breed, double avgWeight, string temperament)
        {
            this.Breed = breed;
            this.AvgWeight = avgWeight;
            this.Temperament = temperament;
        }
          public string Describe()
        {
            return "A " + this.Breed + "'s average wieght is " + this.AvgWeight + "lbs.";
        }

        public string Mood()
        {
            return this.Breed + "'s have a " + this.Temperament + " mood.";
        }
    }
}
    
