using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    interface IReportFormatter
    {
        List<String> OutputFormat(List<Employee> employees);
    }

    class NameFirstFormatter : IReportFormatter
    {
        public List<string> OutputFormat(List<Employee> employees)
        {
            var strings = new List<string>();
            foreach (var employee in employees)
            {
                strings.Add("------------------");
                strings.Add("Name: " + employee.Name);
                strings.Add("Salary: "+ employee.Salary);
                strings.Add("Age: " + employee.Age);
                strings.Add("------------------");
            }
            return strings;
        }
    }

    class SalaryFirstFormatter : IReportFormatter
    {
        public List<string> OutputFormat(List<Employee> employees)
        {
            var strings = new List<string>();
            foreach (var employee in employees)
            {
                strings.Add("------------------");
                strings.Add("Salary: " + employee.Salary);
                strings.Add("Name: " + employee.Name);
                strings.Add("Age: " + employee.Age);
                strings.Add("------------------");
            }
            return strings;
        }
    }

    class AgeFirstFormatter : IReportFormatter
    {
        public List<string> OutputFormat(List<Employee> employees)
        {
            var strings = new List<string>();
            foreach (var employee in employees)
            {
                strings.Add("------------------");
                strings.Add("Age: " + employee.Age);
                strings.Add("Salary: " + employee.Salary);
                strings.Add("Name: " + employee.Name);
                strings.Add("------------------");
            }
            return strings;
        }
    }
}
