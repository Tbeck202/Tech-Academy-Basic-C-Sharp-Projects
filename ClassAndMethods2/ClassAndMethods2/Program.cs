using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods myMethod = new Methods();
            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Methods.doStuff(num1, num2);
            Console.ReadLine();
        }
    }
}
