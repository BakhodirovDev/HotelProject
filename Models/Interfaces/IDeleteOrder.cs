using HotelProject.Models.DataBase.MainModels.Order;
using SysHotel.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Interfaces
{
    public interface IDeleteOrder
    {
        public void CheckOutOrder(Orders order);
        
    }
}
