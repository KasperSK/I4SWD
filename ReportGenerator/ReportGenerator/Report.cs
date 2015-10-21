using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    class Report
    {
        private readonly List<Employee> _employees = new List<Employee>(); 

        public Report(EmployeeDB employeeDb)
        {
            if (employeeDb == null) throw new ArgumentNullException("employeeDb");
            var employeeDb1 = employeeDb;

            Employee employee;

            employeeDb1.Reset();

            while ((employee = employeeDb1.GetNextEmployee()) != null)
            {
                _employees.Add(employee);
            }
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        } 


    }
}
