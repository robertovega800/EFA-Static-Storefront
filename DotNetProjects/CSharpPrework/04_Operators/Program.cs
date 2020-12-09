using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5" + "2"); //result = 7
            Console.WriteLine(10 - 6); //result = 4
            Console.WriteLine(2 * 3); //result = 6
            Console.WriteLine(10 / 2); //result = 5

            Console.WriteLine(10 % 2); //result = 0(10/2 = 5 w/remainder of 0)
            Console.WriteLine(10 % 9); //result = 1(10/9 = 1 w/remainder of 1)
            Console.WriteLine(16 % 3); // result = 1(16/3 = 5 w/remainder of 1)
            Console.WriteLine(19 % 5); //result = 4(19/5 = 3 w/remainder of 4)

            Console.WriteLine(10 % 3); // result = 1(10/3 = 3 w/remainder of 1)
            Console.WriteLine(9 % 2); //result = 1(9/2 = 4 w/remainder of 1)
            Console.WriteLine(100 % 22); //result = 12(100/22 = 4 w/remainder 12)
            Console.WriteLine(13 % 12); //result = 1(13/12 = 1 w/remainder 1)

            Console.WriteLine(3 + 3);
            Console.WriteLine(12 - 6);
            Console.WriteLine(1 * 6);
            Console.WriteLine(24 / 4);
            Console.ReadLine();
        }
    }
}
