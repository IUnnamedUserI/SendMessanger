
namespace Send
{
    partial class Friends
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
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.FriendsList_Panel = new Send.FriendList();
            this.OutcomingQuerys_Panel = new Send.Пользовательские_элементы_управления.OutcomingQuerys();
            this.IncomingQuerys_Panel = new Send.IncomingQuerys();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SlidePanel = new System.Windows.Forms.Panel();
            this.OutcomingQuery_Button = new System.Windows.Forms.Button();
            this.IncomingQuery_Button = new System.Windows.Forms.Button();
            this.Friends_Button = new System.Windows.Forms.Button();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.BottomPanel.Controls.Add(this.FriendsList_Panel);
            this.BottomPanel.Controls.Add(this.OutcomingQuerys_Panel);
            this.BottomPanel.Controls.Add(this.IncomingQuerys_Panel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 40);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(830, 300);
            this.BottomPanel.TabIndex = 2;
            // 
            // FriendsList_Panel
            // 
            this.FriendsList_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.FriendsList_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FriendsList_Panel.Location = new System.Drawing.Point(0, 0);
            this.FriendsList_Panel.Name = "FriendsList_Panel";
            this.FriendsList_Panel.Size = new System.Drawing.Size(830, 300);
            this.FriendsList_Panel.TabIndex = 0;
            // 
            // OutcomingQuerys_Panel
            // 
            this.OutcomingQuerys_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.OutcomingQuerys_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutcomingQuerys_Panel.Location = new System.Drawing.Point(0, 0);
            this.OutcomingQuerys_Panel.Name = "OutcomingQuerys_Panel";
            this.OutcomingQuerys_Panel.Size = new System.Drawing.Size(830, 300);
            this.OutcomingQuerys_Panel.TabIndex = 3;
            // 
            // IncomingQuerys_Panel
            // 
            this.IncomingQuerys_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.IncomingQuerys_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncomingQuerys_Panel.Location = new System.Drawing.Point(0, 0);
            this.IncomingQuerys_Panel.Name = "IncomingQuerys_Panel";
            this.IncomingQuerys_Panel.Size = new System.Drawing.Size(830, 300);
            this.IncomingQuerys_Panel.TabIndex = 2;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.SlidePanel);
            this.TopPanel.Controls.Add(this.OutcomingQuery_Button);
            this.TopPanel.Controls.Add(this.IncomingQuery_Button);
            this.TopPanel.Controls.Add(this.Friends_Button);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(830, 40);
            this.TopPanel.TabIndex = 0;
            // 
            // SlidePanel
            // 
            this.SlidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.SlidePanel.Location = new System.Drawing.Point(0, 34);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(160, 6);
            this.SlidePanel.TabIndex = 5;
            // 
            // OutcomingQuery_Button
            // 
            this.OutcomingQuery_Button.FlatAppearance.BorderSize = 0;
            this.OutcomingQuery_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutcomingQuery_Button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutcomingQuery_Button.ForeColor = System.Drawing.Color.White;
            this.OutcomingQuery_Button.Location = new System.Drawing.Point(322, 0);
            this.OutcomingQuery_Button.Name = "OutcomingQuery_Button";
            this.OutcomingQuery_Button.Size = new System.Drawing.Size(160, 34);
            this.OutcomingQuery_Button.TabIndex = 2;
            this.OutcomingQuery_Button.Text = "Исходящие заявки";
            this.OutcomingQuery_Button.UseVisualStyleBackColor = true;
            this.OutcomingQuery_Button.Click += new System.EventHandler(this.OutcomingQuery_Button_Click);
            // 
            // IncomingQuery_Button
            // 
            this.IncomingQuery_Button.FlatAppearance.BorderSize = 0;
            this.IncomingQuery_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomingQuery_Button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomingQuery_Button.ForeColor = System.Drawing.Color.White;
            this.IncomingQuery_Button.Location = new System.Drawing.Point(161, 0);
            this.IncomingQuery_Button.Name = "IncomingQuery_Button";
            this.IncomingQuery_Button.Size = new System.Drawing.Size(160, 34);
            this.IncomingQuery_Button.TabIndex = 3;
            this.IncomingQuery_Button.Text = "Входящие заявки";
            this.IncomingQuery_Button.UseVisualStyleBackColor = true;
            this.IncomingQuery_Button.Click += new System.EventHandler(this.IncomingQuery_Button_Click);
            // 
            // Friends_Button
            // 
            this.Friends_Button.FlatAppearance.BorderSize = 0;
            this.Friends_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Friends_Button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Friends_Button.ForeColor = System.Drawing.Color.White;
            this.Friends_Button.Location = new System.Drawing.Point(0, 0);
            this.Friends_Button.Name = "Friends_Button";
            this.Friends_Button.Size = new System.Drawing.Size(160, 34);
            this.Friends_Button.TabIndex = 4;
            this.Friends_Button.Text = "Друзья";
            this.Friends_Button.UseVisualStyleBackColor = true;
            this.Friends_Button.Click += new System.EventHandler(this.Friends_Button_Click);
            // 
            // Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Name = "Friends";
            this.Size = new System.Drawing.Size(830, 340);
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel BottomPanel;
        public FriendList FriendsList_Panel;
        public System.Windows.Forms.Panel TopPanel;
        public System.Windows.Forms.Panel SlidePanel;
        public System.Windows.Forms.Button OutcomingQuery_Button;
        public System.Windows.Forms.Button IncomingQuery_Button;
        public System.Windows.Forms.Button Friends_Button;
        private IncomingQuerys IncomingQuerys_Panel;
        private Пользовательские_элементы_управления.OutcomingQuerys OutcomingQuerys_Panel;
    }
}
