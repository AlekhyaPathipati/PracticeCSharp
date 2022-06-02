using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierExp
{
    //public 
     class Class2
    {
        public int a;
        public int b;
        static void main(String[] args)
        {
            Class2 c2=new Class2();
            c2.a = 1;
            c2.b = 2;
            Console.WriteLine(c2.a);
            Console.WriteLine(c2.b);

        }
    }
}
