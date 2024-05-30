using HotelProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Services
{
    public class ClientReportMethod : IClientReport
    {
        public Task<List<ClientReport>> GetClientReport(ClientReport model)
        {
            throw new NotImplementedException();
        }
    }
}
