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
        public static bool InsertQuery<T>(T model, string schema) where T : new()
        {
            using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string entresult = InsertString<T>(model);
            using NpgsqlCommand cmd = new NpgsqlCommand(@$"INSERT INTO {schema}." + entresult, connection);

            cmd.ExecuteNonQuery();

            connection.Close();

            return true;
        }
        public static bool ChangeQueryById<T>(T model, string schema) where T : new()
        {
            using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string entresult = UpdateString<T>(model);
            using NpgsqlCommand cmd = new NpgsqlCommand(@$"update {schema}." + entresult, connection);

            cmd.ExecuteNonQuery();

            connection.Close();
            return true;
        }
        public static T ExecuteQuery<T>(string sql, Dictionary<string, object> parameters, Func<IDataReader, T> mapFunction, out string errorMessage)
        {
            errorMessage = null;
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Parametrlarni qo'shish
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return mapFunction(reader);
                            }
                            else
                            {
                                return default;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return default;
            }
        }
        public static List<T> Query<T>(string query) where T : new()
        {
            try
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

                        string namechange = NamaChange<T>(r.GetName(inc));

                        PropertyInfo prop = type.GetProperty(namechange);

                        if (prop != null && prop.CanWrite)
                        {
                            object value = r.GetValue(inc);

                            if (value != DBNull.Value)
                            {
                                value = Convert.ChangeType(value, prop.PropertyType);
                                prop.SetValue(t, value, null);
                            }
                        }
                    }

                    res.Add(t);
                }
                r.Close();

                return res;
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing query", ex);
            }
        }
<<<<<<< HEAD
=======


>>>>>>> 7ac233c6c059b7d1476474ba8863bf4a1dafc9eb
        static string NamaChange<T>(string Name) where T : new()
        {
            T t = new T();
            Type type = t.GetType();

            PropertyInfo[] prop = type.GetProperties();

            var result = prop.First(prop => prop.Name.ToLower() == Name.ToLower());

            return result.Name;
        }
        static string InsertString<T>(T model) where T : new()
        {
            string text = "", text1 = "", result;

            T t = new T();
            Type type = t.GetType();
            Type modelName = typeof(T);

            PropertyInfo[] prop = type.GetProperties();

            for (int i = 1; i < prop.Length; i++)
            {
                text += prop[i].Name.ToLower() + ",";
            }
            text = modelName.Name + "(" + text.Substring(0, text.Length - 1) + ")";

            for (int i = 1; i < prop.Length; i++)
            {
                object stringValue = GetPropertyValue<T>(model, prop[i].Name);
                PropertyInfo propertyInfo = type.GetProperty(prop[i].Name);
                string newresult = (propertyInfo.PropertyType.ToString() == "System.String") ? $"'{stringValue}'" : stringValue.ToString();
                text1 += newresult + ",";
            }
            text1 = " values (" + text1.Substring(0,text1.Length-1) + ")";
            result = text + text1;

            return result;
        }
        static string UpdateString<T>(T model) where T : new()
        {
            string text = "", result;

            T t = new T();
            Type type = t.GetType();
            Type modelName = typeof(T);

            PropertyInfo[] prop = type.GetProperties();

            for (int i = 1; i < prop.Length; i++)
            {
                object stringValue = GetPropertyValue<T>(model, prop[i].Name);
                PropertyInfo propertyInfo = type.GetProperty(prop[i].Name);
                string newresult = (propertyInfo.PropertyType.ToString() == "System.String") ? $"'{stringValue}'" : stringValue.ToString();

                text += prop[i].Name.ToLower() + "=" + newresult.ToString() + ",";
            }
            result = modelName.Name + " set " + text.Substring(0, text.Length - 1) + " where id=" + GetPropertyValue<T>(model, prop[0].Name);

            return result;
        }
        static object GetPropertyValue<T>(T obj, string propertyName)
        {
            // Get the type of the object
            Type type = typeof(T);

            // Get the PropertyInfo object representing the property
            PropertyInfo propertyInfo = type.GetProperty(propertyName);

            // Check if the property exists
            if (propertyInfo == null)
            {
                throw new ArgumentException($"Property '{propertyName}' not found on type '{type.Name}'.");
            }

            // Get the value of the property
            return propertyInfo.GetValue(obj);
        }
        // Method to execute SELECT queries and return results as a list of objects
        public static List<T> ExecuteQuery<T>(string query) where T : new()
        {
            try
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
                        string namechange = NamaChange<T>(r.GetName(inc));

                        PropertyInfo prop = type.GetProperty(namechange);
                        if (prop != null && prop.CanWrite)
                        {
                            object value = r.IsDBNull(inc) ? null : Convert.ChangeType(r.GetValue(inc), prop.PropertyType);
                            prop.SetValue(t, value, null);
                        }
                    }

                    res.Add(t);
                }

                return res;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
        // Method to execute INSERT, UPDATE, DELETE queries
        public static int ExecuteNonQuery(string query)
        {
            try
            {
                using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();

                NpgsqlCommand q = new NpgsqlCommand(query, connection);
                return q.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }

    }
}
