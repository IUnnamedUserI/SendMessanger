
namespace Send.Пользовательские_элементы_управления
{
    partial class ChangeGroupSettings
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
            this.Panel_Upper = new System.Windows.Forms.Panel();
            this.Button_UsersList = new System.Windows.Forms.Button();
            this.Button_GroupSettings = new System.Windows.Forms.Button();
            this.Panel_UsersList = new System.Windows.Forms.Panel();
            this.Panel_ListOfUsers = new System.Windows.Forms.Panel();
            this.Panel_Border2 = new System.Windows.Forms.Panel();
            this.Button_AddNewUser = new System.Windows.Forms.Button();
            this.Panel_Border = new System.Windows.Forms.Panel();
            this.Label_Description = new System.Windows.Forms.Label();
            this.Panel_Bottom = new System.Windows.Forms.Panel();
            this.Button_CloseForm = new System.Windows.Forms.Button();
            this.Panel_EditGroupSettings = new System.Windows.Forms.Panel();
            this.Button_LeaveGroup = new System.Windows.Forms.Button();
            this.Button_DeleteGroup = new System.Windows.Forms.Button();
            this.Button_DeleteGroupImage = new System.Windows.Forms.Button();
            this.Button_ChangeGroupImage = new System.Windows.Forms.Button();
            this.Panel_TextBox = new System.Windows.Forms.Panel();
            this.TextBox_GroupTitle = new System.Windows.Forms.TextBox();
            this.PictureBox_GroupImage = new System.Windows.Forms.PictureBox();
            this.Button_CancelChanges = new System.Windows.Forms.Button();
            this.Button_SaveChanges = new System.Windows.Forms.Button();
            this.Label_GroupImage = new System.Windows.Forms.Label();
            this.Label_GroupTitle = new System.Windows.Forms.Label();
            this.OpenFileDialog_ChangeImage = new System.Windows.Forms.OpenFileDialog();
            this.AddUserInGroup = new Send.Пользовательские_элементы_управления.AddUserInGroup();
            this.Panel_Upper.SuspendLayout();
            this.Panel_UsersList.SuspendLayout();
            this.Panel_ListOfUsers.SuspendLayout();
            this.Panel_Bottom.SuspendLayout();
            this.Panel_EditGroupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_GroupImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Upper
            // 
            this.Panel_Upper.Controls.Add(this.Button_UsersList);
            this.Panel_Upper.Controls.Add(this.Button_GroupSettings);
            this.Panel_Upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Upper.Location = new System.Drawing.Point(0, 0);
            this.Panel_Upper.Name = "Panel_Upper";
            this.Panel_Upper.Size = new System.Drawing.Size(350, 40);
            this.Panel_Upper.TabIndex = 0;
            // 
            // Button_UsersList
            // 
            this.Button_UsersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_UsersList.FlatAppearance.BorderSize = 0;
            this.Button_UsersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_UsersList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_UsersList.ForeColor = System.Drawing.Color.White;
            this.Button_UsersList.Location = new System.Drawing.Point(175, 0);
            this.Button_UsersList.Name = "Button_UsersList";
            this.Button_UsersList.Size = new System.Drawing.Size(175, 40);
            this.Button_UsersList.TabIndex = 1;
            this.Button_UsersList.Text = "Список участников";
            this.Button_UsersList.UseVisualStyleBackColor = true;
            this.Button_UsersList.Click += new System.EventHandler(this.Button_UsersList_Click);
            // 
            // Button_GroupSettings
            // 
            this.Button_GroupSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_GroupSettings.FlatAppearance.BorderSize = 0;
            this.Button_GroupSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_GroupSettings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_GroupSettings.ForeColor = System.Drawing.Color.White;
            this.Button_GroupSettings.Location = new System.Drawing.Point(0, 0);
            this.Button_GroupSettings.Name = "Button_GroupSettings";
            this.Button_GroupSettings.Size = new System.Drawing.Size(175, 40);
            this.Button_GroupSettings.TabIndex = 0;
            this.Button_GroupSettings.Text = "Настройки обсуждения";
            this.Button_GroupSettings.UseVisualStyleBackColor = true;
            this.Button_GroupSettings.Click += new System.EventHandler(this.Button_GroupSettings_Click);
            // 
            // Panel_UsersList
            // 
            this.Panel_UsersList.Controls.Add(this.Panel_ListOfUsers);
            this.Panel_UsersList.Controls.Add(this.Panel_Border2);
            this.Panel_UsersList.Controls.Add(this.Button_AddNewUser);
            this.Panel_UsersList.Controls.Add(this.Panel_Border);
            this.Panel_UsersList.Controls.Add(this.Label_Description);
            this.Panel_UsersList.Controls.Add(this.Panel_Bottom);
            this.Panel_UsersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_UsersList.Location = new System.Drawing.Point(0, 0);
            this.Panel_UsersList.Name = "Panel_UsersList";
            this.Panel_UsersList.Size = new System.Drawing.Size(350, 450);
            this.Panel_UsersList.TabIndex = 1;
            // 
            // Panel_ListOfUsers
            // 
            this.Panel_ListOfUsers.AutoScroll = true;
            this.Panel_ListOfUsers.Controls.Add(this.AddUserInGroup);
            this.Panel_ListOfUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_ListOfUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Panel_ListOfUsers.ForeColor = System.Drawing.Color.White;
            this.Panel_ListOfUsers.Location = new System.Drawing.Point(0, 84);
            this.Panel_ListOfUsers.Name = "Panel_ListOfUsers";
            this.Panel_ListOfUsers.Size = new System.Drawing.Size(350, 316);
            this.Panel_ListOfUsers.TabIndex = 3;
            // 
            // Panel_Border2
            // 
            this.Panel_Border2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.Panel_Border2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Border2.Location = new System.Drawing.Point(0, 83);
            this.Panel_Border2.Name = "Panel_Border2";
            this.Panel_Border2.Size = new System.Drawing.Size(350, 1);
            this.Panel_Border2.TabIndex = 3;
            // 
            // Button_AddNewUser
            // 
            this.Button_AddNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_AddNewUser.FlatAppearance.BorderSize = 0;
            this.Button_AddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddNewUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_AddNewUser.ForeColor = System.Drawing.Color.White;
            this.Button_AddNewUser.Location = new System.Drawing.Point(0, 46);
            this.Button_AddNewUser.Name = "Button_AddNewUser";
            this.Button_AddNewUser.Size = new System.Drawing.Size(350, 37);
            this.Button_AddNewUser.TabIndex = 0;
            this.Button_AddNewUser.Text = "Добавить нового участника";
            this.Button_AddNewUser.UseVisualStyleBackColor = true;
            this.Button_AddNewUser.Click += new System.EventHandler(this.Button_AddNewUser_Click);
            // 
            // Panel_Border
            // 
            this.Panel_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.Panel_Border.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Border.Location = new System.Drawing.Point(0, 45);
            this.Panel_Border.Name = "Panel_Border";
            this.Panel_Border.Size = new System.Drawing.Size(350, 1);
            this.Panel_Border.TabIndex = 2;
            // 
            // Label_Description
            // 
            this.Label_Description.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Description.ForeColor = System.Drawing.Color.White;
            this.Label_Description.Location = new System.Drawing.Point(0, 0);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(350, 45);
            this.Label_Description.TabIndex = 1;
            this.Label_Description.Text = "Список участников";
            this.Label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Bottom
            // 
            this.Panel_Bottom.AutoScroll = true;
            this.Panel_Bottom.Controls.Add(this.Button_CloseForm);
            this.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Bottom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Panel_Bottom.ForeColor = System.Drawing.Color.White;
            this.Panel_Bottom.Location = new System.Drawing.Point(0, 400);
            this.Panel_Bottom.Name = "Panel_Bottom";
            this.Panel_Bottom.Size = new System.Drawing.Size(350, 50);
            this.Panel_Bottom.TabIndex = 4;
            // 
            // Button_CloseForm
            // 
            this.Button_CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CloseForm.Location = new System.Drawing.Point(203, 8);
            this.Button_CloseForm.Name = "Button_CloseForm";
            this.Button_CloseForm.Size = new System.Drawing.Size(143, 32);
            this.Button_CloseForm.TabIndex = 0;
            this.Button_CloseForm.Text = "Закрыть";
            this.Button_CloseForm.UseVisualStyleBackColor = true;
            this.Button_CloseForm.Click += new System.EventHandler(this.Button_CloseForm_Click);
            // 
            // Panel_EditGroupSettings
            // 
            this.Panel_EditGroupSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_EditGroupSettings.Controls.Add(this.Button_LeaveGroup);
            this.Panel_EditGroupSettings.Controls.Add(this.Button_DeleteGroup);
            this.Panel_EditGroupSettings.Controls.Add(this.Button_DeleteGroupImage);
            this.Panel_EditGroupSettings.Controls.Add(this.Button_ChangeGroupImage);
            this.Panel_EditGroupSettings.Controls.Add(this.Panel_TextBox);
            this.Panel_EditGroupSettings.Controls.Add(this.TextBox_GroupTitle);
            this.Panel_EditGroupSettings.Controls.Add(this.PictureBox_GroupImage);
            this.Panel_EditGroupSettings.Controls.Add(this.Button_CancelChanges);
            this.Panel_EditGroupSettings.Controls.Add(this.Button_SaveChanges);
            this.Panel_EditGroupSettings.Controls.Add(this.Label_GroupImage);
            this.Panel_EditGroupSettings.Controls.Add(this.Label_GroupTitle);
            this.Panel_EditGroupSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_EditGroupSettings.Location = new System.Drawing.Point(0, 40);
            this.Panel_EditGroupSettings.Name = "Panel_EditGroupSettings";
            this.Panel_EditGroupSettings.Size = new System.Drawing.Size(350, 410);
            this.Panel_EditGroupSettings.TabIndex = 0;
            // 
            // Button_LeaveGroup
            // 
            this.Button_LeaveGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_LeaveGroup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_LeaveGroup.ForeColor = System.Drawing.Color.White;
            this.Button_LeaveGroup.Location = new System.Drawing.Point(12, 369);
            this.Button_LeaveGroup.Name = "Button_LeaveGroup";
            this.Button_LeaveGroup.Size = new System.Drawing.Size(163, 33);
            this.Button_LeaveGroup.TabIndex = 8;
            this.Button_LeaveGroup.Text = "Покинуть обсуждение";
            this.Button_LeaveGroup.UseVisualStyleBackColor = true;
            this.Button_LeaveGroup.Click += new System.EventHandler(this.Button_LeaveGroup_Click);
            // 
            // Button_DeleteGroup
            // 
            this.Button_DeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DeleteGroup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_DeleteGroup.ForeColor = System.Drawing.Color.White;
            this.Button_DeleteGroup.Location = new System.Drawing.Point(181, 369);
            this.Button_DeleteGroup.Name = "Button_DeleteGroup";
            this.Button_DeleteGroup.Size = new System.Drawing.Size(157, 33);
            this.Button_DeleteGroup.TabIndex = 7;
            this.Button_DeleteGroup.Text = "Удалить обсуждение";
            this.Button_DeleteGroup.UseVisualStyleBackColor = true;
            this.Button_DeleteGroup.Click += new System.EventHandler(this.Button_DeleteGroup_Click);
            // 
            // Button_DeleteGroupImage
            // 
            this.Button_DeleteGroupImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DeleteGroupImage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_DeleteGroupImage.ForeColor = System.Drawing.Color.White;
            this.Button_DeleteGroupImage.Location = new System.Drawing.Point(193, 147);
            this.Button_DeleteGroupImage.Name = "Button_DeleteGroupImage";
            this.Button_DeleteGroupImage.Size = new System.Drawing.Size(99, 23);
            this.Button_DeleteGroupImage.TabIndex = 6;
            this.Button_DeleteGroupImage.Text = "Удалить";
            this.Button_DeleteGroupImage.UseVisualStyleBackColor = true;
            this.Button_DeleteGroupImage.Click += new System.EventHandler(this.Button_DeleteGroupImage_Click);
            // 
            // Button_ChangeGroupImage
            // 
            this.Button_ChangeGroupImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ChangeGroupImage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ChangeGroupImage.ForeColor = System.Drawing.Color.White;
            this.Button_ChangeGroupImage.Location = new System.Drawing.Point(193, 118);
            this.Button_ChangeGroupImage.Name = "Button_ChangeGroupImage";
            this.Button_ChangeGroupImage.Size = new System.Drawing.Size(99, 23);
            this.Button_ChangeGroupImage.TabIndex = 6;
            this.Button_ChangeGroupImage.Text = "Изменить";
            this.Button_ChangeGroupImage.UseVisualStyleBackColor = true;
            this.Button_ChangeGroupImage.Click += new System.EventHandler(this.Button_ChangeGroupImage_Click);
            // 
            // Panel_TextBox
            // 
            this.Panel_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.Panel_TextBox.Location = new System.Drawing.Point(37, 83);
            this.Panel_TextBox.Name = "Panel_TextBox";
            this.Panel_TextBox.Size = new System.Drawing.Size(272, 1);
            this.Panel_TextBox.TabIndex = 5;
            // 
            // TextBox_GroupTitle
            // 
            this.TextBox_GroupTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.TextBox_GroupTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_GroupTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_GroupTitle.ForeColor = System.Drawing.Color.White;
            this.TextBox_GroupTitle.Location = new System.Drawing.Point(37, 68);
            this.TextBox_GroupTitle.Name = "TextBox_GroupTitle";
            this.TextBox_GroupTitle.Size = new System.Drawing.Size(272, 16);
            this.TextBox_GroupTitle.TabIndex = 4;
            // 
            // PictureBox_GroupImage
            // 
            this.PictureBox_GroupImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_GroupImage.Location = new System.Drawing.Point(37, 118);
            this.PictureBox_GroupImage.Name = "PictureBox_GroupImage";
            this.PictureBox_GroupImage.Size = new System.Drawing.Size(150, 150);
            this.PictureBox_GroupImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_GroupImage.TabIndex = 3;
            this.PictureBox_GroupImage.TabStop = false;
            // 
            // Button_CancelChanges
            // 
            this.Button_CancelChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CancelChanges.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_CancelChanges.ForeColor = System.Drawing.Color.White;
            this.Button_CancelChanges.Location = new System.Drawing.Point(181, 330);
            this.Button_CancelChanges.Name = "Button_CancelChanges";
            this.Button_CancelChanges.Size = new System.Drawing.Size(157, 33);
            this.Button_CancelChanges.TabIndex = 2;
            this.Button_CancelChanges.Text = "Отменить";
            this.Button_CancelChanges.UseVisualStyleBackColor = true;
            this.Button_CancelChanges.Click += new System.EventHandler(this.Button_CancelChanges_Click);
            // 
            // Button_SaveChanges
            // 
            this.Button_SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SaveChanges.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_SaveChanges.ForeColor = System.Drawing.Color.White;
            this.Button_SaveChanges.Location = new System.Drawing.Point(12, 330);
            this.Button_SaveChanges.Name = "Button_SaveChanges";
            this.Button_SaveChanges.Size = new System.Drawing.Size(163, 33);
            this.Button_SaveChanges.TabIndex = 2;
            this.Button_SaveChanges.Text = "Сохранить";
            this.Button_SaveChanges.UseVisualStyleBackColor = true;
            this.Button_SaveChanges.Click += new System.EventHandler(this.Button_SaveChanges_Click);
            // 
            // Label_GroupImage
            // 
            this.Label_GroupImage.AutoSize = true;
            this.Label_GroupImage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_GroupImage.ForeColor = System.Drawing.Color.White;
            this.Label_GroupImage.Location = new System.Drawing.Point(34, 98);
            this.Label_GroupImage.Name = "Label_GroupImage";
            this.Label_GroupImage.Size = new System.Drawing.Size(101, 17);
            this.Label_GroupImage.TabIndex = 1;
            this.Label_GroupImage.Text = "Изображение";
            // 
            // Label_GroupTitle
            // 
            this.Label_GroupTitle.AutoSize = true;
            this.Label_GroupTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_GroupTitle.ForeColor = System.Drawing.Color.White;
            this.Label_GroupTitle.Location = new System.Drawing.Point(34, 45);
            this.Label_GroupTitle.Name = "Label_GroupTitle";
            this.Label_GroupTitle.Size = new System.Drawing.Size(154, 17);
            this.Label_GroupTitle.TabIndex = 0;
            this.Label_GroupTitle.Text = "Название обсуждения";
            // 
            // OpenFileDialog_ChangeImage
            // 
            this.OpenFileDialog_ChangeImage.Filter = "PNG-Файл|*.png|JPG-Файл|*.jpg|JPEG-Файл|*.jpeg|Все файлы|*.*";
            // 
            // AddUserInGroup
            // 
            this.AddUserInGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.AddUserInGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddUserInGroup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserInGroup.ForeColor = System.Drawing.Color.White;
            this.AddUserInGroup.Location = new System.Drawing.Point(0, 0);
            this.AddUserInGroup.Margin = new System.Windows.Forms.Padding(5);
            this.AddUserInGroup.Name = "AddUserInGroup";
            this.AddUserInGroup.Size = new System.Drawing.Size(350, 316);
            this.AddUserInGroup.TabIndex = 0;
            this.AddUserInGroup.Visible = false;
            // 
            // ChangeGroupSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.Panel_EditGroupSettings);
            this.Controls.Add(this.Panel_Upper);
            this.Controls.Add(this.Panel_UsersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeGroupSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeGroupSettings";
            this.Panel_Upper.ResumeLayout(false);
            this.Panel_UsersList.ResumeLayout(false);
            this.Panel_ListOfUsers.ResumeLayout(false);
            this.Panel_Bottom.ResumeLayout(false);
            this.Panel_EditGroupSettings.ResumeLayout(false);
            this.Panel_EditGroupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_GroupImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Upper;
        private System.Windows.Forms.Button Button_UsersList;
        private System.Windows.Forms.Button Button_GroupSettings;
        private System.Windows.Forms.Panel Panel_UsersList;
        private System.Windows.Forms.Panel Panel_EditGroupSettings;
        private System.Windows.Forms.Label Label_GroupImage;
        private System.Windows.Forms.Label Label_GroupTitle;
        private System.Windows.Forms.Button Button_DeleteGroupImage;
        private System.Windows.Forms.Button Button_ChangeGroupImage;
        private System.Windows.Forms.Panel Panel_TextBox;
        private System.Windows.Forms.TextBox TextBox_GroupTitle;
        private System.Windows.Forms.PictureBox PictureBox_GroupImage;
        private System.Windows.Forms.Button Button_CancelChanges;
        private System.Windows.Forms.Button Button_SaveChanges;
        private System.Windows.Forms.Button Button_DeleteGroup;
        private System.Windows.Forms.Panel Panel_Border;
        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.Button Button_AddNewUser;
        private System.Windows.Forms.Panel Panel_ListOfUsers;
        private System.Windows.Forms.Panel Panel_Border2;
        private System.Windows.Forms.Panel Panel_Bottom;
        private System.Windows.Forms.Button Button_CloseForm;
        private System.Windows.Forms.Button Button_LeaveGroup;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_ChangeImage;
        private AddUserInGroup AddUserInGroup;
    }
}