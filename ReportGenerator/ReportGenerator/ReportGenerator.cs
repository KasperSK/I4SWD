using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public class ReportGenerator
    {
        private readonly Report _employeeReport;
        private readonly IReportFormatter _currentFormatter;
        private readonly IReportPrinter _currentPrinter;

        public ReportGenerator(EmployeeDB edb)
        {
            _employeeReport = new Report(edb);
            _currentFormatter = new AgeFirstFormatter();
            _currentPrinter = new ConsolePrinter();
        }

        public void CompileReport()
        {
            var output = _currentFormatter.OutputFormat(_employeeReport.GetEmployees());
            _currentPrinter.PrintReport(output);
            
        }
    }
}
