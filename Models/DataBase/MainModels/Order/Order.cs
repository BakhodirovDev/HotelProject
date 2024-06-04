using HotelProject.Models.DataBase.MainModels.Order;
using HotelProject.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysHotel.Models.DataBase.MainModels.Order
{
    public class Order:Client
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public int ClientId { get; set; }
        public int RoomNumber { get; set; }
        public string EnterTime { get; set; }
        public string ChickoutTime { get; set; }
        public int Price { get; set; }
    }
}
