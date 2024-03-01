
namespace Send
{
    partial class ChangeLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeLog));
            this.ChangeLogTitle_Label = new System.Windows.Forms.Label();
            this.Version_Label = new System.Windows.Forms.Label();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.CloseForm = new System.Windows.Forms.Button();
            this.DividingPanel = new System.Windows.Forms.Panel();
            this.Date_Label = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.ChangeLog_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.UpperPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeLogTitle_Label
            // 
            this.ChangeLogTitle_Label.AutoSize = true;
            this.ChangeLogTitle_Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeLogTitle_Label.ForeColor = System.Drawing.Color.White;
            this.ChangeLogTitle_Label.Location = new System.Drawing.Point(12, 9);
            this.ChangeLogTitle_Label.Name = "ChangeLogTitle_Label";
            this.ChangeLogTitle_Label.Size = new System.Drawing.Size(154, 30);
            this.ChangeLogTitle_Label.TabIndex = 0;
            this.ChangeLogTitle_Label.Text = "Что нового?";
            // 
            // Version_Label
            // 
            this.Version_Label.AutoSize = true;
            this.Version_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Version_Label.ForeColor = System.Drawing.Color.White;
            this.Version_Label.Location = new System.Drawing.Point(12, 39);
            this.Version_Label.Name = "Version_Label";
            this.Version_Label.Size = new System.Drawing.Size(130, 17);
            this.Version_Label.TabIndex = 0;
            this.Version_Label.Text = "Загрузка версии...";
            // 
            // UpperPanel
            // 
            this.UpperPanel.Controls.Add(this.panel6);
            this.UpperPanel.Controls.Add(this.panel5);
            this.UpperPanel.Controls.Add(this.panel4);
            this.UpperPanel.Controls.Add(this.CloseForm);
            this.UpperPanel.Controls.Add(this.DividingPanel);
            this.UpperPanel.Controls.Add(this.ChangeLogTitle_Label);
            this.UpperPanel.Controls.Add(this.Date_Label);
            this.UpperPanel.Controls.Add(this.Version_Label);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(394, 69);
            this.UpperPanel.TabIndex = 1;
            // 
            // CloseForm
            // 
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseForm.Image = ((System.Drawing.Image)(resources.GetObject("CloseForm.Image")));
            this.CloseForm.Location = new System.Drawing.Point(359, 3);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(32, 32);
            this.CloseForm.TabIndex = 3;
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // DividingPanel
            // 
            this.DividingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.DividingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DividingPanel.Location = new System.Drawing.Point(0, 68);
            this.DividingPanel.Name = "DividingPanel";
            this.DividingPanel.Size = new System.Drawing.Size(394, 1);
            this.DividingPanel.TabIndex = 2;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_Label.ForeColor = System.Drawing.Color.White;
            this.Date_Label.Location = new System.Drawing.Point(116, 39);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(0, 17);
            this.Date_Label.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.ChangeLog_Label);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 69);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(394, 395);
            this.ContentPanel.TabIndex = 2;
            // 
            // ChangeLog_Label
            // 
            this.ChangeLog_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeLog_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeLog_Label.ForeColor = System.Drawing.Color.White;
            this.ChangeLog_Label.Location = new System.Drawing.Point(0, 0);
            this.ChangeLog_Label.Name = "ChangeLog_Label";
            this.ChangeLog_Label.Size = new System.Drawing.Size(394, 395);
            this.ChangeLog_Label.TabIndex = 0;
            this.ChangeLog_Label.Text = "Загрузка изменений...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 395);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(1, 463);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(393, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 394);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 1);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 67);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(393, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 67);
            this.panel6.TabIndex = 6;
            // 
            // ChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(394, 464);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.UpperPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ChangeLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeLog";
            this.Load += new System.EventHandler(this.ChangeLog_Load);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ChangeLogTitle_Label;
        private System.Windows.Forms.Label Version_Label;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Panel DividingPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label ChangeLog_Label;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}