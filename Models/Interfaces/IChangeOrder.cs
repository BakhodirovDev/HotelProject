using HotelProject.Models.DataBase.MainModels.EmployeControl;
using HotelProject.Models.DataBase.MainModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Interfaces
{
    public interface IChangeOrder
    {
        public Task<bool> ChangeRoomAndExtendStay(Orders order, Room newRoom, int newUserId, long newPriceId);
        public Task<bool> ChangeTimeAndExtendStay(Orders order, DateTime newCheckoutTime, int newUserId, long newPriceId);
        public double CalculateSumma(Orders order, DateTime? newCheckoutTime, Room? newRoom);
        public long PaymentOrder(OrderMoneyDetails orderMoneyDetails);

    }
}
