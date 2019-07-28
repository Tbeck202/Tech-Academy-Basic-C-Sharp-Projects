using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.Id = 1;
            employee2.Id = 2;

            bool idCheck = (employee1 == employee2);
            if (idCheck == true)
                Console.WriteLine("Employees cannot have matching ID's!");
            else
                Console.WriteLine("Everything is okay");

            Console.ReadLine();
        }
    }
}
