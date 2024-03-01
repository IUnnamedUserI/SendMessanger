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
using System.Net;
using System.Net.Mail;

namespace Send
{
    public partial class Authorization : Form
    {
        //public string connectionString = @"Data Source=NOTEBOOK-L\SQLEXPRESS;Initial Catalog=SendDB;Integrated Security=True";
        public string connectionString = @"Data Source = SQL5108.site4now.net; Initial Catalog = db_a7a4d6_senddb; User Id = db_a7a4d6_senddb_admin; Password=Andersantino2001";

        bool IsPasswordHidden = true;
        bool IsMouseDown = false;

        Color Accent = Color.FromArgb(32, 208, 210);
        Color Black = Color.Black;

        Point mouseOffset;

        public Authorization()
        {
            InitializeComponent();
            Version_Label.Text = GetLastVersion();
        }

        void HoverButton (Button button)
        {
            button.FlatAppearance.BorderColor = Color.FromArgb(156, 24, 50);
            button.ForeColor = Color.White;
            button.BackColor = Color.FromArgb(156, 24, 50);
        }

        void OutButton(Button button)
        {
            button.FlatAppearance.BorderColor = Color.FromArgb(156, 24, 50);
            button.ForeColor = Color.FromArgb(156, 24, 50);
            button.BackColor = Color.FromArgb(9, 5, 16);
        }

        private void Login_Button_MouseEnter(object sender, EventArgs e)
        {
            HoverButton(Login_Button);
        }

        private void Login_Button_MouseLeave(object sender, EventArgs e)
        {
            OutButton(Login_Button);
        }

        private void Registration_Button_MouseEnter(object sender, EventArgs e)
        {
            HoverButton(Registration_Button);
        }

        private void Registration_Button_MouseLeave(object sender, EventArgs e)
        {
            OutButton(Registration_Button);
        }

        private void Username_TextBox_Enter(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox.Text == "Логин или E-Mail")
            {
                textbox.Text = "";
            }
        }

        private void Username_TextBox_Leave(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox.Text == "")
            {
                textbox.Text = "Логин или E-Mail";
            }
        }

        private void Password_TextBox_Enter(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox.Text == "Пароль")
            {
                textbox.Text = "";
            }
            textbox.PasswordChar = '•';
        }

        private void Password_TextBox_Leave(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox.Text == "")
            {
                textbox.Text = "Пароль";
                textbox.PasswordChar = '\0';
            }
        }

        async private void Login_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * From Users Where Password = @password And Username = @username Or EMail = @mail";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                command.Parameters.AddWithValue(@"username", Username_TextBox.Text);
                command.Parameters.AddWithValue(@"mail", Username_TextBox.Text);
                command.Parameters.AddWithValue(@"password", Password_TextBox.Text);

                try
                {
                    connection.Open();
                    reader = await command.ExecuteReaderAsync();
                    if (reader.Read())
                    {
                        if (reader["Status"].ToString() == "Заблокирован")
                        {
                            MessageBox.Show("Ваша учётная запись заблокирована.", "Ошибка авторизации", MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {
                            CheckForInternetConnectionTimer.Stop();
                            MainForm msg = new MainForm();
                            msg.username = reader["Username"].ToString();
                            msg.UserID = Convert.ToInt32(reader["ID"]);
                            msg.Show();
                            FriendList friendList = new FriendList();
                            friendList.username = reader["Username"].ToString();
                            UpdateOnline(Username_TextBox.Text);
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Учётной записи с указанными данными не существует.\nПожалуйста, проверьте правильность введённых данных\nи повторите попытку", "Ошибка", MessageBoxButtons.OK);
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
        }

        async private void UpdateOnline(string Username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Update Users Set LastOnline = @datetime Where Username = '{Username}'";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(@"datetime", DateTime.Now);

                try
                {
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UpdateOnline():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            CheckForInternetConnectionTimer.Stop();
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ShowPassword_Button_Click(object sender, EventArgs e)
        {
            if (Password_TextBox.Text != "Пароль")
            {
                if (IsPasswordHidden == true)
                {
                    Password_TextBox.PasswordChar = '\0';
                    IsPasswordHidden = false;
                    string path = Application.ExecutablePath;
                    DirectoryInfo directoryInfo = new DirectoryInfo(path);
                    ShowPassword_Button.Image = Image.FromFile(directoryInfo.Parent.Parent.Parent.FullName + @"\Resources\Открытый глаз.png");
                }
                else if (IsPasswordHidden == false)
                {
                    Password_TextBox.PasswordChar = '•';
                    IsPasswordHidden = true;
                    string path = Application.ExecutablePath;
                    DirectoryInfo directoryInfo = new DirectoryInfo(path);
                    ShowPassword_Button.Image = Image.FromFile(directoryInfo.Parent.Parent.Parent.FullName + @"\Resources\Закрытый глаз.png");
                }
            }
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://google.ru"))
                {
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }

        private void CheckForInternetConnectionTimer_Tick(object sender, EventArgs e)
        {
            if (CheckForInternetConnection() == false)
                WarningPicture.Visible = true;
            else
                WarningPicture.Visible = false;
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            //CheckForInternetConnectionTimer.Start();
        }

        private void WarningPicture_MouseEnter(object sender, EventArgs e)
        {
            WarningMessage.SetToolTip(WarningPicture, "Отсутствует подключение к сети Интернет");
        }

        private void ShowPassword_Button_MouseLeave(object sender, EventArgs e)
        {
            if (Password_TextBox.Text != "Пароль")
            {
                Password_TextBox.PasswordChar = '•';
                IsPasswordHidden = true;
                string path = Application.ExecutablePath;
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                ShowPassword_Button.Image = Image.FromFile(directoryInfo.Parent.Parent.Parent.FullName + @"\Resources\Закрытый глаз.png");
            }
        }

        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;
                yOffset = -e.Y;
                mouseOffset = new Point(xOffset, yOffset);
                IsMouseDown = true;
            }
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
        
        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        string GetLastVersion()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select VersionNumber From ChangeLog Order By VersionID Desc";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader["VersionNumber"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("GetLastVersion():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            return "Error";
        }
    }
}