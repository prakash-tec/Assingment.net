using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment
{
    class Program5
    {
        static void Main()
        {
            double celsius;
            Console.Write("Enter the Fahrenheit temperture:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is " + celsius);
            Console.ReadKey();
        }
    }
}
