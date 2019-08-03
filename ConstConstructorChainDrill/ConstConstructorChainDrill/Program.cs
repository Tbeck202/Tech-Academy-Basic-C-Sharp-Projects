using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstConstructorChainDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            const string schoolName = "The Tech Academy";
            Console.WriteLine("Welcome to {0}! Please tell us your name.", schoolName);
            var studentName = Console.ReadLine();
            Random newId = new Random();
            int id = newId.Next(1, 100);
            Student student = new Student(studentName, id);
            Console.WriteLine("Thanks {0}! Your ID number is: {1}", studentName, id);
            Console.ReadLine();
        }
    }
}
