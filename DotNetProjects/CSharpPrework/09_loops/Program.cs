using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int number = 500; // number is called a loop control variable or (LCV)

            //2
            while(number <=525)
            {
                //3
                Console.WriteLine(number);
                number = number + 1;
                //4
            }
            //5
            Console.ReadLine();
        }
    }
}
