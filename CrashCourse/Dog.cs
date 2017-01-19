using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    public class Dog: Animal, IAnimal

    {

        // Constructor
        public Dog(string breed, double avgWeight, string temperament)
        {
            this.Breed = breed;
            this.AvgWeight = avgWeight;
            this.Temperament = temperament;
        }

        public Dog()
        {
        }

        public string Describe()
        {
            return "A " + this.Breed + "'s average wieght is " + this.AvgWeight + "lbs.";
        }

        public string Mood()
        {
            return this.Breed + "'s have a " + this.Temperament + " mood.";
        }

        public string makeNoise()
        {
            return "Woof!";
        }

        public void walk()
        {
            //TODO: FixLater
            throw new NotImplementedException();
        }
    }


    }

   
