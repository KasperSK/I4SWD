using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VisitorImplementation
{

    public interface IVisitor
    {
        void Visit(IVisitable e);
        void Visit(Employee e);
        void Visit(Leader e);
    }

    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }

    public class Employees : IVisitable
    {
        private List<Employee> _employeesList = new List<Employee>();

        public Employees()
        {
        }

        public void AddEmployee(Employee e)
        {
            _employeesList.Add(e);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var employee in _employeesList)
            {
                employee.Accept(visitor);
            }
        }
    }

    public class Employee : IVisitable
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public int VacationDays { get; set; }
        public int SickDays { get; set; }

        public Employee(string name, double salary, int vacationDays, int sickDays)
        {
            Name = name;
            Salary = salary;
            VacationDays = vacationDays;
            SickDays = sickDays;
        }

        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("Base Accept");
            visitor.Visit(this);
        }
    }

    public class Leader : Employee
    {
        public Leader(string name, double salary, int vacationDays, int sickDays) : base(name, salary, vacationDays, sickDays)
        {
        }

        public new void Accept(IVisitor visitor)
        {
            Console.WriteLine("Derived Accept");
            visitor.Visit(this);    
        }
    }

    public class SalaryRepport : IVisitor
    {
        public void Visit(IVisitable e)
        {
            Console.WriteLine("FLAF");
        }

        public void Visit(Employee e)
        {
            Console.WriteLine($"{e.Name} get a salary of {e.Salary}");
        }

        public void Visit(Leader e)
        {
            Console.WriteLine("I am the boss");
        }
    }

    public class VacationRepport : IVisitor
    {
        public void Visit(IVisitable e)
        {
            throw new NotImplementedException();
        }

        public void Visit(Employee e)
        {
            Console.WriteLine($"{e.Name} has {e.VacationDays} vacation days left!");
        }

        public void Visit(Leader e)
        {
            throw new NotImplementedException();
        }
    }

    public class SickRepport : IVisitor
    {
        public void Visit(IVisitable e)
        {
            throw new NotImplementedException();
        }

        public void Visit(Employee e)
        {
            Console.WriteLine($"{e.Name} has had {e.SickDays} sickdays so far!");
        }

        public void Visit(Leader e)
        {
            throw new NotImplementedException();
        }
    }
}
