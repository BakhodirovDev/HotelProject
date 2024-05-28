using HotelProject.Models.DataBase.MainModels.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Interfaces
{
    public interface ILogin
    {
        Task<bool> AddUser(Users model);
    }
}
