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

namespace Send
{
    public partial class SendQuery : UserControl
    {
        string connectionString = string.Empty;
        public string username;

        List<string> usernames = new List<string>();
        List<Panel> panelList = new List<Panel>();

        public SendQuery()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
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
            return "Error";
        }

        async private void Search_Button_Click(object sender, EventArgs e)
        {
            ClearPanels();
            string search = Search_TextBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Users Where FirstName Like '%{search}%' Or SecondName Like '%{search}%' Or ThirdName Like '%{search}%'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = await command.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        if (CheckFriend(username, reader["Username"].ToString()) == false && CheckQuery(username, reader["Username"].ToString()) == false && reader["Username"].ToString() != username)
                        {
                            Panel friendPanel = new Panel();
                            PictureBox pictureBox = new PictureBox();
                            Label friendName = new Label();
                            Label locationName = new Label();
                            Button addFriend = new Button();

                            CenterPanel.Controls.Add(friendPanel);
                            friendPanel.Controls.Add(pictureBox);
                            friendPanel.Controls.Add(friendName);
                            friendPanel.Controls.Add(locationName);
                            friendPanel.Controls.Add(addFriend);

                            if (panelList.Count == 0)
                            {
                                friendPanel.Location = new Point(10, 10);
                            }
                            else
                            {
                                friendPanel.Location = new Point(10, panelList[panelList.Count - 1].Height + panelList[panelList.Count - 1].Location.Y + 10);
                            }
                            friendPanel.BorderStyle = BorderStyle.FixedSingle;
                            friendPanel.Width = 800;
                            friendPanel.Height = 70;

                            pictureBox.Location = new Point(10, 10);
                            pictureBox.Width = 50;
                            pictureBox.Height = 50;
                            pictureBox.Image = Image.FromFile(GetImage(reader["Picture"].ToString()));
                            pictureBox.BorderStyle = BorderStyle.FixedSingle;
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox.Tag = reader["Username"].ToString();
                            pictureBox.Click += FriendPictureBox_Clicked;

                            friendName.Text = reader["SecondName"].ToString() + " " + reader["FirstName"].ToString() + " " + reader["ThirdName"].ToString();
                            friendName.ForeColor = Color.White;
                            friendName.Location = new Point(65, 15);
                            friendName.Font = new Font(Search_Button.Font.Name, 14);
                            friendName.AutoSize = true;
                            friendName.Tag = reader["Username"].ToString();
                            friendName.Click += FriendName_Clicked;

                            locationName.Text = string.Empty;
                            if (reader["Country"].ToString() != "NULL")
                                locationName.Text += reader["Country"].ToString();
                            if (reader["Country"].ToString() != string.Empty && reader["City"].ToString() != string.Empty)
                                locationName.Text += ", " + reader["City"].ToString();
                            locationName.ForeColor = Color.White;
                            locationName.Location = new Point(65, friendName.Location.Y + friendName.Width + 10);
                            locationName.Font = new Font(Search_Button.Font.Name, 10);
                            locationName.AutoSize = true;
                            locationName.BringToFront();

                            addFriend.Text = "Отправить";
                            addFriend.Location = new Point(690, 22);
                            addFriend.Width = 100;
                            addFriend.Height = 30;
                            addFriend.FlatStyle = FlatStyle.Flat;
                            addFriend.ForeColor = Color.White;
                            addFriend.Font = new Font(Search_Button.Font.Name, 10);
                            addFriend.Tag = usernames.Count;
                            addFriend.Click += SendUserQuery;

                            panelList.Add(friendPanel);
                            usernames.Add(reader["Username"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search_Button_Click():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void FriendName_Clicked(object sender, EventArgs e)
        {
            var label = sender as Label;
            ((MainForm)(MainForm.ActiveForm)).LoadFriendProfile(label.Tag.ToString());
        }

        private void FriendPictureBox_Clicked(object sender, EventArgs e)
        {
            var pictureBox = sender as PictureBox;
            ((MainForm)(MainForm.ActiveForm)).LoadFriendProfile(pictureBox.Tag.ToString());
        }

        private bool CheckFriend(string Username, string FriendUsername)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * From Friends Where Username = '" + Username + "' And FriendUsername = '" + FriendUsername + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CheckFriend " + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }

        private bool CheckQuery(string Username, string FriendUsername)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * From ActiveQuery Where QuerySender = '" + Username + "' And QueryRecipient = '" + FriendUsername + "' Or QuerySender = '" + FriendUsername + "' And QueryRecipient = '" + Username + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CheckQuery():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }

        private string GetImage(string File)
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return directoryInfo.Parent.Parent.FullName + @"\Resources\UserIcons\" + File;
        }
        
        public void ClearPanels()
        {
            foreach (Panel panel in panelList)
            {
                panel.Dispose();
            }
            panelList.Clear();
        }

        private void SendUserQuery(object sender, EventArgs e)
        {
            var button = sender as Button;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Insert Into ActiveQuery (QuerySender, QueryRecipient) Values ('{username}', '{usernames[Convert.ToInt32(button.Tag)]}')";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Search_TextBox.Text = string.Empty;
                    Search_Button_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SendUserQuery():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
