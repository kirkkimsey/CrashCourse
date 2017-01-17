using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    public abstract class Animal
    {
        public string Breed { get; set; }
        public double AvgWeight { get; set; }
        public string Temperament { get; set; }


        public virtual string MakeNoise()
        {
            return "Meow";
        }
    }
}
