using HotelProject.Models.DataBase.MainModels.EmployeControl;
using HotelProject.Models.DataBase.MainModels.Order;
using HotelProject.Models.Interfaces;
using SysHotel.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace HotelProject.Models.Services
{
    public  class ChangeOrderServices: IChangeOrder
    {
        public async Task<bool> ChangeRoomAndExtendStay(Orders order, Room newRoom, int newUserId, long newPriceId)
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

        public async Task<bool> ChangeTimeAndExtendStay(Orders order, DateTime newCheckoutTime, int newUserId, long newPriceId)
        {
            try
            {
                List<Room> rooms = DbContext.Query<Room>($"select *from \"EmployeControlData\".\"room\" where roomid={order.RoomId}");

                var newOrder = new Orders
                {
                    UserId = newUserId,
                    ClientId = order.ClientId,
                    RoomId = order.RoomId,
                    EnterTime = order.EnterTime,
                    CheckoutTime = newCheckoutTime,
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

        public double CalculateSumma(Orders order, DateTime? newCheckoutTime, Room? newRoom)
        {
            List<Room> rooms = DbContext.Query<Room>($"select *from \"EmployeControlData\".\"room\" where roomid={order.RoomId}");
            double totalCost = 0;
            if (newCheckoutTime != null)
            {
                DateTime now = DateTime.Now;

                double remainingDays = (order.CheckoutTime - now).TotalDays;
                double remainingCost = remainingDays * rooms[0].RoomOnePrice;

                double futureStayDays = (newCheckoutTime.Value - now).TotalDays;
                double futureStayCost = futureStayDays * rooms[0].RoomOnePrice;

                totalCost += futureStayCost - remainingCost;


            }
            if (newRoom != null)
            {
                DateTime now = DateTime.Now;

                double remainingDays = (order.CheckoutTime - now).TotalDays;
                double remainingCost = remainingDays * rooms[0].RoomOnePrice;

                double futureStayDays = (newCheckoutTime.Value - now).TotalDays;
                double futureStayCost = futureStayDays * rooms[0].RoomOnePrice;

                totalCost += futureStayCost - remainingCost;
            }
            return totalCost;
        }

        public long PaymentOrder(OrderMoneyDetails orderMoneyDetails)
        {

            DbContext.InsertQuery(orderMoneyDetails, "\"OrderData\".\"OrderMoneyDetails\"");
            
            List<OrderMoneyDetails>  detailsMoney = DbContext.Query<OrderMoneyDetails>($"SELECT * FROM \"OrderData\".\"OrderMoneyDetails\"\r\nORDER BY id DESC\r\nLIMIT 1;");

            return detailsMoney[0].Id;

        }

    }

}
