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
            FirstName.Location = new Point(138, 12);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(441, 23);
            FirstName.TabIndex = 0;
            // 
            // Password
            // 
            Password.Location = new Point(138, 155);
            Password.Name = "Password";
            Password.Size = new Size(441, 23);
            Password.TabIndex = 1;
            // 
            // UserName
            // 
            UserName.Location = new Point(138, 111);
            UserName.Name = "UserName";
            UserName.Size = new Size(441, 23);
            UserName.TabIndex = 2;
            // 
            // LastName
            // 
            LastName.Location = new Point(138, 62);
            LastName.Name = "LastName";
            LastName.Size = new Size(441, 23);
            LastName.TabIndex = 3;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(138, 225);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(441, 23);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "AddUser";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddUser);
            Controls.Add(LastName);
            Controls.Add(UserName);
            Controls.Add(Password);
            Controls.Add(FirstName);
            Name = "AddUser";
            Text = "AddUser";
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