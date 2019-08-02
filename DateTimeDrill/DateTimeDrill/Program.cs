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
            DateTime num = Convert.ToDateTime(Console.ReadLine());

            TimeSpan hourModify = now + hourModify;

            Console.WriteLine("{0}", hourModify);
            Console.ReadLine();
        }
    }
}
