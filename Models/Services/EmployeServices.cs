using HotelProject.Models.DataBase.MainModels.EmployeControl;
using HotelProject.Models.DataBase.MainModels.Login;
using HotelProject.Models.DataBase.MainModels.ReportModels;
using HotelProject.Models.Interfaces;
using SysHotel.Models.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelProject.Models.Services
{
    public class EmployeServices : IEmploye
    {
        public Task<bool> AddUser(Employe model)
        {
            try
            {
                DbContext.Query<Employe>("");
                return Task.FromResult(true);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int CalculateAge(DateTime birthday)
        {
            int Age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.Month < birthday.Month || (DateTime.Now.Month == birthday.Month && DateTime.Now.Day < birthday.Day))
            {
                Age--;
            }
            return Age;
        }
        public List<Employe> EmployeList()
        {
            try
            {
                List<Employe> employeList = DbContext.Query<Employe>("select * from \"EmployeControlData\".\"employe\"");
                return employeList;
            }
            catch
            {
                throw;
            }
        }
        public bool CheckLogin(string login)
        {
            foreach (Employe employe in EmployeList())
            {
                if (login == employe.Login)
                {
                    return false;
                }
            }
            return true;
        }
        public bool CheckProbel(string str)
        {
            if (str.Length > 0)
            {
                int sanoq = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        sanoq++;
                    }
                }
                if (sanoq != str.Length)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckNumber(string str)
        {
            if (str.Length > 0)
            {
                int sanoq = 0;
                char FirstChar = '1';
                for (int i = 0; i < str.Length; i++)
                {
                    FirstChar = str[0];
                    if (str[i] >= 48 && str[i] <= 57)
                    {
                        sanoq++;
                    }
                }
                if (FirstChar != '0' && sanoq == str.Length)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Employe> GetSeachList(string search)
        {
            throw new NotImplementedException();
        }
    }
}
