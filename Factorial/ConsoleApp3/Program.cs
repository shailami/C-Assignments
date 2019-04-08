using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static int factorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                int result=factorial(num - 1)*num;
                return result;
            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
            int result = factorial(num);
            Console.WriteLine("Factorial of " + num + " is " + result);
            Console.ReadKey();
        }
        
            
    }
    
}
