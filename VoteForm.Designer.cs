
namespace Send
{
    partial class VoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoteForm));
            this.LeftBorderPanel = new System.Windows.Forms.Panel();
            this.RightBorderPanel = new System.Windows.Forms.Panel();
            this.BottomBorderPanel = new System.Windows.Forms.Panel();
            this.TopBorderPanel = new System.Windows.Forms.Panel();
            this.VoteTitle_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SpamVote_RadioButton = new System.Windows.Forms.RadioButton();
            this.OffensiveVote_RadioButton = new System.Windows.Forms.RadioButton();
            this.UserImage_RadioButton = new System.Windows.Forms.RadioButton();
            this.UserName_RadioButton = new System.Windows.Forms.RadioButton();
            this.OtherVote_RadioButton = new System.Windows.Forms.RadioButton();
            this.OtherVote_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SendVote_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeftBorderPanel
            // 
            this.LeftBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.LeftBorderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftBorderPanel.Name = "LeftBorderPanel";
            this.LeftBorderPanel.Size = new System.Drawing.Size(1, 330);
            this.LeftBorderPanel.TabIndex = 0;
            // 
            // RightBorderPanel
            // 
            this.RightBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.RightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBorderPanel.Location = new System.Drawing.Point(618, 0);
            this.RightBorderPanel.Name = "RightBorderPanel";
            this.RightBorderPanel.Size = new System.Drawing.Size(1, 330);
            this.RightBorderPanel.TabIndex = 1;
            // 
            // BottomBorderPanel
            // 
            this.BottomBorderPanel.AccessibleDescription = "";
            this.BottomBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.BottomBorderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorderPanel.Location = new System.Drawing.Point(1, 329);
            this.BottomBorderPanel.Name = "BottomBorderPanel";
            this.BottomBorderPanel.Size = new System.Drawing.Size(617, 1);
            this.BottomBorderPanel.TabIndex = 2;
            // 
            // TopBorderPanel
            // 
            this.TopBorderPanel.AccessibleDescription = "";
            this.TopBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.TopBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorderPanel.Location = new System.Drawing.Point(1, 0);
            this.TopBorderPanel.Name = "TopBorderPanel";
            this.TopBorderPanel.Size = new System.Drawing.Size(617, 1);
            this.TopBorderPanel.TabIndex = 3;
            // 
            // VoteTitle_Label
            // 
            this.VoteTitle_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.VoteTitle_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VoteTitle_Label.ForeColor = System.Drawing.Color.White;
            this.VoteTitle_Label.Location = new System.Drawing.Point(1, 1);
            this.VoteTitle_Label.Name = "VoteTitle_Label";
            this.VoteTitle_Label.Size = new System.Drawing.Size(617, 31);
            this.VoteTitle_Label.TabIndex = 4;
            this.VoteTitle_Label.Text = "Отправить жалобу на <пользователь>";
            this.VoteTitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Причина жалобы:";
            // 
            // SpamVote_RadioButton
            // 
            this.SpamVote_RadioButton.AutoSize = true;
            this.SpamVote_RadioButton.Checked = true;
            this.SpamVote_RadioButton.ForeColor = System.Drawing.Color.White;
            this.SpamVote_RadioButton.Location = new System.Drawing.Point(176, 55);
            this.SpamVote_RadioButton.Name = "SpamVote_RadioButton";
            this.SpamVote_RadioButton.Size = new System.Drawing.Size(119, 20);
            this.SpamVote_RadioButton.TabIndex = 1;
            this.SpamVote_RadioButton.TabStop = true;
            this.SpamVote_RadioButton.Text = "Спам/флуд/бот";
            this.SpamVote_RadioButton.UseVisualStyleBackColor = true;
            this.SpamVote_RadioButton.Click += new System.EventHandler(this.SpamVote_RadioButton_Click);
            // 
            // OffensiveVote_RadioButton
            // 
            this.OffensiveVote_RadioButton.AutoSize = true;
            this.OffensiveVote_RadioButton.ForeColor = System.Drawing.Color.White;
            this.OffensiveVote_RadioButton.Location = new System.Drawing.Point(176, 81);
            this.OffensiveVote_RadioButton.Name = "OffensiveVote_RadioButton";
            this.OffensiveVote_RadioButton.Size = new System.Drawing.Size(232, 20);
            this.OffensiveVote_RadioButton.TabIndex = 2;
            this.OffensiveVote_RadioButton.Text = "Оскорбления/нецензурная лексика";
            this.OffensiveVote_RadioButton.UseVisualStyleBackColor = true;
            this.OffensiveVote_RadioButton.Click += new System.EventHandler(this.OffensiveVote_RadioButton_Click);
            // 
            // UserImage_RadioButton
            // 
            this.UserImage_RadioButton.AutoSize = true;
            this.UserImage_RadioButton.ForeColor = System.Drawing.Color.White;
            this.UserImage_RadioButton.Location = new System.Drawing.Point(176, 107);
            this.UserImage_RadioButton.Name = "UserImage_RadioButton";
            this.UserImage_RadioButton.Size = new System.Drawing.Size(153, 20);
            this.UserImage_RadioButton.TabIndex = 3;
            this.UserImage_RadioButton.TabStop = true;
            this.UserImage_RadioButton.Text = "Содержание аватара";
            this.UserImage_RadioButton.UseVisualStyleBackColor = true;
            this.UserImage_RadioButton.Click += new System.EventHandler(this.UserImage_RadioButton_Click);
            // 
            // UserName_RadioButton
            // 
            this.UserName_RadioButton.AutoSize = true;
            this.UserName_RadioButton.ForeColor = System.Drawing.Color.White;
            this.UserName_RadioButton.Location = new System.Drawing.Point(176, 133);
            this.UserName_RadioButton.Name = "UserName_RadioButton";
            this.UserName_RadioButton.Size = new System.Drawing.Size(132, 20);
            this.UserName_RadioButton.TabIndex = 4;
            this.UserName_RadioButton.TabStop = true;
            this.UserName_RadioButton.Text = "Содержание ФИО";
            this.UserName_RadioButton.UseVisualStyleBackColor = true;
            this.UserName_RadioButton.Click += new System.EventHandler(this.UserName_RadioButton_Click);
            // 
            // OtherVote_RadioButton
            // 
            this.OtherVote_RadioButton.AutoSize = true;
            this.OtherVote_RadioButton.ForeColor = System.Drawing.Color.White;
            this.OtherVote_RadioButton.Location = new System.Drawing.Point(176, 159);
            this.OtherVote_RadioButton.Name = "OtherVote_RadioButton";
            this.OtherVote_RadioButton.Size = new System.Drawing.Size(120, 20);
            this.OtherVote_RadioButton.TabIndex = 5;
            this.OtherVote_RadioButton.TabStop = true;
            this.OtherVote_RadioButton.Text = "Другая причина:";
            this.OtherVote_RadioButton.UseVisualStyleBackColor = true;
            this.OtherVote_RadioButton.Click += new System.EventHandler(this.OtherVote_RadioButton_Click);
            // 
            // OtherVote_RichTextBox
            // 
            this.OtherVote_RichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.OtherVote_RichTextBox.Enabled = false;
            this.OtherVote_RichTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtherVote_RichTextBox.ForeColor = System.Drawing.Color.White;
            this.OtherVote_RichTextBox.Location = new System.Drawing.Point(176, 185);
            this.OtherVote_RichTextBox.Name = "OtherVote_RichTextBox";
            this.OtherVote_RichTextBox.Size = new System.Drawing.Size(274, 96);
            this.OtherVote_RichTextBox.TabIndex = 6;
            this.OtherVote_RichTextBox.Text = "";
            // 
            // SendVote_Button
            // 
            this.SendVote_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendVote_Button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendVote_Button.ForeColor = System.Drawing.Color.White;
            this.SendVote_Button.Location = new System.Drawing.Point(251, 287);
            this.SendVote_Button.Name = "SendVote_Button";
            this.SendVote_Button.Size = new System.Drawing.Size(199, 32);
            this.SendVote_Button.TabIndex = 7;
            this.SendVote_Button.Text = "Отправить жалобу";
            this.SendVote_Button.UseVisualStyleBackColor = true;
            this.SendVote_Button.Click += new System.EventHandler(this.SendVote_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.Location = new System.Drawing.Point(586, 2);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(32, 32);
            this.Close_Button.TabIndex = 8;
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // VoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(619, 330);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.SendVote_Button);
            this.Controls.Add(this.OtherVote_RichTextBox);
            this.Controls.Add(this.OtherVote_RadioButton);
            this.Controls.Add(this.UserName_RadioButton);
            this.Controls.Add(this.UserImage_RadioButton);
            this.Controls.Add(this.OffensiveVote_RadioButton);
            this.Controls.Add(this.SpamVote_RadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VoteTitle_Label);
            this.Controls.Add(this.TopBorderPanel);
            this.Controls.Add(this.BottomBorderPanel);
            this.Controls.Add(this.RightBorderPanel);
            this.Controls.Add(this.LeftBorderPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftBorderPanel;
        private System.Windows.Forms.Panel RightBorderPanel;
        private System.Windows.Forms.Panel BottomBorderPanel;
        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Label VoteTitle_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton SpamVote_RadioButton;
        private System.Windows.Forms.RadioButton OffensiveVote_RadioButton;
        private System.Windows.Forms.RadioButton UserImage_RadioButton;
        private System.Windows.Forms.RadioButton UserName_RadioButton;
        private System.Windows.Forms.RadioButton OtherVote_RadioButton;
        private System.Windows.Forms.RichTextBox OtherVote_RichTextBox;
        private System.Windows.Forms.Button SendVote_Button;
        private System.Windows.Forms.Button Close_Button;
    }
}