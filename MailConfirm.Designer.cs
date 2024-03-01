
namespace Send.Пользовательские_элементы_управления
{
    partial class MailConfirm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Code_TextBox = new System.Windows.Forms.TextBox();
            this.Code_Label = new System.Windows.Forms.Label();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "На указанный адрес электронной почты было отправлено сообщение с кодом подтвежден" +
    "ия.\r\nПожалуйста, укажите код подтверждения в окне ниже.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Code_TextBox
            // 
            this.Code_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.Code_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Code_TextBox.ForeColor = System.Drawing.Color.White;
            this.Code_TextBox.Location = new System.Drawing.Point(305, 90);
            this.Code_TextBox.Name = "Code_TextBox";
            this.Code_TextBox.Size = new System.Drawing.Size(210, 20);
            this.Code_TextBox.TabIndex = 1;
            // 
            // Code_Label
            // 
            this.Code_Label.AutoSize = true;
            this.Code_Label.ForeColor = System.Drawing.Color.White;
            this.Code_Label.Location = new System.Drawing.Point(257, 89);
            this.Code_Label.Name = "Code_Label";
            this.Code_Label.Size = new System.Drawing.Size(42, 21);
            this.Code_Label.TabIndex = 2;
            this.Code_Label.Text = "Код:";
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.FlatAppearance.BorderSize = 0;
            this.Confirm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_Button.ForeColor = System.Drawing.Color.White;
            this.Confirm_Button.Location = new System.Drawing.Point(204, 122);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(200, 30);
            this.Confirm_Button.TabIndex = 3;
            this.Confirm_Button.Text = "Подтвердить";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(305, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 1);
            this.panel1.TabIndex = 4;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.FlatAppearance.BorderSize = 0;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.ForeColor = System.Drawing.Color.White;
            this.Cancel_Button.Location = new System.Drawing.Point(410, 122);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(200, 30);
            this.Cancel_Button.TabIndex = 5;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // MailConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(810, 164);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.Code_Label);
            this.Controls.Add(this.Code_TextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MailConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Code_TextBox;
        private System.Windows.Forms.Label Code_Label;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancel_Button;
    }
}