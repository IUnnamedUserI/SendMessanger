
namespace Send.Пользовательские_элементы_управления
{
    partial class GroupPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupPanel));
            this.UpperGroupPanel = new System.Windows.Forms.Panel();
            this.EditGroup_Button = new System.Windows.Forms.Button();
            this.HideGroupPanel_Button = new System.Windows.Forms.Button();
            this.CurrentGroupTitle_Label = new System.Windows.Forms.Label();
            this.CurrentGroupPicture = new System.Windows.Forms.PictureBox();
            this.GroupMessagesPanel = new System.Windows.Forms.Panel();
            this.AddedGroupContentPanel = new System.Windows.Forms.Panel();
            this.BottomGroupPanel = new System.Windows.Forms.Panel();
            this.GroupMessage_TextBox = new System.Windows.Forms.TextBox();
            this.GroupLengthCount_Label = new System.Windows.Forms.Label();
            this.GroupAddFile_Button = new System.Windows.Forms.Button();
            this.SendGroupMessage_Button = new System.Windows.Forms.Button();
            this.AddFile_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.UpperGroupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentGroupPicture)).BeginInit();
            this.BottomGroupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpperGroupPanel
            // 
            this.UpperGroupPanel.Controls.Add(this.EditGroup_Button);
            this.UpperGroupPanel.Controls.Add(this.HideGroupPanel_Button);
            this.UpperGroupPanel.Controls.Add(this.CurrentGroupTitle_Label);
            this.UpperGroupPanel.Controls.Add(this.CurrentGroupPicture);
            this.UpperGroupPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperGroupPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperGroupPanel.Name = "UpperGroupPanel";
            this.UpperGroupPanel.Size = new System.Drawing.Size(577, 32);
            this.UpperGroupPanel.TabIndex = 2;
            // 
            // EditGroup_Button
            // 
            this.EditGroup_Button.FlatAppearance.BorderSize = 0;
            this.EditGroup_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditGroup_Button.Image = ((System.Drawing.Image)(resources.GetObject("EditGroup_Button.Image")));
            this.EditGroup_Button.Location = new System.Drawing.Point(502, 0);
            this.EditGroup_Button.Name = "EditGroup_Button";
            this.EditGroup_Button.Size = new System.Drawing.Size(32, 32);
            this.EditGroup_Button.TabIndex = 4;
            this.EditGroup_Button.UseVisualStyleBackColor = true;
            this.EditGroup_Button.Click += new System.EventHandler(this.EditGroup_Button_Click);
            // 
            // HideGroupPanel_Button
            // 
            this.HideGroupPanel_Button.FlatAppearance.BorderSize = 0;
            this.HideGroupPanel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideGroupPanel_Button.Image = ((System.Drawing.Image)(resources.GetObject("HideGroupPanel_Button.Image")));
            this.HideGroupPanel_Button.Location = new System.Drawing.Point(540, 0);
            this.HideGroupPanel_Button.Name = "HideGroupPanel_Button";
            this.HideGroupPanel_Button.Size = new System.Drawing.Size(32, 32);
            this.HideGroupPanel_Button.TabIndex = 3;
            this.HideGroupPanel_Button.UseVisualStyleBackColor = true;
            this.HideGroupPanel_Button.Click += new System.EventHandler(this.HideGroupPanel_Button_Click);
            // 
            // CurrentGroupTitle_Label
            // 
            this.CurrentGroupTitle_Label.AutoSize = true;
            this.CurrentGroupTitle_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentGroupTitle_Label.ForeColor = System.Drawing.Color.White;
            this.CurrentGroupTitle_Label.Location = new System.Drawing.Point(53, 6);
            this.CurrentGroupTitle_Label.Name = "CurrentGroupTitle_Label";
            this.CurrentGroupTitle_Label.Size = new System.Drawing.Size(177, 20);
            this.CurrentGroupTitle_Label.TabIndex = 2;
            this.CurrentGroupTitle_Label.Text = "Название обсуждения";
            // 
            // CurrentGroupPicture
            // 
            this.CurrentGroupPicture.Location = new System.Drawing.Point(19, 0);
            this.CurrentGroupPicture.Name = "CurrentGroupPicture";
            this.CurrentGroupPicture.Size = new System.Drawing.Size(32, 32);
            this.CurrentGroupPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CurrentGroupPicture.TabIndex = 2;
            this.CurrentGroupPicture.TabStop = false;
            // 
            // GroupMessagesPanel
            // 
            this.GroupMessagesPanel.AutoScroll = true;
            this.GroupMessagesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupMessagesPanel.Location = new System.Drawing.Point(0, 123);
            this.GroupMessagesPanel.Name = "GroupMessagesPanel";
            this.GroupMessagesPanel.Size = new System.Drawing.Size(577, 208);
            this.GroupMessagesPanel.TabIndex = 7;
            // 
            // AddedGroupContentPanel
            // 
            this.AddedGroupContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddedGroupContentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddedGroupContentPanel.Location = new System.Drawing.Point(0, 73);
            this.AddedGroupContentPanel.Name = "AddedGroupContentPanel";
            this.AddedGroupContentPanel.Size = new System.Drawing.Size(577, 50);
            this.AddedGroupContentPanel.TabIndex = 5;
            this.AddedGroupContentPanel.Visible = false;
            // 
            // BottomGroupPanel
            // 
            this.BottomGroupPanel.Controls.Add(this.GroupMessage_TextBox);
            this.BottomGroupPanel.Controls.Add(this.GroupLengthCount_Label);
            this.BottomGroupPanel.Controls.Add(this.GroupAddFile_Button);
            this.BottomGroupPanel.Controls.Add(this.SendGroupMessage_Button);
            this.BottomGroupPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BottomGroupPanel.Location = new System.Drawing.Point(0, 32);
            this.BottomGroupPanel.Name = "BottomGroupPanel";
            this.BottomGroupPanel.Size = new System.Drawing.Size(577, 41);
            this.BottomGroupPanel.TabIndex = 6;
            // 
            // GroupMessage_TextBox
            // 
            this.GroupMessage_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GroupMessage_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.GroupMessage_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupMessage_TextBox.ForeColor = System.Drawing.Color.White;
            this.GroupMessage_TextBox.Location = new System.Drawing.Point(38, 2);
            this.GroupMessage_TextBox.MaxLength = 500;
            this.GroupMessage_TextBox.Name = "GroupMessage_TextBox";
            this.GroupMessage_TextBox.Size = new System.Drawing.Size(496, 27);
            this.GroupMessage_TextBox.TabIndex = 0;
            // 
            // GroupLengthCount_Label
            // 
            this.GroupLengthCount_Label.AutoSize = true;
            this.GroupLengthCount_Label.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLengthCount_Label.ForeColor = System.Drawing.Color.LightGray;
            this.GroupLengthCount_Label.Location = new System.Drawing.Point(41, 28);
            this.GroupLengthCount_Label.Name = "GroupLengthCount_Label";
            this.GroupLengthCount_Label.Size = new System.Drawing.Size(31, 13);
            this.GroupLengthCount_Label.TabIndex = 3;
            this.GroupLengthCount_Label.Text = "0/500";
            this.GroupLengthCount_Label.Visible = false;
            // 
            // GroupAddFile_Button
            // 
            this.GroupAddFile_Button.FlatAppearance.BorderSize = 0;
            this.GroupAddFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupAddFile_Button.Image = ((System.Drawing.Image)(resources.GetObject("GroupAddFile_Button.Image")));
            this.GroupAddFile_Button.Location = new System.Drawing.Point(3, 0);
            this.GroupAddFile_Button.Name = "GroupAddFile_Button";
            this.GroupAddFile_Button.Size = new System.Drawing.Size(32, 32);
            this.GroupAddFile_Button.TabIndex = 2;
            this.GroupAddFile_Button.UseVisualStyleBackColor = true;
            this.GroupAddFile_Button.Click += new System.EventHandler(this.GroupAddFile_Button_Click);
            // 
            // SendGroupMessage_Button
            // 
            this.SendGroupMessage_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendGroupMessage_Button.FlatAppearance.BorderSize = 0;
            this.SendGroupMessage_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendGroupMessage_Button.Image = ((System.Drawing.Image)(resources.GetObject("SendGroupMessage_Button.Image")));
            this.SendGroupMessage_Button.Location = new System.Drawing.Point(540, 0);
            this.SendGroupMessage_Button.Name = "SendGroupMessage_Button";
            this.SendGroupMessage_Button.Size = new System.Drawing.Size(32, 32);
            this.SendGroupMessage_Button.TabIndex = 1;
            this.SendGroupMessage_Button.UseVisualStyleBackColor = true;
            this.SendGroupMessage_Button.Click += new System.EventHandler(this.SendGroupMessage_Button_Click);
            // 
            // AddFile_OpenFileDialog
            // 
            this.AddFile_OpenFileDialog.FileName = "NewFile";
            // 
            // GroupPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.GroupMessagesPanel);
            this.Controls.Add(this.AddedGroupContentPanel);
            this.Controls.Add(this.BottomGroupPanel);
            this.Controls.Add(this.UpperGroupPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GroupPanel";
            this.Size = new System.Drawing.Size(577, 331);
            this.UpperGroupPanel.ResumeLayout(false);
            this.UpperGroupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentGroupPicture)).EndInit();
            this.BottomGroupPanel.ResumeLayout(false);
            this.BottomGroupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperGroupPanel;
        private System.Windows.Forms.Button HideGroupPanel_Button;
        private System.Windows.Forms.Label CurrentGroupTitle_Label;
        private System.Windows.Forms.PictureBox CurrentGroupPicture;
        private System.Windows.Forms.Panel GroupMessagesPanel;
        private System.Windows.Forms.Panel AddedGroupContentPanel;
        private System.Windows.Forms.Panel BottomGroupPanel;
        private System.Windows.Forms.TextBox GroupMessage_TextBox;
        private System.Windows.Forms.Label GroupLengthCount_Label;
        private System.Windows.Forms.Button GroupAddFile_Button;
        private System.Windows.Forms.Button SendGroupMessage_Button;
        private System.Windows.Forms.Button EditGroup_Button;
        private System.Windows.Forms.OpenFileDialog AddFile_OpenFileDialog;
    }
}
