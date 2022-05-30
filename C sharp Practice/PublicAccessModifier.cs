using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicAccessModifier
{
    class Car

    {
        private string model = "Mustang";
        class Program
        {
            static void Main(string[] args)
            {
                Car c = new Car();
                Console.WriteLine(c.model);
                Console.ReadLine();
            }
        }
       
    }
      

}
