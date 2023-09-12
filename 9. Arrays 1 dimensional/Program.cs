using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays_1_dimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of aarrays
            int[] luckynumbers = { 56,34,70,40,42};
            Console.WriteLine(luckynumbers);
            Console.WriteLine(luckynumbers.Length);
            Console.WriteLine(luckynumbers[3]);
            Console.WriteLine(luckynumbers.Max());
            Console.WriteLine(luckynumbers.Min());

            string[] cars = new string[4];
            cars[0] = "benz";
            cars[1] = "bmw";
            cars[2] = "vw";
            cars[3] = Console.ReadLine();
            
            Console.WriteLine(cars[3]);

            //freeze console
            Console.ReadLine();
        }
    }
}
