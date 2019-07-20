using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathCompareOperators2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            // Person one --------------------------------------------------------------
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly rate to the cent:");
            string persOneHourly = Console.ReadLine();

            Console.WriteLine("Please enter your hours worked per week:");
            string hrsWkPerOne = Console.ReadLine();

            // Person two --------------------------------------------------------------
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate to the cent:");
            string persTwoHourly = Console.ReadLine();

            Console.WriteLine("Please enter your hours worked per week:");
            string hrsWkPerTwo = Console.ReadLine();

            // Person one Totals--------------------------------------------------------------------
            decimal rateOne = Convert.ToDecimal(persOneHourly);
            decimal hoursOne = Convert.ToDecimal(hrsWkPerOne);
            decimal weeklySalaryOne = rateOne * hoursOne;
            Console.WriteLine("Weekly Salary of Person one: " + weeklySalaryOne);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            // Person two Totals--------------------------------------------------------------------
            decimal rateTwo = Convert.ToDecimal(persTwoHourly);
            decimal hoursTwo = Convert.ToDecimal(hrsWkPerTwo);
            decimal weeklySalaryTwo = rateTwo * hoursTwo;
            Console.WriteLine("Weekly Salary of Person one: " + weeklySalaryTwo);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            // Comparison----------------------------------------------------
            Console.WriteLine("Does Person one make more money than Person2? Press enter to find out.");
            Console.ReadLine();

            bool compare = weeklySalaryOne > weeklySalaryTwo;
            Console.WriteLine(compare);
            Console.ReadLine();

        }
    }
}
