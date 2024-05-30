using HotelProject.Models.DataBase.MainModels.EmployeControl;
using HotelProject.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Interfaces
{
    public interface IClientReport
    {
        Task<List<ClientReport>> GetClientReport (ClientReport model);
    }
}
