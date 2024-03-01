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
    public partial class ChangeNameList : UserControl
    {
        string connectionString = string.Empty;
        public string username = string.Empty;

        public ChangeNameList()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        private void ChangesList_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From ChangeNameQuery Where Username = '{ChangesList_ListBox.SelectedItem}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        QueryDate_TextBox.Text = reader["Time"].ToString();
                        QueryUsername_TextBox.Text = reader["Username"].ToString();
                        QueryNameOld_TextBox.Text = GetUserInfo(ChangesList_ListBox.SelectedItem.ToString(), "SecondName") + " " + GetUserInfo(ChangesList_ListBox.SelectedItem.ToString(), "FirstName") + " " + GetUserInfo(ChangesList_ListBox.SelectedItem.ToString(), "ThirdName");
                        QueryNameNew_TextBox.Text = reader["NewSecondName"].ToString() + " " + reader["NewFirstName"].ToString() + " " + reader["NewThirdName"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ChangesList_ListBox_SelectedIndexChanged():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
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
        }       //Получение информации о пользователе

        public void LoadQuerys()
        {
            ChangesList_ListBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From ChangeNameQuery";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ChangesList_ListBox.Items.Add(reader["Username"].ToString());
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
        }       //Загрузка запросов

        private void CancelQuery_Button_Click(object sender, EventArgs e)
        {
            if (ChangesList_ListBox.SelectedItem != null)
            {
                AddActionArchive(username, "Отказ в смене имени пользователю " + QueryUsername_TextBox.Text);
                DeleteQuery();
            }
        }

        private void ApplyQuery_Button_Click(object sender, EventArgs e)
        {
            if (ChangesList_ListBox.SelectedItem != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $@"Update Users Set SecondName = '{GetQueryInfo(ChangesList_ListBox.SelectedItem.ToString(), "NewSecondName")}', FirstName = '{GetQueryInfo(ChangesList_ListBox.SelectedItem.ToString(), "NewFirstName")}', ThirdName = '{GetQueryInfo(ChangesList_ListBox.SelectedItem.ToString(), "NewThirdName")}' Where Username = '{QueryUsername_TextBox.Text}'";
                    SqlCommand command = new SqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        AddActionArchive(username, "Одобрение смены имени пользователю " + QueryUsername_TextBox.Text);

                        DeleteQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ApplyQuery_Button_Click():\n" + ex.Message, ex.Source);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void DeleteQuery()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Delete From ChangeNameQuery Where Username = '{QueryUsername_TextBox.Text}'";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadQuerys();

                    QueryDate_TextBox.Text = string.Empty;
                    QueryUsername_TextBox.Text = string.Empty;
                    QueryNameOld_TextBox.Text = string.Empty;
                    QueryNameNew_TextBox.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DeleteQuery():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }       //Удаление запроса

        private string GetQueryInfo(string Username, string Info)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From ChangeNameQuery Where Username = '{Username}'";
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
                    MessageBox.Show("GetQueryInfo():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            return "Error";
        }       //Получение информации о запросе

        private void AddActionArchive(string ActionSender, string ActionDescription)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Insert Into ActionArchive (DateTime, ActionSender, Action) Values ('{System.DateTime.Now}', '{ActionSender}', '{ActionDescription}')";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("AddActionArchive():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }       //Добавление действия в архив
    }
}
