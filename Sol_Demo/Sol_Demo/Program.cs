using Sol_Demo.Concreate;
using Sol_Demo.Context;
using Sol_Demo.Cores;
using Sol_Demo.Models;
using System;
using System.Threading.Tasks;

namespace Sol_Demo
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ReportModel reportModel = new ReportModel();
            IReportDirector reportDirector = new ReportBuilderDirector();

            // Make Excel Report
            reportModel = await reportDirector.MakeReport(new ExcelReport(), reportModel);

            Console.WriteLine(reportModel.ReportType);

            // Make Pdf Report
            reportModel = await reportDirector.MakeReport(new PdfReport(), reportModel);

            Console.WriteLine(reportModel.ReportType);
        }
    }
}