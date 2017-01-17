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
            //var test = new Dog();
            //var noise = test.MakeNoise();
            //Console.WriteLine(noise);
            //var test2 = new Cat();
            //noise = test2.MakeNoise();

            //Console.WriteLine(noise);
            //Console.Read();

          


            List<Animal> animal = new List<Animal>();
            animal.Add(new Dog("Great Dane", 165.5, "Friendly"));
            animal.Add(new Dog("Pitbull", 50, "Affectionate"));
            animal.Add(new Dog("Bloodhound", 100, "Stubborn"));
            animal.Add(new Dog("Dachshund", 25, "Clever"));
            animal.Add(new Cat("Persian Cat", 10, "Gentle"));
            animal.Add(new Cat("Maine Coon", 16, "Gentle"));
            animal.Add(new Cat("Siamese Cat", 12, "Affectionate"));
            animal.Add(new Cat("British Shorthair", 8, "Easy Going"));

            Console.Read();

            //        foreach (Dog dog in dogs) {
            //            string description = dog.Describe();
            //            string mood = dog.Mood();
            //            Console.WriteLine(description);
            //            Console.WriteLine(mood);
            //        }

            //        foreach (Cat cat in cats) { 
            //            string description = cat.Describe();
            //            string mood = cat.Mood();
            //            Console.WriteLine(description);
            //            Console.WriteLine(mood);
            //         }

            //        Console.Read();
        }
            }
        }

