using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("The current Date and time = {0}", now);

            Console.WriteLine("Enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());

            TimeSpan ts = TimeSpan.FromHours(num);

            DateTime hourModify = now + ts;

            Console.WriteLine("In {0} hours the time will be: {1}",num , hourModify);
            Console.ReadLine();
        }
    }
}
