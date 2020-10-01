using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Cores
{
    public interface IReportDirector
    {
        Task<ReportModel> MakeReport(IReportBuilder reportBuilder, ReportModel reportModel);
    }
}