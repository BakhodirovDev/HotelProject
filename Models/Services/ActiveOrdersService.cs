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
    public class ActiveOrdersService : IActiveOrders
    {
        public async Task<List<ActiveOrders>> ActiveOrdersReadAsync()
        {
            try
            {
                
                List<ActiveOrders> activeOrder = DbContext.Query<ActiveOrders>("select * from \"OrderData\".\"vwActiveOrders\"");
                
                
                for (int i = 0; i < activeOrder.Count; i++)
                {
                    activeOrder[i].TartibRaqam = i + 1;
                }   

                

                return await Task.FromResult(activeOrder);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
