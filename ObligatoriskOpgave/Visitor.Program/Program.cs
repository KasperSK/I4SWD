using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorImplementation;
using VisitorAsset;

namespace Visitor.Program
{
    class Program
    {
        static void Main(string[] args)
        {

            var rooms = new CompositeAsset();

            rooms.Add(new Room { MonthlyRent = 10000 });
            rooms.Add(new Room { MonthlyRent = 15000 });
            rooms.Add(new Room { MonthlyRent = 9000 });

            var gruppe1 = new CompositeAsset();

            gruppe1.Add(new CEO {HiredDate = new DateTime(), HoursWorkedThisMonth = 300, MontlySalary = 100000});
            gruppe1.Add(new StudentEmployee {HiredDate = new DateTime(), HourRate = 120, HoursWorkedThisMonth = 100});
            gruppe1.Add(new StudentEmployee { HiredDate = new DateTime(), HourRate = 10, HoursWorkedThisMonth = 400 });

            var assets = new CompositeAsset();
            assets.Add(rooms);
            assets.Add(gruppe1);

            var monthlycacl = new MonthlyExpenses();
            monthlycacl.ShowMonthly(assets);

            var dates = new HiredDates();
            dates.PrintDates(assets);
            //var Employees = new Employees();

            //var Emp1 = new Employee("Kalle", 5.400, 20, 100);
            //var Emp2 = new Employee("Kasper", 15293.1, 40, 5);
            //var Emp3 = new Employee("Kristian", 100.0, 14, 10);
            //var Emp4 = new Leader("Peter", 500.0, 20, 130);

            //Employees.AddEmployee(Emp1);
            //Employees.AddEmployee(Emp2);
            //Employees.AddEmployee(Emp3);
            //Employees.AddEmployee(Emp4);

            //var SalaryRepport = new SalaryRepport();
            //var VacationRepport = new VacationRepport();
            //var SickRepport = new SickRepport();

            //Employees.Accept(SalaryRepport);
            //Console.WriteLine("");
            //Employees.Accept(VacationRepport);
            //Console.WriteLine("");
            //Employees.Accept(SickRepport);

            //Emp4.Accept(SalaryRepport);

            //Console.ReadKey();
        }
    }
}
