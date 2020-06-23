using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment
{
    class Program17
    {
        static void Main()
        {
            Console.WriteLine("Enter the first string: ");
            String string1 = Console.ReadLine();

            Console.WriteLine("Enter the second string :");

            String string2 = Console.ReadLine();

            if (string1.Equals(string2) == true)
            {
                Console.WriteLine("\nAre both strings same: Yes");
            }
            else
            {
                Console.WriteLine("\nAre both strings same: No");
            }
            Console.ReadKey();
        }
    }
}
