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
            //Add Dog attributes
            var Dog = new Dog();
            Dog.Breed = "Great Dane";
            Dog.AvgWeight = 165.5;
            Dog.Temperament = "Friendly";

            var dog1 = new Dog();
            Dog.Breed = "Pitbull";
            Dog.AvgWeight = 50;
            Dog.Temperament = "Affectionate";

            var dog2 = new Dog();
            Dog.Breed = "Bloodhound";
            Dog.AvgWeight = 100;
            Dog.Temperament = "Stubborn";

            var dog3 = new Dog();
            Dog.Breed = "Dachsund";
            Dog.AvgWeight = 25;
            Dog.Temperament = "Clever";

            //Add Cat Attributes
            var cat = new Cat();
            cat.Breed = "Persian Cat";
            cat.AvgWeight = 10;
            cat.Temperament = "Gentle";

            var cat1 = new Cat();
            cat.Breed = "Maine Coon";
            cat.AvgWeight = 16;
            cat.Temperament = "Gentle";

            var cat2 = new Cat();
            cat.Breed = "Siamese Cat";
            cat.AvgWeight = 12;
            cat.Temperament = "Affectionate";

            var cat3 = new Cat();
            cat.Breed = "British Shorthair";
            cat.AvgWeight = 8;
            cat.Temperament = "Easy Going";

            Lazy<Dog> dog = new List<Dog>();
            

            List<Animal> Animal = new List<Animal>();
            Animal.Add();
           



            Console.WriteLine(noise);
            Console.Read();

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

