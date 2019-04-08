using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] digitFact = new int[10];
            int count = 0,sum=0;
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            while (num > 0)
            {
                int digit = num % 10;
                array[count] = digit;
                num /= 10;                
                digitFact[count]=fact(array[count]);
                //Console.WriteLine(digitFact[count]);
                sum += digitFact[count];
                count++;
            }
            Console.WriteLine(sum);
            int fact(int number)
            {
                if (number == 0 || number == 1)
                {
                    return 1;
                }
                else
                {
                    return (number * fact(number - 1));
                }
            }

            if (sum == temp)
            {
                Console.WriteLine("Strong Number");
            }
            else
            {
                Console.WriteLine("Not a Strong Number");
            }

            Console.ReadKey();
        }
    }
}
