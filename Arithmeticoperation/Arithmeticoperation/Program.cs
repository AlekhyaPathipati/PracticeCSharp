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
            Console.WriteLine("Select an operator: (+, -, *, /, %)");
            ops = Console.ReadLine();
            if ((ops == + ) || (ops != - ) || (ops != *) || (ops != /))
            {
                Console.WriteLine("next proceed...");
            }
            else
            {
                Console.WriteLine("please give the valid operator");
            }
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

            public double Addition(int a, int b)
            {
                return a + b;
            }
            public double Subtraction(int a, int b)
            {
                return a - b;
            }
            public double Multiplication(int a, int b)
            {
                return a * b;
            }
            public double Division(int a, int b)
            {
                return a / b;
            }
    }
}
