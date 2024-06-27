using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.EmployeControl
{
    public class Room
    {
        public int RoomId { get; set; }
        public string? RoomType { get; set; }
        public int RoomNumber { get; set; }
        public int PeopleSize { get; set; }
        public int HavePeople { get; set; }
        public double RoomOnePrice { get; set; }
        public string? RoomDescription { get; set; }
    }
}
