using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.Order
{
    public class ExchangeTime
    {
        public int Id { get; set; }              
        public DateTime EnterTime { get; set; }
        public int GiveUserId { get; set; }      
        public int GetUserId { get; set; }       
        public decimal Amount { get; set; }
    }
}
