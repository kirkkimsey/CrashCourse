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

            List<Cat> cats = new List<Cat>();
            dogs.Add(new Dog("Persian Cat", 10, "Gentle"));
            dogs.Add(new Dog("Maine Coon", 16, "Gentle"));
            dogs.Add(new Dog("Siamese Cat", 12, "Affectionate"));
            dogs.Add(new Dog("British Shorthair", 8, "Easy Going"));

            foreach (Dog dog in dogs) {
                string description = dog.Describe();
                string mood = dog.Mood();
                Console.WriteLine(description);
                Console.WriteLine(mood);
            }

            foreach (Cat cat in cats) { 
                string description = cat.Describe();
                string mood = cat.Mood();
                Console.WriteLine(description);
                Console.WriteLine(mood);
             }

            Console.Read();
        }
    }
    }

