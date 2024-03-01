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
    public partial class UserProfile : UserControl
    {
        string connectionString = string.Empty;
        public string username;
        public string friendUsername;

        public UserProfile()
        {
            InitializeComponent();

            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        public void LoadProfile(string Username)
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
                        if (reader["Status"].ToString() == "Заблокирован")
                        {
                            UserInfoPanel.Visible = false;
                            Vote_Button.Visible = false;
                            WarningPanel.Visible = true;
                            WarningPanel.BringToFront();
                            UserIcon_PictureBox.Image = Image.FromFile(GetImage(@"UserIcons\" + reader["Picture"]));
                            Name_Label.Text = reader["SecondName"] + " " + reader["FirstName"] + "\n" + reader["ThirdName"];
                        }
                        else
                        {
                            #region Заполнение профиля

                            WarningPanel.Visible = false;
                            Vote_Button.Visible = true;
                            UserInfoPanel.Visible = true;
                            UserIcon_PictureBox.Image = Image.FromFile(GetImage(@"UserIcons\" + reader["Picture"]));
                            Name_Label.Text = reader["SecondName"] + " " + reader["FirstName"] + "\n" + reader["ThirdName"];
                            RegDateInfo_Label.Text = reader["RegistrationDate"].ToString();
                            LastOnlineInfo_Label.Text = reader["LastOnline"].ToString();
                            CountryInfo_Label.Text = reader["Country"].ToString();
                            CityInfo_Label.Text = reader["City"].ToString();
                            GenderInfo_Label.Text = reader["Gender"].ToString();
                            var age = DateTime.Today.Year - Convert.ToDateTime(reader["BirthDate"]).Year;
                            if (Convert.ToDateTime(reader["BirthDate"]) > DateTime.Today.AddYears(-age))
                                age--;
                            BirthDateInfo_Label.Text = age.ToString();
                            StatusInfo_Label.Text = reader["Role"].ToString();

                            #endregion
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
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private string GetImage(string File)
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return directoryInfo.Parent.Parent.FullName + @"\Resources\" + File;
        }

        private void Vote_Button_Click(object sender, EventArgs e)
        {
            VoteForm voteForm = new VoteForm();
            voteForm.Show();
            voteForm.votedUser = friendUsername;
            voteForm.username = username;
            voteForm.LoadForm();
        }
    }
}
