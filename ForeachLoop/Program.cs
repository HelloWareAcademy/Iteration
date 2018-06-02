using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //immutable == not able to change
            int[] anotherArray = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int[] intArray = new int[5];
            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;
            intArray[3] = 4;
            intArray[4] = 5;
            //Example of an array not being able to change.
            //intArray[5] = 6;
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            List<int> convertedList = intArray.ToList();

            foreach (int anInt in intArray)
            {
                Console.WriteLine(anInt);
            }
            Console.WriteLine("--------------------------");
            List<int> intList = new List<int>();
            intList.Add(6);
            intList.Add(6);
            intList.Add(8);
            intList.Add(9);
            intList.AddRange(intArray);
            intList.Remove(6);

            int[] convertedArray = intList.ToArray();

            foreach (int anInt in intList)
            {
                Console.WriteLine(anInt);
            }
        }
    }
}
