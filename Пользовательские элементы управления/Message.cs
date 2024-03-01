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

namespace Send
{
    public partial class Message : UserControl
    {
        string connectionString = string.Empty;
        public string User;
        string FriendUsername;

        public Message()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        private void Message_Load(object sender, EventArgs e)
        {
            
        }

        private void Messages_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Messages_ListBox.SelectedItem = null;
        }

        private void Friends_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Friends_ListBox.SelectedItem != null)
            {
                FriendUsername = Friends_ListBox.SelectedItem.ToString();
                LoadMessages(User, FriendUsername);
                Friends_ListBox.SelectedItem = null;
            }
        }

        private void SendMessage_Button_Click(object sender, EventArgs e)
        {
            string message = Message_TextBox.Text;

            if (message != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "Insert Into Messages (Time, SenderUsername, RecipientUsername, Message) Values (@time, @sender, @recipient, @message)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue(@"time", System.DateTime.Now);
                    command.Parameters.AddWithValue(@"sender", User);
                    command.Parameters.AddWithValue(@"recipient", FriendUsername);
                    command.Parameters.AddWithValue(@"message", message);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Message_TextBox.Text = "";
                        LoadMessages(User, FriendUsername);
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
            else
            {
                Message_TextBox.BackColor = Color.FromArgb(156, 24, 50);
                WarningMessage.Start();
            }
        }

        public void LoadMessages(string Username, string FriendUsername)
        {
            Messages_ListBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * From Messages Where SenderUsername = @sender And RecipientUsername = @recipient Or SenderUsername = @recipient And RecipientUsername = @sender Order By Time";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                command.Parameters.AddWithValue(@"sender", Username);
                command.Parameters.AddWithValue(@"recipient", FriendUsername);

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Messages_ListBox.Items.Add("[" + reader["Time"] + "] " + reader["SenderUsername"] + ": " + reader["Message"]);
                        Messages_ListBox.ItemHeight = 20;
                        UpdateTimer.Start();
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

        private void WarningMessage_Tick(object sender, EventArgs e)
        {
            Message_TextBox.BackColor = Color.FromArgb(39, 21, 70);
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            LoadMessages(User, FriendUsername);
        }

        public void LoadFriends(string Username)
        {
            Friends_ListBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * From Friends Where Username = '" + Username + "' Order By FriendUsername";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Friends_ListBox.Items.Add(reader["FriendUsername"].ToString());
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

        private void Message_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage_Button_Click(sender, e);
            }
        }

        private void Friends_ListBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
