using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swicth_Case_Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your first Number : ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Your second Number : ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Which Operation you Want : [+,-,*,/,% ]");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} is {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"{num1} - {num2} is {num1 - num2}");
                    break;

                case "*":
                    Console.WriteLine($"{num1} * {num2} is {num1 * num2}");
                    break;

                case "/":
                    Console.WriteLine($"{num1} / {num2} is {num1 / num2}");
                    break;

                case "%":
                    Console.WriteLine($"{num1} % {num2} is {num1 % num2}");
                    break;

                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }


            Console.ReadKey();
        }
    }
}
