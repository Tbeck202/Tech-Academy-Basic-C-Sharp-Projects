using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            try
            {
            Console.WriteLine("Thanks! Now please enter a number. (this step is optional)");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now  let's do stuff to your  numbers!");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            int result = Math.doStuff(num1, num2);
            Console.WriteLine("After we did stuff, we got: " + result);
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
            }

            catch (FormatException)
            {
                int result = Math.doStuff(num1);
                Console.WriteLine("After we did stuff, we got: " + result);
                Console.WriteLine("Press enter to exit...");
                Console.ReadLine();
            }
        }
    }
}
