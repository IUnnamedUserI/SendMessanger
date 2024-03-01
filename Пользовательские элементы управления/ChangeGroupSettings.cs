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
    public partial class ChangeGroupSettings : Form
    {
        string connectionString = string.Empty;

        public string groupTitle = string.Empty;
        public int groupID;
        public string username = string.Empty;
        private string groupImagePath = string.Empty;
        private string shortGroupImagePath = string.Empty;

        List<string> userList = new List<string>();
        List<Panel> usersPanel = new List<Panel>();

        public ChangeGroupSettings()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        private void Button_GroupSettings_Click(object sender, EventArgs e)
        {
            Panel_EditGroupSettings.BringToFront();
            LoadGroupInfo();
        }

        public void Button_UsersList_Click(object sender, EventArgs e)
        {
            Panel_UsersList.BringToFront();
            LoadUsersList(groupID);
        }

        private void Button_CancelChanges_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ChangeGroupSettings_Load(object sender, EventArgs e)
        {
            TextBox_GroupTitle.Text = groupTitle;
        }

        public void LoadGroupInfo()
        {
            TextBox_GroupTitle.Text = groupTitle;

            if (GetGroupInfo(groupID.ToString(), "GroupCreator") == username)
            {
                Button_DeleteGroup.Enabled = true;
            }
            else
            {
                Button_DeleteGroup.Enabled = false;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Groups Where GroupID = '{groupID}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PictureBox_GroupImage.Image = Image.FromFile(GetGroupImage(reader["GroupImage"].ToString()));
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

        private void Button_SaveChanges_Click(object sender, EventArgs e)
        {
            if (groupImagePath != string.Empty)
            {
                string path = Directory.GetCurrentDirectory();
                string endFileName = string.Empty;
                DirectoryInfo directoryInfo = new DirectoryInfo(path);

                if (!File.Exists(directoryInfo.Parent.Parent.FullName + @"\Resources\" + shortGroupImagePath))
                {
                    endFileName = shortGroupImagePath;
                    File.Copy(path, directoryInfo.Parent.Parent.FullName + @"\Resources\" + endFileName);
                }
                else
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        endFileName = shortGroupImagePath + " (" + i + ").jpg";
                        if (!File.Exists(directoryInfo.Parent.Parent.FullName + @"\Resources\" + endFileName))
                        {
                            File.Copy(groupImagePath, directoryInfo.Parent.Parent.FullName + @"\Resources\" + endFileName);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $@"Update Groups Set GroupImage = '{shortGroupImagePath}' Where GroupID = '{groupID}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Button_SaveChanges_Click():\n" + ex.Message, ex.Source);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Update Groups Set GroupTitle = '{TextBox_GroupTitle.Text}' Where GroupID = '{groupID}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Button_SaveChanges_Click():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Button_DeleteGroup_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Delete From GroupUsersList Where GroupID = '{groupID}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Button_DeleteGroup_Click():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Delete From Groups Where GroupID = '{groupID}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Button_DeleteGroup_Click():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void LoadUsersList(int GroupID)
        {
            ClearUserList();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From GroupUsersList Where GroupID = '{GroupID}' Order By Username";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Panel userPanel = new Panel();
                        PictureBox userPictureBox = new PictureBox();
                        Label userLabel = new Label();
                        Label userAdminLabel = new Label();
                        Button userDeleteButton = new Button();

                        Panel_ListOfUsers.Controls.Add(userPanel);
                        userPanel.Controls.Add(userPictureBox);
                        userPanel.Controls.Add(userLabel);

                        userPanel.Dock = DockStyle.Top;
                        userPanel.Height = 60;
                        userPanel.BorderStyle = BorderStyle.FixedSingle;
                        usersPanel.Add(userPanel);

                        userPictureBox.Height = 50;
                        userPictureBox.Width = 50;
                        userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        userPictureBox.Location = new Point(5, 5);
                        userPictureBox.Image = Image.FromFile(GetUserImage(GetUserInfo(reader["Username"].ToString(), "Picture")));

                        userLabel.Text = GetUserInfo(reader["Username"].ToString(), "SecondName") + " " + GetUserInfo(reader["Username"].ToString(), "FirstName");
                        userLabel.Font = new Font(Panel_ListOfUsers.Font.Name, 14);
                        userLabel.Location = new Point(userPictureBox.Location.X + userPictureBox.Width + 5, 5);
                        userLabel.AutoSize = true;
                        userLabel.ForeColor = Color.White;

                        if (GetGroupInfo(reader["GroupID"].ToString(), "GroupCreator") == reader["Username"].ToString())
                        {
                            userPanel.Controls.Add(userAdminLabel);
                            userAdminLabel.Text = "Администратор";
                            userAdminLabel.Font = new Font(Panel_ListOfUsers.Font.Name, 10);
                            userAdminLabel.Location = new Point(userLabel.Location.X, userLabel.Location.Y + userLabel.Height);
                            userAdminLabel.AutoSize = true;
                            userAdminLabel.ForeColor = Color.LightGray;
                        }

                        if (GetGroupInfo(reader["GroupID"].ToString(), "GroupCreator") == username)
                        {
                            userPanel.Controls.Add(userDeleteButton);
                            userDeleteButton.Text = "Удалить";
                            userDeleteButton.Width = 90;
                            userDeleteButton.Height = 25;
                            userDeleteButton.Location = new Point(userPanel.Width - userDeleteButton.Width - 10, userPanel.Height / 4);
                            userDeleteButton.FlatStyle = FlatStyle.Flat;
                            userDeleteButton.Font = new Font(Panel_ListOfUsers.Font.Name, 9);
                            userDeleteButton.Tag = reader["Username"].ToString();
                            userDeleteButton.Click += UserDeleteButton_Clicked;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadUsersList():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void UserDeleteButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Delete From GroupUsersList Where Username = '{button.Tag.ToString()}' And GroupID = '{groupID}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    ClearUserList();
                    LoadUsersList(groupID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UserDeleteButton_Clicked():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private string GetUserImage(string File)
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return directoryInfo.Parent.Parent.FullName + @"\Resources\UserIcons\" + File;
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

        private void Button_CloseForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ClearUserList()
        {
            foreach (Panel panel in usersPanel)
            {
                panel.Dispose();
            }
            usersPanel.Clear();
        }

        private void Button_LeaveGroup_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Delete From GroupUsersList Where Username = '{username}' And GroupID = '{groupID}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Button_LeaveGroup_Click():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Button_DeleteGroupImage_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Update Groups Set GroupImage = '{"DefaultGroupImage.png"}'";
                SqlCommand command = new SqlCommand(query, connection);
                
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadGroupInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Button_DeleteGroupImage_Click():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Button_ChangeGroupImage_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog_ChangeImage.ShowDialog() == DialogResult.OK)
            {
                groupImagePath = OpenFileDialog_ChangeImage.FileName;
                shortGroupImagePath = OpenFileDialog_ChangeImage.SafeFileName;

                PictureBox_GroupImage.Image = Image.FromFile(groupImagePath);
            }
        }

        private void Button_AddNewUser_Click(object sender, EventArgs e)
        {
            ClearUserList();
            AddUserInGroup.Visible = true;
            AddUserInGroup.groupID = groupID.ToString();
            AddUserInGroup.username = username;
            AddUserInGroup.LoadFriends(username);
        }
    }
}
