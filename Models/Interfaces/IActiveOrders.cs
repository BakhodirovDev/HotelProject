using HotelProject.Models.DataBase.MainModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Interfaces
{
    public interface IActiveOrders
    {
        Task<List<ActiveOrders>> ActiveOrdersReadAsync();
        //Task<List<ActiveOrders>> ActiveOrdersSearchAsync(string text);
    }
}
