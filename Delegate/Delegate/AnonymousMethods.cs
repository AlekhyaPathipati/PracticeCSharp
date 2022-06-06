using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate String WishDelegate(String name);
     class AnonymousMethods
    {
       // public String Wish(String Name)
        //{
            //return "hello" + Name + "Good morning";
        //}
        static void main()
        {
            WishDelegate wd = delegate(String Name)
            {
                return "hello" + Name + "Good morning";

            };
            String str = wd("Alekhya");
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
