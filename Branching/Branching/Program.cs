using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to package express. Please follow the instructions below.");
            Console.WriteLine("How much does your package weigh?");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            if (packWeight < 50)
            {
                Console.WriteLine("How tall is your package?");
                int packHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How long is your package?");
                int packLength = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How wide is your package?");
                int packWidth = Convert.ToInt32(Console.ReadLine());

                int dimension = packHeight + packLength + packWidth;

                if (dimension > 50)
                {
                    Console.WriteLine("Package too big too be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    decimal dim = Convert.ToDecimal(dimension);
                    decimal weight = Convert.ToDecimal(packWeight);

                    decimal quote = (dim * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping is: $" + quote);
                    Console.ReadLine();
                }
            }
           else
            {
                Console.WriteLine("Package too heavy too be shipped.");
                Console.ReadLine();
            }
            

            // Ternary statement---------------------------------------------------------------------------
            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string results = favNum == 12 ? "You must love John Stockton!" : "You must hate John Stockton :(";
            //Console.WriteLine(results);
            //Console.ReadLine();

            //int roomTemp = 70;
            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name  + ", What is the temp where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp!");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp!");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("It is colder than room temp!");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhhhhhhhhhhh....It's the apocalypse!");
            //}
            //Console.ReadLine();

            //int currentTemp = 80;
            //int roomTemp = 70;

            //string comparisonResult = currentTemp == roomTemp ? "It is room temp." : "It is not room temp";

            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("Room temp is warmer than current temp");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temp");
            //}
            //Console.ReadLine();
        }
    }
}
