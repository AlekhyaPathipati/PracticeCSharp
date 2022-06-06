using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject1
{
     class Class1
    {
        static void main()
        {
            int[] arr = { 10, 34, 57, 90, 78, 24, 13, 89, 9 };
            //Query 1
            var brr = from i in arr 
                      where i > 30 
                      orderby i descending
                      select i;
            //Execute the quary
            foreach (int x in brr)
            {
                Console.WriteLine(x + " ");
            }
        }
    }
}
