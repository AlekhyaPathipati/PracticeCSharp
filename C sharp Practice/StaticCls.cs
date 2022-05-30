using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCls
{
     static class Author
    {
        public static string A_name = "Alekhya";
        public static string L_name = "CSharp";
        public static int T_no = 80;

        public static void details()
        {
            Console.WriteLine("The details of Author is:");
        }
    }

    public class Abc
    {
        static public void Main()
        {
            Author.details();
            Console.WriteLine("Author name : {0} ", Author.A_name);
            Console.WriteLine("Language : {0} ", Author.L_name);
            Console.WriteLine("Total number of articles : {0} ", Author.T_no);


        }
    }
}
