﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelProject.Models.Forms.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
