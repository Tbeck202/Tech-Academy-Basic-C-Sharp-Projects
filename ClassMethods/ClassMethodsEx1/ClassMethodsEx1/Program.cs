using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            decimal afterMath = Math.DoMath(num1);
            Console.WriteLine("Your number divided by two = " + afterMath);

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            int num2 = Math.GetTwentyFive(out num2);
            Console.WriteLine("We will now multiply your number by " + num2);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            decimal numsCombined = MoreMath.DoMoreMath(afterMath, num2);
            Console.WriteLine("Your modified number is now: " + numsCombined);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Please enter another number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            decimal afterMath2 = Math.DoMath(num1, num3);
            Console.WriteLine("Your numbers added and divided by two = " + afterMath2);
            Console.ReadLine();
        }
    }

    static class MoreMath
    {
        public static decimal DoMoreMath(decimal afterMath, int num2)
        {
            decimal afterMoreMath = (afterMath * num2);
            return afterMoreMath;
        }
    }
}
