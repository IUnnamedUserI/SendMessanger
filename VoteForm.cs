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
    public partial class VoteForm : Form
    {
        private string connectionString = string.Empty;
        public string username = string.Empty;
        public string votedUser = string.Empty;

        public VoteForm()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        private void OffensiveVote_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SpamVote_RadioButton.Checked = false;
            UserImage_RadioButton.Checked = false;
            UserName_RadioButton.Checked = false;
            OtherVote_RadioButton.Checked = false;
        }

        private void UserImage_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SpamVote_RadioButton.Checked = false;
            OffensiveVote_RadioButton.Checked = false;
            UserName_RadioButton.Checked = false;
            OtherVote_RadioButton.Checked = false;
        }

        private void UserName_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SpamVote_RadioButton.Checked = false;
            OffensiveVote_RadioButton.Checked = false;
            UserImage_RadioButton.Checked = false;
            OtherVote_RadioButton.Checked = false;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SpamVote_RadioButton_Click(object sender, EventArgs e)
        {
            OtherVote_RichTextBox.Enabled = false;
        }

        private void OtherVote_RadioButton_Click(object sender, EventArgs e)
        {
            OtherVote_RichTextBox.Enabled = true;
        }

        private void OffensiveVote_RadioButton_Click(object sender, EventArgs e)
        {
            OtherVote_RichTextBox.Enabled = false;
        }

        private void UserImage_RadioButton_Click(object sender, EventArgs e)
        {
            OtherVote_RichTextBox.Enabled = false;
        }

        private void UserName_RadioButton_Click(object sender, EventArgs e)
        {
            OtherVote_RichTextBox.Enabled = false;
        }

        public void LoadForm()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Users Where Username = '{votedUser}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        VoteTitle_Label.Text = "Отправить жалобу на " + reader["SecondName"].ToString() + " " + reader["FirstName"].ToString() + " " + reader["ThirdName"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadForm():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void SendVote_Button_Click(object sender, EventArgs e)
        {
            string voteReason = string.Empty;

            if (SpamVote_RadioButton.Checked == true)
                voteReason = "Спам/флуд/бот";
            else if (OffensiveVote_RadioButton.Checked == true)
                voteReason = "Оскорбления/нецензурная лексика";
            else if (UserImage_RadioButton.Checked == true)
                voteReason = "Содержание аватара";
            else if (UserName_RadioButton.Checked == true)
                voteReason = "Содержание ФИО";
            else if (OtherVote_RadioButton.Checked == true)
                voteReason = OtherVote_RichTextBox.Text;

            if (!CheckVote())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $@"Insert Into Votes (Time, SenderVote, VotedUser, Reason)
                                            Values (@datetime, '{username}', '{votedUser}', '{voteReason}')";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue(@"datetime", DateTime.Now);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SendVote_Button_Click():\n" + ex.Message, ex.Source);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $@"Update Votes Set Time = @datetime, SenderVote = '{username}', VotedUser = '{votedUser}', Reason = '{voteReason}' Where SenderVote = '{username}' And VotedUser = '{votedUser}'";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue(@"datetime", DateTime.Now);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SendVote_Button_Click():\n" + ex.Message, ex.Source);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        bool CheckVote()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Votes Where SenderVote = '{username}' And VotedUser = '{votedUser}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return true;
                    }
                    else return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CheckVote():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
    }
}
