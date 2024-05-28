using HotelProject.Models.DataBase.MainModels.EmployeControl;
using HotelProject.Models.DataBase.MainModels.Login;
using SysHotel.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Services
{
    public class EmployeServices
    {
        public Task<bool> AddUser(Employe model)
        {
            try
            {
                DbContext.Query<Employe>("");
                return Task.FromResult(true);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
