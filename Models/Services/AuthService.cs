using HotelProject.Models.DataBase.MainModels.Login;
using HotelProject.Models.DataBase.MainModels.Login.ViewModels;
using HotelProject.Models.DataBase.MainModels.Order;
using HotelProject.Models.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using SysHotel.Models.DataBase;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace HotelProject.Models.Services
{
    public class AuthService : ILogin
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

        public ReturnLoginViewModel CheckLogin(string Username,string Password)
        {
            // SQL so'rovini tayyorlash
            string sql = "SELECT auth.auth_login(@uname, @pswd)";

            // Parametrlarni tayyorlash
            var parameters = new Dictionary<string, object>
                {
                    { "uname", Username },
                    { "pswd", Password }
                };
            string errorMessage;
            // So'rovni bajarish va natijani olish
            var userJson = DbContext.ExecuteQuery(sql, parameters, reader => reader.GetString(0), out errorMessage);
            
            if (errorMessage != null)
            {
                Console.WriteLine("Error: " + errorMessage);
            }

            if (userJson != null)
            {
                // JSON ni User modeliga o'girib olish
                var user = JsonSerializer.Deserialize<Users>(userJson);

                var returnModel = new ReturnLoginViewModel
                {
                    Id = user.id,
                    Role = user.role
                };

                return returnModel;
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
            return new ReturnLoginViewModel();  

        }

        
    }
}


