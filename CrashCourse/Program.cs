using System;
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
       

            //Give Instruction
            Console.WriteLine("Pick a number 1-3.");
            Console.Read();

            //Declare winning number
            int winningNumber = 2;

            //Accept string from user
            int answer;
            string data = Console.ReadLine();

            //Convert string to int
            int.TryParse(data, out answer);

            //Compare user input with declared value
            if (answer == winningNumber)
            {
                Console.WriteLine("You Win.");
            }
            else
            {
                Console.WriteLine("Sorry, you are wrong.");
            }
            }
        }
    }

