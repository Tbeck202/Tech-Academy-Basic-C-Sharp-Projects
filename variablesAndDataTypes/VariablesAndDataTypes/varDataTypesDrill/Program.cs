using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varDataTypesDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
                string courseReport = Console.ReadLine();
            Console.WriteLine("you are on the " + courseReport + " course.");
            Console.ReadLine();
        }
    }
}
