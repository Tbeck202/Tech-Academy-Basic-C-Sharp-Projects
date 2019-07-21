using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your first name?");
            string fName = Console.ReadLine();

            Console.WriteLine("And what is your last name?");
            string lName = Console.ReadLine();

            Console.WriteLine("And how old are you?");
            string age = Console.ReadLine();

            Console.WriteLine(fName + " " + lName + " is " + age + " years old!");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            fName = fName.ToUpper();
            Console.WriteLine("Your first name in all uppercase is " + fName);
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.WriteLine("Okay " + fName + ", what is your favorite food?");
            string favFood = Console.ReadLine();

            StringBuilder sb = new StringBuilder("Awesome, your favorite food is " + favFood);

            Console.WriteLine(sb);
            Console.WriteLine("How often do you get to eat " + favFood + "?");
            string getToEat = Console.ReadLine();
            getToEat = getToEat.ToLower();

            sb.Append(" and you get to eat " + favFood + " " + getToEat + "!");
            Console.WriteLine(sb);
            Console.ReadLine();

            

            // STRINGS AND ESCAPE CHARACTERS--------------------------------------------------------------------------

            //string name = "Tyler";
            //string quote = "The man said, \"Hello\", Tyler. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Tyler";

            //bool trueOrFalse = name.Contains("y");
            //trueOrFalse = name.EndsWith("y");

            //int length = name.Length;

            //name = name.ToLower();


            //Console.WriteLine(name);
            //Console.ReadLine();

            // STRING BUILDER--------------------------------------------------------------------------

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Tyler");

            //Console.WriteLine(sb);
            //Console.ReadLine();
        }
    }
}
