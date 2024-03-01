
namespace Send
{
    partial class ChangeNameList
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
            this.ChangesList_ListBox = new System.Windows.Forms.ListBox();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.ApplyQuery_Button = new System.Windows.Forms.Button();
            this.CancelQuery_Button = new System.Windows.Forms.Button();
            this.QueryNameNewPanel = new System.Windows.Forms.Panel();
            this.QueryNameOldPanel = new System.Windows.Forms.Panel();
            this.QueryUsernamePanel = new System.Windows.Forms.Panel();
            this.QueryDatePanel = new System.Windows.Forms.Panel();
            this.QueryNameNew_TextBox = new System.Windows.Forms.TextBox();
            this.QueryNameOld_TextBox = new System.Windows.Forms.TextBox();
            this.QueryUsername_TextBox = new System.Windows.Forms.TextBox();
            this.QueryDate_TextBox = new System.Windows.Forms.TextBox();
            this.QueryNameNew_Label = new System.Windows.Forms.Label();
            this.QueryNameOld_Label = new System.Windows.Forms.Label();
            this.QueryUsername_Label = new System.Windows.Forms.Label();
            this.QueryDate_Label = new System.Windows.Forms.Label();
            this.QueryInfo_Label = new System.Windows.Forms.Label();
            this.CenterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangesList_ListBox
            // 
            this.ChangesList_ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.ChangesList_ListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChangesList_ListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangesList_ListBox.ForeColor = System.Drawing.Color.White;
            this.ChangesList_ListBox.FormattingEnabled = true;
            this.ChangesList_ListBox.ItemHeight = 21;
            this.ChangesList_ListBox.Location = new System.Drawing.Point(0, 0);
            this.ChangesList_ListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangesList_ListBox.Name = "ChangesList_ListBox";
            this.ChangesList_ListBox.Size = new System.Drawing.Size(415, 363);
            this.ChangesList_ListBox.TabIndex = 0;
            this.ChangesList_ListBox.SelectedIndexChanged += new System.EventHandler(this.ChangesList_ListBox_SelectedIndexChanged);
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.ApplyQuery_Button);
            this.CenterPanel.Controls.Add(this.CancelQuery_Button);
            this.CenterPanel.Controls.Add(this.QueryNameNewPanel);
            this.CenterPanel.Controls.Add(this.QueryNameOldPanel);
            this.CenterPanel.Controls.Add(this.QueryUsernamePanel);
            this.CenterPanel.Controls.Add(this.QueryDatePanel);
            this.CenterPanel.Controls.Add(this.QueryNameNew_TextBox);
            this.CenterPanel.Controls.Add(this.QueryNameOld_TextBox);
            this.CenterPanel.Controls.Add(this.QueryUsername_TextBox);
            this.CenterPanel.Controls.Add(this.QueryDate_TextBox);
            this.CenterPanel.Controls.Add(this.QueryNameNew_Label);
            this.CenterPanel.Controls.Add(this.QueryNameOld_Label);
            this.CenterPanel.Controls.Add(this.QueryUsername_Label);
            this.CenterPanel.Controls.Add(this.QueryDate_Label);
            this.CenterPanel.Controls.Add(this.QueryInfo_Label);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(415, 0);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(415, 363);
            this.CenterPanel.TabIndex = 1;
            // 
            // ApplyQuery_Button
            // 
            this.ApplyQuery_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyQuery_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyQuery_Button.ForeColor = System.Drawing.Color.White;
            this.ApplyQuery_Button.Location = new System.Drawing.Point(208, 309);
            this.ApplyQuery_Button.Name = "ApplyQuery_Button";
            this.ApplyQuery_Button.Size = new System.Drawing.Size(192, 34);
            this.ApplyQuery_Button.TabIndex = 4;
            this.ApplyQuery_Button.Text = "Одобрить запрос";
            this.ApplyQuery_Button.UseVisualStyleBackColor = true;
            this.ApplyQuery_Button.Click += new System.EventHandler(this.ApplyQuery_Button_Click);
            // 
            // CancelQuery_Button
            // 
            this.CancelQuery_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelQuery_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelQuery_Button.ForeColor = System.Drawing.Color.White;
            this.CancelQuery_Button.Location = new System.Drawing.Point(10, 309);
            this.CancelQuery_Button.Name = "CancelQuery_Button";
            this.CancelQuery_Button.Size = new System.Drawing.Size(192, 34);
            this.CancelQuery_Button.TabIndex = 3;
            this.CancelQuery_Button.Text = "Отклонить запрос";
            this.CancelQuery_Button.UseVisualStyleBackColor = true;
            this.CancelQuery_Button.Click += new System.EventHandler(this.CancelQuery_Button_Click);
            // 
            // QueryNameNewPanel
            // 
            this.QueryNameNewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.QueryNameNewPanel.Location = new System.Drawing.Point(10, 283);
            this.QueryNameNewPanel.Name = "QueryNameNewPanel";
            this.QueryNameNewPanel.Size = new System.Drawing.Size(390, 1);
            this.QueryNameNewPanel.TabIndex = 2;
            // 
            // QueryNameOldPanel
            // 
            this.QueryNameOldPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.QueryNameOldPanel.Location = new System.Drawing.Point(10, 226);
            this.QueryNameOldPanel.Name = "QueryNameOldPanel";
            this.QueryNameOldPanel.Size = new System.Drawing.Size(390, 1);
            this.QueryNameOldPanel.TabIndex = 2;
            // 
            // QueryUsernamePanel
            // 
            this.QueryUsernamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.QueryUsernamePanel.Location = new System.Drawing.Point(10, 169);
            this.QueryUsernamePanel.Name = "QueryUsernamePanel";
            this.QueryUsernamePanel.Size = new System.Drawing.Size(390, 1);
            this.QueryUsernamePanel.TabIndex = 2;
            // 
            // QueryDatePanel
            // 
            this.QueryDatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.QueryDatePanel.Location = new System.Drawing.Point(10, 112);
            this.QueryDatePanel.Name = "QueryDatePanel";
            this.QueryDatePanel.Size = new System.Drawing.Size(390, 1);
            this.QueryDatePanel.TabIndex = 2;
            // 
            // QueryNameNew_TextBox
            // 
            this.QueryNameNew_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.QueryNameNew_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueryNameNew_TextBox.Enabled = false;
            this.QueryNameNew_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryNameNew_TextBox.ForeColor = System.Drawing.Color.White;
            this.QueryNameNew_TextBox.Location = new System.Drawing.Point(10, 264);
            this.QueryNameNew_TextBox.Name = "QueryNameNew_TextBox";
            this.QueryNameNew_TextBox.Size = new System.Drawing.Size(390, 20);
            this.QueryNameNew_TextBox.TabIndex = 1;
            // 
            // QueryNameOld_TextBox
            // 
            this.QueryNameOld_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.QueryNameOld_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueryNameOld_TextBox.Enabled = false;
            this.QueryNameOld_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryNameOld_TextBox.ForeColor = System.Drawing.Color.White;
            this.QueryNameOld_TextBox.Location = new System.Drawing.Point(10, 207);
            this.QueryNameOld_TextBox.Name = "QueryNameOld_TextBox";
            this.QueryNameOld_TextBox.Size = new System.Drawing.Size(390, 20);
            this.QueryNameOld_TextBox.TabIndex = 1;
            // 
            // QueryUsername_TextBox
            // 
            this.QueryUsername_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.QueryUsername_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueryUsername_TextBox.Enabled = false;
            this.QueryUsername_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryUsername_TextBox.ForeColor = System.Drawing.Color.White;
            this.QueryUsername_TextBox.Location = new System.Drawing.Point(10, 150);
            this.QueryUsername_TextBox.Name = "QueryUsername_TextBox";
            this.QueryUsername_TextBox.Size = new System.Drawing.Size(390, 20);
            this.QueryUsername_TextBox.TabIndex = 1;
            // 
            // QueryDate_TextBox
            // 
            this.QueryDate_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.QueryDate_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueryDate_TextBox.Enabled = false;
            this.QueryDate_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryDate_TextBox.ForeColor = System.Drawing.Color.White;
            this.QueryDate_TextBox.Location = new System.Drawing.Point(10, 93);
            this.QueryDate_TextBox.Name = "QueryDate_TextBox";
            this.QueryDate_TextBox.Size = new System.Drawing.Size(390, 20);
            this.QueryDate_TextBox.TabIndex = 1;
            // 
            // QueryNameNew_Label
            // 
            this.QueryNameNew_Label.AutoSize = true;
            this.QueryNameNew_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryNameNew_Label.ForeColor = System.Drawing.Color.White;
            this.QueryNameNew_Label.Location = new System.Drawing.Point(6, 240);
            this.QueryNameNew_Label.Name = "QueryNameNew_Label";
            this.QueryNameNew_Label.Size = new System.Drawing.Size(179, 21);
            this.QueryNameNew_Label.TabIndex = 0;
            this.QueryNameNew_Label.Text = "ФИО (новые данные)";
            // 
            // QueryNameOld_Label
            // 
            this.QueryNameOld_Label.AutoSize = true;
            this.QueryNameOld_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryNameOld_Label.ForeColor = System.Drawing.Color.White;
            this.QueryNameOld_Label.Location = new System.Drawing.Point(6, 183);
            this.QueryNameOld_Label.Name = "QueryNameOld_Label";
            this.QueryNameOld_Label.Size = new System.Drawing.Size(190, 21);
            this.QueryNameOld_Label.TabIndex = 0;
            this.QueryNameOld_Label.Text = "ФИО (старые данные)";
            // 
            // QueryUsername_Label
            // 
            this.QueryUsername_Label.AutoSize = true;
            this.QueryUsername_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryUsername_Label.ForeColor = System.Drawing.Color.White;
            this.QueryUsername_Label.Location = new System.Drawing.Point(6, 126);
            this.QueryUsername_Label.Name = "QueryUsername_Label";
            this.QueryUsername_Label.Size = new System.Drawing.Size(151, 21);
            this.QueryUsername_Label.TabIndex = 0;
            this.QueryUsername_Label.Text = "Имя пользователя";
            // 
            // QueryDate_Label
            // 
            this.QueryDate_Label.AutoSize = true;
            this.QueryDate_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryDate_Label.ForeColor = System.Drawing.Color.White;
            this.QueryDate_Label.Location = new System.Drawing.Point(6, 69);
            this.QueryDate_Label.Name = "QueryDate_Label";
            this.QueryDate_Label.Size = new System.Drawing.Size(202, 21);
            this.QueryDate_Label.TabIndex = 0;
            this.QueryDate_Label.Text = "Дата создания запроса";
            // 
            // QueryInfo_Label
            // 
            this.QueryInfo_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryInfo_Label.ForeColor = System.Drawing.Color.White;
            this.QueryInfo_Label.Location = new System.Drawing.Point(-1, 0);
            this.QueryInfo_Label.Name = "QueryInfo_Label";
            this.QueryInfo_Label.Size = new System.Drawing.Size(451, 21);
            this.QueryInfo_Label.TabIndex = 0;
            this.QueryInfo_Label.Text = "Информация о запросе";
            this.QueryInfo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeNameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.ChangesList_ListBox);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChangeNameList";
            this.Size = new System.Drawing.Size(830, 363);
            this.CenterPanel.ResumeLayout(false);
            this.CenterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ChangesList_ListBox;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Label QueryInfo_Label;
        private System.Windows.Forms.TextBox QueryNameNew_TextBox;
        private System.Windows.Forms.TextBox QueryNameOld_TextBox;
        private System.Windows.Forms.TextBox QueryUsername_TextBox;
        private System.Windows.Forms.TextBox QueryDate_TextBox;
        private System.Windows.Forms.Label QueryNameNew_Label;
        private System.Windows.Forms.Label QueryNameOld_Label;
        private System.Windows.Forms.Label QueryUsername_Label;
        private System.Windows.Forms.Label QueryDate_Label;
        private System.Windows.Forms.Panel QueryNameNewPanel;
        private System.Windows.Forms.Panel QueryNameOldPanel;
        private System.Windows.Forms.Panel QueryUsernamePanel;
        private System.Windows.Forms.Panel QueryDatePanel;
        private System.Windows.Forms.Button ApplyQuery_Button;
        private System.Windows.Forms.Button CancelQuery_Button;
    }
}
