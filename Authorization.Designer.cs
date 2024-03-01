namespace Send
{
    partial class Authorization
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.Login_Button = new System.Windows.Forms.Button();
            this.Registration_Button = new System.Windows.Forms.Button();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.WarningPicture = new System.Windows.Forms.PictureBox();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Password_PictureBox = new System.Windows.Forms.PictureBox();
            this.Login_PictureBox = new System.Windows.Forms.PictureBox();
            this.Password_Panel = new System.Windows.Forms.Panel();
            this.Login_Panel = new System.Windows.Forms.Panel();
            this.ShowPassword_Button = new System.Windows.Forms.Button();
            this.CheckForInternetConnectionTimer = new System.Windows.Forms.Timer(this.components);
            this.WarningMessage = new System.Windows.Forms.ToolTip(this.components);
            this.Version_Label = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.Login_Button.Location = new System.Drawing.Point(53, 264);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(260, 32);
            this.Login_Button.TabIndex = 3;
            this.Login_Button.Text = "Войти";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            this.Login_Button.MouseEnter += new System.EventHandler(this.Login_Button_MouseEnter);
            this.Login_Button.MouseLeave += new System.EventHandler(this.Login_Button_MouseLeave);
            // 
            // Registration_Button
            // 
            this.Registration_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration_Button.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.Registration_Button.Location = new System.Drawing.Point(53, 302);
            this.Registration_Button.Name = "Registration_Button";
            this.Registration_Button.Size = new System.Drawing.Size(260, 32);
            this.Registration_Button.TabIndex = 4;
            this.Registration_Button.Text = "Регистрация";
            this.Registration_Button.UseVisualStyleBackColor = true;
            this.Registration_Button.Click += new System.EventHandler(this.Registration_Button_Click);
            this.Registration_Button.MouseEnter += new System.EventHandler(this.Registration_Button_MouseEnter);
            this.Registration_Button.MouseLeave += new System.EventHandler(this.Registration_Button_MouseLeave);
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.Username_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Username_TextBox.ForeColor = System.Drawing.Color.White;
            this.Username_TextBox.Location = new System.Drawing.Point(53, 162);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(260, 20);
            this.Username_TextBox.TabIndex = 1;
            this.Username_TextBox.Text = "Логин или E-Mail";
            this.Username_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Username_TextBox.Enter += new System.EventHandler(this.Username_TextBox_Enter);
            this.Username_TextBox.Leave += new System.EventHandler(this.Username_TextBox_Leave);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.Password_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_TextBox.ForeColor = System.Drawing.Color.White;
            this.Password_TextBox.Location = new System.Drawing.Point(53, 207);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(260, 20);
            this.Password_TextBox.TabIndex = 2;
            this.Password_TextBox.Text = "Пароль";
            this.Password_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password_TextBox.Enter += new System.EventHandler(this.Password_TextBox_Enter);
            this.Password_TextBox.Leave += new System.EventHandler(this.Password_TextBox_Leave);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.LeftPanel.Controls.Add(this.Version_Label);
            this.LeftPanel.Controls.Add(this.WarningPicture);
            this.LeftPanel.Controls.Add(this.Close_Button);
            this.LeftPanel.Controls.Add(this.Password_PictureBox);
            this.LeftPanel.Controls.Add(this.Login_PictureBox);
            this.LeftPanel.Controls.Add(this.Password_TextBox);
            this.LeftPanel.Controls.Add(this.Password_Panel);
            this.LeftPanel.Controls.Add(this.Username_TextBox);
            this.LeftPanel.Controls.Add(this.Login_Panel);
            this.LeftPanel.Controls.Add(this.Registration_Button);
            this.LeftPanel.Controls.Add(this.ShowPassword_Button);
            this.LeftPanel.Controls.Add(this.Login_Button);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(358, 409);
            this.LeftPanel.TabIndex = 7;
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.LeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseMove);
            this.LeftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseUp);
            // 
            // WarningPicture
            // 
            this.WarningPicture.Image = ((System.Drawing.Image)(resources.GetObject("WarningPicture.Image")));
            this.WarningPicture.Location = new System.Drawing.Point(172, 117);
            this.WarningPicture.Name = "WarningPicture";
            this.WarningPicture.Size = new System.Drawing.Size(30, 30);
            this.WarningPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WarningPicture.TabIndex = 12;
            this.WarningPicture.TabStop = false;
            this.WarningPicture.Visible = false;
            this.WarningPicture.MouseEnter += new System.EventHandler(this.WarningPicture_MouseEnter);
            // 
            // Close_Button
            // 
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.Location = new System.Drawing.Point(322, 4);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(32, 32);
            this.Close_Button.TabIndex = 0;
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Password_PictureBox
            // 
            this.Password_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Password_PictureBox.Image")));
            this.Password_PictureBox.Location = new System.Drawing.Point(17, 201);
            this.Password_PictureBox.Name = "Password_PictureBox";
            this.Password_PictureBox.Size = new System.Drawing.Size(30, 30);
            this.Password_PictureBox.TabIndex = 8;
            this.Password_PictureBox.TabStop = false;
            // 
            // Login_PictureBox
            // 
            this.Login_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Login_PictureBox.Image")));
            this.Login_PictureBox.Location = new System.Drawing.Point(17, 157);
            this.Login_PictureBox.Name = "Login_PictureBox";
            this.Login_PictureBox.Size = new System.Drawing.Size(30, 30);
            this.Login_PictureBox.TabIndex = 8;
            this.Login_PictureBox.TabStop = false;
            // 
            // Password_Panel
            // 
            this.Password_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.Password_Panel.Location = new System.Drawing.Point(53, 229);
            this.Password_Panel.Name = "Password_Panel";
            this.Password_Panel.Size = new System.Drawing.Size(260, 1);
            this.Password_Panel.TabIndex = 7;
            // 
            // Login_Panel
            // 
            this.Login_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.Login_Panel.Location = new System.Drawing.Point(53, 184);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.Size = new System.Drawing.Size(260, 1);
            this.Login_Panel.TabIndex = 7;
            // 
            // ShowPassword_Button
            // 
            this.ShowPassword_Button.FlatAppearance.BorderSize = 0;
            this.ShowPassword_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPassword_Button.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassword_Button.Image = global::Send.Properties.Resources.Закрытый_глаз;
            this.ShowPassword_Button.Location = new System.Drawing.Point(320, 200);
            this.ShowPassword_Button.Name = "ShowPassword_Button";
            this.ShowPassword_Button.Size = new System.Drawing.Size(30, 30);
            this.ShowPassword_Button.TabIndex = 5;
            this.ShowPassword_Button.UseVisualStyleBackColor = true;
            this.ShowPassword_Button.Click += new System.EventHandler(this.ShowPassword_Button_Click);
            this.ShowPassword_Button.MouseLeave += new System.EventHandler(this.ShowPassword_Button_MouseLeave);
            // 
            // CheckForInternetConnectionTimer
            // 
            this.CheckForInternetConnectionTimer.Interval = 3000;
            this.CheckForInternetConnectionTimer.Tick += new System.EventHandler(this.CheckForInternetConnectionTimer_Tick);
            // 
            // WarningMessage
            // 
            this.WarningMessage.BackColor = System.Drawing.Color.Black;
            this.WarningMessage.ForeColor = System.Drawing.Color.White;
            this.WarningMessage.IsBalloon = true;
            // 
            // Version_Label
            // 
            this.Version_Label.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Version_Label.ForeColor = System.Drawing.Color.White;
            this.Version_Label.Location = new System.Drawing.Point(0, 378);
            this.Version_Label.Name = "Version_Label";
            this.Version_Label.Size = new System.Drawing.Size(358, 31);
            this.Version_Label.TabIndex = 13;
            this.Version_Label.Text = "v.0.0.0";
            this.Version_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 409);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Registration_Button;
        public System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Button ShowPassword_Button;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.PictureBox Password_PictureBox;
        private System.Windows.Forms.PictureBox Login_PictureBox;
        private System.Windows.Forms.Panel Password_Panel;
        private System.Windows.Forms.Panel Login_Panel;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.PictureBox WarningPicture;
        private System.Windows.Forms.Timer CheckForInternetConnectionTimer;
        private System.Windows.Forms.ToolTip WarningMessage;
        private System.Windows.Forms.Label Version_Label;
    }
}

