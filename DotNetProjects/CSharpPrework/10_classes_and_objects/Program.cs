using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //1    //2         //3    //4
            Donut dougDonut = new Donut();
            Donut chrisDonut = new Donut();
            Donut nickDonut = new Donut();

            //setting property values
            //1         //2         //3
            dougDonut.Filling = "cherry";
            dougDonut.Price = 3;
            dougDonut.Type = "normal";
            dougDonut.IsSpecial = true;
            dougDonut.Sprinkles = "yes";


            chrisDonut.Filling = "none";
            chrisDonut.Price = 2;
            chrisDonut.Type = "normal";
            chrisDonut.IsSpecial = false;
            chrisDonut.Sprinkles = "yes";

            nickDonut.Filling = "chocolate";
            nickDonut.Price = 3;
            nickDonut.Type = "normal";
            nickDonut.IsSpecial = true;
            nickDonut.Sprinkles = "yes";

            Console.WriteLine(nickDonut.Price);
            Console.ReadLine();


        }
    }
}
