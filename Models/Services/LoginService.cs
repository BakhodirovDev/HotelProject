using HotelProject.Models.DataBase.MainModels.Login;
using HotelProject.Models.DataBase.MainModels.Login.ViewModels;
using HotelProject.Models.DataBase.MainModels.Order;
using HotelProject.Models.Interfaces;
using SysHotel.Models.DataBase;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.Services
{
    public class LoginService : ILogin
    {
        public Task<bool> AddUser(Users model,Client client)
        {
			try
			{
                List<Users> list=DbContext.Query<Users>("select * from public.users");
                if (list!= null)
                    return Task.FromResult(false);
                bool result=DbContext.InsertQuery<Users>(model,"public");
                return Task.FromResult(result);
            }
			catch (Exception)
			{
				throw;
			}
        }

        public ReturnLoginViewModel CheckLogin(string login,string pass)
        {
            ReturnLoginViewModel result= new ReturnLoginViewModel();
            result.result = false;
            result.Message = "Login yoki parol noto`g`ri kiritildi!";
            Users? model = DbContext.Query<Users>(@$"select * from 
                                                         public.users where username='{login}'
                                                         and password='{pass}'").FirstOrDefault();
            if (model!=null)
            {
                result.result = true;
                result.Message = "Ok";
                result.User = model;
                return result;
            }
            return result;
        }

        public ReturnLoginViewModel UpdateLogin(Users model)
        {
            ReturnLoginViewModel result = new ReturnLoginViewModel();
            result.result = true;
            result.Message = "Ok";
            bool queryresult = DbContext.ChangeQueryById(model, "public");
            if(queryresult)
                return result;
            result.result = false;
            result.Message = "Xatolik yuz berdi!";
            return result;
        }
    }
}
