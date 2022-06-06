using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject1
{
     class Class3
    {
        //orderby
        static void main()
        {
            int[] numbers = { 5, 7, 9, 13, 20, 7, 1, 10 };
            var firstNumbers=numbers.TakeWhile(x => x >10);
            Console.WriteLine("first numbers greater than 10");
            foreach(int number in firstNumbers)
            {
                Console.WriteLine(number);
            }


        }
    }
}
