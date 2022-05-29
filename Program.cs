using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        interface interface1
        {
            void show();
        }
        class MyClass : interface1
        {
            public void show()
            {
                Console.WriteLine("Welcome");
            }
            static void Main(string[] args)
            {
                MyClass obj1 = new MyClass();
                obj1.show();
                Console.ReadLine();

            }
        }
    }
}
