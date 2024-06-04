using HotelProject.Models.DataBase.MainModels.Login;
using HotelProject.Models.Interfaces;
using SysHotel.Models.DataBase;
using SysHotel.Models.DataBase.MainModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Services
{
    public class ClientService : IClient
    {
        public List<Order> ActiveRoomsList()
        {
            try
            {
                return DbContext.Query<Order>("select * from \"OrderAction\".\"order\"");
            }
            catch (Exception ex) 
            {
                throw;
            }   
        }
    }
}
