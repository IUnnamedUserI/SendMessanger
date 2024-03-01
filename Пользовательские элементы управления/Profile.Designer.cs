
namespace Send
{
    partial class Profile
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
            this.UserIcon_PictureBox = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.Name_Label = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusInfo_Label = new System.Windows.Forms.Label();
            this.AgeInfo_Label = new System.Windows.Forms.Label();
            this.GenderInfo_Label = new System.Windows.Forms.Label();
            this.CityInfo_Label = new System.Windows.Forms.Label();
            this.CountryInfo_Label = new System.Windows.Forms.Label();
            this.LastOnlineInfo_Label = new System.Windows.Forms.Label();
            this.RegDateInfo_Label = new System.Windows.Forms.Label();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Gender_Label = new System.Windows.Forms.Label();
            this.City_Label = new System.Windows.Forms.Label();
            this.Country_Label = new System.Windows.Forms.Label();
            this.LastOnline_Label = new System.Windows.Forms.Label();
            this.RegDate_Label = new System.Windows.Forms.Label();
            this.AboutUser_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon_PictureBox)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserIcon_PictureBox
            // 
            this.UserIcon_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserIcon_PictureBox.Location = new System.Drawing.Point(36, 33);
            this.UserIcon_PictureBox.Name = "UserIcon_PictureBox";
            this.UserIcon_PictureBox.Size = new System.Drawing.Size(177, 175);
            this.UserIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserIcon_PictureBox.TabIndex = 0;
            this.UserIcon_PictureBox.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.LeftPanel.Controls.Add(this.UserIcon_PictureBox);
            this.LeftPanel.Controls.Add(this.Name_Label);
            this.LeftPanel.Location = new System.Drawing.Point(27, 18);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(247, 301);
            this.LeftPanel.TabIndex = 2;
            // 
            // Name_Label
            // 
            this.Name_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Label.Location = new System.Drawing.Point(0, 220);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(247, 44);
            this.Name_Label.TabIndex = 1;
            this.Name_Label.Text = "??? ???\r\n???";
            this.Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.RightPanel.Controls.Add(this.panel1);
            this.RightPanel.Controls.Add(this.AboutUser_Label);
            this.RightPanel.Location = new System.Drawing.Point(308, 18);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(498, 301);
            this.RightPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.StatusInfo_Label);
            this.panel1.Controls.Add(this.AgeInfo_Label);
            this.panel1.Controls.Add(this.GenderInfo_Label);
            this.panel1.Controls.Add(this.CityInfo_Label);
            this.panel1.Controls.Add(this.CountryInfo_Label);
            this.panel1.Controls.Add(this.LastOnlineInfo_Label);
            this.panel1.Controls.Add(this.RegDateInfo_Label);
            this.panel1.Controls.Add(this.Status_Label);
            this.panel1.Controls.Add(this.Age_Label);
            this.panel1.Controls.Add(this.Gender_Label);
            this.panel1.Controls.Add(this.City_Label);
            this.panel1.Controls.Add(this.Country_Label);
            this.panel1.Controls.Add(this.LastOnline_Label);
            this.panel1.Controls.Add(this.RegDate_Label);
            this.panel1.Location = new System.Drawing.Point(19, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 252);
            this.panel1.TabIndex = 2;
            // 
            // StatusInfo_Label
            // 
            this.StatusInfo_Label.AutoSize = true;
            this.StatusInfo_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusInfo_Label.Location = new System.Drawing.Point(266, 219);
            this.StatusInfo_Label.Name = "StatusInfo_Label";
            this.StatusInfo_Label.Size = new System.Drawing.Size(37, 21);
            this.StatusInfo_Label.TabIndex = 1;
            this.StatusInfo_Label.Text = "???";
            this.StatusInfo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AgeInfo_Label
            // 
            this.AgeInfo_Label.AutoSize = true;
            this.AgeInfo_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeInfo_Label.Location = new System.Drawing.Point(266, 185);
            this.AgeInfo_Label.Name = "AgeInfo_Label";
            this.AgeInfo_Label.Size = new System.Drawing.Size(37, 21);
            this.AgeInfo_Label.TabIndex = 1;
            this.AgeInfo_Label.Text = "???";
            this.AgeInfo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GenderInfo_Label
            // 
            this.GenderInfo_Label.AutoSize = true;
            this.GenderInfo_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.Status_Label.Location = new System.Drawing.Point(11, 219);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(64, 21);
            this.Status_Label.TabIndex = 1;
            this.Status_Label.Text = "Статус";
            this.Status_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age_Label.Location = new System.Drawing.Point(11, 185);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(74, 21);
            this.Age_Label.TabIndex = 1;
            this.Age_Label.Text = "Возраст";
            this.Age_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gender_Label
            // 
            this.Gender_Label.AutoSize = true;
            this.Gender_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.RegDate_Label.Location = new System.Drawing.Point(11, 15);
            this.RegDate_Label.Name = "RegDate_Label";
            this.RegDate_Label.Size = new System.Drawing.Size(159, 21);
            this.RegDate_Label.TabIndex = 1;
            this.RegDate_Label.Text = "Дата регистрации";
            this.RegDate_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AboutUser_Label
            // 
            this.AboutUser_Label.AutoSize = true;
            this.AboutUser_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutUser_Label.Location = new System.Drawing.Point(15, 8);
            this.AboutUser_Label.Name = "AboutUser_Label";
            this.AboutUser_Label.Size = new System.Drawing.Size(157, 22);
            this.AboutUser_Label.TabIndex = 1;
            this.AboutUser_Label.Text = "О пользователе";
            this.AboutUser_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(830, 335);
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon_PictureBox)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox UserIcon_PictureBox;
        public System.Windows.Forms.Panel LeftPanel;
        public System.Windows.Forms.Label Name_Label;
        public System.Windows.Forms.Panel RightPanel;
        public System.Windows.Forms.Label AboutUser_Label;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label StatusInfo_Label;
        public System.Windows.Forms.Label AgeInfo_Label;
        public System.Windows.Forms.Label GenderInfo_Label;
        public System.Windows.Forms.Label CityInfo_Label;
        public System.Windows.Forms.Label CountryInfo_Label;
        public System.Windows.Forms.Label LastOnlineInfo_Label;
        public System.Windows.Forms.Label RegDateInfo_Label;
        public System.Windows.Forms.Label Status_Label;
        public System.Windows.Forms.Label Age_Label;
        public System.Windows.Forms.Label Gender_Label;
        public System.Windows.Forms.Label City_Label;
        public System.Windows.Forms.Label Country_Label;
        public System.Windows.Forms.Label LastOnline_Label;
        public System.Windows.Forms.Label RegDate_Label;
    }
}
