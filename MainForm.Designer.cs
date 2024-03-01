namespace Send
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ChangeLog_Button = new System.Windows.Forms.Button();
            this.Moderator_Button = new System.Windows.Forms.Button();
            this.Collapse_Button = new System.Windows.Forms.Button();
            this.LogOut_Button = new System.Windows.Forms.Button();
            this.NameUser_Label = new System.Windows.Forms.Label();
            this.UserIcon_PictureBox = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ActualPanel = new System.Windows.Forms.Panel();
            this.FriendsSubpanel = new System.Windows.Forms.Panel();
            this.SendQuery_Button = new System.Windows.Forms.Button();
            this.Friends_Button = new System.Windows.Forms.Button();
            this.Messages_Button = new System.Windows.Forms.Button();
            this.ProfileSubpanel = new System.Windows.Forms.Panel();
            this.EditProfile_Button = new System.Windows.Forms.Button();
            this.Profile_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Home_Button = new System.Windows.Forms.Button();
            this.Menu_Button = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HiddenApplication = new System.Windows.Forms.NotifyIcon(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon_PictureBox)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.FriendsSubpanel.SuspendLayout();
            this.ProfileSubpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.TopPanel.Controls.Add(this.ChangeLog_Button);
            this.TopPanel.Controls.Add(this.Moderator_Button);
            this.TopPanel.Controls.Add(this.Collapse_Button);
            this.TopPanel.Controls.Add(this.LogOut_Button);
            this.TopPanel.Controls.Add(this.NameUser_Label);
            this.TopPanel.Controls.Add(this.UserIcon_PictureBox);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1072, 96);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // ChangeLog_Button
            // 
            this.ChangeLog_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeLog_Button.FlatAppearance.BorderSize = 0;
            this.ChangeLog_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeLog_Button.Image = ((System.Drawing.Image)(resources.GetObject("ChangeLog_Button.Image")));
            this.ChangeLog_Button.Location = new System.Drawing.Point(898, 22);
            this.ChangeLog_Button.Name = "ChangeLog_Button";
            this.ChangeLog_Button.Size = new System.Drawing.Size(50, 50);
            this.ChangeLog_Button.TabIndex = 3;
            this.ChangeLog_Button.UseVisualStyleBackColor = true;
            this.ChangeLog_Button.Click += new System.EventHandler(this.ChangeLog_Button_Click);
            // 
            // Moderator_Button
            // 
            this.Moderator_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Moderator_Button.FlatAppearance.BorderSize = 0;
            this.Moderator_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Moderator_Button.Image = ((System.Drawing.Image)(resources.GetObject("Moderator_Button.Image")));
            this.Moderator_Button.Location = new System.Drawing.Point(842, 22);
            this.Moderator_Button.Name = "Moderator_Button";
            this.Moderator_Button.Size = new System.Drawing.Size(50, 50);
            this.Moderator_Button.TabIndex = 3;
            this.Moderator_Button.UseVisualStyleBackColor = true;
            this.Moderator_Button.Visible = false;
            this.Moderator_Button.Click += new System.EventHandler(this.Moderator_Button_Click);
            // 
            // Collapse_Button
            // 
            this.Collapse_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Collapse_Button.FlatAppearance.BorderSize = 0;
            this.Collapse_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Collapse_Button.ForeColor = System.Drawing.Color.White;
            this.Collapse_Button.Image = ((System.Drawing.Image)(resources.GetObject("Collapse_Button.Image")));
            this.Collapse_Button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Collapse_Button.Location = new System.Drawing.Point(954, 22);
            this.Collapse_Button.Name = "Collapse_Button";
            this.Collapse_Button.Size = new System.Drawing.Size(50, 50);
            this.Collapse_Button.TabIndex = 2;
            this.Collapse_Button.UseVisualStyleBackColor = true;
            this.Collapse_Button.Click += new System.EventHandler(this.Collapse_Button_Click);
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOut_Button.FlatAppearance.BorderSize = 0;
            this.LogOut_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut_Button.ForeColor = System.Drawing.Color.White;
            this.LogOut_Button.Image = ((System.Drawing.Image)(resources.GetObject("LogOut_Button.Image")));
            this.LogOut_Button.Location = new System.Drawing.Point(1010, 22);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.Size = new System.Drawing.Size(50, 50);
            this.LogOut_Button.TabIndex = 2;
            this.LogOut_Button.UseVisualStyleBackColor = true;
            this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click);
            // 
            // NameUser_Label
            // 
            this.NameUser_Label.AutoSize = true;
            this.NameUser_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameUser_Label.ForeColor = System.Drawing.Color.White;
            this.NameUser_Label.Location = new System.Drawing.Point(91, 33);
            this.NameUser_Label.Name = "NameUser_Label";
            this.NameUser_Label.Size = new System.Drawing.Size(233, 22);
            this.NameUser_Label.TabIndex = 1;
            this.NameUser_Label.Text = "Фамилия Имя Отчество";
            // 
            // UserIcon_PictureBox
            // 
            this.UserIcon_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserIcon_PictureBox.Image")));
            this.UserIcon_PictureBox.Location = new System.Drawing.Point(15, 10);
            this.UserIcon_PictureBox.Name = "UserIcon_PictureBox";
            this.UserIcon_PictureBox.Size = new System.Drawing.Size(70, 70);
            this.UserIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserIcon_PictureBox.TabIndex = 0;
            this.UserIcon_PictureBox.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.LeftPanel.Controls.Add(this.ActualPanel);
            this.LeftPanel.Controls.Add(this.FriendsSubpanel);
            this.LeftPanel.Controls.Add(this.Friends_Button);
            this.LeftPanel.Controls.Add(this.Messages_Button);
            this.LeftPanel.Controls.Add(this.ProfileSubpanel);
            this.LeftPanel.Controls.Add(this.Profile_Button);
            this.LeftPanel.Controls.Add(this.Exit_Button);
            this.LeftPanel.Controls.Add(this.Home_Button);
            this.LeftPanel.Controls.Add(this.Menu_Button);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 96);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(242, 403);
            this.LeftPanel.TabIndex = 2;
            // 
            // ActualPanel
            // 
            this.ActualPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.ActualPanel.Location = new System.Drawing.Point(0, 50);
            this.ActualPanel.Name = "ActualPanel";
            this.ActualPanel.Size = new System.Drawing.Size(9, 50);
            this.ActualPanel.TabIndex = 4;
            // 
            // FriendsSubpanel
            // 
            this.FriendsSubpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(7)))), ((int)(((byte)(23)))));
            this.FriendsSubpanel.Controls.Add(this.SendQuery_Button);
            this.FriendsSubpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FriendsSubpanel.Location = new System.Drawing.Point(0, 300);
            this.FriendsSubpanel.Name = "FriendsSubpanel";
            this.FriendsSubpanel.Size = new System.Drawing.Size(242, 50);
            this.FriendsSubpanel.TabIndex = 6;
            this.FriendsSubpanel.Visible = false;
            // 
            // SendQuery_Button
            // 
            this.SendQuery_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendQuery_Button.FlatAppearance.BorderSize = 0;
            this.SendQuery_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendQuery_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendQuery_Button.ForeColor = System.Drawing.Color.White;
            this.SendQuery_Button.Image = ((System.Drawing.Image)(resources.GetObject("SendQuery_Button.Image")));
            this.SendQuery_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SendQuery_Button.Location = new System.Drawing.Point(0, 0);
            this.SendQuery_Button.Name = "SendQuery_Button";
            this.SendQuery_Button.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.SendQuery_Button.Size = new System.Drawing.Size(242, 50);
            this.SendQuery_Button.TabIndex = 0;
            this.SendQuery_Button.Text = "          Отправить заявку";
            this.SendQuery_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SendQuery_Button.UseVisualStyleBackColor = true;
            this.SendQuery_Button.Click += new System.EventHandler(this.SendQuery_Button_Click);
            // 
            // Friends_Button
            // 
            this.Friends_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Friends_Button.FlatAppearance.BorderSize = 0;
            this.Friends_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Friends_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Friends_Button.ForeColor = System.Drawing.Color.White;
            this.Friends_Button.Image = ((System.Drawing.Image)(resources.GetObject("Friends_Button.Image")));
            this.Friends_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Friends_Button.Location = new System.Drawing.Point(0, 250);
            this.Friends_Button.Name = "Friends_Button";
            this.Friends_Button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Friends_Button.Size = new System.Drawing.Size(242, 50);
            this.Friends_Button.TabIndex = 3;
            this.Friends_Button.Text = "          Друзья";
            this.Friends_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Friends_Button.UseVisualStyleBackColor = true;
            this.Friends_Button.Click += new System.EventHandler(this.Friends_Button_Click);
            // 
            // Messages_Button
            // 
            this.Messages_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Messages_Button.FlatAppearance.BorderSize = 0;
            this.Messages_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Messages_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Messages_Button.ForeColor = System.Drawing.Color.White;
            this.Messages_Button.Image = ((System.Drawing.Image)(resources.GetObject("Messages_Button.Image")));
            this.Messages_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Messages_Button.Location = new System.Drawing.Point(0, 200);
            this.Messages_Button.Name = "Messages_Button";
            this.Messages_Button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Messages_Button.Size = new System.Drawing.Size(242, 50);
            this.Messages_Button.TabIndex = 3;
            this.Messages_Button.Text = "          Сообщения";
            this.Messages_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Messages_Button.UseVisualStyleBackColor = true;
            this.Messages_Button.Click += new System.EventHandler(this.Message_Button_Click);
            // 
            // ProfileSubpanel
            // 
            this.ProfileSubpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(7)))), ((int)(((byte)(23)))));
            this.ProfileSubpanel.Controls.Add(this.EditProfile_Button);
            this.ProfileSubpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileSubpanel.Location = new System.Drawing.Point(0, 150);
            this.ProfileSubpanel.Name = "ProfileSubpanel";
            this.ProfileSubpanel.Size = new System.Drawing.Size(242, 50);
            this.ProfileSubpanel.TabIndex = 5;
            this.ProfileSubpanel.Visible = false;
            // 
            // EditProfile_Button
            // 
            this.EditProfile_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditProfile_Button.FlatAppearance.BorderSize = 0;
            this.EditProfile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProfile_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditProfile_Button.ForeColor = System.Drawing.Color.White;
            this.EditProfile_Button.Image = ((System.Drawing.Image)(resources.GetObject("EditProfile_Button.Image")));
            this.EditProfile_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditProfile_Button.Location = new System.Drawing.Point(0, 0);
            this.EditProfile_Button.Name = "EditProfile_Button";
            this.EditProfile_Button.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.EditProfile_Button.Size = new System.Drawing.Size(242, 50);
            this.EditProfile_Button.TabIndex = 0;
            this.EditProfile_Button.Text = "          Редактировать";
            this.EditProfile_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditProfile_Button.UseVisualStyleBackColor = true;
            this.EditProfile_Button.Click += new System.EventHandler(this.EditProfile_Button_Click);
            // 
            // Profile_Button
            // 
            this.Profile_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profile_Button.FlatAppearance.BorderSize = 0;
            this.Profile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Profile_Button.ForeColor = System.Drawing.Color.White;
            this.Profile_Button.Image = ((System.Drawing.Image)(resources.GetObject("Profile_Button.Image")));
            this.Profile_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile_Button.Location = new System.Drawing.Point(0, 100);
            this.Profile_Button.Name = "Profile_Button";
            this.Profile_Button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Profile_Button.Size = new System.Drawing.Size(242, 50);
            this.Profile_Button.TabIndex = 1;
            this.Profile_Button.Text = "          Профиль";
            this.Profile_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile_Button.UseVisualStyleBackColor = true;
            this.Profile_Button.Click += new System.EventHandler(this.Profile_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Button.Image")));
            this.Exit_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_Button.Location = new System.Drawing.Point(0, 353);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Exit_Button.Size = new System.Drawing.Size(242, 50);
            this.Exit_Button.TabIndex = 3;
            this.Exit_Button.Text = "          Выйти";
            this.Exit_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Home_Button
            // 
            this.Home_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_Button.FlatAppearance.BorderSize = 0;
            this.Home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Home_Button.ForeColor = System.Drawing.Color.White;
            this.Home_Button.Image = ((System.Drawing.Image)(resources.GetObject("Home_Button.Image")));
            this.Home_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_Button.Location = new System.Drawing.Point(0, 50);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Home_Button.Size = new System.Drawing.Size(242, 50);
            this.Home_Button.TabIndex = 2;
            this.Home_Button.Text = "          Главная";
            this.Home_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_Button.UseVisualStyleBackColor = true;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // Menu_Button
            // 
            this.Menu_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu_Button.FlatAppearance.BorderSize = 0;
            this.Menu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Button.ForeColor = System.Drawing.Color.White;
            this.Menu_Button.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Button.Image")));
            this.Menu_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu_Button.Location = new System.Drawing.Point(0, 0);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Menu_Button.Size = new System.Drawing.Size(242, 50);
            this.Menu_Button.TabIndex = 7;
            this.Menu_Button.Text = "          Скрыть меню";
            this.Menu_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu_Button.UseVisualStyleBackColor = true;
            this.Menu_Button.Click += new System.EventHandler(this.Menu_Button_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(242, 96);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(830, 403);
            this.MainPanel.TabIndex = 3;
            // 
            // HiddenApplication
            // 
            this.HiddenApplication.Icon = ((System.Drawing.Icon)(resources.GetObject("HiddenApplication.Icon")));
            this.HiddenApplication.Text = "Send";
            this.HiddenApplication.Visible = true;
            this.HiddenApplication.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HiddenApplication_MouseClick);
            this.HiddenApplication.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HiddenApplication_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1072, 499);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Gill Sans MT", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1072, 499);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Messages_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon_PictureBox)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.FriendsSubpanel.ResumeLayout(false);
            this.ProfileSubpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox UserIcon_PictureBox;
        private System.Windows.Forms.Button LogOut_Button;
        private System.Windows.Forms.Label NameUser_Label;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button Profile_Button;
        private System.Windows.Forms.Panel ActualPanel;
        private System.Windows.Forms.Button Moderator_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Home_Button;
        private System.Windows.Forms.Panel MainPanel;
        public Message Messages_Panel;
        private System.Windows.Forms.Button Friends_Button;
        public Friends Friends_Panel;
        private System.Windows.Forms.Panel ProfileSubpanel;
        private System.Windows.Forms.Button EditProfile_Button;
        private System.Windows.Forms.Panel FriendsSubpanel;
        private System.Windows.Forms.Button SendQuery_Button;
        private System.Windows.Forms.Button Menu_Button;
        public Пользовательские_элементы_управления.UserProfile UserProfile_Panel;
        public System.Windows.Forms.Button Messages_Button;
        private System.Windows.Forms.Button Collapse_Button;
        private System.Windows.Forms.NotifyIcon HiddenApplication;
        private StartPanel Panel_Start;
        private Profile Panel_Profile;
        private Friends Panel_Friends;
        public Пользовательские_элементы_управления.MessagePanel Panel_Messages;
        public EditProfile Panel_EditProfile;
        private Пользовательские_элементы_управления.ModeratorScreen Panel_ModeratorScreen;
        public Пользовательские_элементы_управления.UserProfile Panel_UserProfile;
        private SendQuery Panel_SendQuery;
        private System.Windows.Forms.Button ChangeLog_Button;
    }
}