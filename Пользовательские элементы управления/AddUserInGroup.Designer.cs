
namespace Send.Пользовательские_элементы_управления
{
    partial class AddUserInGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserInGroup));
            this.Button_Back = new System.Windows.Forms.Button();
            this.Panel_Upper = new System.Windows.Forms.Panel();
            this.Panel_FriendsList = new System.Windows.Forms.Panel();
            this.Panel_Bottom = new System.Windows.Forms.Panel();
            this.Button_AddUser = new System.Windows.Forms.Button();
            this.Panel_Upper.SuspendLayout();
            this.Panel_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Back
            // 
            this.Button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Back.Image = ((System.Drawing.Image)(resources.GetObject("Button_Back.Image")));
            this.Button_Back.Location = new System.Drawing.Point(0, 0);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(65, 23);
            this.Button_Back.TabIndex = 0;
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Panel_Upper
            // 
            this.Panel_Upper.Controls.Add(this.Button_Back);
            this.Panel_Upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Upper.Location = new System.Drawing.Point(0, 0);
            this.Panel_Upper.Name = "Panel_Upper";
            this.Panel_Upper.Size = new System.Drawing.Size(350, 23);
            this.Panel_Upper.TabIndex = 1;
            // 
            // Panel_FriendsList
            // 
            this.Panel_FriendsList.AutoScroll = true;
            this.Panel_FriendsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_FriendsList.Location = new System.Drawing.Point(0, 23);
            this.Panel_FriendsList.Name = "Panel_FriendsList";
            this.Panel_FriendsList.Size = new System.Drawing.Size(350, 258);
            this.Panel_FriendsList.TabIndex = 2;
            // 
            // Panel_Bottom
            // 
            this.Panel_Bottom.Controls.Add(this.Button_AddUser);
            this.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Bottom.Location = new System.Drawing.Point(0, 281);
            this.Panel_Bottom.Name = "Panel_Bottom";
            this.Panel_Bottom.Size = new System.Drawing.Size(350, 35);
            this.Panel_Bottom.TabIndex = 3;
            // 
            // Button_AddUser
            // 
            this.Button_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_AddUser.Location = new System.Drawing.Point(195, 4);
            this.Button_AddUser.Name = "Button_AddUser";
            this.Button_AddUser.Size = new System.Drawing.Size(146, 25);
            this.Button_AddUser.TabIndex = 0;
            this.Button_AddUser.Text = "Добавить";
            this.Button_AddUser.UseVisualStyleBackColor = true;
            this.Button_AddUser.Click += new System.EventHandler(this.Button_AddUser_Click);
            // 
            // AddUserInGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.Panel_FriendsList);
            this.Controls.Add(this.Panel_Bottom);
            this.Controls.Add(this.Panel_Upper);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddUserInGroup";
            this.Size = new System.Drawing.Size(350, 316);
            this.Panel_Upper.ResumeLayout(false);
            this.Panel_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Panel Panel_Upper;
        private System.Windows.Forms.Panel Panel_FriendsList;
        private System.Windows.Forms.Panel Panel_Bottom;
        private System.Windows.Forms.Button Button_AddUser;
    }
}
