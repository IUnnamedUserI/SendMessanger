
namespace Send.Пользовательские_элементы_управления
{
    partial class ModeratorScreen
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
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.Votes_Button = new System.Windows.Forms.Button();
            this.ChangeNames_Button = new System.Windows.Forms.Button();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.ChangeNameList_Panel = new Send.ChangeNameList();
            this.VoteList_Panel = new Send.Пользовательские_элементы_управления.VoteList();
            this.UpperPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.UpperPanel.Controls.Add(this.Votes_Button);
            this.UpperPanel.Controls.Add(this.ChangeNames_Button);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(830, 47);
            this.UpperPanel.TabIndex = 0;
            // 
            // Votes_Button
            // 
            this.Votes_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Votes_Button.FlatAppearance.BorderSize = 0;
            this.Votes_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Votes_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Votes_Button.ForeColor = System.Drawing.Color.White;
            this.Votes_Button.Location = new System.Drawing.Point(415, 0);
            this.Votes_Button.Name = "Votes_Button";
            this.Votes_Button.Size = new System.Drawing.Size(415, 47);
            this.Votes_Button.TabIndex = 1;
            this.Votes_Button.Text = "Жалобы";
            this.Votes_Button.UseVisualStyleBackColor = true;
            this.Votes_Button.Click += new System.EventHandler(this.Votes_Button_Click);
            // 
            // ChangeNames_Button
            // 
            this.ChangeNames_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChangeNames_Button.FlatAppearance.BorderSize = 0;
            this.ChangeNames_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeNames_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeNames_Button.ForeColor = System.Drawing.Color.White;
            this.ChangeNames_Button.Location = new System.Drawing.Point(0, 0);
            this.ChangeNames_Button.Name = "ChangeNames_Button";
            this.ChangeNames_Button.Size = new System.Drawing.Size(415, 47);
            this.ChangeNames_Button.TabIndex = 0;
            this.ChangeNames_Button.Text = "Запросы на смену имени";
            this.ChangeNames_Button.UseVisualStyleBackColor = true;
            this.ChangeNames_Button.Click += new System.EventHandler(this.ChangeNames_Button_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.VoteList_Panel);
            this.CenterPanel.Controls.Add(this.ChangeNameList_Panel);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(0, 47);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(830, 356);
            this.CenterPanel.TabIndex = 1;
            // 
            // ChangeNameList_Panel
            // 
            this.ChangeNameList_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.ChangeNameList_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeNameList_Panel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeNameList_Panel.Location = new System.Drawing.Point(0, 0);
            this.ChangeNameList_Panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeNameList_Panel.Name = "ChangeNameList_Panel";
            this.ChangeNameList_Panel.Size = new System.Drawing.Size(830, 356);
            this.ChangeNameList_Panel.TabIndex = 0;
            // 
            // VoteList_Panel
            // 
            this.VoteList_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.VoteList_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VoteList_Panel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VoteList_Panel.Location = new System.Drawing.Point(0, 0);
            this.VoteList_Panel.Margin = new System.Windows.Forms.Padding(5);
            this.VoteList_Panel.Name = "VoteList_Panel";
            this.VoteList_Panel.Size = new System.Drawing.Size(830, 356);
            this.VoteList_Panel.TabIndex = 1;
            // 
            // ModeratorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.UpperPanel);
            this.Name = "ModeratorScreen";
            this.Size = new System.Drawing.Size(830, 403);
            this.UpperPanel.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Button Votes_Button;
        private System.Windows.Forms.Button ChangeNames_Button;
        private System.Windows.Forms.Panel CenterPanel;
        private ChangeNameList ChangeNameList_Panel;
        private VoteList VoteList_Panel;
    }
}
