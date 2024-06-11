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
    public class OrderService : IOrder
    {
        public List<Orders> ActiveOrderList()
        {
            try
            {
                List<Orders> activeRoomsModelDGV= DbContext.Query<Orders>("select * from \"OrderData\".\"Orders\"");
                return activeRoomsModelDGV.ToList();
            }
            catch(Exception ex) 
            {
                throw;
            }
        }
    }
}
