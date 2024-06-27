using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.EmployeControl
{
    public class Employe
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? SureName { get; set; }
        public DateTime YearOfCompletion { get; set; }
        public double Salary { get; set; }
        public string EmployeType { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
    }
}

