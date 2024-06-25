using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.Order
{
    public class OrderMoneyDetails
    {
        public long Id { get; set; }
        public double? TerminalPayment { get; set; }
        public double? CardPayment { get; set; }
        public double? CashPayment { get; set; }
    }
}
