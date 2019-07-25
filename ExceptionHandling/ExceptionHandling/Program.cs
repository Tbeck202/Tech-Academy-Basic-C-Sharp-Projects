using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 8, 13, 43, 82, 96, 105 };

            try
            {
            Console.WriteLine("Please enter a number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing our numbers by yours...");

                foreach (int number in numbers)
                {
                    try
                    {
                        int numDiv = number / userNum;
                        Console.WriteLine(number + " divided by " + userNum + " = " + numDiv);
                        continue;
                    }
                    catch (DivideByZeroException ex1)
                    {
                        Console.WriteLine("You can't divide a number by zero, dum dum :)");
                        break;
                    }
                }
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("Please enter a whole number, in numeric format");
            }
            finally
            {
                Console.WriteLine("Thanks for playing along!");
            }

            Console.ReadLine();
            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick another number");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two numbers....");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " = " + numberThree);
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}


        }
    }
}
