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

namespace Send.Пользовательские_элементы_управления
{
    public partial class VoteList : UserControl
    {
        string connectionString = string.Empty;
        public string username = string.Empty;
        string selectedSender = string.Empty;
        string selectedSuspect = string.Empty;

        List<string> senderUser = new List<string>();
        List<string> suspectUser = new List<string>();
        List<Button> buttonList = new List<Button>();

        public VoteList()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        public void LoadVotes()
        {
            ClearVoteList();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Votes";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Button voteButton = new Button();

                        LeftPanel.Controls.Add(voteButton);

                        voteButton.Dock = DockStyle.Top;
                        voteButton.FlatStyle = FlatStyle.Flat;
                        voteButton.Height = 40;
                        voteButton.Text = "Жалоба " + reader["SenderVote"].ToString() + " на " + reader["VotedUser"].ToString();
                        voteButton.TextAlign = ContentAlignment.MiddleLeft;
                        voteButton.Tag = buttonList.Count;
                        voteButton.Click += VoteButton_Clicked;

                        buttonList.Add(voteButton);
                        senderUser.Add(reader["SenderVote"].ToString());
                        suspectUser.Add(reader["VotedUser"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadVotes():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void BlockUser_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Update Users Set Status = '{"Banned"}' Where Username = '{Suspect_TextBox.Text}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    DeleteVote("Пользователь заблокирован (" + Suspect_TextBox.Text + ")");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("BlockUser_Button_Click():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void DeleteVote(string Result)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Delete From Votes Where SenderVote = '{VoteSender_TextBox.Text}' And VotedUser = '{Suspect_TextBox.Text}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    AddInArchive(Result);
                    ClearTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DeleteVote():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void AddInArchive(string Result)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Insert Into ActionArchive (DateTime, ActionSender, Action)" +
                                                $@"Values ('{System.DateTime.Now}', '{username}', '{Result}')";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadVotes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("AddInArchive():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Ignore_Button_Click(object sender, EventArgs e)
        {
            DeleteVote("Жалоба игнорирована (нарушитель - " + Suspect_TextBox.Text + ")");
        }

        private void ClearTextBox()
        {
            LoadVotes();
            Time_TextBox.Text = string.Empty;
            VoteSender_TextBox.Text = string.Empty;
            Suspect_TextBox.Text = string.Empty;
            Reason_RichTextBox.Text = string.Empty;
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

        private void VoteButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            FillInfo(senderUser[Convert.ToInt32(button.Tag)], suspectUser[Convert.ToInt32(button.Tag)]);
            selectedSender = senderUser[Convert.ToInt32(button.Tag)];
            selectedSuspect = suspectUser[Convert.ToInt32(button.Tag)];
        }

        private void FillInfo(string SenderUsername, string SuspectUsername)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Votes Where SenderVote = '{SenderUsername}' And VotedUser = '{SuspectUsername}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Time_TextBox.Text = reader["Time"].ToString();
                        VoteSender_TextBox.Text = GetUserInfo(SenderUsername, "SecondName") + " " + GetUserInfo(SenderUsername, "FirstName") + " " + GetUserInfo(SenderUsername, "ThirdName");
                        Suspect_TextBox.Text = GetUserInfo(SuspectUsername, "SecondName") + " " + GetUserInfo(SuspectUsername, "FirstName") + " " + GetUserInfo(SuspectUsername, "ThirdName");
                        Reason_RichTextBox.Text = reader["Reason"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("FillInfo():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void SenderProfile_Button_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.FlatAppearance.BorderColor = Color.FromArgb(156, 24, 50);
            button.ForeColor = Color.FromArgb(156, 24, 50);
        }

        private void SuspectProfile_Button_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.FlatAppearance.BorderColor = Color.FromArgb(156, 24, 50);
            button.ForeColor = Color.FromArgb(156, 24, 50);
        }

        private void SenderProfile_Button_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.FlatAppearance.BorderColor = Color.White;
            button.ForeColor = Color.White;
        }

        private void SuspectProfile_Button_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.FlatAppearance.BorderColor = Color.White;
            button.ForeColor = Color.White;
        }

        private void ClearVoteList()
        {
            foreach (Button button in buttonList)
            {
                button.Dispose();
            }
            buttonList.Clear();
            senderUser.Clear();
            suspectUser.Clear();
        }

        private void SenderProfile_Button_Click(object sender, EventArgs e)
        {
            ((MainForm)(MainForm.ActiveForm)).LoadFriendProfile(selectedSender);
        }

        private void SuspectProfile_Button_Click(object sender, EventArgs e)
        {
            ((MainForm)(MainForm.ActiveForm)).LoadFriendProfile(selectedSuspect);
        }
    }
}
