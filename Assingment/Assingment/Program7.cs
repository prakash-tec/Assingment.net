using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment
{
    class Program7
    {
        static void Main()
        {
            int i, fact = 1, number;
            Console.WriteLine("Enter any number :");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial is {0}", fact);
            Console.ReadKey();
        }
    }
}
