﻿using System;
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
            Console.WriteLine("Pick a number (1-5)");
            //Declare winning numbers
            const int winningNumber1 = 3;
            const int winningNumber2 = 5;
            //collect user date
            string userData = Console.ReadLine();
            int userNumber;
            int.TryParse(userData, out userNumber);
            //do they match?
            switch (userNumber) {
                case winningNumber1:
                Console.WriteLine("You win!");
                    break;
                case winningNumber2:
                   Console.WriteLine("you kind of win");
                    break;
                default:
                    Console.WriteLine("You Lose");
                    break;
            }
            Console.Read();

            ////Give Instruction
            //Console.WriteLine("Pick a number 1-3.");


            ////Declare winning number
            //int winningNumber = 2;

            ////Accept string from user
            //string data = Console.ReadLine();

            ////Convert string to int
            //int answer;
            //int.TryParse(data, out answer);

            ////Compare user input with declared value
            //if (answer == winningNumber)
            //{
            //    Console.WriteLine("You Win.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you are wrong.");
            //}
            //Console.Read();
        }
    }
    }

