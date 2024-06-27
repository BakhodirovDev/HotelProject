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
    public class DeleteOrderServices : IDeleteOrder
    {
        public void CheckOutOrder(Orders order)
        {
            DbContext.ChangeQueryById(order, "UPDATE \"OrderData\".\"Orders\"\r\nSET checkouttime = now()\r\nWHERE id = 1;");
        }
    }
}
