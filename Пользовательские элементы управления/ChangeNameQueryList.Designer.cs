
namespace Send.Пользовательские_элементы_управления
{
    partial class ChangeNameQueryList
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.ChangeNameQueryList_ListBox = new System.Windows.Forms.ListBox();
            this.Username_Textbox = new System.Windows.Forms.TextBox();
            this.RejectQuery_Button = new System.Windows.Forms.Button();
            this.ApplyQuery_Button = new System.Windows.Forms.Button();
            this.Username_Label = new System.Windows.Forms.Label();
            this.OldName_TextBox = new System.Windows.Forms.TextBox();
            this.OldName_Label = new System.Windows.Forms.Label();
            this.NewName_TextBox = new System.Windows.Forms.TextBox();
            this.NewName_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.ChangeNameQueryList_ListBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(415, 356);
            this.LeftPanel.TabIndex = 0;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.NewName_Label);
            this.CenterPanel.Controls.Add(this.OldName_Label);
            this.CenterPanel.Controls.Add(this.label3);
            this.CenterPanel.Controls.Add(this.Username_Label);
            this.CenterPanel.Controls.Add(this.NewName_TextBox);
            this.CenterPanel.Controls.Add(this.ApplyQuery_Button);
            this.CenterPanel.Controls.Add(this.OldName_TextBox);
            this.CenterPanel.Controls.Add(this.RejectQuery_Button);
            this.CenterPanel.Controls.Add(this.Username_Textbox);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(415, 0);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(415, 356);
            this.CenterPanel.TabIndex = 1;
            // 
            // ChangeNameQueryList_ListBox
            // 
            this.ChangeNameQueryList_ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.ChangeNameQueryList_ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeNameQueryList_ListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeNameQueryList_ListBox.ForeColor = System.Drawing.Color.White;
            this.ChangeNameQueryList_ListBox.FormattingEnabled = true;
            this.ChangeNameQueryList_ListBox.ItemHeight = 21;
            this.ChangeNameQueryList_ListBox.Location = new System.Drawing.Point(0, 0);
            this.ChangeNameQueryList_ListBox.Name = "ChangeNameQueryList_ListBox";
            this.ChangeNameQueryList_ListBox.Size = new System.Drawing.Size(415, 356);
            this.ChangeNameQueryList_ListBox.TabIndex = 0;
            this.ChangeNameQueryList_ListBox.SelectedIndexChanged += new System.EventHandler(this.ChangeNameQueryList_ListBox_SelectedIndexChanged);
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Username_Textbox.Enabled = false;
            this.Username_Textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Username_Textbox.ForeColor = System.Drawing.Color.White;
            this.Username_Textbox.Location = new System.Drawing.Point(10, 102);
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.Size = new System.Drawing.Size(370, 27);
            this.Username_Textbox.TabIndex = 0;
            // 
            // RejectQuery_Button
            // 
            this.RejectQuery_Button.FlatAppearance.BorderSize = 0;
            this.RejectQuery_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RejectQuery_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RejectQuery_Button.ForeColor = System.Drawing.Color.White;
            this.RejectQuery_Button.Location = new System.Drawing.Point(6, 312);
            this.RejectQuery_Button.Name = "RejectQuery_Button";
            this.RejectQuery_Button.Size = new System.Drawing.Size(189, 41);
            this.RejectQuery_Button.TabIndex = 1;
            this.RejectQuery_Button.Text = "Отклонить заявку";
            this.RejectQuery_Button.UseVisualStyleBackColor = true;
            // 
            // ApplyQuery_Button
            // 
            this.ApplyQuery_Button.FlatAppearance.BorderSize = 0;
            this.ApplyQuery_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyQuery_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyQuery_Button.ForeColor = System.Drawing.Color.White;
            this.ApplyQuery_Button.Location = new System.Drawing.Point(223, 312);
            this.ApplyQuery_Button.Name = "ApplyQuery_Button";
            this.ApplyQuery_Button.Size = new System.Drawing.Size(189, 41);
            this.ApplyQuery_Button.TabIndex = 1;
            this.ApplyQuery_Button.Text = "Одобрить заявку";
            this.ApplyQuery_Button.UseVisualStyleBackColor = true;
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Username_Label.ForeColor = System.Drawing.Color.White;
            this.Username_Label.Location = new System.Drawing.Point(6, 78);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(165, 21);
            this.Username_Label.TabIndex = 2;
            this.Username_Label.Text = "Логин пользователя";
            // 
            // OldName_TextBox
            // 
            this.OldName_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.OldName_TextBox.Enabled = false;
            this.OldName_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldName_TextBox.ForeColor = System.Drawing.Color.White;
            this.OldName_TextBox.Location = new System.Drawing.Point(10, 156);
            this.OldName_TextBox.Name = "OldName_TextBox";
            this.OldName_TextBox.Size = new System.Drawing.Size(370, 27);
            this.OldName_TextBox.TabIndex = 0;
            // 
            // OldName_Label
            // 
            this.OldName_Label.AutoSize = true;
            this.OldName_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldName_Label.ForeColor = System.Drawing.Color.White;
            this.OldName_Label.Location = new System.Drawing.Point(6, 132);
            this.OldName_Label.Name = "OldName_Label";
            this.OldName_Label.Size = new System.Drawing.Size(165, 21);
            this.OldName_Label.TabIndex = 2;
            this.OldName_Label.Text = "Логин пользователя";
            // 
            // NewName_TextBox
            // 
            this.NewName_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.NewName_TextBox.Enabled = false;
            this.NewName_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewName_TextBox.ForeColor = System.Drawing.Color.White;
            this.NewName_TextBox.Location = new System.Drawing.Point(10, 210);
            this.NewName_TextBox.Name = "NewName_TextBox";
            this.NewName_TextBox.Size = new System.Drawing.Size(370, 27);
            this.NewName_TextBox.TabIndex = 0;
            // 
            // NewName_Label
            // 
            this.NewName_Label.AutoSize = true;
            this.NewName_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewName_Label.ForeColor = System.Drawing.Color.White;
            this.NewName_Label.Location = new System.Drawing.Point(6, 186);
            this.NewName_Label.Name = "NewName_Label";
            this.NewName_Label.Size = new System.Drawing.Size(165, 21);
            this.NewName_Label.TabIndex = 2;
            this.NewName_Label.Text = "Логин пользователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Информация о запросе";
            // 
            // ChangeNameQueryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "ChangeNameQueryList";
            this.Size = new System.Drawing.Size(830, 356);
            this.LeftPanel.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            this.CenterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.ListBox ChangeNameQueryList_ListBox;
        private System.Windows.Forms.Label NewName_Label;
        private System.Windows.Forms.Label OldName_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.TextBox NewName_TextBox;
        private System.Windows.Forms.Button ApplyQuery_Button;
        private System.Windows.Forms.TextBox OldName_TextBox;
        private System.Windows.Forms.Button RejectQuery_Button;
        private System.Windows.Forms.TextBox Username_Textbox;
    }
}
