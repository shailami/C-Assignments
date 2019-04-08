using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            if (num == 1 || num == 0)
            {
                Console.WriteLine("Neither Prime nor Composite");
            }
            else
            {
                for (int i = 2; i <= (num / 2); i++)
                {
                    if (num % i == 0)
                    { 
                        count++;
                    }

                }
                if(count==0)
                {
                    Console.WriteLine("PRIME NUMBER");
                }
                else
                {
                    Console.WriteLine("NOT A PRIME NUMBER");
                }

            }
            Console.ReadKey();
        }
    }
}
