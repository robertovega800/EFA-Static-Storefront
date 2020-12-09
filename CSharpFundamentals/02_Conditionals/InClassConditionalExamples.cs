using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class InClassConditionalExamples
    {
        [TestMethod]
        public void IfElseStatements()
        {
            int studentCount = 16;
            if (studentCount >= 20)
            {
                Console.WriteLine("The class is getting pretty small");
            }
            else if (studentCount >= 10)
            {
                Console.WriteLine("This class is really small");
            }
            else
            {
                Console.WriteLine("How many students do you have?");
            }

            switch (studentCount)
            {
                case 12:
                    Console.WriteLine("You have exactly 12 students");
                    break;
                case 10:
                    Console.WriteLine("You have exactly 10 students");
                    break;
                case 13:
                case 14:
                case 15:
                    Console.WriteLine("You have x number of students");
                    break;
                default:
                    Console.WriteLine("How many students do you have?");
                    break;

            }
            //Ternaries
            bool result = (studentCount == 10) ? true : false;
            string isGoodSize = (studentCount < 65) ? "This class is manageable" : "Oh boy that's a lot of students";
        }
    }
}
