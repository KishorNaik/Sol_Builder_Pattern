using Sol_Demo.Cores;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Context
{
    public class ReportBuilderDirector : IReportDirector
    {
        async Task<ReportModel> IReportDirector.MakeReport(IReportBuilder reportBuilder, ReportModel reportModel)
        {
            await reportBuilder.CreateNewReport(reportModel);
            await reportBuilder.SetReportType();
            await reportBuilder.SetReportHeader();
            await reportBuilder.SetReportContent();
            await reportBuilder.SetReportFooter();

            return await reportBuilder.GetReport();
        }
    }
}