using HotelProject.Models.DataBase.MainModels.Login;
using HotelProject.Models.DataBase.MainModels.Order;
using HotelProject.Models.Interfaces;
using SysHotel.Models.DataBase;
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
        public  List<Client> ActiveRoomsList()
        {
            try
            {
                List<Client> Test = DbContext.Query<Client>("select * from \"public\".\"Client\"");
                return Test.ToList();
            }
            catch (Exception ex) 
            {
                throw;
            }   
        }
    }
}
