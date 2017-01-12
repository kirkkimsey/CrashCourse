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
            //Car car1 = new Car("Red");
            //string description = car1.Describe();
            //Console.WriteLine(description);
            //string action = car1.Drive();
            //Console.WriteLine(action);

            List<Car> cars = new List<Car>();
            cars.Add(new Car("Red"));
            cars.Add(new Car("Green"));
            cars.Add(new Car("Blue"));
            cars.Add(new Car("Black"));
            cars.Add(new Car("White"));

            foreach (Car car in cars) {
                string description = car.Describe();
                Console.WriteLine(description);
            }
            Console.Read();
        }
    }
    }

