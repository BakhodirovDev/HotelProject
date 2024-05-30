using HotelProject.Models.DataBase.MainModels.Login;
using HotelProject.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelProject.Models.Forms.Login
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Users users = new Users()
            {
                FirstName=FirstName.Text,
                LastName=LastName.Text,
                UserName=UserName.Text,
                Password=Password.Text,
                RoleId=1
            };
            LoginService loginService = new LoginService();
            loginService.AddUser(users);
        }
    }
}
