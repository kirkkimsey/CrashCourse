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
            //bool playGame = true;
            //do
            //{

            //}
            //while (playGame);

            //int lives = 5;
            //for (int i = 0; i < lives; i++)
            //{

            //}

            //string[] stuff = new string[5];

            ArrayList stuff = new ArrayList();
            stuff.Add("cat");
            stuff.Add("dog");
            stuff.Add("squirrel");

            List<string> stuff2 = new List<string>();
            stuff2.Add("cat");
            stuff2.Add("dog");
            stuff2.Add("squirrel");
            //stuff2.RemoveAt(1);
            //stuff2.RemoveAt(stuff2.IndexOf("squirrel"));
            var index = stuff2.IndexOf("cat");
            if (index > 0)
            {
                stuff2.RemoveAt(index);
            }

            foreach (var animal in stuff2)
            {
                Console.WriteLine(animal);
            }
            Console.Read();
        }
    }
    }

