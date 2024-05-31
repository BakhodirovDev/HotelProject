﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.EmployeControl
{
    public class EmpControl
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SureName { get; set; }
        public DateTime EnterTime { get; set; } 
        public DateTime EndTime { get; set; }
    }
}
