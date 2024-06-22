using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.ReportModels
{
    public class ClientReport
    {
        public int id { get; set; }
        public string FIO { get; set; }
        public DateTime InCome { get; set; }
        public DateTime OutCome { get; set; }
        public string room { get; set; }
        public string roomType { get; set; }
        public int LivedTime { get; set; }
        public int count { get; set; }
        public double Pay { get; set; }
    }
}
