namespace Send.Пользовательские_элементы_управления
{
    partial class MessagePanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagePanel));
            this.FriendsPanel = new System.Windows.Forms.Panel();
            this.FriendsListPanel = new System.Windows.Forms.Panel();
            this.CreateNewChat_Button = new System.Windows.Forms.Button();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.MessagesPanel = new System.Windows.Forms.Panel();
            this.AddedContentPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.Message_TextBox = new System.Windows.Forms.TextBox();
            this.LengthCount_Label = new System.Windows.Forms.Label();
            this.AddFile_Button = new System.Windows.Forms.Button();
            this.SendMessage_Button = new System.Windows.Forms.Button();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.HideCenterPanel_Button = new System.Windows.Forms.Button();
            this.CurrentName_Label = new System.Windows.Forms.Label();
            this.CurrentUserPicture = new System.Windows.Forms.PictureBox();
            this.Panel_GroupChat = new Send.Пользовательские_элементы_управления.GroupPanel();
            this.AddFile_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CheckReaded = new System.Windows.Forms.Timer(this.components);
            this.FriendsPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // FriendsPanel
            // 
            this.FriendsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FriendsPanel.Controls.Add(this.FriendsListPanel);
            this.FriendsPanel.Controls.Add(this.CreateNewChat_Button);
            this.FriendsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FriendsPanel.Location = new System.Drawing.Point(0, 0);
            this.FriendsPanel.Name = "FriendsPanel";
            this.FriendsPanel.Size = new System.Drawing.Size(253, 331);
            this.FriendsPanel.TabIndex = 0;
            // 
            // FriendsListPanel
            // 
            this.FriendsListPanel.AutoScroll = true;
            this.FriendsListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FriendsListPanel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FriendsListPanel.Location = new System.Drawing.Point(0, 32);
            this.FriendsListPanel.Name = "FriendsListPanel";
            this.FriendsListPanel.Size = new System.Drawing.Size(251, 297);
            this.FriendsListPanel.TabIndex = 3;
            // 
            // CreateNewChat_Button
            // 
            this.CreateNewChat_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateNewChat_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewChat_Button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateNewChat_Button.Image = ((System.Drawing.Image)(resources.GetObject("CreateNewChat_Button.Image")));
            this.CreateNewChat_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateNewChat_Button.Location = new System.Drawing.Point(0, 0);
            this.CreateNewChat_Button.Name = "CreateNewChat_Button";
            this.CreateNewChat_Button.Size = new System.Drawing.Size(251, 32);
            this.CreateNewChat_Button.TabIndex = 4;
            this.CreateNewChat_Button.Text = "         Создать общий чат";
            this.CreateNewChat_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateNewChat_Button.UseVisualStyleBackColor = true;
            this.CreateNewChat_Button.Click += new System.EventHandler(this.CreateNewChat_Button_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.MessagesPanel);
            this.CenterPanel.Controls.Add(this.AddedContentPanel);
            this.CenterPanel.Controls.Add(this.BottomPanel);
            this.CenterPanel.Controls.Add(this.UpperPanel);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(253, 0);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(577, 331);
            this.CenterPanel.TabIndex = 1;
            this.CenterPanel.Visible = false;
            // 
            // MessagesPanel
            // 
            this.MessagesPanel.AutoScroll = true;
            this.MessagesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesPanel.Location = new System.Drawing.Point(0, 123);
            this.MessagesPanel.Name = "MessagesPanel";
            this.MessagesPanel.Size = new System.Drawing.Size(577, 208);
            this.MessagesPanel.TabIndex = 4;
            // 
            // AddedContentPanel
            // 
            this.AddedContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddedContentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddedContentPanel.Location = new System.Drawing.Point(0, 73);
            this.AddedContentPanel.Name = "AddedContentPanel";
            this.AddedContentPanel.Size = new System.Drawing.Size(577, 50);
            this.AddedContentPanel.TabIndex = 0;
            this.AddedContentPanel.Visible = false;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.Message_TextBox);
            this.BottomPanel.Controls.Add(this.LengthCount_Label);
            this.BottomPanel.Controls.Add(this.AddFile_Button);
            this.BottomPanel.Controls.Add(this.SendMessage_Button);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BottomPanel.Location = new System.Drawing.Point(0, 32);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(577, 41);
            this.BottomPanel.TabIndex = 0;
            // 
            // Message_TextBox
            // 
            this.Message_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Message_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Message_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message_TextBox.ForeColor = System.Drawing.Color.White;
            this.Message_TextBox.Location = new System.Drawing.Point(32, 0);
            this.Message_TextBox.MaxLength = 500;
            this.Message_TextBox.Name = "Message_TextBox";
            this.Message_TextBox.Size = new System.Drawing.Size(513, 27);
            this.Message_TextBox.TabIndex = 0;
            this.Message_TextBox.TextChanged += new System.EventHandler(this.Message_TextBox_TextChanged);
            // 
            // LengthCount_Label
            // 
            this.LengthCount_Label.AutoSize = true;
            this.LengthCount_Label.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthCount_Label.ForeColor = System.Drawing.Color.LightGray;
            this.LengthCount_Label.Location = new System.Drawing.Point(41, 28);
            this.LengthCount_Label.Name = "LengthCount_Label";
            this.LengthCount_Label.Size = new System.Drawing.Size(31, 13);
            this.LengthCount_Label.TabIndex = 3;
            this.LengthCount_Label.Text = "0/500";
            this.LengthCount_Label.Visible = false;
            // 
            // AddFile_Button
            // 
            this.AddFile_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddFile_Button.FlatAppearance.BorderSize = 0;
            this.AddFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFile_Button.Image = ((System.Drawing.Image)(resources.GetObject("AddFile_Button.Image")));
            this.AddFile_Button.Location = new System.Drawing.Point(0, 0);
            this.AddFile_Button.Name = "AddFile_Button";
            this.AddFile_Button.Size = new System.Drawing.Size(32, 41);
            this.AddFile_Button.TabIndex = 2;
            this.AddFile_Button.UseVisualStyleBackColor = true;
            this.AddFile_Button.Click += new System.EventHandler(this.AddFile_Button_Click);
            // 
            // SendMessage_Button
            // 
            this.SendMessage_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.SendMessage_Button.FlatAppearance.BorderSize = 0;
            this.SendMessage_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessage_Button.Image = ((System.Drawing.Image)(resources.GetObject("SendMessage_Button.Image")));
            this.SendMessage_Button.Location = new System.Drawing.Point(545, 0);
            this.SendMessage_Button.Name = "SendMessage_Button";
            this.SendMessage_Button.Size = new System.Drawing.Size(32, 41);
            this.SendMessage_Button.TabIndex = 1;
            this.SendMessage_Button.UseVisualStyleBackColor = true;
            this.SendMessage_Button.Click += new System.EventHandler(this.SendMessage_Button_Click);
            // 
            // UpperPanel
            // 
            this.UpperPanel.Controls.Add(this.HideCenterPanel_Button);
            this.UpperPanel.Controls.Add(this.CurrentName_Label);
            this.UpperPanel.Controls.Add(this.CurrentUserPicture);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(577, 32);
            this.UpperPanel.TabIndex = 1;
            // 
            // HideCenterPanel_Button
            // 
            this.HideCenterPanel_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.HideCenterPanel_Button.FlatAppearance.BorderSize = 0;
            this.HideCenterPanel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideCenterPanel_Button.Image = ((System.Drawing.Image)(resources.GetObject("HideCenterPanel_Button.Image")));
            this.HideCenterPanel_Button.Location = new System.Drawing.Point(545, 0);
            this.HideCenterPanel_Button.Name = "HideCenterPanel_Button";
            this.HideCenterPanel_Button.Size = new System.Drawing.Size(32, 32);
            this.HideCenterPanel_Button.TabIndex = 3;
            this.HideCenterPanel_Button.UseVisualStyleBackColor = true;
            this.HideCenterPanel_Button.Click += new System.EventHandler(this.HideCenterPanel_Button_Click);
            // 
            // CurrentName_Label
            // 
            this.CurrentName_Label.AutoSize = true;
            this.CurrentName_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentName_Label.ForeColor = System.Drawing.Color.White;
            this.CurrentName_Label.Location = new System.Drawing.Point(53, 6);
            this.CurrentName_Label.Name = "CurrentName_Label";
            this.CurrentName_Label.Size = new System.Drawing.Size(186, 20);
            this.CurrentName_Label.TabIndex = 2;
            this.CurrentName_Label.Text = "Фамилия Имя Отчество";
            this.CurrentName_Label.Click += new System.EventHandler(this.CurrentName_Label_Click);
            // 
            // CurrentUserPicture
            // 
            this.CurrentUserPicture.Location = new System.Drawing.Point(19, 0);
            this.CurrentUserPicture.Name = "CurrentUserPicture";
            this.CurrentUserPicture.Size = new System.Drawing.Size(32, 32);
            this.CurrentUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CurrentUserPicture.TabIndex = 2;
            this.CurrentUserPicture.TabStop = false;
            this.CurrentUserPicture.Click += new System.EventHandler(this.CurrentUserPicture_Click);
            // 
            // Panel_GroupChat
            // 
            this.Panel_GroupChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Panel_GroupChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_GroupChat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Panel_GroupChat.Location = new System.Drawing.Point(0, 0);
            this.Panel_GroupChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_GroupChat.Name = "Panel_GroupChat";
            this.Panel_GroupChat.Size = new System.Drawing.Size(830, 331);
            this.Panel_GroupChat.TabIndex = 4;
            this.Panel_GroupChat.Visible = false;
            // 
            // AddFile_OpenFileDialog
            // 
            this.AddFile_OpenFileDialog.Filter = "PNG-Файл|*.png|JPG-Файл|*.jpg|JPEG-Файл|*.jpeg|Все файлы|*.*";
            // 
            // CheckReaded
            // 
            this.CheckReaded.Interval = 1000;
            this.CheckReaded.Tick += new System.EventHandler(this.CheckReaded_Tick);
            // 
            // MessagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.FriendsPanel);
            this.Controls.Add(this.Panel_GroupChat);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MessagePanel";
            this.Size = new System.Drawing.Size(830, 331);
            this.FriendsPanel.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentUserPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FriendsPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.TextBox Message_TextBox;
        private System.Windows.Forms.Button SendMessage_Button;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label CurrentName_Label;
        private System.Windows.Forms.PictureBox CurrentUserPicture;
        private System.Windows.Forms.Panel MessagesPanel;
        private System.Windows.Forms.Button HideCenterPanel_Button;
        private System.Windows.Forms.Panel FriendsListPanel;
        private System.Windows.Forms.Button AddFile_Button;
        private System.Windows.Forms.OpenFileDialog AddFile_OpenFileDialog;
        private System.Windows.Forms.Panel AddedContentPanel;
        private System.Windows.Forms.Label LengthCount_Label;
        private System.Windows.Forms.Button CreateNewChat_Button;
        public GroupPanel Panel_GroupChat;
        public System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Timer CheckReaded;
    }
}
