using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.Order
{
    public class IncomeOutcome
    {
        public int Id { get; set; }
        public DateTime EnterTime { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } 
        public string Commit { get; set; } 
        public DateTime AmountTime { get; set; }
    }
}
