using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 0; i < 9; i++)
            {
                if (i <= 3)
                {
                    for (int j = 0; j < k; j++)
                    {
                        Console.Write("*");
                    }
                    k = k + 2;
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < k; j++)
                    {
                        Console.Write("*");
                    }
                    k = k - 2;
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
