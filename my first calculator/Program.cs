using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_first_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1:  ");
            double firstnumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Number 2:  ");
            double secondnumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter opeator (+, _, *, /) : ");
            string operation = Console.ReadLine();

            double result;

            switch (operation)
            {
                case "+":
                    result = firstnumber + secondnumber;
                    Console.WriteLine($"Result: {result}");
                    break;
                case "-":
                    result = firstnumber - secondnumber;
                    Console.WriteLine($"Result: {result}");
                    break;
                case "*":
                    result = firstnumber * secondnumber;
                    Console.WriteLine($"Result: {result}");
                    break;
                case "/":
                    if (secondnumber == 0)
                    {
                        Console.WriteLine("Error: cannot divide by zero.");
                    }
                    else
                    {
                        result = firstnumber / secondnumber;
                        Console.WriteLine($"Result: {result}");
                    }
                    break;

                default:
                    Console.WriteLine("invalid operator. please enter +, _, * or /.");
                    break;
            }




        }
    }
}
