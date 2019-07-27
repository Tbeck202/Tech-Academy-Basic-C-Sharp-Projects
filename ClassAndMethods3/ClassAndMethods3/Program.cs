using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods myMethods = new Methods();

            //DRILL 1------------------------------------------------------------------
            int num1 = 12;
            Methods.DoStuff(num1);
            int numAdd = Methods.DoStuff(num1);
            Console.WriteLine("12 + 5 = " + numAdd);
            Console.WriteLine("press enter to continue");
            Console.ReadLine();

            // DRILL 2 -------------------------------------------------------------------------
            decimal num2 = 12.5m;
            decimal returnValue2 = Methods.DoStuff(num2);
            int decToInt = Convert.ToInt32(returnValue2);
            Console.WriteLine("12.5 divided by 2 rounds down to: " + decToInt);
            Console.WriteLine("press enter to continue");
            Console.ReadLine();

            //  DRILL 3-------------------------------------------------------------------------
            Console.WriteLine("Enter a number.");
            string num3 = Console.ReadLine();
            string returnValue = Methods.DoStuff(num3);
            int didStuff = Convert.ToInt32(returnValue);

            Console.WriteLine("We did stuff to your number and now it is: " + didStuff);
            Console.WriteLine("press enter to exit program");
            Console.ReadLine();
        }
    }
}
