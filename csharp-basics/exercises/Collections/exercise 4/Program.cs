﻿using System;
using System.Collections.Generic;

namespace exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Brains();
        }

        static void Exit()
        {
            Console.Clear();
            Console.Write("Do you want to continue (Y/N)? ");
            Console.WriteLine(" ");
            char ch = Console.ReadLine()[0];
            if (ch == 'n' || ch == 'N')
            {
                Environment.Exit(0);
            }
            Console.Clear();
            Brains();
        }

        private static void Brains()
        {
            var myHashSet = new HashSet<int>();
            Console.WriteLine("Enter number to check for 'happines': ");
            var userValue = Console.ReadLine();
      
            if (int.TryParse(userValue, out int value))
            {
                if (value < 0)
                {
                    Console.WriteLine("Error! Positive numbers only");
                }
                myHashSet.Add(value);
                do
                {
                    value = SummingTheSquaresOfInputDigits(value);
                    Console.WriteLine(value);
                    if (value == 1)
                    {
                        Console.WriteLine("Happy");
                        Console.ReadKey();
                        Exit();
                    }

                    if (myHashSet.Contains(value))
                    {
                        Console.WriteLine("Not happy");
                        Console.ReadKey();
                        Exit();
                    }

                    myHashSet.Add(value);
                } while (value > 1 || myHashSet.Contains(value) != true);
            }
            else
            {
                Console.WriteLine("Error! Numbers Only!");
                Brains();
            }
        }

        static int SummingTheSquaresOfInputDigits(int number) // do each number individually.
        {                                                    
            int squareSum = 0;                                 
            while (number != 0)             
            {
                squareSum += (number % 10) * (number % 10);
                number /= 10;       // this doesnt do anything, only checking if need to countinue loop.
            }
            return squareSum;
        }
    }
}
