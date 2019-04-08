using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
       
            int fibonacci(int number)
            { 
                if (number == 0 || number == 1)
                {
                    return 1;
                }
                else
                {
                    return (fibonacci(number- 1) + fibonacci(number - 2));
                }
            }

            for(int i = 0; i <= num; i++)
            {
                Console.WriteLine(fibonacci(i));
            }
            Console.ReadKey();
        }
    }
}
