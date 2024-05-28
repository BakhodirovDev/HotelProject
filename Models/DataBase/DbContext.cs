using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using SysHotel.Models.DataBase.MainModels;
using System.Reflection;
using System.Collections;
using System.Data;

namespace SysHotel.Models.DataBase
{
    internal class DbContext
    {
        static string connectionString = "Host=hotel-project-bbahodirov005.i.aivencloud.com;Port=12815;Database=defaultdb;Username=avnadmin;Password=AVNS_30IUYMHOZMenPstqonv;";
        //static string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres;";

        public static string GetConnectionString() { return connectionString; }

        public static bool ChangeQuery<T>(T model) where T : new()
        {
            using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            using NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT * FROM public.test2", connection);

            using NpgsqlDataReader reader = cmd.ExecuteReader();

            return true;
        }

        public static List<T> Query<T>(string query) where T : new()
        {

            using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            List<T> res = new List<T>();
            NpgsqlCommand q = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader r = q.ExecuteReader();

            while (r.Read())
            {
                T t = new T();

                for (int inc = 0; inc < r.FieldCount; inc++)
                {
                    Type type = t.GetType();

                    string namechange= NamaChange<T>(r.GetName(inc));

                    PropertyInfo prop = type.GetProperty(namechange);
                    
                    prop.SetValue(t, Convert.ChangeType(r.GetValue(inc), r.GetFieldType(inc)), null);
                    prop.SetValue(t, r.GetValue(inc), null);
                }

                res.Add(t);
            }
            r.Close();

            return res;
        }

        static string NamaChange<T>(string Name) where T : new()
        {
            T obj = new T();
            
            Type type = obj.GetType();

            PropertyInfo[] prop = type.GetProperties();

            var result = prop.First(prop => prop.Name.ToLower() == Name.ToLower());

            return result.Name;
        }
      
    }
}
