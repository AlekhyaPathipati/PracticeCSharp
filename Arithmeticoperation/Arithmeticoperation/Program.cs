using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmeticoperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum;
            double secondNum;
            double answer;
            String ops;

            Console.WriteLine(".....Console Calculator....");
            Console.WriteLine("Select an operator: (+, -, *, /)");
            ops = Console.ReadLine();
            do
            {
                
                if ((ops == "+") || (ops == "-") || (ops == "*") || (ops == "/"))
                {
                    Console.WriteLine("Enter firstNum = ");
                    firstNum = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter secondNum = ");
                    secondNum = double.Parse(Console.ReadLine());
                    if (ops == "+")
                    {
                        answer = Addition(firstNum, secondNum);
                        Console.WriteLine(answer);
                    }
                    if (ops == "-")
                    {
                        answer = Subtraction(firstNum, secondNum);
                        Console.WriteLine(answer);
                    }
                    if (ops == "*")
                    {
                        answer = Multiplication(firstNum, secondNum);
                        Console.WriteLine(answer);
                    }
                    if (ops == "/")
                    {
                        answer = Division(firstNum, secondNum);
                        Console.WriteLine(answer);
                    }
                }
                
            }
            while (false);
            {
                Console.WriteLine("invalid operator please select right one..");
            }
              
        }

            public static double Addition(double a, double b)
            {
                return a + b;
            }
            public static double Subtraction(double a, double b)
            {
                return a - b;
            }
            public static double Multiplication(double a, double b)
            {
                return a * b;
            }
            public static double Division(double a, double b)
            {
                return a / b;
            }
    }
}
