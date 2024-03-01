using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Send
{
    public partial class FriendList : UserControl
    {
        string connectionString = string.Empty;
        public string username;
        List<Panel> panelList = new List<Panel>();

        public FriendList()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        async public void LoadFriends()
        {
            ClearPanels();
            int friendCount = GetFriendCount();

            PictureBox loadingGif = new PictureBox()
            {
                Size = new Size(100, 100),
                Location = new Point(365, 104),
                Image = Image.FromFile(GetPicture(@"\Gif\Loading.gif")),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            MainPanel.Controls.Add(loadingGif);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Friends Where Username = '{username}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = await command.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        Panel panel = new Panel()
                        {
                            Size = new Size(820, 60),
                            BorderStyle = BorderStyle.Fixed3D,
                            Visible = false
                        };
                        if (panelList.Count == 0)
                            panel.Location = new Point(5, 20);
                        else
                            panel.Location = new Point(5, panelList[panelList.Count - 1].Location.Y + panelList[panelList.Count - 1].Height + 5);
                        panelList.Add(panel);

                        PictureBox pictureBox = new PictureBox()
                        {
                            Size = new Size(48, 48),
                            Location = new Point(6, 6),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Image = Image.FromFile(GetUserPicture(GetInfo(reader["FriendUsername"].ToString(), "Picture")))
                        };

                        Label label = new Label()
                        {
                            Text = GetInfo(reader["FriendUsername"].ToString(), "SecondName") + " " + GetInfo(reader["FriendUsername"].ToString(), "FirstName") + " " + GetInfo(reader["FriendUsername"].ToString(), "ThirdName"),
                            ForeColor = Color.White,
                            Font = new Font(MainPanel.Font.Name, 12),
                            Location = new Point(61, 19),
                            AutoSize = true
                        };

                        Button messageButton = new Button()
                        {
                            Size = new Size(32, 32),
                            Location = new Point(699, 14),
                            Text = string.Empty,
                            Image = Image.FromFile(GetPicture("icons8-сообщение-32.png")),
                            Tag = reader["FriendUsername"].ToString(),
                            FlatStyle = FlatStyle.Flat
                        };
                        messageButton.FlatAppearance.BorderSize = 0;
                        messageButton.Click += OpenFriendMessage;

                        Button profileButton = new Button()
                        {
                            Size = new Size(32, 32),
                            Location = new Point(737, 14),
                            Text = string.Empty,
                            Image = Image.FromFile(GetPicture("icons8-мужчина-32.png")),
                            Tag = reader["FriendUsername"].ToString(),
                            FlatStyle = FlatStyle.Flat
                        };
                        profileButton.FlatAppearance.BorderSize = 0;
                        profileButton.Click += OpenFriendProfile;

                        Button deleteButton = new Button()
                        {
                            Size = new Size(32, 32),
                            Location = new Point(775, 14),
                            Text = string.Empty,
                            Image = Image.FromFile(GetPicture("icons8-удалить-32 (1).png")),
                            Tag = reader["FriendUsername"].ToString(),
                            FlatStyle = FlatStyle.Flat
                        };
                        deleteButton.FlatAppearance.BorderSize = 0;
                        deleteButton.Click += DeleteFriend;

                        MainPanel.Controls.Add(panel);
                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(label);
                        panel.Controls.Add(messageButton);
                        panel.Controls.Add(profileButton);
                        panel.Controls.Add(deleteButton);

                        if (panelList.Count == friendCount)
                        {
                            foreach (Panel panelObject in panelList)
                                panelObject.Visible = true;
                            loadingGif.Dispose();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadFriends():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        void OpenFriendProfile(object sender, EventArgs e)
        {
            var button = sender as Button;
            ((MainForm)(MainForm.ActiveForm)).LoadFriendProfile(button.Tag.ToString());
        }

        void OpenFriendMessage(object sender, EventArgs e)
        {
            var button = sender as Button;
            ((MainForm)(MainForm.ActiveForm)).TransferToMessages(button.Tag.ToString());
        }

        async void DeleteFriend(object sender, EventArgs e)
        {
            var button = sender as Button;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Delete From Friends Where Username = '{username}' And FriendUsername = '{button.Tag.ToString()}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DeleteFriends():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Delete From Friends Where Username = '{button.Tag.ToString()}' And FriendUsername = '{username}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    LoadFriends();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DeleteFriends():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        void ClearPanels()
        {
            foreach (Panel panel in panelList)
                panel.Dispose();
            panelList.Clear();
        }

        private string GetInfo(string Username, string Info)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * From Users Where Username = '" + Username + "'";
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
            return "";
        }

        private string GetUserPicture(string File)
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

        int GetFriendCount()
        {
            int friendCount = 0;

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
                        friendCount++;
                    }
                    return friendCount;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("GetFriendCount():\n" + ex.Message, ex.Source);
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
