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
    public class RoomsServices : IRooms
    {
        public Task<bool> AddUser(Rooms model)
        {
            try
            {
                DbContext.Query<Rooms>("");
                return Task.FromResult(true);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
