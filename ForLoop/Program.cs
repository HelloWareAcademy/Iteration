using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i == 52)
                {
                    continue;
                }
                int eachElement = i + 1;
                Console.Write(eachElement + " ");
                sum = sum + eachElement;
            }
            Console.WriteLine("The sum is: " + sum);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(j+1);
                }
                Console.WriteLine();
            }
        }
    }
}
