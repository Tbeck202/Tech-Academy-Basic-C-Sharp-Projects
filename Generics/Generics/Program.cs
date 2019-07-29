using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Tyler", "Joe", "Jill" };
            Employee<string> employees = new Employee<string>();
            {
                employees.Things = names.ToList();
            }

            List<int> idNum = new List<int>() { 1, 2, 3 };
            Employee<int> id = new Employee<int>();
            {
                id.Things = idNum.ToList();
            }

            foreach (string employee in names)
            {
                Console.WriteLine(employee);
            }
            foreach (int num in idNum)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }

    }
}
