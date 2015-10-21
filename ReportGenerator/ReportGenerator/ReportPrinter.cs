using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    interface IReportPrinter
    {
        void PrintReport(List<string> output);
    }

    class ConsolePrinter : IReportPrinter
    {
        public void PrintReport(List<string> output)
        {
            foreach(var line in output)
            System.Console.WriteLine(line);
        }
    }
}
