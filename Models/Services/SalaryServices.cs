using HotelProject.Models.DataBase.MainModels.Login;
using SysHotel.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Services
{
    public class SalaryServices
    {
        public Task<bool> AddUser(SalaryServices model)
        {
            try
            {
                DbContext.Query<SalaryServices>("");
                return Task.FromResult(true);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
