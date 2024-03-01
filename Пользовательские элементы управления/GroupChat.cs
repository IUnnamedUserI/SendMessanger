using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Send.Пользовательские_элементы_управления
{
    public partial class GroupPanel : UserControl
    {
        string connectionString = string.Empty;
        public string groupTitle = string.Empty;
        public int groupID;
        public string username = string.Empty;
        const int VDistance = 6;
        const int MaxMessageWidth = 400;
        string path = string.Empty;
        string fileName = string.Empty;
        string shortFileName = string.Empty;
        bool IsPictureAdded = false;
        public string selectedGroup = string.Empty;

        List<Panel> panelList = new List<Panel>();
        List<PictureBox> pictureBoxList = new List<PictureBox>();

        public GroupPanel()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        public void LoadGroupInfo(string GroupID)
        {
            CurrentGroupTitle_Label.Text = groupTitle;
            LoadMessages(username, GroupID);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Groups Where GroupID = '{GroupID}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        CurrentGroupPicture.Image = Image.FromFile(GetGroupImage(reader["GroupImage"].ToString()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadGroupInfo():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private string GetGroupImage(string File)
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return directoryInfo.Parent.Parent.FullName + @"\Resources\" + File;
        }

        private void EditGroup_Button_Click(object sender, EventArgs e)
        {
            ChangeGroupSettings changeGroupSettings = new ChangeGroupSettings();
            changeGroupSettings.Show();
            changeGroupSettings.groupTitle = groupTitle;
            changeGroupSettings.groupID = groupID;
            changeGroupSettings.username = username;
            changeGroupSettings.LoadGroupInfo();
        }

        private void HideGroupPanel_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ClearGroupMessages()
        {
            foreach (Panel panel in panelList)
            {
                panel.Dispose();
            }
            panelList.Clear();
        }

        async public void LoadMessages(string Username, string GroupID)
        {
            ClearGroupMessages();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From GroupMessages Where GroupID = '{GroupID}' Order By Time Desc";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = await command.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        Panel messagePanel = new Panel();
                        Label messageLabel = new Label();
                        Label timeLabel = new Label();
                        Label senderLabel = new Label();
                        PictureBox pictureBox = new PictureBox();

                        double currentLabelWidth;
                        double currentLabelHeight;
                        double changedLabelWidth;

                        GroupMessagesPanel.Controls.Add(messagePanel);
                        messagePanel.Controls.Add(timeLabel);
                        messagePanel.Controls.Add(senderLabel);

                        if (reader["Message"].ToString() != string.Empty)
                        {
                            messagePanel.Controls.Add(messageLabel);

                            if (reader["AddedPicture"].ToString() != string.Empty || reader["AddedPicture"].ToString() != null)
                            {
                                messagePanel.Controls.Add(pictureBox);
                            }

                            messageLabel.Text = reader["Message"].ToString();
                            messageLabel.AutoSize = true;

                            if (messageLabel.Width > senderLabel.Location.X + senderLabel.Width)
                            {
                                messagePanel.Width = messageLabel.Location.X + messageLabel.Width;
                                messageLabel.Height = 100;
                            }
                            else
                            {
                                messagePanel.Width = senderLabel.Location.X + senderLabel.Width;
                                messageLabel.Height = 100;
                            }

                            timeLabel.Text = reader["Time"].ToString() + ",";
                            timeLabel.AutoSize = true;
                            timeLabel.ForeColor = Color.LightGray;
                            senderLabel.Text = reader["MessageSender"].ToString();
                            senderLabel.ForeColor = Color.LightGray;
                            messagePanel.Height = messageLabel.Height + timeLabel.Height + 2;
                            timeLabel.Location = new Point(0, messagePanel.Height - 15);
                            senderLabel.Location = new Point(timeLabel.Location.X + timeLabel.Width + 1, timeLabel.Location.Y);

                            messageLabel.Font = new Font(CurrentGroupTitle_Label.Font.Name, 10);
                            timeLabel.Font = new Font(CurrentGroupTitle_Label.Font.Name, 8);
                            senderLabel.Font = new Font(CurrentGroupTitle_Label.Font.Name, 8);

                            if (messageLabel.Width > 200)
                            {
                                currentLabelWidth = messageLabel.Width;
                                currentLabelHeight = messageLabel.Height;
                                messageLabel.AutoSize = false;
                                messageLabel.Width = MaxMessageWidth;
                                changedLabelWidth = messageLabel.Width;
                                messageLabel.Height = Convert.ToInt32(currentLabelHeight + (currentLabelWidth / currentLabelHeight));

                                if (reader["AddedPicture"].ToString() != string.Empty || reader["AddedPicture"].ToString() != null)
                                {
                                    Image image;
                                    image = Image.FromFile(GetMessagePicture(reader["AddedPicture"].ToString()));
                                    pictureBox.Tag = GetMessagePicture(reader["AddedPicture"].ToString());

                                    if (reader["Message"].ToString() == string.Empty)
                                        pictureBox.Location = new Point(5, 5);
                                    else
                                        pictureBox.Location = new Point(5, messageLabel.Location.Y + messageLabel.Height + 5);
                                    if (reader["AddedPicture"].ToString() != string.Empty)
                                        pictureBox.Image = image;
                                    if (image.Width <= 250)
                                        pictureBox.Width = image.Width;
                                    else
                                        pictureBox.Width = 250;
                                    if (image.Height <= 250)
                                        pictureBox.Height = image.Height;
                                    else
                                        pictureBox.Height = 250;
                                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                }

                                if (reader["AddedPicture"].ToString() == string.Empty)
                                    messagePanel.Height = messageLabel.Height + timeLabel.Height + 2;
                                else
                                    messagePanel.Height = messageLabel.Height + timeLabel.Height + 2 + pictureBox.Height;
                                timeLabel.Location = new Point(0, messagePanel.Height - 15);
                                senderLabel.Location = new Point(timeLabel.Location.X + timeLabel.Width + 1, timeLabel.Location.Y);
                            }

                            if (messageLabel.Width > senderLabel.Location.X + senderLabel.Width)
                            {
                                messagePanel.Width = messageLabel.Location.X + messageLabel.Width;
                            }
                            else
                            {
                                messagePanel.Width = senderLabel.Location.X + senderLabel.Width;
                            }

                            if (panelList.Count == 0)
                            {
                                if (reader["MessageSender"].ToString() == Username)
                                {
                                    messagePanel.BackColor = Color.FromArgb(40, 30, 60);
                                    messagePanel.Location = new Point(Convert.ToInt32(GroupMessagesPanel.Width - messagePanel.Width - 20), 0);
                                }
                                else
                                {
                                    messagePanel.BackColor = Color.FromArgb(20, 10, 40);
                                    messagePanel.Location = new Point(5, 0);
                                }
                            }
                            else
                            {
                                if (reader["MessageSender"].ToString() == Username)
                                {
                                    messagePanel.BackColor = Color.FromArgb(40, 30, 60);
                                    messagePanel.Location = new Point(Convert.ToInt32(GroupMessagesPanel.Width - messagePanel.Width - 20), panelList[panelList.Count - 1].Location.Y + panelList[panelList.Count - 1].Height + VDistance);
                                }
                                else
                                {
                                    messagePanel.BackColor = Color.FromArgb(20, 10, 40);
                                    messagePanel.Location = new Point(5, panelList[panelList.Count - 1].Location.Y + panelList[panelList.Count - 1].Height + VDistance);
                                }
                            }
                        }
                        else
                        {
                            messagePanel.Controls.Add(pictureBox);
                            pictureBox.Tag = reader["AddedPicture"].ToString();
                            Image image = Image.FromFile(GetMessagePicture(reader["AddedPicture"].ToString()));
                            pictureBox.Image = image;
                            pictureBox.Location = new Point(5, 5);
                            if (image.Width <= 250)
                                pictureBox.Width = image.Width;
                            else
                                pictureBox.Width = 250;
                            if (image.Height <= 250)
                                pictureBox.Height = image.Height;
                            else
                                pictureBox.Height = 250;
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                            if (pictureBox.Width > senderLabel.Location.X + senderLabel.Width)
                                messagePanel.Width = pictureBox.Width + 5;
                            else
                                messagePanel.Width = senderLabel.Location.X + senderLabel.Width + 5;
                            messagePanel.Height = pictureBox.Height + 15;

                            timeLabel.Text = reader["Time"].ToString() + ",";
                            timeLabel.AutoSize = true;
                            timeLabel.ForeColor = Color.LightGray;
                            senderLabel.Text = reader["MessageSender"].ToString();
                            senderLabel.ForeColor = Color.LightGray;
                            timeLabel.Location = new Point(0, messagePanel.Height - 15);
                            senderLabel.Location = new Point(timeLabel.Location.X + timeLabel.Width + 1, timeLabel.Location.Y);

                            timeLabel.Font = new Font(CurrentGroupTitle_Label.Font.Name, 8);
                            senderLabel.Font = new Font(CurrentGroupTitle_Label.Font.Name, 8);

                            timeLabel.Location = new Point(0, messagePanel.Height - 15);
                            senderLabel.Location = new Point(timeLabel.Location.X + timeLabel.Width + 1, timeLabel.Location.Y);

                            pictureBox.Click += PictureBox_Clicked;


                            if (panelList.Count == 0)
                            {
                                if (reader["MessageSender"].ToString() == Username)
                                {
                                    messagePanel.BackColor = Color.FromArgb(40, 30, 60);
                                    messagePanel.Location = new Point(Convert.ToInt32(GroupMessagesPanel.Width - messagePanel.Width - 20), 0);
                                }
                                else
                                {
                                    messagePanel.BackColor = Color.FromArgb(20, 10, 40);
                                    messagePanel.Location = new Point(5, 0);
                                }
                            }
                            else
                            {
                                if (reader["MessageSender"].ToString() == Username)
                                {
                                    messagePanel.BackColor = Color.FromArgb(40, 30, 60);
                                    messagePanel.Location = new Point(Convert.ToInt32(GroupMessagesPanel.Width - messagePanel.Width - 20), panelList[panelList.Count - 1].Location.Y + panelList[panelList.Count - 1].Height + VDistance);
                                }
                                else
                                {
                                    messagePanel.BackColor = Color.FromArgb(20, 10, 40);
                                    messagePanel.Location = new Point(5, panelList[panelList.Count - 1].Location.Y + panelList[panelList.Count - 1].Height + VDistance);
                                }
                            }
                        }
                        panelList.Add(messagePanel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadMessages():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void PictureBox_Clicked(object sender, EventArgs e)
        {
            var picture = sender as PictureBox;
            OpenImage openImage = new OpenImage();
            openImage.path = GetMessagePicture(picture.Tag.ToString());
            openImage.Image_PictureBox.Image = Image.FromFile(GetMessagePicture(picture.Tag.ToString()));
            openImage.Image_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            openImage.Show();
        }

        private string GetMessagePicture(string File)
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return directoryInfo.Parent.Parent.FullName + @"\Resources\MessageIcons\" + File;
        }

        async private void SendGroupMessage_Button_Click(object sender, EventArgs e)
        {
            AddedGroupContentPanel.Visible = false;
            string defaultPath = Directory.GetCurrentDirectory();
            string endFileName = string.Empty;
            DirectoryInfo directoryInfo = new DirectoryInfo(defaultPath);
            if (IsPictureAdded == true)
            {
                if (!File.Exists(directoryInfo.Parent.Parent.FullName + @"\Resources\MessageIcons\" + fileName))
                {
                    endFileName = fileName;
                    File.Copy(path, directoryInfo.Parent.Parent.FullName + @"\Resources\MessageIcons\" + endFileName);
                }
                else
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        endFileName = shortFileName + " (" + i + ").jpg";
                        if (!File.Exists(directoryInfo.Parent.Parent.FullName + @"\Resources\MessageIcons\" + endFileName))
                        {
                            File.Copy(path, directoryInfo.Parent.Parent.FullName + @"\Resources\MessageIcons\" + endFileName);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            if (GroupMessage_TextBox.Text != string.Empty || IsPictureAdded == true)
            {
                if (selectedGroup != string.Empty)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = $@"Insert Into GroupMessages (GroupID, Time, MessageSender, Message, AddedPicture) Values ('{selectedGroup}', @datetime, '{username}', '{GroupMessage_TextBox.Text}', '{endFileName}')";
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue(@"datetime", DateTime.Now);

                        try
                        {
                            connection.Open();
                            await command.ExecuteNonQueryAsync();
                            LoadMessages(username, selectedGroup);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SendMessage_Button_Click():\n" + ex.Message, ex.Source);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            GroupMessage_TextBox.Text = string.Empty;
            IsPictureAdded = false;
            path = string.Empty;
            fileName = string.Empty;
            defaultPath = string.Empty;
        }

        private void GroupAddFile_Button_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pictureBox in pictureBoxList)
            {
                pictureBox.Dispose();
            }
            pictureBoxList.Clear();

            if (AddFile_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                AddedGroupContentPanel.Visible = true;
                path = AddFile_OpenFileDialog.FileName;
                fileName = AddFile_OpenFileDialog.SafeFileName;
                shortFileName = Path.GetFileNameWithoutExtension(AddFile_OpenFileDialog.SafeFileName);

                PictureBox pictureBox = new PictureBox();
                AddedGroupContentPanel.Controls.Add(pictureBox);
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.Width = 50;
                pictureBox.Height = 50;
                pictureBox.Location = new Point(10, 5);
                pictureBox.Image = Image.FromFile(path);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                IsPictureAdded = true;
            }
        }
    }
}
