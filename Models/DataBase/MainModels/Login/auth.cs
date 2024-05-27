using Npgsql;
using SysHotel.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelProject.Models.DataBase.MainModels.Login
{
    public class auth
    {
        public static (int? ID, string? Role) VerifyUser(string Username, string Password)
        {
            NpgsqlConnection connection = new NpgsqlConnection(DbContext.GetConnectionString());
            connection.Open();

            string query_CheckUser = @"SELECT COUNT(*) FROM public.""Users"" WHERE ""Username"" = @username AND ""Password"" = @password";

            using NpgsqlCommand cmd_CheckUser = new NpgsqlCommand(query_CheckUser, connection);
            cmd_CheckUser.Parameters.AddWithValue("@username", Username);
            cmd_CheckUser.Parameters.AddWithValue("@password", Password);

            int userCount = Convert.ToInt32(cmd_CheckUser.ExecuteScalar());

            if (userCount > 0)
            {
                string query_GetId = @"SELECT ""ID"" FROM public.""Users"" WHERE ""Username"" = @username";

                using NpgsqlCommand cmd1 = new NpgsqlCommand(query_GetId, connection);
                cmd1.Parameters.AddWithValue("@username", Username);
                object result1 = cmd1.ExecuteScalar();

                string query_GetRole = @"SELECT ""Role"" FROM public.""Users"" WHERE ""Username"" = @username";

                using NpgsqlCommand cmd2 = new NpgsqlCommand(query_GetRole, connection);
                cmd2.Parameters.AddWithValue("@username", Username);
                object result2 = cmd2.ExecuteScalar();

                int id = Convert.ToInt32(result1);
                string role = result2.ToString();

                return (id, role);
            }
            else
            {
                return (null, null);
            }
        }


    }
}
