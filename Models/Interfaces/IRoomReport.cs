using HotelProject.Models.DataBase.MainModels.ReportModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Interfaces
{
    public interface IRoomReport
    {
        Task<List<RoomReport>> GetRoomReport(RoomReport model);

    }
}
