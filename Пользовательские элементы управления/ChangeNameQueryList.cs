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
    public partial class ChangeNameQueryList : UserControl
    {
        string connectionString = string.Empty;
        public string username = string.Empty;

        public ChangeNameQueryList()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        private void ChangeNameQueryList_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            if (ChangeNameQueryList_ListBox.SelectedItem != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $@"Select * From ChangeNameQuery Where Username = '{listBox.SelectedItem.ToString()}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader;

                    try
                    {
                        connection.Open();
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            Username_Textbox.Text = reader["Username"].ToString();
                            OldName_TextBox.Text = GetUserInfo(listBox.SelectedItem.ToString(), "SecondName") + " " + GetUserInfo(listBox.SelectedItem.ToString(), "FirstName") + " " + GetUserInfo(listBox.SelectedItem.ToString(), "ThirdName");
                            NewName_TextBox.Text = reader["NewSecondName"].ToString() + " " + reader["NewFirstName"].ToString() + " " + reader["NewThirdName"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ChangeNameQueryList_ListBox_SelectedIndexChanged():\n" + ex.Message, ex.Source);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
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
                        return reader["Info"].ToString();
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

        public void LoadInfo()
        {
            ChangeNameQueryList_ListBox.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * From ChangeNameQuery";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ChangeNameQueryList_ListBox.Items.Add(reader["Username"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadInfo():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
