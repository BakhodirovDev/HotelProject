using HotelProject.Models.Services;
using SysHotel.Models.Forms.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace HotelProject.Models.Forms.Admin
{
    public partial class AdminForm : Form
    {
        public bool TimePanel = false;
        public bool MenuPanel = false;
        public AdminForm(int id)
        {
            InitializeComponent();
            this.Load += new EventHandler(this.AdminForm_Load);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Barcha ekranlarni qamrab oluvchi formani maksimal hajmda o'rnating
            Rectangle totalBounds = new Rectangle();

            foreach (Screen screen in Screen.AllScreens)
            {
                totalBounds = Rectangle.Union(totalBounds, screen.Bounds);
            }

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal; // Maximal hajmda ochilishi uchun
            this.Bounds = totalBounds;
        }



        private void ActiveRoomsPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ActiveRoomsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientService clientService = new ClientService();
            ActiveRoomsDGV.DataSource = clientService.ActiveRoomsList();
        }

        private void ActiveRoomsDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (e.Start < DateTime.Today)
            {

                // Tanlovni bekor qilish va bugungi sanaga o'rnatish
                monthCalendar1.SetDate(DateTime.Today);
                monthCalendar1.AddBoldedDate(DateTime.Today.AddDays(-1));
            }
        }

        private void ChangeTimeARoomsButton_Click(object sender, EventArgs e)
        {
            TimePanel = !TimePanel;
            if (TimePanel == false)
            {
                ChangeTimeARoomsPanel.Visible = false;
            }
            else
            {
                ChangeTimeARoomsPanel.Visible = true;
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuPanel = !MenuPanel;
            if (MenuPanel == false)
            {
                ActiveRoomsButton.Text = "";
                LogOutButton.Text = "";
                MenuButtonsPanel.Size = new Size(58, 595);
            }
            else
            {
                ActiveRoomsButton.Text = "Active Rooms";
                LogOutButton.Text = "Log out";
                MenuButtonsPanel.Size = new Size(226, 595);
            }
        }

        private void ActiveRoomsPanel_FontChanged(object sender, EventArgs e)
        {
            
        }
    }
}
