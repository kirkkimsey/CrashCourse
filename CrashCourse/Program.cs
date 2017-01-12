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
            string name = "Kirk";
            string greeting = Greeting(name);
            Console.WriteLine(greeting);
            DoStuff("Kirk");
            Console.WriteLine(name);
            Console.Read();
        }
        public static void DoStuff() {
            Console.WriteLine("Hello from DoStuff()");
        }
        public static void DoStuff(string name) {
            Console.WriteLine("Hello, " + name);
        }
        public static string Greeting(string name) {
            name = "Eduardo";
            return "Hello, " + name;
        }
    }
    }

