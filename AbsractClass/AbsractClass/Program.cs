using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            IQuittable quitter = new Employee();
            quitter.Quit(employee);
            Console.ReadLine();
        }
    }
}
