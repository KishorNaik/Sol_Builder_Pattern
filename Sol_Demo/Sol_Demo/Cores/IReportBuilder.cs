using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Cores
{
    public interface IReportBuilder
    {
        Task CreateNewReport(ReportModel reportModel);

        Task SetReportType();

        Task SetReportHeader();

        Task SetReportContent();

        Task SetReportFooter();

        Task<ReportModel> GetReport();
    }
}