using HotelProject.Models.DataBase.MainModels.Login;
using HotelProject.Models.DataBase.MainModels.Order;
using HotelProject.Models.Forms.Admin;
using HotelProject.Models.Forms.Manager;
using HotelProject.Models.Services;
using Microsoft.VisualBasic.ApplicationServices;
using SysHotel.Models.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SysHotel.Models.Forms.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CheckInputs();
            //DbContext.Query<Test2>("SELECT * FROM public.test2");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            AuthService loginService = new AuthService();
            var loginResult = loginService.CheckLogin(Username.Text, Password.Text);
            if (loginResult != null)
            {
                if (loginResult.Role == "Manager")
                {
                    ManagerForm managerForm = new ManagerForm(loginResult.Id);
                    managerForm.Show();
                    this.Hide();
                }
                if (loginResult.Role == "Admin")
                {
                    AdminForm adminForm = new AdminForm(loginResult.Id);
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    Console.WriteLine("User is not a Manager. Role: " + loginResult.Role);
                    // Boshqa rollar uchun kodni bu yerda yozishingiz mumkin
                }
            }
            else
            {
                Console.WriteLine("Login failed or an error occurred.");
            }

        }
        private void Username_TextChanged(object sender, EventArgs e)
        {
            CheckInputs();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            CheckInputs();
        }

        public void CheckInputs()
        {
            // Shartni tekshiramiz
            if (Username.Text.Length < 4 || Password.Text.Length < 4 || Username.Text == "" || Password.Text == "")
            {
                // Agar shart bajarilsa, tugmasni faolsiz qilamiz
                LoginBTN.Enabled = false;
            }
            else
            {
                // Agar shart bajarilmasa, tugmasni faol qilamiz
                LoginBTN.Enabled = true;
            }
        }



        private void LoginBTN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginBTN_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void LoginBTN_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
