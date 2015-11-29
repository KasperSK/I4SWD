using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorImplementation;

namespace Visitor.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var Employees = new Employees();

            var Emp1 = new Employee("Kalle", 5.400, 20, 100);
            var Emp2 = new Employee("Kasper", 15293.1, 40, 5);
            var Emp3 = new Employee("Kristian", 100.0, 14, 10);
            var Emp4 = new Leader("Peter", 500.0, 20, 130);

            Employees.AddEmployee(Emp1);
            Employees.AddEmployee(Emp2);
            Employees.AddEmployee(Emp3);
            Employees.AddEmployee(Emp4);

            var SalaryRepport = new SalaryRepport();
            var VacationRepport = new VacationRepport();
            var SickRepport = new SickRepport();

            Employees.Accept(SalaryRepport);
            Console.WriteLine("");
            Employees.Accept(VacationRepport);
            Console.WriteLine("");
            Employees.Accept(SickRepport);

            Emp4.Accept(SalaryRepport);

            Console.ReadKey();
        }
    }
}
