using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee emp1 = new Employee();
            emp1.FirstName = "Joe";
            emp1.LastName = "Ingles";
            emp1.EmpId = 1;

            Employee emp2 = new Employee();
            emp2.FirstName = "Mike";
            emp2.LastName = "Smith";
            emp2.EmpId = 2;

            Employee emp3 = new Employee();
            emp3.FirstName = "Jenny";
            emp3.LastName = "Williams";
            emp3.EmpId = 3;

            Employee emp4 = new Employee();
            emp4.FirstName = "Melissa";
            emp4.LastName = "Miles";
            emp4.EmpId = 4;

            Employee emp5 = new Employee();
            emp5.FirstName = "Jake";
            emp5.LastName = "Roberts";
            emp5.EmpId = 5;

            Employee emp6 = new Employee();
            emp6.FirstName = "Rudy";
            emp6.LastName = "Gobert";
            emp6.EmpId = 6;

            Employee emp7 = new Employee();
            emp7.FirstName = "Donovan";
            emp7.LastName = "Mitchell";
            emp7.EmpId = 7;

            Employee emp8 = new Employee();
            emp8.FirstName = "Joe";
            emp8.LastName = "Johnson";
            emp8.EmpId = 8;

            Employee emp9 = new Employee();
            emp9.FirstName = "Lisa";
            emp9.LastName = "Walters";
            emp9.EmpId = 9;

            Employee emp10 = new Employee();
            emp10.FirstName = "Sally";
            emp10.LastName = "Sallerson";
            emp10.EmpId = 10;

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);
            employees.Add(emp5);
            employees.Add(emp6);
            employees.Add(emp7);
            employees.Add(emp8);
            employees.Add(emp9);
            employees.Add(emp10);

            // FOR EACH LOOP ---------------------------------------------------------
            List<Employee> allTheJoes = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    allTheJoes.Add(employee);
                }
            }
            foreach (Employee joe in allTheJoes)
                Console.WriteLine(joe.FirstName + " " + joe.LastName+ " " + joe.EmpId);

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            // LAMBDA 1 ---------------------------------------------------------------------------
            List<Employee> joes = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee thisJoe in joes)
                Console.WriteLine(thisJoe.FirstName + " " + thisJoe.LastName + " " + thisJoe.EmpId);

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            // LAMBDA 2 ---------------------------------------------------------------------------
            List<Employee> newList = employees.Where(y => y.EmpId > 5).ToList();
            foreach (Employee emp in newList)
                Console.WriteLine(emp.FirstName + " " + emp.LastName + " " + emp.EmpId);

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();

        }
    }
}
