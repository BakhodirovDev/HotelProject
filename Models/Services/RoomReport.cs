using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Services
{
    public class RoomReport
    {
        public int RoomNumber {  get; set; }
        public string RoomType {  get; set; }
        public int RoomSize {  get; set; }
        public int Floor {  get; set; }
        public bool status {  get; set; }
        public double Price {  get; set; }
        public int CountOrders {  get; set; }
        public double inComeAmount {  get; set; }
        public double Expance {  get; set; }
        
    }
}
