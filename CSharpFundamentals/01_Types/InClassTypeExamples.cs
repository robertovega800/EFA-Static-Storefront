using System;
using System.Collections.Generic;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class InClassTypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
           int age = 32;

            byte someByte = 23;

            int anotherNumber = 23;

            anotherNumber = 256;

            double someDouble = 23.345343434;
            float someFloat = 23.34343424f;
            decimal someDecimal = 23.3434434m;

            char letter = 'm';
            bool trueOrFalse = true;

        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string randomCharacters = "asdkfjadf sfjdf @ #.";
            string specialCharacters = "\"Michael\"";
            string otherSpecialCharacters = "\n"; // line return
            Console.WriteLine(specialCharacters);

            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            TimeSpan age = DateTime.Now - new DateTime(1988, 04, 11);
            Console.WriteLine(age);

            string[] names = { "Casey", "Miachael", "Simon" };
            List<string> fruits = new List<string>();
            fruits.Add("grape");
            fruits.Add("apple");

            Dictionary<char, double> dictionary = new Dictionary<char, double>();
            dictionary.Add('x', 3.1459);
            dictionary['x'] = 3423425.2423; // changing the value in the value pair

            Console.WriteLine(fruits[1]);
            Console.WriteLine(dictionary['x']);
        }
    }
}
