using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorAsset
{
    public interface IVisitor
    {
        void Visit(Room room);
        void Visit(Employee employee);
        void Visit(StudentEmployee employee);
        void Visit(CEO ceo);
    }

    public class MonthlyExpenses : IVisitor
    {
        public void Visit(Room room)
        {
            _expenses += room.MonthlyRent;
        }

        public void Visit(Employee employee)
        {
            
        }

        public void Visit(StudentEmployee employee)
        {
            _expenses += employee.HourRate*employee.HoursWorkedThisMonth;
        }

        public void Visit(CEO ceo)
        {
            _expenses += ceo.MontlySalary;
        }

        private int _expenses;

        public MonthlyExpenses()
        {
            _expenses = 0;
        }

        public void ShowMonthly(IAsset asset)
        {
            _expenses = 0;
            asset.Accept(this);
            Console.WriteLine("Monthly expenses: " + _expenses);
        }
    }


    public class HiredDates : IVisitor
    {
        public void Visit(Room room)
        {
            
        }

        public void Visit(Employee employee)
        {
            Console.WriteLine("Empl: " + employee.HiredDate);
        }

        public void Visit(StudentEmployee employee)
        {
            Console.WriteLine("Student: " + employee.HiredDate);
        }

        public void Visit(CEO ceo)
        {
            Console.WriteLine("Ceo: " + ceo.HiredDate);
        }

        public void PrintDates(IAsset assets)
        {
            assets.Accept(this);
        }
    }
    public interface IAsset
    {
        void Accept(IVisitor visitor);
    }

    public class Room : IAsset
    {
        public int MonthlyRent { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Employee : IAsset
    {
        public virtual DateTime HiredDate { get; set; }

        public virtual int HoursWorkedThisMonth { get; set; }
        public virtual void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class StudentEmployee : Employee
    {
        public int HourRate { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class CEO : Employee
    {
        public int MontlySalary { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class CompositeAsset : IAsset
    {
        private readonly List<IAsset> _assets;

        public CompositeAsset()
        {
            _assets = new List<IAsset>();
        }

        public void Add(IAsset asset)
        {
            _assets.Add(asset);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var asset in _assets)
            {
                asset.Accept(visitor);
            }
        }


    }
}
