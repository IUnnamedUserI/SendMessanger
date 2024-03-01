
namespace Send.Пользовательские_элементы_управления
{
    partial class OutcomingQuerys
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
            this.QueryCount_Label = new System.Windows.Forms.Label();
            this.QueryDetected_Label = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SubPanel = new System.Windows.Forms.Panel();
            this.InfoPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QueryCount_Label
            // 
            this.QueryCount_Label.AutoSize = true;
            this.QueryCount_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryCount_Label.ForeColor = System.Drawing.Color.White;
            this.QueryCount_Label.Location = new System.Drawing.Point(9, 33);
            this.QueryCount_Label.Name = "QueryCount_Label";
            this.QueryCount_Label.Size = new System.Drawing.Size(19, 21);
            this.QueryCount_Label.TabIndex = 0;
            this.QueryCount_Label.Text = "?";
            // 
            // QueryDetected_Label
            // 
            this.QueryDetected_Label.AutoSize = true;
            this.QueryDetected_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryDetected_Label.ForeColor = System.Drawing.Color.White;
            this.QueryDetected_Label.Location = new System.Drawing.Point(9, 8);
            this.QueryDetected_Label.Name = "QueryDetected_Label";
            this.QueryDetected_Label.Size = new System.Drawing.Size(200, 21);
            this.QueryDetected_Label.TabIndex = 0;
            this.QueryDetected_Label.Text = "Обнаружено запросов:";
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.InfoPanel.Controls.Add(this.QueryCount_Label);
            this.InfoPanel.Controls.Add(this.QueryDetected_Label);
            this.InfoPanel.Location = new System.Drawing.Point(539, 15);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(238, 172);
            this.InfoPanel.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.MainPanel.Controls.Add(this.SubPanel);
            this.MainPanel.Controls.Add(this.InfoPanel);
            this.MainPanel.Location = new System.Drawing.Point(20, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(790, 233);
            this.MainPanel.TabIndex = 1;
            // 
            // SubPanel
            // 
            this.SubPanel.AutoScroll = true;
            this.SubPanel.Location = new System.Drawing.Point(3, 3);
            this.SubPanel.Name = "SubPanel";
            this.SubPanel.Size = new System.Drawing.Size(507, 227);
            this.SubPanel.TabIndex = 3;
            // 
            // OutcomingQuerys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.MainPanel);
            this.Name = "OutcomingQuerys";
            this.Size = new System.Drawing.Size(830, 292);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label QueryCount_Label;
        private System.Windows.Forms.Label QueryDetected_Label;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SubPanel;
    }
}
