﻿using System;

namespace Exercise6_FIZZBUZZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer");
            int userInt = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i < userInt + 1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write("FizzBuzz ");
                else if (i % 3 == 0)
                    Console.Write("Fizz ");
                else if (i % 5 == 0)
                    Console.Write("Buzz ");
                else
                    Console.Write($"{i} ");

                if (i % 20 == 0) Console.Write("\n");
            }
        }
    }
}