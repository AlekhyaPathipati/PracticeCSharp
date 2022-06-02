using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierExp 
{ 
     class Program
    {
        //private int x;
        //private int y;
        static void Main(string[] args)
        {
            Class2 cls = new Class2();
            cls.a = 10;
            cls.b = 20;
            Console.WriteLine(cls.a);
            Console.WriteLine(cls.b);

        }
    }
}
