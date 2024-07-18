namespace HotelProject.Models.Forms.Report
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            jadval = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            entertimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkouttimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomnumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomtypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            payDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            livedayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientReportUpdateBindingSource = new BindingSource(components);
            clientReportBindingSource = new BindingSource(components);
            enterTime = new DateTimePicker();
            outTime = new DateTimePicker();
            button1 = new Button();
            roomnumber = new Button();
            ((System.ComponentModel.ISupportInitialize)jadval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientReportUpdateBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientReportBindingSource).BeginInit();
            SuspendLayout();
            // 
            // jadval
            // 
            jadval.AutoGenerateColumns = false;
            jadval.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jadval.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstnameDataGridViewTextBoxColumn, lastnameDataGridViewTextBoxColumn, entertimeDataGridViewTextBoxColumn, checkouttimeDataGridViewTextBoxColumn, roomnumberDataGridViewTextBoxColumn, roomtypeDataGridViewTextBoxColumn, payDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, livedayDataGridViewTextBoxColumn });
            jadval.DataSource = clientReportUpdateBindingSource;
            jadval.Location = new Point(108, 229);
            jadval.Name = "jadval";
            jadval.RowHeadersWidth = 51;
            jadval.Size = new Size(1538, 417);
            jadval.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            firstnameDataGridViewTextBoxColumn.Width = 180;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            lastnameDataGridViewTextBoxColumn.Width = 180;
            // 
            // entertimeDataGridViewTextBoxColumn
            // 
            entertimeDataGridViewTextBoxColumn.DataPropertyName = "entertime";
            entertimeDataGridViewTextBoxColumn.HeaderText = "entertime";
            entertimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            entertimeDataGridViewTextBoxColumn.Name = "entertimeDataGridViewTextBoxColumn";
            entertimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // checkouttimeDataGridViewTextBoxColumn
            // 
            checkouttimeDataGridViewTextBoxColumn.DataPropertyName = "checkouttime";
            checkouttimeDataGridViewTextBoxColumn.HeaderText = "checkouttime";
            checkouttimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            checkouttimeDataGridViewTextBoxColumn.Name = "checkouttimeDataGridViewTextBoxColumn";
            checkouttimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomnumberDataGridViewTextBoxColumn
            // 
            roomnumberDataGridViewTextBoxColumn.DataPropertyName = "roomnumber";
            roomnumberDataGridViewTextBoxColumn.HeaderText = "roomnumber";
            roomnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomnumberDataGridViewTextBoxColumn.Name = "roomnumberDataGridViewTextBoxColumn";
            roomnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomtypeDataGridViewTextBoxColumn
            // 
            roomtypeDataGridViewTextBoxColumn.DataPropertyName = "roomtype";
            roomtypeDataGridViewTextBoxColumn.HeaderText = "roomtype";
            roomtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomtypeDataGridViewTextBoxColumn.Name = "roomtypeDataGridViewTextBoxColumn";
            roomtypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // payDataGridViewTextBoxColumn
            // 
            payDataGridViewTextBoxColumn.DataPropertyName = "pay";
            payDataGridViewTextBoxColumn.HeaderText = "pay";
            payDataGridViewTextBoxColumn.MinimumWidth = 6;
            payDataGridViewTextBoxColumn.Name = "payDataGridViewTextBoxColumn";
            payDataGridViewTextBoxColumn.Width = 150;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "count";
            countDataGridViewTextBoxColumn.HeaderText = "count";
            countDataGridViewTextBoxColumn.MinimumWidth = 6;
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.Width = 125;
            // 
            // livedayDataGridViewTextBoxColumn
            // 
            livedayDataGridViewTextBoxColumn.DataPropertyName = "liveday";
            livedayDataGridViewTextBoxColumn.HeaderText = "liveday";
            livedayDataGridViewTextBoxColumn.MinimumWidth = 6;
            livedayDataGridViewTextBoxColumn.Name = "livedayDataGridViewTextBoxColumn";
            livedayDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientReportUpdateBindingSource
            // 
            clientReportUpdateBindingSource.DataSource = typeof(DataBase.MainModels.ReportModels.ClientReportUpdate);
            // 
            // clientReportBindingSource
            // 
            clientReportBindingSource.DataSource = typeof(DataBase.MainModels.ReportModels.ClientReport);
            // 
            // enterTime
            // 
            enterTime.Location = new Point(154, 40);
            enterTime.Name = "enterTime";
            enterTime.Size = new Size(250, 27);
            enterTime.TabIndex = 1;
            // 
            // outTime
            // 
            outTime.Location = new Point(541, 40);
            outTime.Name = "outTime";
            outTime.Size = new Size(250, 27);
            outTime.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(835, 119);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // roomnumber
            // 
            roomnumber.BackColor = Color.Cornsilk;
            roomnumber.Location = new Point(945, 229);
            roomnumber.Name = "roomnumber";
            roomnumber.Size = new Size(124, 29);
            roomnumber.TabIndex = 4;
            roomnumber.Text = "roomnumber";
            roomnumber.UseVisualStyleBackColor = false;
            roomnumber.Click += Btn_roomnumber_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1785, 658);
            Controls.Add(roomnumber);
            Controls.Add(button1);
            Controls.Add(outTime);
            Controls.Add(enterTime);
            Controls.Add(jadval);
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)jadval).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientReportUpdateBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientReportBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView jadval;
        private BindingSource clientReportBindingSource;
        private DateTimePicker enterTime;
        private DateTimePicker outTime;
        private Button button1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn entertimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkouttimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn payDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn livedayDataGridViewTextBoxColumn;
        private BindingSource clientReportUpdateBindingSource;
        private Button roomnumber;
    }
}