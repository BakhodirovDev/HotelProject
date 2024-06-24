using HotelProject.Models.DataBase.MainModels.EmployeControl;
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
    public class ChangeTimeUserServise: IChangeTimeUser //Time
    {
        public async Task<bool> ChangeRoomAndExtendStay(Orders order, DateTime newCheckoutTime,int newUserId, long newPriceId)
        {
            
            try
            {
                List<Room> rooms = DbContext.Query<Room>($"select *from \"EmployeControlData\".\"room\" where roomid={order.RoomId}");

                //DateTime now = DateTime.Now;

                //double remainingDays = (order.CheckoutTime - now).TotalDays;
                //double remainingCost = remainingDays * rooms[0].RoomOnePrice ;

                //double futureStayDays = (newCheckoutTime - now).TotalDays;
                //double futureStayCost = futureStayDays * rooms[0].RoomOnePrice;

                //double totalCost = futureStayCost - remainingCost;

                //order.OldId = order.Id;
                //order.CheckoutTime = newCheckoutTime;


                var newOrder = new Orders
                {
                    UserId = newUserId,
                    ClientId = order.ClientId,
                    RoomId = order.RoomId,
                    EnterTime = order.EnterTime,
                    CheckoutTime = newCheckoutTime,
                    OldId = order.Id,
                    PriceId=newPriceId
                    
                };
                bool success = DbContext.InsertQuery(newOrder, "\"OrderData\".\"Orders\"");

                return await Task.FromResult(success);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                throw;
            }
        }

       
    }
}
