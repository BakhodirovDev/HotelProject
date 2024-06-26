﻿using Guna.UI2.WinForms;
using HotelProject.Models.DataBase.MainModels.EmployeControl;
using HotelProject.Models.DataBase.MainModels.Order;
using HotelProject.Models.Services;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using SysHotel.Models.Forms.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelProject.Models.Forms.Admin
{
    public partial class AdminForm : Form
    {
        List<User> SearchOneUser = new List<User>();
        List<Client> SearchOneClient = new List<Client>();
        List<Room> SearchOneRoom = new List<Room>();

        List<Client> ThisRoomClients = new List<Client>();
        List<Orders> NewOrders = new List<Orders>();

        List<Client> OrdersAddRooms = new List<Client>();

        public bool TimePanel = false;
        public bool MenuPanel = false;
        OrderService orderService = new OrderService();
        public AdminForm(long id)
        {
            InitializeComponent();
            AddRoomTypes();
            this.Load += new EventHandler(this.AdminForm_Load);
            OrderDVG.DataSource = orderService.ActiveOrderList(false, "");
            ActiveRoomsButton_Click(ActiveRoomsPanel, EventArgs.Empty);
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


        private void ActiveRoomsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientService clientService = new ClientService();
            ActiveRoomsDGV.DataSource = clientService.ActiveRoomsList();
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (e.Start < DateTime.Today)
            {

                // Tanlovni bekor qilish va bugungi sanaga o'rnatish
                //monthCalendar1.SetDate(DateTime.Today);
                //monthCalendar1.AddBoldedDate(DateTime.Today.AddDays(-1));
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

        private void guna2DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            ButtonCellPaintingDGV("Plus", @"../../../Pictures/Plus.png", OrderDVG, e);
            foreach (DataGridViewRow row in OrderDVG.Rows)
            {
                double qiymat1 = Convert.ToDouble(row.Cells[2].Value);
                double qiymat2 = Convert.ToDouble(row.Cells[3].Value);
                double qiymat3 = Convert.ToDouble(row.Cells[4].Value);
                row.Cells[5].Value = (qiymat2 - qiymat1) * qiymat3;
            }
        }

        private void guna2DataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            ButtonCellPaintingDGV("Delete", @"../../../Pictures/DeleteDGV.png", guna2DataGridView2, e);
            ButtonCellPaintingDGV("Update", @"../../../Pictures/Available Updates.png", guna2DataGridView2, e);
        }
        private void ButtonCellPaintingDGV(string ColumnName, string PicturePath, DataGridView dataGridViewName, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewName.Columns[ColumnName].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Rasmni yuklash
                Image img = Image.FromFile(PicturePath);
                int imgX = e.CellBounds.Left + (e.CellBounds.Width - img.Width) / 2;
                int imgY = e.CellBounds.Top + (e.CellBounds.Height - img.Height) / 2;

                e.Graphics.DrawImage(img, new Rectangle(imgX, imgY, img.Width, img.Height));
                e.Handled = true;
            }
        }


        private void OrderDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = OrderDVG.Rows[e.RowIndex];
                RoomNumberTextBox.Text = selectedRow.Cells[1].Value.ToString() + "-xona  " + selectedRow.Cells[0].Value.ToString();
                RoomNameAddOrderTextBox.Text = selectedRow.Cells[1].Value.ToString() + "-xona  " + selectedRow.Cells[0].Value.ToString();
                RoomDescriptionTextBox.Text = selectedRow.Cells[6].Value.ToString();
                RoomDiscriptionAddOrderTextBox.Text = selectedRow.Cells[6].Value.ToString();
            }
        }

        private void SearchOrderButton_Click(object sender, EventArgs e)
        {
            OrderDVG.DataSource = orderService.ActiveOrderList(BedOrRoom.Checked, RoomTypeComboBox.Text);
        }


        private void AddRoomTypes()
        {
            RoomTypeComboBox.Items.Add("Active Rooms");
            List<RoomTypes> roomTypes = new List<RoomTypes>();
            roomTypes = orderService.RoomTypesOrder();
            foreach (var item in roomTypes)
            {
                RoomTypeComboBox.Items.Add(item.RoomType);
            }

        }

        private void OrderDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                OrderPanel.Visible = false;
                AddOrderPanel.Visible = true;
                AddOrderPanel.Dock = DockStyle.Fill;
                AddOrderPanel.BringToFront();
                AddOrderPanel.Refresh();
                OrderDVG.Refresh();
            }
        }

        private void ActiveRoomsButton_Click(object sender, EventArgs e)
        {
            OrderPanel.Visible = false;
            ActiveRoomsPanel.Visible = true;
            ActiveRoomsPanel.Dock = DockStyle.Fill;
            ActiveRoomsPanel.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ActiveRoomsPanel.Visible = false;
            OrderPanel.Visible = true;
            OrderPanel.Dock = DockStyle.Fill;
            OrderPanel.BringToFront();
        }



        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string originalText = PasswordIdTextBox.Text;
            string filteredText = new string(originalText.Where(c => char.IsLetterOrDigit(c)).ToArray());

            filteredText = filteredText.ToUpper();

            PasswordIdTextBox.TextChanged -= guna2TextBox1_TextChanged;

            PasswordIdTextBox.Text = filteredText;

            PasswordIdTextBox.SelectionStart = filteredText.Length;

            PasswordIdTextBox.TextChanged += guna2TextBox1_TextChanged;
        }



        private void IsmTextBox_TextChanged_1(object sender, EventArgs e)
        {
            string originalText = IsmTextBox.Text;
            string filteredText = new string(originalText.Where(c => char.IsLetterOrDigit(c)).ToArray());

            IsmTextBox.TextChanged -= IsmTextBox_TextChanged_1;

            IsmTextBox.Text = filteredText;

            IsmTextBox.SelectionStart = filteredText.Length;

            IsmTextBox.TextChanged += IsmTextBox_TextChanged_1;
        }

        private void FamilyaTextBox_TextChanged(object sender, EventArgs e)
        {
            string originalText = FamilyaTextBox.Text;
            string filteredText = new string(originalText.Where(c => char.IsLetterOrDigit(c)).ToArray());

            FamilyaTextBox.TextChanged -= FamilyaTextBox_TextChanged;

            FamilyaTextBox.Text = filteredText;

            FamilyaTextBox.SelectionStart = filteredText.Length;

            FamilyaTextBox.TextChanged += FamilyaTextBox_TextChanged;
        }



        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            try
            {
                client = new Client()
                {
                    PassportId = PasswordIdTextBox.Text,
                    FirstName = IsmTextBox.Text,
                    LastName = FamilyaTextBox.Text,
                    PhoneNumber = PhoneNumberTextBox.Text,
                    YearOfCompletion = int.Parse(TogilganYilTextBox.Text),
                    Gender = GenderComboBox.Text
                };
            }
            catch
            {
                MessageBox.Show("Malumotlarni to'liq kiriting!!!");
            }
            Client HaveClient = new Client();
            HaveClient = ThisRoomClients.Find(x => x.PassportId == client.PassportId);

            if (HaveClient == null || ThisRoomClients == null)
                ThisRoomClients.Add(client);

            ThisRoomOrdersDGV.DataSource = null;
            ThisRoomOrdersDGV.DataSource = ThisRoomClients;

            ClearText();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SearchOneClient = orderService.SearchClient(PasswordIdTextBox.Text);
            if (SearchOneClient.Count >= 1)
            {
                IsmTextBox.Text = SearchOneClient[0].FirstName;
                FamilyaTextBox.Text = SearchOneClient[0].LastName;
                PhoneNumberTextBox.Text = SearchOneClient[0].PhoneNumber;
                TogilganYilTextBox.Text = SearchOneClient[0].YearOfCompletion.ToString();
                GenderComboBox.Text = SearchOneClient[0].Gender;
            }

            SearchOneClient.Clear();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ThisRoomOrdersDGV.DataSource = ThisRoomClients;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            PasswordIdTextBox.Text = string.Empty;
            IsmTextBox.Text = string.Empty;
            FamilyaTextBox.Text = string.Empty;
            PhoneNumberTextBox.Text = string.Empty;
            TogilganYilTextBox.Text = string.Empty;
            GenderComboBox.SelectedIndex = -1;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

            ThisRoomOrdersDGV.DataSource = null;
            ThisRoomClients.Clear();
            ClearText();
            OrderPanel.Visible = true;
            AddOrderPanel.Visible = false;
            OrderPanel.Dock = DockStyle.Fill;
            OrderPanel.BringToFront();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
