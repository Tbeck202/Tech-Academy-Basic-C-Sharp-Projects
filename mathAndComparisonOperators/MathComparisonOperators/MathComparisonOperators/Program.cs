using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine("Ten times 5 = " + product.ToString());
            //Console.ReadLine();

            //double quotient = 100.0 / 23.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature <= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;

            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            // Multiply user input by 50
            Console.WriteLine("Give me a number to multiply by fifty:");
            string userInput = Console.ReadLine();
            int input = Convert.ToInt32(userInput);
            int multiplier = 50;

            int product = input * multiplier;
            Console.WriteLine(input.ToString() + "  multiplied by 50 equals " + product);
            Console.ReadLine();

            // Add 25 to user input
            Console.WriteLine("Give me a number and I'll add 25 to it:");
            string userInputTwo = Console.ReadLine();
            int inputTwo = Convert.ToInt32(userInputTwo);
            int addTwentyFive = 25;

            int sum = inputTwo + addTwentyFive;
            Console.WriteLine("Your number + 25 = " + sum);
            Console.ReadLine();

            // Divide User input by 12.5
            Console.WriteLine("Give me a number and I'll divide it by 12.5:");
            string userInputThree = Console.ReadLine();
            int inputThree = Convert.ToInt32(userInputThree);
            double divider = 12.5;

            double quotient = inputThree / divider;
            Console.WriteLine(quotient);
            Console.ReadLine();

            // Is user input greater than 50
            Console.WriteLine("Is your number greater than my Number?");
            string userInputFour = Console.ReadLine();
            int inputFour = Convert.ToInt32(userInputFour);
            int myNum = 50;

            bool isGreater = inputFour > myNum;
            Console.WriteLine(isGreater);
            Console.ReadLine();

            // Remainder after User input divided by 7
            Console.WriteLine("find the remainder of your age divided by 7! Please enter your age:");
            string userInputFive = Console.ReadLine();
            double inputFive = Convert.ToDouble(userInputFive);

            double remainder = inputFive % 7;
            Console.WriteLine("The remainder is: " + remainder);
            Console.ReadLine();
        }
    }
}
