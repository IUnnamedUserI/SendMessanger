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
using Send.Пользовательские_элементы_управления;

namespace Send
{
    public partial class MainForm : Form
    {
        string connectionString = string.Empty;
        public string username;

        public int UserID;

        bool IsCollapsed = false;
        bool IsMouseDown = false;

        Point mouseOffset;

        public MainForm()
        {
            InitializeComponent();

            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        public void Messages_Load(object sender, EventArgs e)
        {
            NameUser_Label.Text = GetInfo(username, "SecondName") + " " + GetInfo(username, "FirstName");
            //LoadProfile();

            ChangeLog changeLog = new ChangeLog();
            changeLog.Show();

            StartPanel startPanel = new StartPanel();
            MainPanel.Controls.Add(startPanel);
            startPanel.Dock = DockStyle.Fill;
            startPanel.BringToFront();
        }

        #region Кнопки

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            HiddenApplication.Visible = false;
            SaveAccount();
            Application.Exit();
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            ProfileSubpanel.Visible = false;
            FriendsSubpanel.Visible = false;
            /*HidePanels();
            Panel_Start.BringToFront();*/
            var button = sender as Button;
            ActualPanel.Height = button.Height;
            ActualPanel.Top = button.Top;
            ActualPanel.Left = button.Left;

            CloseAllPanels();
            StartPanel startPanel = new StartPanel();
            MainPanel.Controls.Add(startPanel);
        }

        private void Profile_Button_Click(object sender, EventArgs e)
        {
            FriendsSubpanel.Visible = false;
            var button = sender as Button;
            ActualPanel.Height = button.Height;
            ActualPanel.Top = button.Top;
            ActualPanel.Left = button.Left;
            ProfileSubpanel.Visible = true;

            CloseAllPanels();
            Profile profile = new Profile();
            MainPanel.Controls.Add(profile);
            profile.username = username;
            profile.Dock = DockStyle.Fill;
            profile.LoadProfile(username);
        }

        private void Messages_Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            ActualPanel.Height = button.Height;
            ActualPanel.Top = button.Top;
            ActualPanel.Left = button.Left;
        }

        private void Message_Button_Click(object sender, EventArgs e)
        {
            ProfileSubpanel.Visible = false;
            FriendsSubpanel.Visible = false;
            var button = sender as Button;
            ActualPanel.Height = button.Height;
            ActualPanel.Top = button.Top;
            ActualPanel.Left = button.Left;
            CloseAllPanels();
            MessagePanel messagePanel = new MessagePanel();
            MainPanel.Controls.Add(messagePanel);
            messagePanel.Dock = DockStyle.Fill;
            messagePanel.username = username;
            messagePanel.LoadFriends();
            messagePanel.LoadGroups();
        }


        private void Friends_Button_Click(object sender, EventArgs e)
        {
            ProfileSubpanel.Visible = false;
            FriendsSubpanel.Visible = true;
            var button = sender as Button;
            ActualPanel.Height = button.Height;
            ActualPanel.Top = button.Top;
            ActualPanel.Left = button.Left;

            CloseAllPanels();
            Friends friends = new Friends();
            MainPanel.Controls.Add(friends);
            friends.Dock = DockStyle.Fill;
            friends.username = username;
            friends.Friends_Button_Click(sender, e);
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            HiddenApplication.Visible = false;
            ProfileSubpanel.Visible = false;
            FriendsSubpanel.Visible = false;
            SaveAccount();
            Authorization login = new Authorization();
            login.Show();
            this.Hide();
        }

        #endregion 

        public void LoadProfile()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * From Users Where Username = '" + username + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Profile profile = new Profile();
                        MainPanel.Controls.Add(profile);

                        UserIcon_PictureBox.Image = Image.FromFile(GetImage($@"UserIcons\" + reader["Picture"].ToString()));
                        profile.Name_Label.Text = reader["SecondName"].ToString() + " " + reader["FirstName"].ToString() + "\n" + reader["ThirdName"].ToString();
                        profile.RegDateInfo_Label.Text = reader["RegistrationDate"].ToString();
                        profile.LastOnlineInfo_Label.Text = reader["LastOnline"].ToString();
                        profile.CountryInfo_Label.Text = reader["Country"].ToString();
                        profile.CityInfo_Label.Text = reader["City"].ToString();
                        profile.GenderInfo_Label.Text = reader["Gender"].ToString();
                        var age = System.DateTime.Today.Year - Convert.ToDateTime(reader["BirthDate"]).Year;
                        if (Convert.ToDateTime(reader["BirthDate"]) > DateTime.Today.AddYears(-age))
                            age--;
                        profile.AgeInfo_Label.Text = age.ToString();
                        profile.StatusInfo_Label.Text = reader["Role"].ToString();

                        if (reader["Role"].ToString() != "Подтверждён")
                        {
                            Moderator_Button.Visible = true;
                        }
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
        }       //----------Загрузка профиля

        private string GetImage(string File)
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return directoryInfo.Parent.Parent.FullName + @"\Resources\" + File;
        }

        public string GetInfo(string Username, string Info)
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
        }       //----------Вывод информации о пользователе

        void SaveAccount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Update Users Set LastOnline = @datetime Where Username = '{username}'";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(@"datetime", DateTime.Now);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
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
        }

        public void TransferToMessages(string FriendUsername)
        {
            CloseAllPanels();
            MessagePanel messagePanel = new MessagePanel();
            MainPanel.Controls.Add(messagePanel);
            messagePanel.Dock = DockStyle.Fill;
            messagePanel.username = username;
            messagePanel.LoadFriends();
            messagePanel.LoadGroups();
            messagePanel.LoadMessages(username, FriendUsername);
            ActualPanel.Top = Messages_Button.Top;
            ActualPanel.Height = Messages_Button.Height;
            ActualPanel.Left = Messages_Button.Left;
            FriendsSubpanel.Visible = false;
        }

        private void EditProfile_Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            ActualPanel.Height = button.Height;
            ActualPanel.Top = 150;
            ActualPanel.Left = button.Left;
            //Code
            CloseAllPanels();
            EditProfile editProfile = new EditProfile();
            editProfile.username = username;
            editProfile.LoadProfile();
            MainPanel.Controls.Add(editProfile);
            editProfile.Dock = DockStyle.Fill;
        }

        private void SendQuery_Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            ActualPanel.Height = button.Height;
            ActualPanel.Top = 250;
            ActualPanel.Left = button.Left;

            CloseAllPanels();
            SendQuery sendQuery = new SendQuery();
            sendQuery.username = username;
            MainPanel.Controls.Add(sendQuery);
        }

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            if (IsCollapsed == false)
            {
                LeftPanel.Width = 70;
                Menu_Button.Text = string.Empty;
                Home_Button.Text = string.Empty;
                Profile_Button.Text = string.Empty;
                EditProfile_Button.Text = string.Empty;
                EditProfile_Button.Padding = new Padding(10, 0, 0, 0);
                Messages_Button.Text = string.Empty;
                Friends_Button.Text = string.Empty;
                SendQuery_Button.Text = string.Empty;
                SendQuery_Button.Padding = new Padding(10, 0, 0, 0);
                Exit_Button.Text = string.Empty;
                IsCollapsed = true;
                MainPanel.Width += 70;
            }
            else
            {
                LeftPanel.Width = 242;
                Menu_Button.Text = "          Меню";
                Home_Button.Text = "          Главная";
                Profile_Button.Text = "          Профиль";
                EditProfile_Button.Text = "          Редактировать";
                EditProfile_Button.Padding = new Padding(25, 0, 0, 0);
                Messages_Button.Text = "          Сообщения";
                Friends_Button.Text = "          Друзья";
                SendQuery_Button.Text = "          Отправить заявку";
                SendQuery_Button.Padding = new Padding(25, 0, 0, 0);
                Exit_Button.Text = "          Выйти";
                IsCollapsed = false;
                MainPanel.Width -= 70;
            }
        }

        public void LoadFriendProfile(string Username)
        {
            UserProfile userProfile = new UserProfile();
            userProfile.username = username;
            userProfile.friendUsername = Username;
            userProfile.LoadProfile(Username);
            MainPanel.Controls.Add(userProfile);
            userProfile.Dock = DockStyle.Fill;
            userProfile.BringToFront();
        }

        private void Moderator_Button_Click(object sender, EventArgs e)
        {
            Panel_ModeratorScreen.BringToFront();
            Panel_ModeratorScreen.username = username;
            Panel_ModeratorScreen.ChangeNames_Button_Click(sender, e);
        }

        private void Collapse_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            HiddenApplication.Visible = false;
        }

        private void HiddenApplication_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                NormalWindowState(sender, e);
        }

        private void HiddenApplication_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu contextMenu = new ContextMenu();
                contextMenu.MenuItems.Add(0, new MenuItem("Выйти из учётной записи", new EventHandler(Exit_Button_Click)));
                contextMenu.MenuItems.Add(1, new MenuItem("Выйти", new EventHandler(LogOut_Button_Click)));
                contextMenu.MenuItems.Add(2, new MenuItem("Развернуть", new EventHandler(NormalWindowState)));
                HiddenApplication.ContextMenu = contextMenu;
            }
        }

        private void NormalWindowState(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                IsMouseDown = true;
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                Point mousePosition = MousePosition;
                mousePosition.Offset(mouseOffset);
                Location = mousePosition;
            }
        }

        private void ChangeLog_Button_Click(object sender, EventArgs e)
        {
            if (CheckOpened("ChangeLog"))
            {
                FormCollection formCollection = Application.OpenForms;
                foreach (Form form in formCollection)
                    if (form.Name == "ChangeLog")
                        form.Activate();
            }
            else
            {
                ChangeLog changeLog = new ChangeLog();
                changeLog.Show();
            }
        }

        bool CheckOpened(string FormName)
        {
            FormCollection formCollection = Application.OpenForms;

            foreach (Form form in formCollection)
            {
                if (form.Name == FormName)
                    return true;
            }
            return false;
        }

        void CloseAllPanels()
        {
            foreach (Control panel in MainPanel.Controls)
                panel.Dispose();
        }
    }
}
