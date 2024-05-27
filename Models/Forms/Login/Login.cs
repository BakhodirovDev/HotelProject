using HotelProject.Models.DataBase.MainModels.Login;
using SysHotel.Models.DataBase;
using SysHotel.Models.DataBase.MainModels;
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

namespace SysHotel.Models.Forms.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

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
            var (id, role) = auth.VerifyUser(Username.Text, Password.Text);

            if (id.HasValue && role == "Manager")
            {
                MessageBox.Show("Behruz");
                
            }
            else if (id.HasValue && role == "Admin")
            {
                MessageBox.Show("Diyorbek");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
