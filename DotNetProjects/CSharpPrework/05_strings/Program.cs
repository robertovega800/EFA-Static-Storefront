﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {
           string first = "The Cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";

            Console.WriteLine(first + second);
         //result: The cars we sell are BMW, Lexus, and Mercedes.

            string firstName = "Jenn";
            string lastName = "Williams";

            Console.WriteLine("Her name is {0} {1}." firstName, lastName);

            //result: Her name is Jenn Williams.

            string firstName = "Robin";
            string lastName = "Holler";
            
            Console.WriteLine($"Her name is {firstName} {lastName}");

           Console.ReadLine();
        }
    }
}
