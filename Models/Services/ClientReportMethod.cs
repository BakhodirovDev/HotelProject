﻿using HotelProject.Models.DataBase.MainModels.ReportModels;
using HotelProject.Models.Interfaces;
using SysHotel.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Services
{
    public class ClientReportMethod :IClientReport
    {
        public Task<List<ClientReport>> clientReportList()
        {
            try
            {
                List<ClientReport> clientReports = DbContext.Query<ClientReport>("select * from report_client_mv_new1");
                return Task.FromResult(clientReports);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Task<List<ClientReport>> clientSortReport()
        {
            try
            {
                List<ClientReport> clientReports=new List<ClientReport>();
                clientReports.Sort();
                return Task.FromResult(clientReports);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
       public  Task<List<ClientReport>> clientReportFilter(DateTime time1,DateTime time2)
        {
            try
            {
                List<ClientReport> clientReports = DbContext.Query<ClientReport>("select * from report_client_mv_new1");
                List<ClientReport> filterClientReport = new List<ClientReport>();
                foreach (ClientReport clientReport in clientReports)
                {
                    if(clientReport.entertime>=time1 && clientReport.checkouttime <= time2)
                    {
                        filterClientReport.Add(clientReport);
                    }
                }
                return Task.FromResult(filterClientReport); 
            }
            catch (Exception ex) 
            { 
                throw;
            }
        }

    }
}
