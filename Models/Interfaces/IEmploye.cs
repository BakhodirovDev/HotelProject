using HotelProject.Models.DataBase.MainModels.EmployeControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Interfaces
{
    public interface IEmploye
    {
        Task<bool> AddUser(Employe model);
    }
}
