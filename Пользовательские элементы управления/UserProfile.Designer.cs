namespace Send.Пользовательские_элементы_управления
{
    partial class UserProfile
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.AboutUser_Label = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.Vote_Button = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Name_Label = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.UserIcon_PictureBox = new System.Windows.Forms.PictureBox();
            this.WarningPanel = new System.Windows.Forms.Panel();
            this.WarningText_Label = new System.Windows.Forms.Label();
            this.BannedIcon_PictureBox = new System.Windows.Forms.PictureBox();
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.StatusInfo_Label = new System.Windows.Forms.Label();
            this.BirthDateInfo_Label = new System.Windows.Forms.Label();
            this.GenderInfo_Label = new System.Windows.Forms.Label();
            this.CityInfo_Label = new System.Windows.Forms.Label();
            this.CountryInfo_Label = new System.Windows.Forms.Label();
            this.LastOnlineInfo_Label = new System.Windows.Forms.Label();
            this.RegDateInfo_Label = new System.Windows.Forms.Label();
            this.Status_Label = new System.Windows.Forms.Label();
            this.BirthDate_Label = new System.Windows.Forms.Label();
            this.Gender_Label = new System.Windows.Forms.Label();
            this.City_Label = new System.Windows.Forms.Label();
            this.Country_Label = new System.Windows.Forms.Label();
            this.LastOnline_Label = new System.Windows.Forms.Label();
            this.RegDate_Label = new System.Windows.Forms.Label();
            this.RightPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon_PictureBox)).BeginInit();
            this.WarningPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannedIcon_PictureBox)).BeginInit();
            this.UserInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutUser_Label
            // 
            this.AboutUser_Label.AutoSize = true;
            this.AboutUser_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutUser_Label.ForeColor = System.Drawing.Color.White;
            this.AboutUser_Label.Location = new System.Drawing.Point(15, 8);
            this.AboutUser_Label.Name = "AboutUser_Label";
            this.AboutUser_Label.Size = new System.Drawing.Size(157, 22);
            this.AboutUser_Label.TabIndex = 1;
            this.AboutUser_Label.Text = "О пользователе";
            this.AboutUser_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.RightPanel.Controls.Add(this.UserInfoPanel);
            this.RightPanel.Controls.Add(this.WarningPanel);
            this.RightPanel.Controls.Add(this.Vote_Button);
            this.RightPanel.Controls.Add(this.CloseButton);
            this.RightPanel.Controls.Add(this.AboutUser_Label);
            this.RightPanel.Location = new System.Drawing.Point(307, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(498, 301);
            this.RightPanel.TabIndex = 5;
            // 
            // Vote_Button
            // 
            this.Vote_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Vote_Button.FlatAppearance.BorderSize = 0;
            this.Vote_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vote_Button.Image = ((System.Drawing.Image)(resources.GetObject("Vote_Button.Image")));
            this.Vote_Button.Location = new System.Drawing.Point(416, 4);
            this.Vote_Button.Name = "Vote_Button";
            this.Vote_Button.Size = new System.Drawing.Size(26, 26);
            this.Vote_Button.TabIndex = 6;
            this.Vote_Button.UseVisualStyleBackColor = false;
            this.Vote_Button.Click += new System.EventHandler(this.Vote_Button_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(453, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 26);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Name_Label
            // 
            this.Name_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Label.ForeColor = System.Drawing.Color.White;
            this.Name_Label.Location = new System.Drawing.Point(0, 220);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(247, 44);
            this.Name_Label.TabIndex = 1;
            this.Name_Label.Text = "??? ???\r\n???";
            this.Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.LeftPanel.Controls.Add(this.UserIcon_PictureBox);
            this.LeftPanel.Controls.Add(this.Name_Label);
            this.LeftPanel.Location = new System.Drawing.Point(26, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(247, 301);
            this.LeftPanel.TabIndex = 4;
            // 
            // UserIcon_PictureBox
            // 
            this.UserIcon_PictureBox.Location = new System.Drawing.Point(36, 33);
            this.UserIcon_PictureBox.Name = "UserIcon_PictureBox";
            this.UserIcon_PictureBox.Size = new System.Drawing.Size(177, 175);
            this.UserIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserIcon_PictureBox.TabIndex = 0;
            this.UserIcon_PictureBox.TabStop = false;
            // 
            // WarningPanel
            // 
            this.WarningPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.WarningPanel.Controls.Add(this.BannedIcon_PictureBox);
            this.WarningPanel.Controls.Add(this.WarningText_Label);
            this.WarningPanel.Location = new System.Drawing.Point(25, 36);
            this.WarningPanel.Name = "WarningPanel";
            this.WarningPanel.Size = new System.Drawing.Size(454, 245);
            this.WarningPanel.TabIndex = 2;
            this.WarningPanel.Visible = false;
            // 
            // WarningText_Label
            // 
            this.WarningText_Label.AutoSize = true;
            this.WarningText_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarningText_Label.ForeColor = System.Drawing.Color.White;
            this.WarningText_Label.Location = new System.Drawing.Point(71, 32);
            this.WarningText_Label.Name = "WarningText_Label";
            this.WarningText_Label.Size = new System.Drawing.Size(337, 21);
            this.WarningText_Label.TabIndex = 0;
            this.WarningText_Label.Text = "Данный пользователь был заблокирован";
            // 
            // BannedIcon_PictureBox
            // 
            this.BannedIcon_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BannedIcon_PictureBox.Image")));
            this.BannedIcon_PictureBox.Location = new System.Drawing.Point(159, 62);
            this.BannedIcon_PictureBox.Name = "BannedIcon_PictureBox";
            this.BannedIcon_PictureBox.Size = new System.Drawing.Size(150, 150);
            this.BannedIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BannedIcon_PictureBox.TabIndex = 1;
            this.BannedIcon_PictureBox.TabStop = false;
            // 
            // UserInfoPanel
            // 
            this.UserInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.UserInfoPanel.Controls.Add(this.StatusInfo_Label);
            this.UserInfoPanel.Controls.Add(this.BirthDateInfo_Label);
            this.UserInfoPanel.Controls.Add(this.GenderInfo_Label);
            this.UserInfoPanel.Controls.Add(this.CityInfo_Label);
            this.UserInfoPanel.Controls.Add(this.CountryInfo_Label);
            this.UserInfoPanel.Controls.Add(this.LastOnlineInfo_Label);
            this.UserInfoPanel.Controls.Add(this.RegDateInfo_Label);
            this.UserInfoPanel.Controls.Add(this.Status_Label);
            this.UserInfoPanel.Controls.Add(this.BirthDate_Label);
            this.UserInfoPanel.Controls.Add(this.Gender_Label);
            this.UserInfoPanel.Controls.Add(this.City_Label);
            this.UserInfoPanel.Controls.Add(this.Country_Label);
            this.UserInfoPanel.Controls.Add(this.LastOnline_Label);
            this.UserInfoPanel.Controls.Add(this.RegDate_Label);
            this.UserInfoPanel.Location = new System.Drawing.Point(19, 36);
            this.UserInfoPanel.Name = "UserInfoPanel";
            this.UserInfoPanel.Size = new System.Drawing.Size(460, 252);
            this.UserInfoPanel.TabIndex = 7;
            // 
            // StatusInfo_Label
            // 
            this.StatusInfo_Label.AutoSize = true;
            this.StatusInfo_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusInfo_Label.ForeColor = System.Drawing.Color.White;
            this.StatusInfo_Label.Location = new System.Drawing.Point(266, 219);
            this.StatusInfo_Label.Name = "StatusInfo_Label";
            this.StatusInfo_Label.Size = new System.Drawing.Size(37, 21);
            this.StatusInfo_Label.TabIndex = 1;
            this.StatusInfo_Label.Text = "???";
            this.StatusInfo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BirthDateInfo_Label
            // 
            this.BirthDateInfo_Label.AutoSize = true;
            this.BirthDateInfo_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDateInfo_Label.ForeColor = System.Drawing.Color.White;
            this.BirthDateInfo_Label.Location = new System.Drawing.Point(266, 185);
            this.BirthDateInfo_Label.Name = "BirthDateInfo_Label";
            this.BirthDateInfo_Label.Size = new System.Drawing.Size(37, 21);
            this.BirthDateInfo_Label.TabIndex = 1;
            this.BirthDateInfo_Label.Text = "???";
            this.BirthDateInfo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GenderInfo_Label
            // 
            this.GenderInfo_Label.AutoSize = true;
            this.GenderInfo_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderInfo_Label.ForeColor = System.Drawing.Color.White;
            this.GenderInfo_Label.Location = new System.Drawing.Point(266, 151);
            this.GenderInfo_Label.Name = "GenderInfo_Label";
            this.GenderInfo_Label.Size = new System.Drawing.Size(37, 21);
            this.GenderInfo_Label.TabIndex = 1;
            this.GenderInfo_Label.Text = "???";
            this.GenderInfo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CityInfo_Label
            // 
            this.CityInfo_Label.AutoSize = true;
            this.CityInfo_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityInfo_Label.ForeColor = System.Drawing.Color.White;
            this.CityInfo_Label.Location = new System.Drawing.Point(266, 117);
            this.CityInfo_Label.Name = "CityInfo_Label";
            this.CityInfo_Label.Size = new System.Drawing.Size(37, 21);
            this.CityInfo_Label.TabIndex = 1;
            this.CityInfo_Label.Text = "???";
            this.CityInfo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CountryInfo_Label
            // 
            this.CountryInfo_Label.AutoSize = true;
            this.CountryInfo_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryInfo_Label.ForeColor = System.Drawing.Color.White;
            this.CountryInfo_Label.Location = new System.Drawing.Point(266, 83);
            this.CountryInfo_Label.Name = "CountryInfo_Label";
            this.CountryInfo_Label.Size = new System.Drawing.Size(37, 21);
            this.CountryInfo_Label.TabIndex = 1;
            this.CountryInfo_Label.Text = "???";
            this.CountryInfo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastOnlineInfo_Label
            // 
            this.LastOnlineInfo_Label.AutoSize = true;
            this.LastOnlineInfo_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastOnlineInfo_Label.ForeColor = System.Drawing.Color.White;
            this.LastOnlineInfo_Label.Location = new System.Drawing.Point(266, 49);
            this.LastOnlineInfo_Label.Name = "LastOnlineInfo_Label";
            this.LastOnlineInfo_Label.Size = new System.Drawing.Size(79, 21);
            this.LastOnlineInfo_Label.TabIndex = 1;
            this.LastOnlineInfo_Label.Text = "??? / ???";
            this.LastOnlineInfo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegDateInfo_Label
            // 
            this.RegDateInfo_Label.AutoSize = true;
            this.RegDateInfo_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegDateInfo_Label.ForeColor = System.Drawing.Color.White;
            this.RegDateInfo_Label.Location = new System.Drawing.Point(266, 15);
            this.RegDateInfo_Label.Name = "RegDateInfo_Label";
            this.RegDateInfo_Label.Size = new System.Drawing.Size(37, 21);
            this.RegDateInfo_Label.TabIndex = 1;
            this.RegDateInfo_Label.Text = "???";
            this.RegDateInfo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status_Label.ForeColor = System.Drawing.Color.White;
            this.Status_Label.Location = new System.Drawing.Point(11, 219);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(64, 21);
            this.Status_Label.TabIndex = 1;
            this.Status_Label.Text = "Статус";
            this.Status_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BirthDate_Label
            // 
            this.BirthDate_Label.AutoSize = true;
            this.BirthDate_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDate_Label.ForeColor = System.Drawing.Color.White;
            this.BirthDate_Label.Location = new System.Drawing.Point(11, 185);
            this.BirthDate_Label.Name = "BirthDate_Label";
            this.BirthDate_Label.Size = new System.Drawing.Size(74, 21);
            this.BirthDate_Label.TabIndex = 1;
            this.BirthDate_Label.Text = "Возраст";
            this.BirthDate_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gender_Label
            // 
            this.Gender_Label.AutoSize = true;
            this.Gender_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender_Label.ForeColor = System.Drawing.Color.White;
            this.Gender_Label.Location = new System.Drawing.Point(11, 151);
            this.Gender_Label.Name = "Gender_Label";
            this.Gender_Label.Size = new System.Drawing.Size(40, 21);
            this.Gender_Label.TabIndex = 1;
            this.Gender_Label.Text = "Пол";
            this.Gender_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // City_Label
            // 
            this.City_Label.AutoSize = true;
            this.City_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.City_Label.ForeColor = System.Drawing.Color.White;
            this.City_Label.Location = new System.Drawing.Point(11, 117);
            this.City_Label.Name = "City_Label";
            this.City_Label.Size = new System.Drawing.Size(57, 21);
            this.City_Label.TabIndex = 1;
            this.City_Label.Text = "Город";
            this.City_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Country_Label
            // 
            this.Country_Label.AutoSize = true;
            this.Country_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Country_Label.ForeColor = System.Drawing.Color.White;
            this.Country_Label.Location = new System.Drawing.Point(11, 83);
            this.Country_Label.Name = "Country_Label";
            this.Country_Label.Size = new System.Drawing.Size(72, 21);
            this.Country_Label.TabIndex = 1;
            this.Country_Label.Text = "Страна";
            this.Country_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastOnline_Label
            // 
            this.LastOnline_Label.AutoSize = true;
            this.LastOnline_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastOnline_Label.ForeColor = System.Drawing.Color.White;
            this.LastOnline_Label.Location = new System.Drawing.Point(11, 49);
            this.LastOnline_Label.Name = "LastOnline_Label";
            this.LastOnline_Label.Size = new System.Drawing.Size(183, 21);
            this.LastOnline_Label.TabIndex = 1;
            this.LastOnline_Label.Text = "Последняя активность";
            this.LastOnline_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegDate_Label
            // 
            this.RegDate_Label.AutoSize = true;
            this.RegDate_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegDate_Label.ForeColor = System.Drawing.Color.White;
            this.RegDate_Label.Location = new System.Drawing.Point(11, 15);
            this.RegDate_Label.Name = "RegDate_Label";
            this.RegDate_Label.Size = new System.Drawing.Size(159, 21);
            this.RegDate_Label.TabIndex = 1;
            this.RegDate_Label.Text = "Дата регистрации";
            this.RegDate_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "UserProfile";
            this.Size = new System.Drawing.Size(830, 301);
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon_PictureBox)).EndInit();
            this.WarningPanel.ResumeLayout(false);
            this.WarningPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannedIcon_PictureBox)).EndInit();
            this.UserInfoPanel.ResumeLayout(false);
            this.UserInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label AboutUser_Label;
        public System.Windows.Forms.Panel RightPanel;
        public System.Windows.Forms.Label Name_Label;
        public System.Windows.Forms.Panel LeftPanel;
        public System.Windows.Forms.PictureBox UserIcon_PictureBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button Vote_Button;
        private System.Windows.Forms.Panel WarningPanel;
        private System.Windows.Forms.PictureBox BannedIcon_PictureBox;
        private System.Windows.Forms.Label WarningText_Label;
        public System.Windows.Forms.Panel UserInfoPanel;
        public System.Windows.Forms.Label StatusInfo_Label;
        public System.Windows.Forms.Label BirthDateInfo_Label;
        public System.Windows.Forms.Label GenderInfo_Label;
        public System.Windows.Forms.Label CityInfo_Label;
        public System.Windows.Forms.Label CountryInfo_Label;
        public System.Windows.Forms.Label LastOnlineInfo_Label;
        public System.Windows.Forms.Label RegDateInfo_Label;
        public System.Windows.Forms.Label Status_Label;
        public System.Windows.Forms.Label BirthDate_Label;
        public System.Windows.Forms.Label Gender_Label;
        public System.Windows.Forms.Label City_Label;
        public System.Windows.Forms.Label Country_Label;
        public System.Windows.Forms.Label LastOnline_Label;
        public System.Windows.Forms.Label RegDate_Label;
    }
}
