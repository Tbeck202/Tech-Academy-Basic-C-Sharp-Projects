using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND operator && -----------------------------------------
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.ReadLine();

            //OR operator || ----------------------------------------------
            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);
            //Console.ReadLine();

            // EQUALS operator == ----------------------------------------------
            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);
            //Console.ReadLine();

            // Does NOT equal operator != ------------------------------------------
            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.Write(false != false);
            //Console.ReadLine();

            // XOR operator ^ (returns true if ONE is true BUT NOT both   ----------------------------------------------
            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);
            //Console.ReadLine();

            Console.WriteLine("Do you qualify for auto insurance?");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            byte age = Convert.ToByte(ageString);

            Console.WriteLine("Have you ever had a DUI? enter true for yes, or false for no:");
            string duiString = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiString);

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketString = Console.ReadLine();
            byte tickets = Convert.ToByte(ticketString);

            Console.WriteLine("Qualified?");
            bool qualified = (age > 15 && dui != true && tickets < 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
