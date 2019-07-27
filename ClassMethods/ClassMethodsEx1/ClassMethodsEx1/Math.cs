using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsEx1
{
    public class Math
    {
        public static void DoMath (int num1)
        {
            decimal num1Convert = Convert.ToDecimal(num1);
            decimal result = num1Convert / 2;
            Console.WriteLine("Your number divided by two = " + result);
        }

        public static decimal DoMath (int num1, int num3)
        {
            decimal num1Convert = Convert.ToDecimal(num1);
            decimal num2Convert = Convert.ToDecimal(num3);
            decimal result = (num1Convert + num2Convert) / 2;
            return result;
        }

        public static int GetTwentyFive(out int x)
        {
            int y = 5 * 5;
            x = y;
            return x;
        }
    }
}
