using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

        // Boolean Comparison with While statement   ----------------------------------------------------

            //Console.WriteLine("Guess my favorite movie:");
            //string movie = Console.ReadLine();

            //bool isGuessed = movie == "The Big Lebowski";

            //while (!isGuessed)
            //{
            //    switch (movie)
            //    {
            //        case "The Big Lebowski":
            //            Console.WriteLine("you got it!");
            //            isGuessed = true;
            //            break;

            //        default:
            //            Console.WriteLine("That's just like, your opinion, man.");
            //            Console.WriteLine("Guess my favorite movie:");
            //            movie = Console.ReadLine();
            //            break;
            //    }
            //}
            //Console.ReadLine();

        // Boolean Comparison with Do While statement   ----------------------------------------------------

            Console.WriteLine("Guess my favorite movie:");
            string movie = Console.ReadLine();

            bool isGuessed = movie == "The Big Lebowski";

            do
            {
                {
                    switch (movie)
                    {
                        case "The Big Lebowski":
                            Console.WriteLine("you got it!");
                            isGuessed = true;
                            break;

                        default:
                            Console.WriteLine("That's just like, your opinion, man.");
                            Console.WriteLine("Guess my favorite movie:");
                            movie = Console.ReadLine();
                            break;
                    }
                }
            }
            while (!isGuessed);

            Console.ReadLine();

            // switch statement, while loop, do while loop -----------------------------------------

            //Console.WriteLine("Guess a number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //bool isGuessed = number == 12;

            //do
            //{
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62. Try again.");
            //            Console.WriteLine("Guess a number");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29. Try again.");
            //            Console.WriteLine("Guess a number");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55. Try again.");
            //            Console.WriteLine("Guess a number");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("You guessed 12. That is correct!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You're wrong, dummy!  Try again.");
            //            Console.WriteLine("Guess a number");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!isGuessed);

            //Console.ReadLine();
        }
    }
}
