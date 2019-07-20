using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varDataTypeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string courseReport = Console.ReadLine();

            Console.WriteLine("Great, and what page of the " + courseReport + " course are you on?");
            string pageNumber = Console.ReadLine();
            byte pgNum = Convert.ToByte(pageNumber);

            Console.WriteLine("Awesome! Do you need help with anything? Please answer true or false.");
            string helpNeeded = Console.ReadLine();
            bool needsHelp = Convert.ToBoolean(helpNeeded);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please give specifics.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hourse did you study today?");
            string hoursStudied = Console.ReadLine();
            byte studyHrs = Convert.ToByte(hoursStudied);

            Console.WriteLine("Course: " + courseReport);
            Console.WriteLine("Page Number: " + pageNumber);
            Console.WriteLine("Help Needed: " + helpNeeded);
            Console.WriteLine("Experience Shared: " + experience);
            Console.WriteLine("Feedback: " + feedback);
            Console.WriteLine("Hours Studied: " + hoursStudied);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have agreat day!");
            Console.ReadLine();

           


        }
    }
}
