using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool flag = false;
            double a=0, b=0;
            void GetValue()
            {
                Console.WriteLine("Enter values of A");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter values of B");
                b = double.Parse(Console.ReadLine());
            }
            do
            {
                Console.WriteLine();
                Console.WriteLine("Calculator is ON !");
                Console.WriteLine("Select Operation:");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Exit");

                choice = int.Parse(Console.ReadLine());
                //Console.WriteLine(choice);
   
                switch (choice)
                {
                    case 1:
                        GetValue();
                        Console.WriteLine("Addition of " + a + " & " + b + " is " + (a + b));
                        break;
                    case 2:
                        GetValue();
                        Console.WriteLine("Subtraction of " + a + " & " + b + " is " + (a - b));
                        break;
                    case 3:
                        GetValue();
                        Console.WriteLine("Multiplication of " + a + " & " + b + " is " + (a * b));
                        break;
                    case 4:
                        GetValue();
                        Console.WriteLine("Division of " + a + " & " + b + " is " + (a / b));
                        break;
                    case 5: flag = true;
                        //Console.WriteLine("Calculator Closed !");
                        //Console.WriteLine(flag);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (flag == false);
            //Console.ReadKey();

        }
    }
}
