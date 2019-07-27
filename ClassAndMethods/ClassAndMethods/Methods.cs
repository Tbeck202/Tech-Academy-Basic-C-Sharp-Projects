using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    class Methods
    {
        public static int AddOne (int userNum)
        {
            int userAddOne = userNum + 1;
            return userAddOne;
        }

        public static int SubtractOne (int userNum)
        {
            int userSubOne = userNum - 1;
            return userSubOne;
        }

        public  static int MultiplyTwo (int userNum)
        {
            int userMultTwo = userNum * 2;
            return userMultTwo;
        }
    }
}
