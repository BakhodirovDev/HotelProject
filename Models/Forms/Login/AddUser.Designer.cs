namespace HotelProject.Models.Forms.Login
{
    partial class AddUser
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
            FirstName = new TextBox();
            Password = new TextBox();
            UserName = new TextBox();
            LastName = new TextBox();
            btnAddUser = new Button();
            SuspendLayout();
            // 
            // FirstName
            // 
            FirstName.Location = new Point(158, 16);
            FirstName.Margin = new Padding(3, 4, 3, 4);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(503, 27);
            FirstName.TabIndex = 0;
            // 
            // Password
            // 
            Password.Location = new Point(158, 207);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Name = "Password";
            Password.Size = new Size(503, 27);
            Password.TabIndex = 1;
            // 
            // UserName
            // 
            UserName.Location = new Point(158, 148);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Name = "UserName";
            UserName.Size = new Size(503, 27);
            UserName.TabIndex = 2;
            // 
            // LastName
            // 
            LastName.Location = new Point(158, 83);
            LastName.Margin = new Padding(3, 4, 3, 4);
            LastName.Name = "LastName";
            LastName.Size = new Size(503, 27);
            LastName.TabIndex = 3;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(158, 300);
            btnAddUser.Margin = new Padding(3, 4, 3, 4);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(504, 31);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "AddUser";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnAddUser);
            Controls.Add(LastName);
            Controls.Add(UserName);
            Controls.Add(Password);
            Controls.Add(FirstName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddUser";
            Text = "AddUser";
            Load += AddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstName;
        private TextBox Password;
        private TextBox UserName;
        private TextBox LastName;
        private Button btnAddUser;
    }
}