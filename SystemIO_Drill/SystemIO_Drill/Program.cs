using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIO_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yo! Gimme a number!");
            string num = Convert.ToString(Console.ReadLine());

            File.WriteAllText(@"C:\Users\Tyler\Logs\logdrill.txt", num);

            string read = File.ReadAllText(@"C:\Users\Tyler\Logs\logdrill.txt");
            Console.WriteLine(read);
            Console.ReadLine();
        }
    }
}
