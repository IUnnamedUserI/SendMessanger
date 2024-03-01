
namespace Send.Пользовательские_элементы_управления
{
    partial class VotesList
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
            this.VotesList_ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // VotesList_ListBox
            // 
            this.VotesList_ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.VotesList_ListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.VotesList_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VotesList_ListBox.ForeColor = System.Drawing.Color.White;
            this.VotesList_ListBox.FormattingEnabled = true;
            this.VotesList_ListBox.ItemHeight = 20;
            this.VotesList_ListBox.Location = new System.Drawing.Point(0, 0);
            this.VotesList_ListBox.Name = "VotesList_ListBox";
            this.VotesList_ListBox.Size = new System.Drawing.Size(380, 363);
            this.VotesList_ListBox.TabIndex = 0;
            // 
            // VotesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.VotesList_ListBox);
            this.Name = "VotesList";
            this.Size = new System.Drawing.Size(830, 363);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox VotesList_ListBox;
    }
}
