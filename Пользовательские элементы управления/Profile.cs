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
    public partial class Profile : UserControl
    {
        string connectionString = string.Empty;
        public string username;

        public Profile()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        async public void LoadProfile(string Username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Users Where Username = '{Username}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = await command.ExecuteReaderAsync();
                    if (reader.Read())
                    {
                        UserIcon_PictureBox.Image = Image.FromFile(GetImage(@"UserIcons\" + reader["Picture"].ToString()));
                        Name_Label.Text = reader["SecondName"].ToString() + " " + reader["FirstName"].ToString() + "\n" + reader["ThirdName"].ToString();
                        RegDateInfo_Label.Text = reader["RegistrationDate"].ToString();
                        LastOnlineInfo_Label.Text = reader["LastOnline"].ToString();
                        CountryInfo_Label.Text = reader["Country"].ToString();
                        CityInfo_Label.Text = reader["City"].ToString();
                        GenderInfo_Label.Text = reader["Gender"].ToString();
                        var age = DateTime.Today.Year - Convert.ToDateTime(reader["BirthDate"]).Year;
                        if (Convert.ToDateTime(reader["BirthDate"]) > DateTime.Today.AddYears(-age))
                            age--;
                        AgeInfo_Label.Text = age.ToString();
                        StatusInfo_Label.Text = reader["Status"].ToString();
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

        private string GetImage(string File)
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return directoryInfo.Parent.Parent.FullName + @"\Resources\" + File;
        }
    }
}
