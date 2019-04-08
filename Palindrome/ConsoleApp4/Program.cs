using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str1 = Console.ReadLine();
            char[] strArray1 = new char[10];
            strArray1 = str1.ToCharArray();
            char[] strArray2 = strArray1;
            Array.Reverse(strArray2);
            string str2 = new string(strArray2);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            if (str1.Equals(str2))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
            Console.ReadKey();

        }
    }
}
