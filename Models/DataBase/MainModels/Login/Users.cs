using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.Login
{
    public class Users
    {
        public long id { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public int age { get; set; }
        public string passport { get; set; }
        public string phonenumber { get; set; }
        public string gender { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

    }
}
