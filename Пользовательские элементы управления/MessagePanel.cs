using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Send.Пользовательские_элементы_управления
{
    public partial class MessagePanel : UserControl
    {
        string connectionString = string.Empty;
        public string username;
        const int VDistance = 6;
        const int MaxMessageWidth = 400;
        public string selectedUsername = string.Empty;
        string path = string.Empty;
        string fileName = string.Empty;
        string shortFileName = string.Empty;
        bool IsPictureAdded = false;

        List<Panel> panelList = new List<Panel>();
        List<Button> friendsButtonList = new List<Button>();
        List<PictureBox> pictureBoxList = new List<PictureBox>();

        List<Button> groupButtonList = new List<Button>();
        List<int> groupID = new List<int>();

        public MessagePanel()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;

            Panel phantomPanel = new Panel();
            phantomPanel.Height = 0;
            phantomPanel.Width = 0;
            panelList.Add(phantomPanel);
        }

        async public void LoadFriends()
        {
            Panel_GroupChat.SendToBack();
            ClearFriends();

            PictureBox loadingGif = new PictureBox()
            {
                Size = new Size(50, 50),
                Location = new Point((FriendsListPanel.Width - 50) / 2, (FriendsListPanel.Height - 50) / 5),
                Image = Image.FromFile(GetPicture(@"\Gif\Loading.gif")),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            FriendsListPanel.Controls.Add(loadingGif);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Friends Where Username = '{username}' Order By (Select SecondName From Users Where Username = Friends.FriendUsername) Desc";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = await command.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        Button friendButton = new Button();
                        PictureBox friendPictureBox = new PictureBox();

                        FriendsListPanel.Controls.Add(friendButton);
                        friendButton.Controls.Add(friendPictureBox);

                        friendButton.Visible = false;
                        friendButton.Text = GetUserInfo(reader["FriendUsername"].ToString(), "SecondName") + " " + GetUserInfo(reader["FriendUsername"].ToString(), "FirstName");
                        friendButton.Height = 50;
                        friendButton.Dock = DockStyle.Top;
                        friendButton.FlatStyle = FlatStyle.Flat;
                        friendButton.TextAlign = ContentAlignment.MiddleLeft;
                        friendButton.Padding = new Padding(40, 0, 0, 0);
                        friendButton.ForeColor = Color.White;
                        friendButton.Font = new Font(CurrentName_Label.Font.Name, 12);
                        friendButton.Tag = reader["FriendUsername"].ToString();
                        friendButton.Enabled = true;
                        friendButton.Click += FriendButton_Clicked;

                        friendPictureBox.Height = 40;
                        friendPictureBox.Width = 40;
                        friendPictureBox.Location = new Point(friendButton.Location.X + 5, friendButton.Location.Y + 5);
                        friendPictureBox.Image = Image.FromFile(GetIcon(GetUserInfo(reader["FriendUsername"].ToString(), "Picture")));
                        friendPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                        friendsButtonList.Add(friendButton);

                        if (friendsButtonList.Count == GetFriendsCount())
                            foreach (Button button in friendsButtonList)
                                button.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadFriends():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                    loadingGif.Dispose();
                }
            }
            LoadGroups();
            CheckReaded.Start();
        }

        async public void LoadGroups()
        {
            ClearGroups();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From GroupUsersList Where Username = '{username}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = await command.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        groupID.Add(Convert.ToInt32(reader["GroupID"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadGroups():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Groups Order By GroupTitle";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = await command.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        if (groupID.Contains(Convert.ToInt32(reader["GroupID"].ToString())))
                        {
                            Button groupButton = new Button();
                            PictureBox groupPictureBox = new PictureBox();

                            FriendsListPanel.Controls.Add(groupButton);
                            groupButton.Controls.Add(groupPictureBox);

                            groupButton.Text = reader["GroupTitle"].ToString();
                            groupButton.Height = 50;
                            groupButton.Dock = DockStyle.Top;
                            groupButton.FlatStyle = FlatStyle.Flat;
                            groupButton.TextAlign = ContentAlignment.MiddleLeft;
                            groupButton.Padding = new Padding(40, 0, 0, 0);
                            groupButton.ForeColor = Color.White;
                            groupButton.Font = new Font(CurrentName_Label.Font.Name, 12);
                            groupButton.Tag = reader["GroupID"].ToString();
                            groupButton.Enabled = true;
                            groupButton.Click += GroupButton_Clicked;
                            groupButtonList.Add(groupButton);

                            groupPictureBox.Height = 40;
                            groupPictureBox.Width = 40;
                            groupPictureBox.Location = new Point(groupButton.Location.X + 5, groupButton.Location.Y + 5);
                            groupPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            groupPictureBox.Image = Image.FromFile(GetGroupImage(reader["GroupImage"].ToString()));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadGroups():\n" + ex.Message, ex.Source);
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

        private void ClearGroups()
        {
            foreach (Button button in groupButtonList)
            {
                button.Dispose();
            }
            groupButtonList.Clear();
            groupID.Clear();
        }

        private void GroupButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;

            Panel_GroupChat.groupTitle = GetGroupInfo(button.Tag.ToString(), "GroupTitle");
            Panel_GroupChat.groupID = Convert.ToInt32(button.Tag.ToString());
            Panel_GroupChat.username = username;
            Panel_GroupChat.selectedGroup = button.Tag.ToString();
            Panel_GroupChat.Visible = true;
            Panel_GroupChat.LoadGroupInfo(button.Tag.ToString());
            Panel_GroupChat.BringToFront();
        }

        private string GetGroupInfo(string GroupID, string Info)
        {
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
                        return reader[Info].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("GetGroupInfo():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            return "Error";
        }

        private void ChangeReaded(string Username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Update Messages Set IsReaded = '{"Yes"}' Where RecipientUsername = '{Username}' And SenderUsername = '{selectedUsername}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
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

        private void FriendButton_Clicked(object sender, EventArgs e)
        {
            Panel_GroupChat.Visible = false;
            selectedUsername = (sender as Button).Tag.ToString();
            LoadMessages(username, selectedUsername);
        }

        async public void LoadMessages(string Username, string FriendUsername)
        {
            ClearMessages();
            CenterPanel.Visible = true;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Messages Where SenderUsername = '{Username}' And RecipientUsername = '{FriendUsername}' Or SenderUsername = '{FriendUsername}' And RecipientUsername = '{Username}' Order By Time Desc";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = await command.ExecuteReaderAsync();
                    if (reader.Read())
                    {
                        CurrentName_Label.Text = GetUserInfo(FriendUsername, "SecondName") + " " + GetUserInfo(FriendUsername, "FirstName") + " " + GetUserInfo(FriendUsername, "ThirdName");
                        CurrentUserPicture.Image = Image.FromFile(GetIcon(GetUserInfo(FriendUsername, "Picture")));

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

                            MessagesPanel.Controls.Add(messagePanel);
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
                                senderLabel.Text = reader["SenderUsername"].ToString();
                                senderLabel.ForeColor = Color.LightGray;
                                messagePanel.Height = messageLabel.Height + timeLabel.Height + 2;
                                timeLabel.Location = new Point(0, messagePanel.Height - 15);
                                senderLabel.Location = new Point(timeLabel.Location.X + timeLabel.Width + 1, timeLabel.Location.Y);

                                messageLabel.Font = new Font(CurrentName_Label.Font.Name, 10);
                                timeLabel.Font = new Font(CurrentName_Label.Font.Name, 8);
                                senderLabel.Font = new Font(CurrentName_Label.Font.Name, 8);

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
                                    if (reader["SenderUsername"].ToString() == Username)
                                    {
                                        messagePanel.BackColor = Color.FromArgb(40, 30, 60);
                                        messagePanel.Location = new Point(Convert.ToInt32(MessagesPanel.Width - messagePanel.Width - 20), 0);
                                    }
                                    else
                                    {
                                        messagePanel.BackColor = Color.FromArgb(20, 10, 40);
                                        messagePanel.Location = new Point(5, 0);
                                    }
                                }
                                else
                                {
                                    if (reader["SenderUsername"].ToString() == Username)
                                    {
                                        messagePanel.BackColor = Color.FromArgb(40, 30, 60);
                                        messagePanel.Location = new Point(Convert.ToInt32(MessagesPanel.Width - messagePanel.Width - 20), panelList[panelList.Count - 1].Location.Y + panelList[panelList.Count - 1].Height + VDistance);
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
                                senderLabel.Text = reader["SenderUsername"].ToString();
                                senderLabel.ForeColor = Color.LightGray;
                                timeLabel.Location = new Point(0, messagePanel.Height - 15);
                                senderLabel.Location = new Point(timeLabel.Location.X + timeLabel.Width + 1, timeLabel.Location.Y);

                                timeLabel.Font = new Font(CurrentName_Label.Font.Name, 8);
                                senderLabel.Font = new Font(CurrentName_Label.Font.Name, 8);

                                timeLabel.Location = new Point(0, messagePanel.Height - 15);
                                senderLabel.Location = new Point(timeLabel.Location.X + timeLabel.Width + 1, timeLabel.Location.Y);

                                pictureBox.Click += PictureBox_Clicked;


                                if (panelList.Count == 0)
                                {
                                    if (reader["SenderUsername"].ToString() == Username)
                                    {
                                        messagePanel.BackColor = Color.FromArgb(40, 30, 60);
                                        messagePanel.Location = new Point(Convert.ToInt32(MessagesPanel.Width - messagePanel.Width - 20), 0);
                                    }
                                    else
                                    {
                                        messagePanel.BackColor = Color.FromArgb(20, 10, 40);
                                        messagePanel.Location = new Point(5, 0);
                                    }
                                }
                                else
                                {
                                    if (reader["SenderUsername"].ToString() == Username)
                                    {
                                        messagePanel.BackColor = Color.FromArgb(40, 30, 60);
                                        messagePanel.Location = new Point(Convert.ToInt32(MessagesPanel.Width - messagePanel.Width - 20), panelList[panelList.Count - 1].Location.Y + panelList[panelList.Count - 1].Height + VDistance);
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
                        ChangeReaded(username);
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

        private string GetUserInfo(string Username, string Info)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Users Where Username = '{Username}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader[Info].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            return "Error";
        }

        private void SendMessage_Button_Click(object sender, EventArgs e)
        {
            AddedContentPanel.Visible = false;
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
            if (Message_TextBox.Text != string.Empty || IsPictureAdded == true)
            {
                if (selectedUsername != string.Empty)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = $@"Insert Into Messages (Time, SenderUsername, RecipientUsername, Message, IsReaded, AddedPicture) Values (@datetime, '{username}', '{selectedUsername}', '{Message_TextBox.Text}', '{"No"}', '{endFileName}')";
                        
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue(@"datetime", DateTime.Now);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            LoadMessages(username, selectedUsername);
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
            Message_TextBox.Text = string.Empty;
            IsPictureAdded = false;
            path = string.Empty;
            fileName = string.Empty;
            defaultPath = string.Empty;
        }

        private string GetIcon(string File)
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return directoryInfo.Parent.Parent.FullName + @"\Resources\UserIcons\" + File;
        }

        private string GetPicture(string File)
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return directoryInfo.Parent.Parent.FullName + @"\bin\Release\Icons\" + File;
        }

        private void HideCenterPanel_Button_Click(object sender, EventArgs e)
        {
            CheckReaded.Stop();
            ClearMessages();
            selectedUsername = string.Empty;
            CenterPanel.Visible = false;
            IsPictureAdded = false;
        }

        private void ClearFriends()
        {
            foreach (Button button in friendsButtonList)
            {
                button.Dispose();
            }
            friendsButtonList.Clear();
        }

        private void ClearMessages()
        {
            foreach (Panel panel in panelList)
            {
                panel.Dispose();
            }
            panelList.Clear();
            IsPictureAdded = false;
            CenterPanel.Visible = false;
        }

        private void CurrentName_Label_Click(object sender, EventArgs e)
        {
            ((MainForm)(MainForm.ActiveForm)).LoadFriendProfile(selectedUsername);
        }

        private void CurrentUserPicture_Click(object sender, EventArgs e)
        {
            ((MainForm)(MainForm.ActiveForm)).LoadFriendProfile(selectedUsername);
        }

        private void AddFile_Button_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pictureBox in pictureBoxList)
            {
                pictureBox.Dispose();
            }
            pictureBoxList.Clear();

            if (AddFile_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                AddedContentPanel.Visible = true;
                path = AddFile_OpenFileDialog.FileName;
                fileName = AddFile_OpenFileDialog.SafeFileName;
                shortFileName = Path.GetFileNameWithoutExtension(AddFile_OpenFileDialog.SafeFileName);

                PictureBox pictureBox = new PictureBox();
                AddedContentPanel.Controls.Add(pictureBox);
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.Width = 50;
                pictureBox.Height = 50;
                pictureBox.Location = new Point(10, 5);
                pictureBox.Image = Image.FromFile(path);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                IsPictureAdded = true;
            }
        }

        private void Message_TextBox_TextChanged(object sender, EventArgs e)
        {
            int textLenght = Message_TextBox.Text.Length;
            if (Message_TextBox.Text != string.Empty)
            {
                LengthCount_Label.Visible = true;
                LengthCount_Label.Text = textLenght.ToString() + @"/500";
            }
            else
            {
                LengthCount_Label.Visible = false;
                LengthCount_Label.Text = string.Empty;
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

        private void CheckForNewMessage(string Username, string FriendUsername)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Messages Where SenderUsername = '{FriendUsername}' And RecipientUsername = '{Username}' And IsReaded = '{"No"}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        LoadMessages(Username, FriendUsername);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CheckForNewMessage():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private string GetMessagePicture(string File)
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return directoryInfo.Parent.Parent.FullName + @"\Resources\MessageIcons\" + File;
        }

        private void CreateNewChat_Button_Click(object sender, EventArgs e)
        {
            int id = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Insert Into Groups (GroupTitle, GroupCreator, GroupImage) Values ('{"Новое обсуждение"}', '{username}', '{"DefaultGroupImage.png"}')";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CreateNewChat_Button_Click():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Groups";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["GroupID"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CreateNewChat_Button_Click():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Insert Into GroupUsersList (Username, GroupID) Values ('{username}', '{id}')";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CreateNewChat_Button_Click():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void CheckReaded_Tick(object sender, EventArgs e)
        {
            if (selectedUsername != string.Empty)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $@"Select * From Messages Where RecipientUsername = '{username}' And SenderUsername = '{selectedUsername}' And IsReaded = 'No'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader;

                    try
                    {
                        connection.Open();
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            LoadMessages(username, selectedUsername);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("CheckReaded_Tick():\n" + ex.Message, ex.Source);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            CheckReaded.Start();
        }

        int GetFriendsCount()
        {
            int friendsCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Friends Where Username = '{username}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        friendsCount++;
                    }
                    return friendsCount;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("GetFriendsCount():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            return -1;
        }
    }
}