﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataTypes
            int i = 10;
            long l = 231708532189044;
            float f=5.87F;
            double d = 77.89D;
            String name = "Learning c#";
            bool result = true;
            char ch = 'a';
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(name);
            Console.WriteLine(ch);
            Console.WriteLine(result);
            //Writing and Reading from console
            Console.WriteLine("Enter Username:");
            String Username = Console.ReadLine();
            Console.WriteLine("Username is: " + Username);
            Console.ReadLine();

        }
    }
}
