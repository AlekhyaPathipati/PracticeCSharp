using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
     class Program
    {
        static void Main(string[] args)
        {
            try
            {


                double firstNum;
                double secondNum;
                double answer;
                String ops;

                Console.WriteLine(".....Console Calculator....");
                Console.WriteLine("Enter firstNum = ");
                firstNum = double.Parse(Console.ReadLine());
                Console.WriteLine("Select an operator: (+, -, *, /, %)");
                ops = Console.ReadLine();
                Console.WriteLine("Enter secondNum = ");
                secondNum = double.Parse(Console.ReadLine());

                if (ops == "+")
                {
                    answer = firstNum + secondNum;
                    Console.WriteLine(answer);
                }
                if (ops == "-")
                {
                    answer = firstNum - secondNum;
                    Console.WriteLine(answer);
                }
                if (ops == "*")
                {
                    answer = firstNum * secondNum;
                    Console.WriteLine(answer);
                }
                if (ops == "/")
                {
                    answer = firstNum / secondNum;
                    Console.WriteLine(answer);
                }
                if (ops == "%")
                {
                    answer = firstNum % secondNum;
                    Console.WriteLine(answer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Program executed");
            }

        }
    }
    }
