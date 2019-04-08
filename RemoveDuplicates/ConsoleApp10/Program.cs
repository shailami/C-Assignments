using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a number");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int[] noDuplicateArray = array.Distinct().ToArray();
            for (int i = 0; i < noDuplicateArray.Length; i++)
            {
                Console.WriteLine(noDuplicateArray[i]);
            }



                Console.ReadKey();
        }
    }
}
