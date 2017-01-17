using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    public abstract class Animal
    {
     
        public string Describe()
        {
            return "A " + this.Breed + "'s average wieght is " + this.AvgWeight + "lbs.";
        }

        public string Mood()
        {
            return this.Breed + "'s have a " + this.Temperament + " mood.";
        }

        public virtual string MakeNoise()
        {
            return "Meow";
        }
    }
}
