using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it?");
            string currentDay = Console.ReadLine();

            try
            {
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), currentDay);
                Console.WriteLine("Today is: " + day);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();
        }

        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

    }
}
