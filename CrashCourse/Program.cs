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



            List<Animal> Animal = new List<Animal>();
            Animal.Add(new Dog("Great Dane", 165.5, "Friendly"));
            Animal.Add(new Dog("Pitbull", 50, "Affectionate"));
            Animal.Add(new Dog("Bloodhound", 100, "Stubborn"));
            Animal.Add(new Dog("Dachshund", 25, "Clever"));
            Animal.Add(new Cat("Persian Cat", 10, "Gentle"));
            Animal.Add(new Cat("Maine Coon", 16, "Gentle"));
            Animal.Add(new Cat("Siamese Cat", 12, "Affectionate"));
            Animal.Add(new Cat("British Shorthair", 8, "Easy Going"));





            foreach (Animal animal in Animal)
            {
                string description = animal.Describe();
                string mood = animal.Mood();
                Console.WriteLine(description);
                Console.WriteLine(mood);
            }

            Console.Read();
        }

        
    }
        }

