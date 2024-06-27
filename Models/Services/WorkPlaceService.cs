using HotelProject.Models.DataBase.MainModels.EmployeControl;
using SysHotel.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Services
{
    public class WorkPlaceService
    {
        public List<WorkPlace> WorkPlaceList()
        {
            try
            {
                List<WorkPlace> workPlaceList = DbContext.Query<WorkPlace>("select * from \"EmployeControlData\".\"workplace\"");
                return workPlaceList;
            }
            catch
            {
                throw;
            }
        }
        public List<string> GetAllType()
        {
            List<string> types = new List<string>();
            foreach (WorkPlace workPlace in WorkPlaceList())
            {
                types.Add(workPlace.Type);
            }
            return types;
        }
        public int GetPrice(string employeType)
        {
            foreach (WorkPlace workPlace in WorkPlaceList())
            {
                if (employeType == workPlace.Type)
                {
                    return workPlace.Price;
                }
            }
            return 0;
        }
    }
}
