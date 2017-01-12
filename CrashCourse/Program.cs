using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Great Dane", 165.5, "Friendly"));
            dogs.Add(new Dog("Pitbull", 50, "Affectionate"));
            dogs.Add(new Dog("Bloodhound", 100, "Stubborn"));
            dogs.Add(new Dog("Dachshund", 25, "Clever"));

            foreach (Dog dog in dogs) {
                string description = dog.Describe();
                string mood = dog.Mood();
                Console.WriteLine(description);
                Console.WriteLine(mood);
            }
            Console.Read();
        }
    }
    }

