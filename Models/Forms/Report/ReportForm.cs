using HotelProject.Models.DataBase.MainModels.ReportModels;
using HotelProject.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelProject.Models.Forms.Report
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            loadReportList();
        }
        public async void loadReportList()
        {
            ClientReportMethod clientReportMethod = new ClientReportMethod();
            List<ClientReport> clientReports = await clientReportMethod.clientReportList();
            List<ClientReportUpdate> clientReportsUpdate = new List<ClientReportUpdate>();
            foreach (ClientReport r in clientReports)
            {
                int a = clientReports.Count(x => x.id == r.id);
                TimeSpan time = r.checkouttime - r.entertime;
                clientReportsUpdate.Add(new ClientReportUpdate() { id = r.id, firstname = r.firstname, lastname = r.lastname, entertime = r.entertime, checkouttime = r.checkouttime, roomnumber = r.roomnumber, roomtype = r.roomtype, liveday = time, pay = time.Days * r.roomoneprice, count = a });
            }
            jadval.DataSource = clientReportsUpdate;
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ClientReportMethod clientReportMethod = new ClientReportMethod();
            List<ClientReport> clientReports1 = await clientReportMethod.clientReportFilter(DateTime.Parse(enterTime.Text), DateTime.Parse(outTime.Text));
            List<ClientReportUpdate> clientReportsUpdate = new List<ClientReportUpdate>();
            foreach (ClientReport r in clientReports1)
            {
                int a = clientReports1.Count(x => x.id == r.id);
                TimeSpan time = r.checkouttime - r.entertime;
                clientReportsUpdate.Add(new ClientReportUpdate() { id = r.id, firstname = r.firstname, lastname = r.lastname, entertime = r.entertime, checkouttime = r.checkouttime, roomnumber = r.roomnumber, roomtype = r.roomtype, liveday = time, pay = time.Days * r.roomoneprice, count = a });
            }
            jadval.DataSource = clientReportsUpdate;
        }

        private void Btn_roomnumber_Click(object sender, EventArgs e)
        {
            
            //ClientReportMethod clientReportMethod = new ClientReportMethod();
            //List<ClientReport> clientReports1 = clientReportMethod.clientSortReport(name);
            //List<ClientReportUpdate> clientReportsUpdate = new List<ClientReportUpdate>();
            //foreach (ClientReport r in clientReports1)
            //{
            //    int a = clientReports1.Count(x => x.id == r.id);
            //    TimeSpan time = r.checkouttime - r.entertime;
            //    clientReportsUpdate.Add(new ClientReportUpdate() { id = r.id, firstname = r.firstname, lastname = r.lastname, entertime = r.entertime, checkouttime = r.checkouttime, roomnumber = r.roomnumber, roomtype = r.roomtype, liveday = time, pay = time.Days * r.roomoneprice, count = a });
            //}
            //jadval.DataSource = clientReportsUpdate;
        }
    }
}
