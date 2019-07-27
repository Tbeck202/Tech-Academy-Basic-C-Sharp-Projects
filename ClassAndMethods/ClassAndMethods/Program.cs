using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int userNum = Convert.ToInt32(Console.ReadLine());

            int addResult = Methods.AddOne(userNum);
            Console.WriteLine("Your number, plus one = " + addResult);

            int subResult = Methods.SubtractOne(userNum);
            Console.WriteLine("Your number, minus one = " + subResult);

            int multResult = Methods.MultiplyTwo(userNum);
            Console.WriteLine("Your number, multiplied by two = " + multResult);
            Console.ReadLine();

        }
    }
}
