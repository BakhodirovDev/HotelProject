using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysHotel.Models.DataBase.MainModels.Order
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ClientId { get; set; }
        public int RoomId { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime ChickoutTime { get; set; }
        public double Price { get; set; }
    }
}
