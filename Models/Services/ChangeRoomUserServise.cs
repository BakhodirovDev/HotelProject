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
    public class ChangeRoomUserServise:IChangeRoomUser
    {
        public async Task<bool> ChangeRoomAndExtendStay(Orders order, Room newRoom,int newUserId,long newPriceId)
        {

            try
            {
                List<Room> rooms = DbContext.Query<Room>($"select *from \"EmployeControlData\".\"room\" where roomid={order.RoomId}");

                var newOrder = new Orders
                {
                    UserId = newUserId,
                    ClientId = order.ClientId,
                    RoomId = newRoom.RoomId,
                    EnterTime = order.EnterTime,
                    CheckoutTime = order.CheckoutTime,
                    OldId = order.Id,
                    PriceId = newPriceId
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
        private bool IsRoomAvailable(List<Orders> orders, int roomId, DateTime enterTime, DateTime checkoutTime)
        {
            foreach (var existingOrder in orders)
            {
                if (existingOrder.RoomId == roomId &&
                    checkoutTime > existingOrder.EnterTime &&
                    enterTime < existingOrder.CheckoutTime)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
