using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.ActiveRoomsModel
{
    public class ActiveRoomsModelDGV
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string RoomSize { get; set; }
        public double PriceOne { get; set; }
        public double PriceGeneral { get; set; }
    }
}
