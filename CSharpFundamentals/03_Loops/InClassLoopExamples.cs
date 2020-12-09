using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class InClassLoopExamples
    {
        [TestMethod]
        public void Loops()
        {
            int studentCount = 10;

            //For Loop
            for (int i = 0; i <= studentCount; i++) // i = i + 1;
            {
                Console.WriteLine(i); 
            }

            string[] names = { "Michael", "Simon", "Peyton", "Casey" };
            Console.WriteLine(names); // doesn't give us individual strings

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(names.Length); // Give the number of strings in the array

           while (studentCount > 0)
            {
                Console.WriteLine(studentCount);
                studentCount --;
            }
        } 

    }
}
