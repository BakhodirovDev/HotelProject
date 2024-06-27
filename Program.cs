using HotelProject.Models.Forms.Admin;
using HotelProject.Models.Forms.Login;
using HotelProject.Models.Forms.Manager;
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
<<<<<<< HEAD
            Application.Run(new AdminForm(1));
=======
            Application.Run(new ManagerForm(1));
>>>>>>> a9a5f39b6e6fb50c90146d0bd6bbcc315e17d89f
        }
    }
}