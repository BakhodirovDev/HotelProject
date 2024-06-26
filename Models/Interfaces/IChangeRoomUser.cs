using HotelProject.Models.DataBase.MainModels.EmployeControl;
using HotelProject.Models.DataBase.MainModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Interfaces
{
    public interface IChangeRoomUser
    {
            Task<bool> ChangeRoomAndExtendStay(Orders order, Room newRoom, int newUserId, long newPriceId);
    }
}
