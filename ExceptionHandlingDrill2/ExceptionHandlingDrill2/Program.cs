using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Hello. How old are you?");
            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());

                if (userAge < 0)
                {
                    Console.WriteLine("Please enter a valid whole number, greater than zero.");
                    Console.ReadLine();
                    return;
                }
                int yearBorn = now.Year - userAge;
                Console.WriteLine("You were born in " + yearBorn + "!");
                Console.ReadLine();

            }
            catch (FormatException)
            {
                Console.WriteLine("Text input not allowed. \nPlease enter a valid whole number, greater than zero.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error.");
                Console.ReadLine();
            }
            
            //bool validAnswer = false;
            //int userAge = 0;
            //while (!validAnswer)
            //{
            //    Console.WriteLine("Hello. How old are you?");
            //    validAnswer = int.TryParse(Console.ReadLine(), out userAge);
            //}
            //if (userAge < 0)
            //{
            //    Console.WriteLine("Please enter a valid whole number, greater than zero.");
            //    Console.ReadLine();
            //    return;
            //}
            //else
            //{

            //    int yearBorn = now.Year - userAge;
            //    Console.WriteLine("You were born in " + yearBorn+ "!");
            //    Console.ReadLine();
            //}
        }
    }
}
