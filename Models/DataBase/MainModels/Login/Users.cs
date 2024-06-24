using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.Login
{
    public class Users
    {
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
    }
}
