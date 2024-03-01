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
    public partial class ChangeName : Form
    {
        string connectionString = string.Empty;
        public string username = string.Empty;

        public ChangeName()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        private void SendQuery_Button_Click(object sender, EventArgs e)
        {
            if (NewSecondname_TextBox.Text != string.Empty)
            {
                if (CheckUserQuery() == true)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = $@"Update ChangeNameQuery Set Time = '{System.DateTime.Now}', NewSecondName = '{NewSecondname_TextBox.Text}', NewFirstName = '{NewFirstname_TextBox.Text}', NewThirdName = '{NewThirdname_TextBox.Text}'";
                        SqlCommand command = new SqlCommand(query, connection);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Заявка успешно отправлена");
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SendQuery_Button_Click():\n" + ex.Message, ex.Source);
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
                        string query = $@"Insert Into ChangeNameQuery (Time, Username, NewSecondName, NewFirstName, NewThirdName) 
                                                                        Values ('{System.DateTime.Now}', '{username}', '{NewSecondname_TextBox.Text}', '{NewFirstname_TextBox.Text}', '{NewThirdname_TextBox.Text}')";
                        SqlCommand command = new SqlCommand(query, connection);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Заявка успешно отправлена");
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SendQuery_Button_Click():\n" + ex.Message, ex.Source);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private bool CheckUserQuery()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From ChangeNameQuery Where Username = '{username}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CheckUserQuery():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            return true;
        }

        private void HideForm_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void ChangeName_Load(object sender, EventArgs e)
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
                        NewSecondname_TextBox.Text = reader["SecondName"].ToString();
                        NewFirstname_TextBox.Text = reader["FirstName"].ToString();
                        NewThirdname_TextBox.Text = reader["ThirdName"].ToString();
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
    }
}
