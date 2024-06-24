using HotelProject.Models.DataBase.MainModels.EmployeControl;
using HotelProject.Models.DataBase.MainModels.Login;
using HotelProject.Models.DataBase.MainModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Interfaces
{
    public interface IOrder
    {
        public List<Room> ActiveOrderList(bool badOrRoom, string roomType);
        public List<RoomTypes> RoomTypesOrder();

        public List<Client> SearchClient(string passportId);
    }
}
