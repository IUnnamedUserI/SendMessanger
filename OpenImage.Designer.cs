
namespace Send
{
    partial class OpenImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenImage));
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.DownloadPicture_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Image_PictureBox = new System.Windows.Forms.PictureBox();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpperPanel.Controls.Add(this.DownloadPicture_Button);
            this.UpperPanel.Controls.Add(this.Close_Button);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(800, 50);
            this.UpperPanel.TabIndex = 2;
            // 
            // SaveFile
            // 
            this.SaveFile.FileName = "FileName";
            this.SaveFile.Filter = "PNG-Файл|*.png|JPG-Файл|*.jpg|JPEG-Файл|*.jpeg";
            // 
            // DownloadPicture_Button
            // 
            this.DownloadPicture_Button.FlatAppearance.BorderSize = 0;
            this.DownloadPicture_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadPicture_Button.Image = ((System.Drawing.Image)(resources.GetObject("DownloadPicture_Button.Image")));
            this.DownloadPicture_Button.Location = new System.Drawing.Point(694, 0);
            this.DownloadPicture_Button.Name = "DownloadPicture_Button";
            this.DownloadPicture_Button.Size = new System.Drawing.Size(50, 50);
            this.DownloadPicture_Button.TabIndex = 1;
            this.DownloadPicture_Button.UseVisualStyleBackColor = true;
            this.DownloadPicture_Button.Click += new System.EventHandler(this.DownloadPicture_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.Location = new System.Drawing.Point(750, 0);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(50, 50);
            this.Close_Button.TabIndex = 1;
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Image_PictureBox
            // 
            this.Image_PictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.Image_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Image_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Image_PictureBox.Location = new System.Drawing.Point(0, 50);
            this.Image_PictureBox.Name = "Image_PictureBox";
            this.Image_PictureBox.Size = new System.Drawing.Size(800, 380);
            this.Image_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Image_PictureBox.TabIndex = 3;
            this.Image_PictureBox.TabStop = false;
            // 
            // OpenImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.Image_PictureBox);
            this.Controls.Add(this.UpperPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OpenImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenImage";
            this.UpperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Button DownloadPicture_Button;
        private System.Windows.Forms.Button Close_Button;
        public System.Windows.Forms.PictureBox Image_PictureBox;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}