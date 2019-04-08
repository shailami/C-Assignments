using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit;
            double sum = 0;
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            double[] array = new double[10];
            while (num > 0)
            {
                int count=0;
                digit = num % 10;
                num /= 10;
                array[count] = Math.Pow(digit,3);
                sum += array[count];
                count++;
            }
            if(temp==sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not a Armstrong number");
            }
            Console.ReadKey();
        }
    }
}
