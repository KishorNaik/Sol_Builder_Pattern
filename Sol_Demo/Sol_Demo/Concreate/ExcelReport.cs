using Sol_Demo.Cores;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Concreate
{
    public class ExcelReport : IReportBuilder
    {
        private ReportModel reportModel = null;

        Task IReportBuilder.CreateNewReport(ReportModel reportModel)
        {
            return Task.Run(() => this.reportModel = reportModel);
        }

        Task IReportBuilder.SetReportType()
        {
            return Task.Run(() => this.reportModel.ReportType = "Excel");
        }

        Task IReportBuilder.SetReportHeader()
        {
            return Task.Run(() => this.reportModel.ReportHeader = "Excel Header");
        }

        Task IReportBuilder.SetReportContent()
        {
            return Task.Run(() => this.reportModel.ReportContent = "Excel Content");
        }

        Task IReportBuilder.SetReportFooter()
        {
            return Task.Run(() => this.reportModel.ReportFooter = "Excel Footer");
        }

        Task<ReportModel> IReportBuilder.GetReport()
        {
            return Task.Run(() => this.reportModel);
        }
    }
}