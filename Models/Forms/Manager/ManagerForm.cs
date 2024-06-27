﻿using HotelProject.Models.DataBase.MainModels.EmployeControl;
using HotelProject.Models.Interfaces;
using HotelProject.Models.Services;
using SysHotel.Models.DataBase;
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


namespace HotelProject.Models.Forms.Manager
{
    public partial class ManagerForm : Form
    {
        EmployeServices employeServices = new EmployeServices();
        WorkPlaceService workPlaceService = new WorkPlaceService();
        public ManagerForm(int ID)
        {
            InitializeComponent();
            pnManager.Visible = true;
            pnEmployeControl.Visible = false;
            dataGridView1.DataSource = employeServices.EmployeList();
            cbEmployeType.DataSource = workPlaceService.GetAllType();
            cbEmployeType.SelectedIndex = -1;
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            //Login login = new Login();
            //login.StartPosition = FormStartPosition.CenterScreen;
            //login.Show();
            //this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            pnEmployeControl.Visible = true;
            lbId.Visible = false;
            txId.Visible = false;
            lbLogin.Visible = false;
            txLogin.Visible = false;
            lbPassword.Visible = false;
            txPassword.Visible = false;
            btDo.Text = "Qo'shish";

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            lbId.Visible = true;
            txId.Visible = true;
            lbLogin.Visible = false;
            txLogin.Visible = false;
            lbPassword.Visible = false;
            txPassword.Visible = false;
            btDo.Text = "Yangilash";
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            lbId.Visible = true;
            txId.Visible = true;
            lbLogin.Visible = false;
            txLogin.Visible = false;
            lbPassword.Visible = false;
            txPassword.Visible = false;
            btDo.Text = "O'chirish";
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void btDo_Click(object sender, EventArgs e)
        {
            if(btDo.Text == "Qo'shish")
            {
                if (employeServices.CalculateAge(DateTime.Parse(dTPBirthday.Text)) >= 18)
                {
                    if(cbEmployeType.Text.Length > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Ishchi turini tanlamadingiz", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Yosh bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(btDo.Text == "Yangilash")
            {

            }
            else
            {

            }
        }
    }
}
