
namespace Send
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.Friends_ListBox = new System.Windows.Forms.ListBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.SendMessage_Button = new System.Windows.Forms.Button();
            this.Message_TextBox = new System.Windows.Forms.TextBox();
            this.Messages_ListBox = new System.Windows.Forms.ListBox();
            this.WarningMessage = new System.Windows.Forms.Timer(this.components);
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.Friends_ListBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(215, 331);
            this.LeftPanel.TabIndex = 0;
            // 
            // Friends_ListBox
            // 
            this.Friends_ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(21)))), ((int)(((byte)(70)))));
            this.Friends_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Friends_ListBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Friends_ListBox.ForeColor = System.Drawing.Color.White;
            this.Friends_ListBox.FormattingEnabled = true;
            this.Friends_ListBox.ItemHeight = 22;
            this.Friends_ListBox.Location = new System.Drawing.Point(8, 11);
            this.Friends_ListBox.Name = "Friends_ListBox";
            this.Friends_ListBox.Size = new System.Drawing.Size(199, 308);
            this.Friends_ListBox.TabIndex = 0;
            this.Friends_ListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Friends_ListBox_MouseClick);
            this.Friends_ListBox.SelectedIndexChanged += new System.EventHandler(this.Friends_ListBox_SelectedIndexChanged);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.RightPanel.Controls.Add(this.SendMessage_Button);
            this.RightPanel.Controls.Add(this.Message_TextBox);
            this.RightPanel.Controls.Add(this.Messages_ListBox);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(235, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(595, 331);
            this.RightPanel.TabIndex = 1;
            // 
            // SendMessage_Button
            // 
            this.SendMessage_Button.FlatAppearance.BorderSize = 0;
            this.SendMessage_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessage_Button.ForeColor = System.Drawing.Color.White;
            this.SendMessage_Button.Image = ((System.Drawing.Image)(resources.GetObject("SendMessage_Button.Image")));
            this.SendMessage_Button.Location = new System.Drawing.Point(559, 291);
            this.SendMessage_Button.Name = "SendMessage_Button";
            this.SendMessage_Button.Size = new System.Drawing.Size(30, 30);
            this.SendMessage_Button.TabIndex = 2;
            this.SendMessage_Button.UseVisualStyleBackColor = true;
            this.SendMessage_Button.Click += new System.EventHandler(this.SendMessage_Button_Click);
            // 
            // Message_TextBox
            // 
            this.Message_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Message_TextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message_TextBox.ForeColor = System.Drawing.Color.White;
            this.Message_TextBox.Location = new System.Drawing.Point(3, 297);
            this.Message_TextBox.Name = "Message_TextBox";
            this.Message_TextBox.Size = new System.Drawing.Size(553, 23);
            this.Message_TextBox.TabIndex = 1;
            this.Message_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Message_TextBox_KeyDown);
            // 
            // Messages_ListBox
            // 
            this.Messages_ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(21)))), ((int)(((byte)(70)))));
            this.Messages_ListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Messages_ListBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Messages_ListBox.ForeColor = System.Drawing.Color.White;
            this.Messages_ListBox.FormattingEnabled = true;
            this.Messages_ListBox.ItemHeight = 20;
            this.Messages_ListBox.Location = new System.Drawing.Point(0, 0);
            this.Messages_ListBox.MultiColumn = true;
            this.Messages_ListBox.Name = "Messages_ListBox";
            this.Messages_ListBox.Size = new System.Drawing.Size(595, 284);
            this.Messages_ListBox.TabIndex = 0;
            this.Messages_ListBox.SelectedIndexChanged += new System.EventHandler(this.Messages_ListBox_SelectedIndexChanged);
            // 
            // WarningMessage
            // 
            this.WarningMessage.Interval = 2000;
            this.WarningMessage.Tick += new System.EventHandler(this.WarningMessage_Tick);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 2000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Message";
            this.Size = new System.Drawing.Size(830, 331);
            this.Load += new System.EventHandler(this.Message_Load);
            this.LeftPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel LeftPanel;
        public System.Windows.Forms.ListBox Friends_ListBox;
        public System.Windows.Forms.Panel RightPanel;
        public System.Windows.Forms.Button SendMessage_Button;
        public System.Windows.Forms.TextBox Message_TextBox;
        public System.Windows.Forms.ListBox Messages_ListBox;
        private System.Windows.Forms.Timer WarningMessage;
        private System.Windows.Forms.Timer UpdateTimer;
    }
}
