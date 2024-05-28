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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SureName { get; set; }
        public int Age { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EmpType { get; set; }
        public int SalaryId { get; set; }

    }
}
