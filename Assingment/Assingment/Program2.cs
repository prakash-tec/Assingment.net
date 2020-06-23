using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment
{
    class Program2
    {
        static void Main()
        {
            Console.WriteLine("Enter the 1st number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2st number");
            int n2 = int.Parse(Console.ReadLine());
            while(n1<=n2)
            {
                Console.WriteLine(n1);
                n1++;
            }
            Console.ReadKey();

        }
    }
}
