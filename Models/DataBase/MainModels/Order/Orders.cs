using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace SysHotel.Models.DataBase.MainModels.Order
{
    public class Orders
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public int ClientId { get; set; }
        public int RoomId { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public long PriceId { get; set; }
=======
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
>>>>>>> b7a38c9d3b2310664d5c9682cc5bdb1e27807646
    }
}
