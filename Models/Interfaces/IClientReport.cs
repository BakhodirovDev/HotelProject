using HotelProject.Models.DataBase.MainModels.EmployeControl;
using HotelProject.Models.DataBase.MainModels.ReportModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Interfaces
{
    public interface IClientReport
    {
        Task<List<ClientReport>> clientReportList();
        Task<List<ClientReport>> clientSortReport(string model);
        Task<List<ClientReport>> clientReportFilter(DateTime time1, DateTime time2);

    }
}
