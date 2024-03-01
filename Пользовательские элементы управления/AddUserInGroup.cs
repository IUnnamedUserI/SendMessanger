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
    public partial class AddUserInGroup : UserControl
    {
        private string connectionString = string.Empty;
        public string username = string.Empty;
        public string groupID = string.Empty;

        List<string> friendsList = new List<string>();
        List<Panel> panelList = new List<Panel>();
        List<string> addedUsersList = new List<string>();

        public AddUserInGroup()
        {
            InitializeComponent();

            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        public void LoadFriends(string Username)
        {
            ClearFriends();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Friends Where Username = '{Username}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!CheckUser(reader["FriendUsername"].ToString()))
                        {
                            Panel friendPanel = new Panel();
                            CheckBox friendCheckBox = new CheckBox();
                            PictureBox friendPicturebox = new PictureBox();
                            Label friendLabel = new Label();

                            Panel_FriendsList.Controls.Add(friendPanel);
                            friendPanel.Controls.Add(friendCheckBox);
                            friendPanel.Controls.Add(friendPicturebox);
                            friendPanel.Controls.Add(friendLabel);

                            friendPanel.Dock = DockStyle.Top;
                            friendPanel.Height = 60;
                            friendPanel.BorderStyle = BorderStyle.FixedSingle;
                            panelList.Add(friendPanel);

                            friendCheckBox.Checked = false;
                            friendCheckBox.Text = string.Empty;
                            friendCheckBox.Tag = reader["FriendUsername"].ToString();
                            friendCheckBox.Location = new Point(5, friendPanel.Height / 2 - friendCheckBox.Height / 2);
                            friendCheckBox.Width = 10;
                            friendCheckBox.CheckedChanged += FriendCheckBox_CheckChanged;

                            friendPicturebox.Location = new Point(friendCheckBox.Location.X + 15, 5);
                            friendPicturebox.Width = 50;
                            friendPicturebox.Height = 50;
                            friendPicturebox.SizeMode = PictureBoxSizeMode.Zoom;
                            friendPicturebox.Image = Image.FromFile(GetUserImage(GetUserInfo(reader["FriendUsername"].ToString(), "Picture")));

                            friendLabel.Text = GetUserInfo(reader["FriendUsername"].ToString(), "SecondName") + " " + GetUserInfo(reader["FriendUsername"].ToString(), "FirstName");
                            friendLabel.Font = new Font(Button_Back.Font.Name, 10);
                            friendLabel.Location = new Point(friendPicturebox.Location.X + friendPicturebox.Width + 5, 5);
                            friendLabel.AutoSize = true;
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

        private void FriendCheckBox_CheckChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox.Checked)
                addedUsersList.Add(checkBox.Tag.ToString());
            else
                addedUsersList.Remove(checkBox.Tag.ToString());
        }

        private void ClearFriends()
        {
            foreach (Panel panel in panelList)
            {
                panel.Dispose();
            }
            panelList.Clear();
            addedUsersList.Clear();
        }

        private bool CheckUser(string Username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From GroupUsersList Where Username = '{Username}' And GroupID = '{groupID}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                        return true;
                    else
                        return false;
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
            return true;
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
                    MessageBox.Show("GetUserInfo():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            return "Error";
        }

        private string GetUserImage(string File)
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return directoryInfo.Parent.Parent.FullName + $@"\Resources\UserIcons\" + File;
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((ChangeGroupSettings)(ChangeGroupSettings.ActiveForm)).Button_UsersList_Click(sender, e);
        }

        private void Button_AddUser_Click(object sender, EventArgs e)
        {
            foreach (string user in addedUsersList)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $@"Insert Into GroupUsersList (Username, GroupID) Values ('{user}', '{groupID}')";
                    SqlCommand command = new SqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Button_AddUser_Click():\n" + ex.Message, ex.Source);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            LoadFriends(username);
        }
    }
}
