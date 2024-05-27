using Npgsql;
using SysHotel.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Models.DataBase.MainModels.Login
{
    public class auth
    {
        public static bool VerifyUser(string Username, string Password)
        {
            NpgsqlConnection connection = new NpgsqlConnection(DbContext.GetConnectionString());
            connection.Open();

            string query = @"SELECT COUNT(*) FROM public.""Users"" WHERE ""Username"" = @username AND ""Password"" = @password";

            using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", Username);
            cmd.Parameters.AddWithValue("@password", Password);

            int userCount = Convert.ToInt32(cmd.ExecuteScalar());

            return userCount > 0;
        }
    }
}
