using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.ConsoleAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new EmployeeDB();

            // Add some employees
            db.AddEmployee(new Employee("Anne", 3000, 10));
            db.AddEmployee(new Employee("Berit", 2000, 12));
            db.AddEmployee(new Employee("Christel", 1000, 4));

            var reportGenerator = new ReportGenerator(db);

            // Create a default (name-first) report
            reportGenerator.CompileReport();

            Console.WriteLine("");
            Console.WriteLine("");

            // Create a salary-first report
            reportGenerator.CompileReport();
        }
    }
}
