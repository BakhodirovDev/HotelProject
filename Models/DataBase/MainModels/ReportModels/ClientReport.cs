﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.ReportModels
{
    public class ClientReport
    {
        public string id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime entertime { get; set; }
        public DateTime checkouttime { get; set; }
        public string roomnumber { get; set; }
        public string roomtype { get; set; }
        public double roomoneprice { get; set; }

    }
}
