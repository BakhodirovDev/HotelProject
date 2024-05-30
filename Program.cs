using HotelProject.Models.Forms.Admin;
using HotelProject.Models.Forms.Login;
using SysHotel.Models.Forms.Login;

namespace HotelProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AddUser());
        }
    }
}