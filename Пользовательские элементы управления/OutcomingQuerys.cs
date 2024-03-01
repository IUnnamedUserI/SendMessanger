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
    public partial class OutcomingQuerys : UserControl
    {
        string connectionString = string.Empty;
        public string username;
        List<Panel> panelList = new List<Panel>();

        public OutcomingQuerys()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        void ClearResults()
        {
            foreach (Panel panel in panelList)
                panel.Dispose();
            panelList.Clear();
        }

        async public void LoadQuerys(string Username)
        {
            ClearResults();
            GetQueryCount();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From ActiveQuery Where QuerySender = '{Username}'";
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
                            Image = Image.FromFile(GetUserPicture(GetInfo(reader["QueryRecipient"].ToString(), "Picture")))
                        };

                        Label label = new Label()
                        {
                            Location = new Point(63, 22),
                            ForeColor = Color.White,
                            Font = new Font(QueryDetected_Label.Font.Name, 12),
                            Text = GetInfo(reader["QueryRecipient"].ToString(), "SecondName") + " " + GetInfo(reader["QueryRecipient"].ToString(), "FirstName") + " " + GetInfo(reader["QueryRecipient"].ToString(), "ThirdName"),
                            AutoSize = true
                        };

                        Button buttonProfile = new Button()
                        {
                            Location = new Point(416, 18),
                            Size = new Size(32, 32),
                            Text = string.Empty,
                            Image = Image.FromFile(GetPicture("icons8-мужчина-32.png")),
                            Tag = reader["QueryRecipient"].ToString(),
                            FlatStyle = FlatStyle.Flat
                        };
                        buttonProfile.FlatAppearance.BorderSize = 0;
                        buttonProfile.Click += OpenProfile;

                        Button buttonDelete = new Button()
                        {
                            Location = new Point(454, 18),
                            Size = new Size(32, 32),
                            Text = string.Empty,
                            Image = Image.FromFile(GetPicture("icons8-удалить-32 (1).png")),
                            Tag = reader["QueryRecipient"].ToString(),
                            FlatStyle = FlatStyle.Flat
                        };
                        buttonDelete.FlatAppearance.BorderSize = 0;
                        buttonDelete.Click += DeleteQuery;

                        SubPanel.Controls.Add(panel);
                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(label);
                        panel.Controls.Add(buttonProfile);
                        panel.Controls.Add(buttonDelete);
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

        void OpenProfile(object sender, EventArgs e)
        {
            var button = sender as Button;
            ((MainForm)(MainForm.ActiveForm)).LoadFriendProfile(button.Tag.ToString());
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

        private string GetInfo(string Username, string Info)
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
                    while (reader.Read())
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

        private void DeleteQuery(object sender, EventArgs e)
        {
            var button = sender as Button;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Delete From ActiveQuery Where QuerySender = '{username}' And QueryRecipient = '{button.Tag.ToString()}'";
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
        }

        int GetQueryCount()
        {
            int queryCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From ActiveQuery Where QuerySender = '{username}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        queryCount++;
                    }
                    QueryCount_Label.Text = queryCount.ToString();
                    return queryCount;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("GetQueryCount():\n" + ex.Message, ex.Source);
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
