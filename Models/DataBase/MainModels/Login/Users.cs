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
<<<<<<< HEAD
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
=======
        public int Id { get; set; }
        public string PassportId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public int? YearOfBirth { get; set; }
        public string Gender { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string Role { get; set; }
>>>>>>> 7ac233c6c059b7d1476474ba8863bf4a1dafc9eb
    }
}
