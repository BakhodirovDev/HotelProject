using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.Order
{
    public class Client
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int YearOfCompletion { get; set; }
        public string? PhoneNumber { get; set; }
        public string PassportId { get; set; }
        public string Gender { get; set; }
    }
}
