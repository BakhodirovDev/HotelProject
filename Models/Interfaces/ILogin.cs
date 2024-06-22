using HotelProject.Models.DataBase.MainModels.Login;
using HotelProject.Models.DataBase.MainModels.Login.ViewModels;
using HotelProject.Models.DataBase.MainModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Interfaces
{
    public interface ILogin
    {
        Task<bool> AddUser(Users model,Client client);
        ReturnLoginViewModel CheckLogin(string login, string pass);

        ReturnLoginViewModel UpdateLogin(Users model);
    }
}
