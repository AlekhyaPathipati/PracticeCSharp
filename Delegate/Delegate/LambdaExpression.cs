using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    public delegate String WishDelegate(String name);
    class LambdaExpression
    {
        static void main()
        {
            WishDelegate wd = (Name) =>
            {
                return "hello" + Name + "Good morning";
            };
            String str = wd("Alekhya");
            Console.WriteLine(str);
            Console.ReadLine();

        }

    }
}
