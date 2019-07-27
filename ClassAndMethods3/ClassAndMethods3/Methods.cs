using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods3
{
    class Methods
    {
        public static int DoStuff(int num1)
        {
            int result = num1 + 5;
            return result;
        }

        public static int DoStuff(decimal num2)
        {
            decimal result = num2 / 2;
            int x = Convert.ToInt32(result);
            return x;
        }

        public static int DoStuff(string num3)
        {
            int numConvert = Convert.ToInt32(num3);
            int result = (numConvert * 7) - 2;
            return result;
        }

    }
}
