using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //by using Delegate
    //defining the delegate
    public delegate void AddDelegate(int a,int b);
    public delegate String HelloDelegate(String a);
     class Program
    {
        public void AddNums(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public static String Hello(String Name)
        {
            return "Hiii" + Name;

        }
        static void Main(string[] args)
        {
            Program p=new Program();
            //p.AddNums(100,200);
            //instance of delegate
            AddDelegate ad = new AddDelegate(p.AddNums);
            ad(100, 200);
            HelloDelegate hd = new HelloDelegate(Program.Hello);
            String str= hd("Alekhya");
           // String str = Program.Hello("Alekhya");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
