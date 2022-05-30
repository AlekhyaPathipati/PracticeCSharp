using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstractCls
{
    abstract class Language
    {

        // non-abstract method
        public void display()
        {
            Console.WriteLine("Non abstract method");
        }
    }

    // inheriting from abstract class
    class Program : Language
    {

        static void Main(string[] args)
        {

            // object of Program class
            Program obj = new Program();

            // access method of an abstract class
            obj.display();

            Console.ReadLine();
        }


    }

   
    }
