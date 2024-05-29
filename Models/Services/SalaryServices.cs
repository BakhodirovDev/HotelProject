using HotelProject.Models.DataBase.MainModels.EmployeControl;
using HotelProject.Models.DataBase.MainModels.Login;
using HotelProject.Models.Interfaces;
using SysHotel.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Services
{
    public class SalaryServices : ISalary
    {
        public Task<bool> AddUser(Salary model)
        {
            try
            {
                DbContext.Query<Salary>("");
                return Task.FromResult(true);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
