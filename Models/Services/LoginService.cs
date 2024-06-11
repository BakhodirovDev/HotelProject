using HotelProject.Models.DataBase.MainModels.Login;
using HotelProject.Models.DataBase.MainModels.Order;
using HotelProject.Models.Interfaces;
using SysHotel.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Services
{
    public class LoginService : ILogin
    {
        public Task<bool> AddUser(Users model,Client client)
        {
			try
			{
                

                bool result = DbContext.InsertQuery<Users>(model, "public");
                return Task.FromResult(result);
            }
			catch (Exception)
			{
				throw;
			}
        }
    }
}
