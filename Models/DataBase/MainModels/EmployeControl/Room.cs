using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.EmployeControl
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomType { get; set; }
        public int RoomNumber { get; set; }
        public string PeopleSize { get; set; }
        public double RoomOnePrice { get; set; }
        public double RoomManyPrice { get; set; }
        public string RoomDescription { get; set; }
    }
}
