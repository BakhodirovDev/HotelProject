using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelProject.Models.DataBase.MainModels.Order
{
    public class Orders
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ClientId { get; set; }
        public long RoomId { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public long PriceId { get; set; }
        public long? OldId { get; set; }
        public long? SubClientId { get; set; }
    }
}
