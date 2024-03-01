
namespace Send
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.AboutUser_Label = new System.Windows.Forms.Label();
            this.AboutUserPanel = new System.Windows.Forms.Panel();
            this.ShowAboutUser_Button = new System.Windows.Forms.Button();
            this.Content_Panel = new System.Windows.Forms.Panel();
            this.BirthDate_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Gender_ComboBox = new System.Windows.Forms.ComboBox();
            this.City_ComboBox = new System.Windows.Forms.ComboBox();
            this.Country_ComboBox = new System.Windows.Forms.ComboBox();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Gender_Label = new System.Windows.Forms.Label();
            this.City_Label = new System.Windows.Forms.Label();
            this.Country_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.EditName_Button = new System.Windows.Forms.Button();
            this.ChangeIcon_Panel = new System.Windows.Forms.Panel();
            this.ChangeImage_Label = new System.Windows.Forms.Label();
            this.UserIcon_PictureBox = new System.Windows.Forms.PictureBox();
            this.SaveProfile_Button = new System.Windows.Forms.Button();
            this.CancelSave_Button = new System.Windows.Forms.Button();
            this.SecurityPanel = new System.Windows.Forms.Panel();
            this.ShowSecurity_Button = new System.Windows.Forms.Button();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.ChangePassword_Button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RepeatPassword_Label = new System.Windows.Forms.Label();
            this.FirstPassword_Label = new System.Windows.Forms.Label();
            this.RepeatPassword_TextBox = new System.Windows.Forms.TextBox();
            this.FirstPassword_TextBox = new System.Windows.Forms.TextBox();
            this.Security_Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AboutUserPanel.SuspendLayout();
            this.Content_Panel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.ChangeIcon_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon_PictureBox)).BeginInit();
            this.SecurityPanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutUser_Label
            // 
            this.AboutUser_Label.AutoSize = true;
            this.AboutUser_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutUser_Label.Location = new System.Drawing.Point(63, 8);
            this.AboutUser_Label.Name = "AboutUser_Label";
            this.AboutUser_Label.Size = new System.Drawing.Size(157, 22);
            this.AboutUser_Label.TabIndex = 1;
            this.AboutUser_Label.Text = "О пользователе";
            this.AboutUser_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AboutUserPanel
            // 
            this.AboutUserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.AboutUserPanel.Controls.Add(this.ShowAboutUser_Button);
            this.AboutUserPanel.Controls.Add(this.Content_Panel);
            this.AboutUserPanel.Controls.Add(this.AboutUser_Label);
            this.AboutUserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutUserPanel.ForeColor = System.Drawing.Color.White;
            this.AboutUserPanel.Location = new System.Drawing.Point(0, 0);
            this.AboutUserPanel.Name = "AboutUserPanel";
            this.AboutUserPanel.Size = new System.Drawing.Size(532, 33);
            this.AboutUserPanel.TabIndex = 5;
            // 
            // ShowAboutUser_Button
            // 
            this.ShowAboutUser_Button.FlatAppearance.BorderSize = 0;
            this.ShowAboutUser_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAboutUser_Button.Image = ((System.Drawing.Image)(resources.GetObject("ShowAboutUser_Button.Image")));
            this.ShowAboutUser_Button.Location = new System.Drawing.Point(19, 0);
            this.ShowAboutUser_Button.Name = "ShowAboutUser_Button";
            this.ShowAboutUser_Button.Size = new System.Drawing.Size(32, 32);
            this.ShowAboutUser_Button.TabIndex = 3;
            this.ShowAboutUser_Button.UseVisualStyleBackColor = true;
            this.ShowAboutUser_Button.Click += new System.EventHandler(this.ShowAboutUser_Button_Click);
            // 
            // Content_Panel
            // 
            this.Content_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.Content_Panel.Controls.Add(this.BirthDate_DateTimePicker);
            this.Content_Panel.Controls.Add(this.Gender_ComboBox);
            this.Content_Panel.Controls.Add(this.City_ComboBox);
            this.Content_Panel.Controls.Add(this.Country_ComboBox);
            this.Content_Panel.Controls.Add(this.Age_Label);
            this.Content_Panel.Controls.Add(this.Gender_Label);
            this.Content_Panel.Controls.Add(this.City_Label);
            this.Content_Panel.Controls.Add(this.Country_Label);
            this.Content_Panel.Location = new System.Drawing.Point(19, 33);
            this.Content_Panel.Name = "Content_Panel";
            this.Content_Panel.Size = new System.Drawing.Size(460, 161);
            this.Content_Panel.TabIndex = 2;
            // 
            // BirthDate_DateTimePicker
            // 
            this.BirthDate_DateTimePicker.CalendarForeColor = System.Drawing.Color.White;
            this.BirthDate_DateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.BirthDate_DateTimePicker.CalendarTitleForeColor = System.Drawing.Color.White;
            this.BirthDate_DateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDate_DateTimePicker.Location = new System.Drawing.Point(206, 120);
            this.BirthDate_DateTimePicker.Name = "BirthDate_DateTimePicker";
            this.BirthDate_DateTimePicker.Size = new System.Drawing.Size(240, 27);
            this.BirthDate_DateTimePicker.TabIndex = 3;
            this.BirthDate_DateTimePicker.Value = new System.DateTime(2021, 3, 8, 0, 0, 0, 0);
            // 
            // Gender_ComboBox
            // 
            this.Gender_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.Gender_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender_ComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender_ComboBox.ForeColor = System.Drawing.Color.White;
            this.Gender_ComboBox.FormatString = "White";
            this.Gender_ComboBox.FormattingEnabled = true;
            this.Gender_ComboBox.Location = new System.Drawing.Point(206, 88);
            this.Gender_ComboBox.Name = "Gender_ComboBox";
            this.Gender_ComboBox.Size = new System.Drawing.Size(240, 29);
            this.Gender_ComboBox.TabIndex = 2;
            // 
            // City_ComboBox
            // 
            this.City_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.City_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.City_ComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.City_ComboBox.ForeColor = System.Drawing.Color.White;
            this.City_ComboBox.FormatString = "White";
            this.City_ComboBox.FormattingEnabled = true;
            this.City_ComboBox.Location = new System.Drawing.Point(206, 54);
            this.City_ComboBox.Name = "City_ComboBox";
            this.City_ComboBox.Size = new System.Drawing.Size(240, 29);
            this.City_ComboBox.TabIndex = 2;
            // 
            // Country_ComboBox
            // 
            this.Country_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.Country_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Country_ComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Country_ComboBox.ForeColor = System.Drawing.Color.White;
            this.Country_ComboBox.FormatString = "White";
            this.Country_ComboBox.FormattingEnabled = true;
            this.Country_ComboBox.Location = new System.Drawing.Point(206, 20);
            this.Country_ComboBox.Name = "Country_ComboBox";
            this.Country_ComboBox.Size = new System.Drawing.Size(240, 29);
            this.Country_ComboBox.TabIndex = 2;
            this.Country_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Country_ComboBox_SelectedIndexChanged);
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age_Label.Location = new System.Drawing.Point(11, 125);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(132, 21);
            this.Age_Label.TabIndex = 1;
            this.Age_Label.Text = "Дата рождения";
            this.Age_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gender_Label
            // 
            this.Gender_Label.AutoSize = true;
            this.Gender_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender_Label.Location = new System.Drawing.Point(11, 91);
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
            this.City_Label.Location = new System.Drawing.Point(11, 57);
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
            this.Country_Label.Location = new System.Drawing.Point(11, 23);
            this.Country_Label.Name = "Country_Label";
            this.Country_Label.Size = new System.Drawing.Size(72, 21);
            this.Country_Label.TabIndex = 1;
            this.Country_Label.Text = "Страна";
            this.Country_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // LeftPanel
            // 
            this.LeftPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.LeftPanel.Controls.Add(this.EditName_Button);
            this.LeftPanel.Controls.Add(this.ChangeIcon_Panel);
            this.LeftPanel.Controls.Add(this.UserIcon_PictureBox);
            this.LeftPanel.Controls.Add(this.Name_Label);
            this.LeftPanel.ForeColor = System.Drawing.Color.White;
            this.LeftPanel.Location = new System.Drawing.Point(27, 18);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(247, 301);
            this.LeftPanel.TabIndex = 4;
            // 
            // EditName_Button
            // 
            this.EditName_Button.FlatAppearance.BorderSize = 0;
            this.EditName_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditName_Button.Image = ((System.Drawing.Image)(resources.GetObject("EditName_Button.Image")));
            this.EditName_Button.Location = new System.Drawing.Point(105, 266);
            this.EditName_Button.Name = "EditName_Button";
            this.EditName_Button.Size = new System.Drawing.Size(32, 32);
            this.EditName_Button.TabIndex = 3;
            this.EditName_Button.UseVisualStyleBackColor = true;
            this.EditName_Button.Click += new System.EventHandler(this.EditName_Button_Click);
            // 
            // ChangeIcon_Panel
            // 
            this.ChangeIcon_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.ChangeIcon_Panel.Controls.Add(this.ChangeImage_Label);
            this.ChangeIcon_Panel.Location = new System.Drawing.Point(36, 171);
            this.ChangeIcon_Panel.Name = "ChangeIcon_Panel";
            this.ChangeIcon_Panel.Size = new System.Drawing.Size(177, 37);
            this.ChangeIcon_Panel.TabIndex = 2;
            this.ChangeIcon_Panel.Visible = false;
            this.ChangeIcon_Panel.Click += new System.EventHandler(this.ChangeIcon_Panel_Click);
            // 
            // ChangeImage_Label
            // 
            this.ChangeImage_Label.AutoSize = true;
            this.ChangeImage_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeImage_Label.Location = new System.Drawing.Point(3, 10);
            this.ChangeImage_Label.Name = "ChangeImage_Label";
            this.ChangeImage_Label.Size = new System.Drawing.Size(167, 17);
            this.ChangeImage_Label.TabIndex = 0;
            this.ChangeImage_Label.Text = "Изменить фотографию";
            this.ChangeImage_Label.Click += new System.EventHandler(this.UserIcon_PictureBox_Click);
            this.ChangeImage_Label.MouseEnter += new System.EventHandler(this.ChangeImage_Label_MouseEnter);
            this.ChangeImage_Label.MouseLeave += new System.EventHandler(this.ChangeImage_Label_MouseLeave);
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
            this.UserIcon_PictureBox.Click += new System.EventHandler(this.UserIcon_PictureBox_Click);
            this.UserIcon_PictureBox.MouseEnter += new System.EventHandler(this.UserIcon_PictureBox_MouseEnter);
            this.UserIcon_PictureBox.MouseLeave += new System.EventHandler(this.UserIcon_PictureBox_MouseLeave);
            // 
            // SaveProfile_Button
            // 
            this.SaveProfile_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveProfile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProfile_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProfile_Button.ForeColor = System.Drawing.Color.White;
            this.SaveProfile_Button.Location = new System.Drawing.Point(612, 286);
            this.SaveProfile_Button.Name = "SaveProfile_Button";
            this.SaveProfile_Button.Size = new System.Drawing.Size(197, 34);
            this.SaveProfile_Button.TabIndex = 6;
            this.SaveProfile_Button.Text = "Сохранить";
            this.SaveProfile_Button.UseVisualStyleBackColor = true;
            this.SaveProfile_Button.Click += new System.EventHandler(this.SaveProfile_Button_Click);
            // 
            // CancelSave_Button
            // 
            this.CancelSave_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelSave_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSave_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSave_Button.ForeColor = System.Drawing.Color.White;
            this.CancelSave_Button.Location = new System.Drawing.Point(409, 286);
            this.CancelSave_Button.Name = "CancelSave_Button";
            this.CancelSave_Button.Size = new System.Drawing.Size(197, 34);
            this.CancelSave_Button.TabIndex = 6;
            this.CancelSave_Button.Text = "Отменить изменения";
            this.CancelSave_Button.UseVisualStyleBackColor = true;
            this.CancelSave_Button.Click += new System.EventHandler(this.CancelSave_Button_Click);
            // 
            // SecurityPanel
            // 
            this.SecurityPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.SecurityPanel.Controls.Add(this.ShowSecurity_Button);
            this.SecurityPanel.Controls.Add(this.PasswordPanel);
            this.SecurityPanel.Controls.Add(this.Security_Label);
            this.SecurityPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecurityPanel.Location = new System.Drawing.Point(0, 33);
            this.SecurityPanel.Name = "SecurityPanel";
            this.SecurityPanel.Size = new System.Drawing.Size(532, 33);
            this.SecurityPanel.TabIndex = 7;
            // 
            // ShowSecurity_Button
            // 
            this.ShowSecurity_Button.FlatAppearance.BorderSize = 0;
            this.ShowSecurity_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowSecurity_Button.Image = ((System.Drawing.Image)(resources.GetObject("ShowSecurity_Button.Image")));
            this.ShowSecurity_Button.Location = new System.Drawing.Point(19, 0);
            this.ShowSecurity_Button.Name = "ShowSecurity_Button";
            this.ShowSecurity_Button.Size = new System.Drawing.Size(32, 32);
            this.ShowSecurity_Button.TabIndex = 3;
            this.ShowSecurity_Button.UseVisualStyleBackColor = true;
            this.ShowSecurity_Button.Click += new System.EventHandler(this.ShowSecurity_Button_Click);
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.PasswordPanel.Controls.Add(this.ChangePassword_Button);
            this.PasswordPanel.Controls.Add(this.panel4);
            this.PasswordPanel.Controls.Add(this.panel1);
            this.PasswordPanel.Controls.Add(this.RepeatPassword_Label);
            this.PasswordPanel.Controls.Add(this.FirstPassword_Label);
            this.PasswordPanel.Controls.Add(this.RepeatPassword_TextBox);
            this.PasswordPanel.Controls.Add(this.FirstPassword_TextBox);
            this.PasswordPanel.Location = new System.Drawing.Point(19, 34);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(460, 158);
            this.PasswordPanel.TabIndex = 2;
            // 
            // ChangePassword_Button
            // 
            this.ChangePassword_Button.FlatAppearance.BorderSize = 0;
            this.ChangePassword_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassword_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePassword_Button.ForeColor = System.Drawing.Color.White;
            this.ChangePassword_Button.Location = new System.Drawing.Point(255, 115);
            this.ChangePassword_Button.Name = "ChangePassword_Button";
            this.ChangePassword_Button.Size = new System.Drawing.Size(205, 36);
            this.ChangePassword_Button.TabIndex = 3;
            this.ChangePassword_Button.Text = "Сменить пароль";
            this.ChangePassword_Button.UseVisualStyleBackColor = true;
            this.ChangePassword_Button.Click += new System.EventHandler(this.ChangePassword_Button_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.panel4.Location = new System.Drawing.Point(206, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 1);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(206, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 1);
            this.panel1.TabIndex = 2;
            // 
            // RepeatPassword_Label
            // 
            this.RepeatPassword_Label.AutoSize = true;
            this.RepeatPassword_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPassword_Label.ForeColor = System.Drawing.Color.White;
            this.RepeatPassword_Label.Location = new System.Drawing.Point(11, 53);
            this.RepeatPassword_Label.Name = "RepeatPassword_Label";
            this.RepeatPassword_Label.Size = new System.Drawing.Size(154, 21);
            this.RepeatPassword_Label.TabIndex = 1;
            this.RepeatPassword_Label.Text = "Повторите пароль";
            // 
            // FirstPassword_Label
            // 
            this.FirstPassword_Label.AutoSize = true;
            this.FirstPassword_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstPassword_Label.ForeColor = System.Drawing.Color.White;
            this.FirstPassword_Label.Location = new System.Drawing.Point(11, 20);
            this.FirstPassword_Label.Name = "FirstPassword_Label";
            this.FirstPassword_Label.Size = new System.Drawing.Size(70, 21);
            this.FirstPassword_Label.TabIndex = 1;
            this.FirstPassword_Label.Text = "Пароль";
            // 
            // RepeatPassword_TextBox
            // 
            this.RepeatPassword_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.RepeatPassword_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RepeatPassword_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPassword_TextBox.ForeColor = System.Drawing.Color.White;
            this.RepeatPassword_TextBox.Location = new System.Drawing.Point(206, 50);
            this.RepeatPassword_TextBox.Name = "RepeatPassword_TextBox";
            this.RepeatPassword_TextBox.PasswordChar = '•';
            this.RepeatPassword_TextBox.Size = new System.Drawing.Size(240, 20);
            this.RepeatPassword_TextBox.TabIndex = 0;
            this.RepeatPassword_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstPassword_TextBox
            // 
            this.FirstPassword_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.FirstPassword_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstPassword_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstPassword_TextBox.ForeColor = System.Drawing.Color.White;
            this.FirstPassword_TextBox.Location = new System.Drawing.Point(206, 17);
            this.FirstPassword_TextBox.Name = "FirstPassword_TextBox";
            this.FirstPassword_TextBox.PasswordChar = '•';
            this.FirstPassword_TextBox.Size = new System.Drawing.Size(240, 20);
            this.FirstPassword_TextBox.TabIndex = 0;
            this.FirstPassword_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Security_Label
            // 
            this.Security_Label.AutoSize = true;
            this.Security_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Security_Label.ForeColor = System.Drawing.Color.White;
            this.Security_Label.Location = new System.Drawing.Point(63, 9);
            this.Security_Label.Name = "Security_Label";
            this.Security_Label.Size = new System.Drawing.Size(140, 22);
            this.Security_Label.TabIndex = 1;
            this.Security_Label.Text = "Безопасность";
            this.Security_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.SecurityPanel);
            this.panel3.Controls.Add(this.AboutUserPanel);
            this.panel3.Location = new System.Drawing.Point(298, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 277);
            this.panel3.TabIndex = 8;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.CancelSave_Button);
            this.Controls.Add(this.SaveProfile_Button);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.panel3);
            this.Name = "EditProfile";
            this.Size = new System.Drawing.Size(830, 335);
            this.AboutUserPanel.ResumeLayout(false);
            this.AboutUserPanel.PerformLayout();
            this.Content_Panel.ResumeLayout(false);
            this.Content_Panel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.ChangeIcon_Panel.ResumeLayout(false);
            this.ChangeIcon_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon_PictureBox)).EndInit();
            this.SecurityPanel.ResumeLayout(false);
            this.SecurityPanel.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label AboutUser_Label;
        public System.Windows.Forms.Panel AboutUserPanel;
        public System.Windows.Forms.Panel Content_Panel;
        public System.Windows.Forms.Label Age_Label;
        public System.Windows.Forms.Label Gender_Label;
        public System.Windows.Forms.Label City_Label;
        public System.Windows.Forms.Label Country_Label;
        public System.Windows.Forms.Label Name_Label;
        public System.Windows.Forms.Panel LeftPanel;
        public System.Windows.Forms.PictureBox UserIcon_PictureBox;
        private System.Windows.Forms.ComboBox Gender_ComboBox;
        private System.Windows.Forms.ComboBox City_ComboBox;
        private System.Windows.Forms.ComboBox Country_ComboBox;
        private System.Windows.Forms.Panel ChangeIcon_Panel;
        private System.Windows.Forms.Label ChangeImage_Label;
        private System.Windows.Forms.Button SaveProfile_Button;
        private System.Windows.Forms.Button CancelSave_Button;
        private System.Windows.Forms.DateTimePicker BirthDate_DateTimePicker;
        private System.Windows.Forms.Panel SecurityPanel;
        public System.Windows.Forms.Label Security_Label;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.Button ShowAboutUser_Button;
        private System.Windows.Forms.Button ShowSecurity_Button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label RepeatPassword_Label;
        private System.Windows.Forms.Label FirstPassword_Label;
        private System.Windows.Forms.TextBox RepeatPassword_TextBox;
        private System.Windows.Forms.TextBox FirstPassword_TextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChangePassword_Button;
        private System.Windows.Forms.Button EditName_Button;
    }
}
