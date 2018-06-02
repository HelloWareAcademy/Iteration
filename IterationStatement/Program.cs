using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool incorrect = true;
            Console.Write("trgd fgd agaf sdfs ");
            Console.WriteLine();
            Console.WriteLine("Question:2-1=?");
            Console.WriteLine("A:1\nB:2\nC:3\nD:4?");
            
            while (incorrect)
            {
                Console.WriteLine("Please choose an answer:");
                string answer = Console.ReadLine();
                incorrect = !(answer == "A" || answer == "a");
                Console.WriteLine(incorrect ? "Incorrect" : "Correct");
            }

            int i = 0;

            while (i < 10)
            {
                Console.Write(i+1+" ");
                i++;//i = i +1;
            }


        }
    }
}
