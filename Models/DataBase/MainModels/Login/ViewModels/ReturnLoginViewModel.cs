using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.Login.ViewModels
{
    public class ReturnLoginViewModel
    {
        public bool result { get; set; }
        public string Message{ get; set; }

        public Users? User {  get; set; }
    }
}
