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
    public partial class EditProfile : UserControl
    {
        string connectionString = string.Empty;
        public string username;
        bool AboutUserIsCollapsed = true;
        bool SecurityIsCollapsed = true;

        public EditProfile()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        private void UserIcon_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            ChangeIcon_Panel.Visible = true;
        }

        private void UserIcon_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            ChangeIcon_Panel.Visible = false;
        }

        public void LoadProfile()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Users Where Username = '{username}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        UserIcon_PictureBox.Image = Image.FromFile(GetImage(@"UserIcons\" + reader["Picture"]));
                        Country_ComboBox.Text = reader["Country"].ToString();
                        City_ComboBox.Text = reader["City"].ToString();
                        Gender_ComboBox.Text = reader["Gender"].ToString();
                        Name_Label.Text = reader["SecondName"].ToString() + " " + reader["FirstName"].ToString() + " " + reader["ThirdName"].ToString();

                        FillCountry();
                        FillGender();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadProfile():\n" + ex.Message, ex.Source);
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

        private void ChangeImage_Label_MouseEnter(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.FromArgb(156, 24, 50);
        }

        private void ChangeImage_Label_MouseLeave(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.White;
        }

        private void FillCountry()
        {
            Country_ComboBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * From Country Order By CountryName";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Country_ComboBox.Items.Add(reader["CountryName"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("FillCountry():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void FillCity()
        {
            City_ComboBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From City Where CountryID = '{GetCountryInfo(Country_ComboBox.SelectedItem.ToString(), "CountryID")}' Order By CityName";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        City_ComboBox.Items.Add(reader["CityName"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("FillCity():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private string GetCountryInfo(string CountryName, string ReturnInfo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Country Where CountryName = '{CountryName}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader[ReturnInfo].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("GetCountryInfo():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            return "Error";
        }

        private void Country_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country_ComboBox.Text = string.Empty;
            FillCity();
        }

        private void FillGender()
        {
            Gender_ComboBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * From Gender";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Gender_ComboBox.Items.Add(reader["GenderName"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("FillGender():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void CancelSave_Button_Click(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void SaveProfile_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Update Users Set Country = '{Country_ComboBox.Text}', City = '{City_ComboBox.Text}', Gender = '{Gender_ComboBox.Text}', BirthDate = '{BirthDate_DateTimePicker.Value}' Where Username = '{username}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadProfile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SaveProfile_Button_Click():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void ChangeImage_Label_Click(object sender, EventArgs e)
        {
            ChangeUserImage cui = new ChangeUserImage();
            cui.Show();
        }

        private void ChangeIcon_Panel_Click(object sender, EventArgs e)
        {
            ChangeUserImage cui = new ChangeUserImage();
            cui.Show();
        }

        private void UserIcon_PictureBox_Click(object sender, EventArgs e)
        {
            ChangeUserImage cui = new ChangeUserImage();
            cui.Show();
            cui.username = username;
        }

        private void ShowAboutUser_Button_Click(object sender, EventArgs e)
        {
            SecurityPanel.Height = 41;
            ShowSecurity_Button.Image = Image.FromFile(GetImage(@"Иконки\Шевроны\Белый\Шеврон вправо.png"));
            SecurityIsCollapsed = true;

            if (AboutUserIsCollapsed == false)
            {
                AboutUserPanel.Height = 41;
                ShowAboutUser_Button.Image = Image.FromFile(GetImage(@"Иконки\Шевроны\Белый\Шеврон вправо.png"));
                AboutUserIsCollapsed = true;
            }
            else
            {
                AboutUserPanel.Height = 253;
                ShowAboutUser_Button.Image = Image.FromFile(GetImage(@"Иконки\Шевроны\Белый\Шеврон вниз.png"));
                AboutUserIsCollapsed = false;
            }
        }

        private void ShowSecurity_Button_Click(object sender, EventArgs e)
        {
            AboutUserPanel.Height = 41;
            ShowAboutUser_Button.Image = Image.FromFile(GetImage(@"Иконки\Шевроны\Белый\Шеврон вправо.png"));
            AboutUserIsCollapsed = true;

            if (SecurityIsCollapsed == false)
            {
                SecurityPanel.Height = 41;
                ShowSecurity_Button.Image = Image.FromFile(GetImage(@"Иконки\Шевроны\Белый\Шеврон вправо.png"));
                SecurityIsCollapsed = true;
            }
            else
            {
                SecurityPanel.Height = 253;
                ShowSecurity_Button.Image = Image.FromFile(GetImage(@"Иконки\Шевроны\Белый\Шеврон вниз.png"));
                SecurityIsCollapsed = false;
            }
        }

        private void ChangePassword_Button_Click(object sender, EventArgs e)
        {
            if (FirstPassword_TextBox.Text == RepeatPassword_TextBox.Text)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $@"Update Users Set Password = '{FirstPassword_TextBox.Text}' Where Username = '{username}'";
                    SqlCommand command = new SqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Пароль успешно изменён");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ChangePassword_Button_Click():\n" + ex.Message, ex.Source);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void EditName_Button_Click(object sender, EventArgs e)
        {
            ChangeName changeName = new ChangeName();
            changeName.Show();
            changeName.username = username;
            changeName.ChangeName_Load(sender, e);
        }
    }
}
