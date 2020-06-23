using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment
{
    class Program12
    {
        static void Main()
        {
            int[] arr1 = new int[3];
            int i, mx;
            Console.WriteLine("Input 3 elements in the array :\n");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            mx = arr1[0];
            for (i = 0; i < 3; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }
            }
            Console.WriteLine("Largest among 3 number " + mx);
            Console.ReadKey();
        }
    }
}
