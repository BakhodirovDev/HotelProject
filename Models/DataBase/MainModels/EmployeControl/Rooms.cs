using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.EmployeControl
{
    public  class Rooms
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string RoomType { get; set; }
        public int Price { get; set; }

        public string Status { get; set; }
    }
}
