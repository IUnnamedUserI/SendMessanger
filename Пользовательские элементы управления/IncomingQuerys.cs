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
    public partial class IncomingQuerys : UserControl
    {
        string connectionString = string.Empty;
        public string username;
        List<Panel> panelList = new List<Panel>();

        public IncomingQuerys()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        void ClearQuerys()
        {
            foreach (Panel panel in panelList)
                panel.Dispose();
            panelList.Clear();
        }

        async public void LoadQuerys(string Username)
        {
            ClearQuerys();
            int querysCount = QuerysCount(username);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * From ActiveQuery Where QueryRecipient = '" + Username + "'";
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
                            Size = new Size(497, 66),
                            BorderStyle = BorderStyle.Fixed3D
                        };
                        Point panelLocation;
                        if (panelList.Count == 0)
                            panelLocation = new Point(5, 5);
                        else
                            panelLocation = new Point(5, panelList[panelList.Count - 1].Location.Y + panelList[panelList.Count - 1].Height + 5);
                        panel.Location = panelLocation;

                        panelList.Add(panel);

                        PictureBox pictureBox = new PictureBox()
                        {
                            Size = new Size(48, 48),
                            Location = new Point(8, 8),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Image = Image.FromFile(GetUserPicture(GetInfo(reader["QuerySender"].ToString(), "Picture")))
                        };

                        Label label = new Label()
                        {
                            Location = new Point(63, 22),
                            ForeColor = Color.White,
                            Font = new Font(QueryDetected_Label.Font.Name, 12),
                            Text = GetInfo(reader["QuerySender"].ToString(), "SecondName") + " " + GetInfo(reader["QuerySender"].ToString(), "FirstName") + " " + GetInfo(reader["QuerySender"].ToString(), "ThirdName")
                        };

                        Button buttonProfile = new Button()
                        {
                            Location = new Point(378, 18),
                            Size = new Size(32, 32),
                            Text = string.Empty,
                            Image = Image.FromFile(GetPicture("icons8-мужчина-32.png")),
                            Tag = reader["QuerySender"].ToString(),
                            FlatStyle = FlatStyle.Flat
                        };
                        buttonProfile.FlatAppearance.BorderSize = 0;

                        Button buttonAdd = new Button()
                        {
                            Location = new Point(416, 18),
                            Size = new Size(32, 32),
                            Text = string.Empty,
                            Image = Image.FromFile(GetPicture("Добавить пользователя.png")),
                            Tag = reader["QuerySender"].ToString(),
                            FlatStyle = FlatStyle.Flat,
                            ImageAlign = ContentAlignment.TopCenter
                        };
                        buttonAdd.FlatAppearance.BorderSize = 0;
                        buttonAdd.Click += AddFriend;

                        Button buttonDelete = new Button()
                        {
                            Location = new Point(454, 18),
                            Size = new Size(32, 32),
                            Text = string.Empty,
                            Image = Image.FromFile(GetPicture("icons8-удалить-32 (1).png")),
                            Tag = reader["QuerySender"].ToString(),
                            FlatStyle = FlatStyle.Flat
                        };
                        buttonDelete.FlatAppearance.BorderSize = 0;

                        SubPanel.Controls.Add(panel);
                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(label);
                        panel.Controls.Add(buttonProfile);
                        panel.Controls.Add(buttonDelete);
                        panel.Controls.Add(buttonAdd);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadQuerys():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }       //----------Загрузка запросов

        async void AddFriend(object sender, EventArgs e)
        {
            var button = sender as Button;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Insert Into Friends (Username, FriendUsername) Values ('{username}', '{button.Tag.ToString()}')";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("AddFriend():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Insert Into Friends (Username, FriendUsername) Values ('{button.Tag.ToString()}', '{username}')";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("AddFriend():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Delete From ActiveQuery Where QuerySender = '{button.Tag.ToString()}' And QueryRecipient = '{username}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    LoadQuerys(username);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("AddFriend (Delete):\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private int QuerysCount(string Username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int CurrentQuerys = 0;
                string query = "Select * From ActiveQuery Where QueryRecipient = '" + Username + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CurrentQuerys++;
                    }
                    QueryCount_Label.Text = CurrentQuerys.ToString();

                    return CurrentQuerys;
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
            return -1;
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
        }       //----------Получение информации через Username

        private void DeleteQuery(string SenderUsername, string RecipientUsername)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Delete From ActiveQuery Where QuerySender = '{SenderUsername}' And QueryRecipient = '{RecipientUsername}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadQuerys(username);

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
        }       //----------Удаление запроса

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
    }
}
