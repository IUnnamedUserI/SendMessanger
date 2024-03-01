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
    public partial class MailConfirm : Form
    {
        public string connectionString = string.Empty;
        public string randomCode = string.Empty;
        public string Username = string.Empty;
        public string Password = string.Empty;
        public string EMail = string.Empty;
        public string FirstName = string.Empty;
        public string SecondName = string.Empty;
        public string ThirdName = string.Empty;
        public string PhoneNumber = string.Empty;
        public string Gender = string.Empty;
        public string Country = string.Empty;
        public string City = string.Empty;
        public DateTime BirthDate;

        public MailConfirm()
        {
            InitializeComponent();

            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        void Registration()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Insert Into Users (Username, Password, EMail, FirstName, SecondName, ThirdName, PhoneNumber, Gender, Role, Picture, Status, RegistrationDate, Country, City, BirthDate)" +
                                        $@"Values ('{Username}', '{Password}', '{EMail}', '{FirstName}', '{SecondName}', '{ThirdName}', '{PhoneNumber}', '{Gender}', 'Пользователь', 'DefaultIcon1.png', 'Подверждён', @registrationDate, '{Country}', '{City}', @birthdate)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(@"registrationDate", System.DateTime.Now);
                command.Parameters.AddWithValue(@"birthdate", BirthDate);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    RegistrationSuccess rs = new RegistrationSuccess();
                    rs.Show();
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

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if (Code_TextBox.Text == randomCode)
                MessageBox.Show("Совпадает");
            else
                MessageBox.Show("Не совпадает");
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
