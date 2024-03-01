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
using Send.Пользовательские_элементы_управления;
using System.Net.Mail;
using System.Net;

namespace Send
{
    public partial class Registration : Form
    {
        string connectionString = string.Empty;
        string GenderValue = "Male";
        string AgreementValue = "Disagree";
        string randomCode = string.Empty;

        double Seconds = 10;

        int TimeMinutes = 0, TimeSeconds = 10;

        bool IsMouseDown = false;

        Point mouseOffset;

        private void Registration_Load(object sender, EventArgs e)
        {
            Authorization login = new Authorization();
            connectionString = login.connectionString;

            TimerContinue.Start();
            LoadCountry();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Authorization login = new Authorization();
            login.Show();
            this.Hide();
        }

        public Registration()
        {
            InitializeComponent();
        }

        private void Gender_Click(object sender, EventArgs e)
        {
            if (GenderValue == "Male")
            {
                GenderValue = "Female";
                Gender.Image = Image.FromFile(GetResources("Включить.png"));
            }
            else if (GenderValue == "Female")
            {
                GenderValue = "Male";
                Gender.Image = Image.FromFile(GetResources("Выключить.png"));
            }
        }

        private void Agreement_Click(object sender, EventArgs e)
        {
            if (AgreementValue == "Disagree")
            {
                AgreementValue = "Agree";
                Agreement.Image = Image.FromFile(GetResources("Точка в круге.png"));
                RegistrationButton.Enabled = true;
                RegistrationButton.FlatAppearance.BorderSize = 1;
            }
            else if (AgreementValue == "Agree")
            {
                AgreementValue = "Disagree";
                Agreement.Image = Image.FromFile(GetResources("Круг.png"));
                RegistrationButton.Enabled = false;
                RegistrationButton.FlatAppearance.BorderSize = 0;
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (CheckVoid() && !CheckUsername())
            {
                string stringrandomCode = string.Empty;
                string stringUsername = string.Empty;
                string stringPassword = string.Empty;
                string stringEMail = string.Empty;
                string stringFirstName = string.Empty;
                string stringSecondName = string.Empty;
                string stringThirdName = string.Empty;
                string stringPhoneNumber = string.Empty;
                string stringGender = string.Empty;
                string stringCountry = string.Empty;
                string stringCity = string.Empty;
                DateTime datetimeBirthDate;

                if (ThirdName.Text != "")
                    stringThirdName = ThirdName.Text;

                if (PhoneNumber.Text != "")
                    stringPhoneNumber = PhoneNumber.Text;

                if (GenderValue == "Male")
                    stringGender = "Мужской";
                else
                    stringGender = "Женский";

                if (Country.Text != "")
                    stringCountry = Country.Text;
                else if (Country.Text == "" || Country.Text == "Не выбрано")
                    stringCountry = "Не указано";

                if (City.Text != "")
                    stringCity = City.Text;
                else if (City.Text == "" || City.Text == "Не выбрано")
                    stringCity = "Не указано";
                datetimeBirthDate =  Convert.ToDateTime(BirthDate.Text);

                MailConfirm confirm = new MailConfirm();
                confirm.Username = stringUsername;
                confirm.Password = stringPassword;
                confirm.EMail = stringEMail;
                confirm.FirstName = stringFirstName;
                confirm.SecondName = stringSecondName;
                confirm.ThirdName = stringThirdName;
                confirm.PhoneNumber = stringPhoneNumber;
                confirm.Gender = stringGender;
                confirm.Country = stringCountry;
                confirm.City = stringCity;
                randomCode = GenerateRandomCode();
                confirm.randomCode = randomCode;
                SendCode();
                confirm.Show();
            }
            else if (CheckUsername())
            {
                MessageBox.Show("Пользователь с указанным логином уже существует.", "Ошибка", MessageBoxButtons.OK);
            }
            else if (!CheckVoid())
            {
                MessageBox.Show("Пожалуйста, проверьте правильность указанных данных.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void TimerContinue_Tick(object sender, EventArgs e)
        {
            if (Seconds != 0)
            {
                Seconds--;
                TimeSeconds--;
                if (TimeSeconds < 0 && TimeMinutes != 0)
                {
                    TimeMinutes--;
                    TimeSeconds = 59;
                }
                if (TimeSeconds < 10)
                    TimeLeft.Text = "Можно продолжить через: " + TimeMinutes + ":0" + TimeSeconds;
                else
                    TimeLeft.Text = "Можно продолжить через: " + TimeMinutes + ":" + TimeSeconds;
                TimerContinue.Start();
            }
            else
            {
                Agreement.Enabled = true;
                TimeLeft.Visible = false;
            }
        }

        private bool CheckVoid()
        {
            if (Username.Text != "Логин" || Username.Text != "" ||
                Password.Text != "Пароль" || Password.Text != "" ||
                EMail.Text != "Электронная почта" || EMail.Text != "" ||
                SecondName.Text != "Фамилия" || SecondName.Text != "" ||
                FirstName.Text != "Имя" || FirstName.Text != "" || BirthDate.Text != "")
            {

                string[] birthDate = BirthDate.Text.Split('.');
                if (birthDate[0] == string.Empty || Convert.ToInt32(birthDate[0]) < 01 || Convert.ToInt32(birthDate[0]) > 31)
                    return false;
                if (birthDate[1] == string.Empty || Convert.ToInt32(birthDate[1]) < 01 || Convert.ToInt32(birthDate[1]) > 12)
                    return false;
                if (birthDate[2] == string.Empty || Convert.ToInt32(birthDate[2]) < 1900 || Convert.ToInt32(birthDate[2]) > DateTime.Now.Year)
                    return false;

                try
                {
                    Convert.ToDateTime(BirthDate.Text);
                    return true;
                }
                catch
                {
                    MessageBox.Show("Возникла непредвиденная ситуация.\nПожалуйста, обратитесь к разработчику, приложив\nскришот ошибки", "Ошибка", MessageBoxButtons.OK);
                    return false;
                }
            }
            else
                return false;
        }

        private bool CheckUsername()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Users Where Username = '{Username.Text}'";
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
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CheckUsername():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            return true;
        }

        public void CloseForm()
        {
            Authorization login = new Authorization();
            this.Hide();
            login.Show();
        }

        public string GetResources(string File)
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo di = new DirectoryInfo(path);
            return di.Parent.Parent.FullName + @"\Resources\" + File;
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "Логин")
            {
                Username.Text = "";
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Логин";
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Пароль")
            {
                Password.Text = "";
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Пароль";
            }
        }

        private void EMail_Enter(object sender, EventArgs e)
        {
            if (EMail.Text == "Электронная почта")
            {
                EMail.Text = "";
            }
        }

        private void EMail_Leave(object sender, EventArgs e)
        {
            if (EMail.Text == "")
            {
                EMail.Text = "Электронная почта";
            }
        }

        private void SecondName_Enter(object sender, EventArgs e)
        {
            if (SecondName.Text == "Фамилия")
            {
                SecondName.Text = "";
            }
        }

        private void SecondName_Leave(object sender, EventArgs e)
        {
            if (SecondName.Text == "")
            {
                SecondName.Text = "Фамилия";
            }
        }

        private void FirstName_Enter(object sender, EventArgs e)
        {
            if (FirstName.Text == "Имя")
            {
                FirstName.Text = "";
            }
        }

        private void FirstName_Leave(object sender, EventArgs e)
        {
            if (FirstName.Text == "")
            {
                FirstName.Text = "Имя";
            }
        }

        private void ThirdName_Enter(object sender, EventArgs e)
        {
            if (ThirdName.Text == "Отчество")
            {
                ThirdName.Text = "";
            }
        }

        private void ThirdName_Leave(object sender, EventArgs e)
        {
            if (ThirdName.Text == "")
            {
                ThirdName.Text = "Отчество";
            }
        }

        private void PhoneNumber_Enter(object sender, EventArgs e)
        {
            if (PhoneNumber.Text == "Номер телефона")
            {
                PhoneNumber.Text = "";
            }
        }

        private void PhoneNumber_Leave(object sender, EventArgs e)
        {
            if (PhoneNumber.Text == "")
            {
                PhoneNumber.Text = "Номер телефона";
            }
        }

        private void BirchDate_Enter(object sender, EventArgs e)
        {
            if (BirthDate.Text == "Дата рождения")
            {
                BirthDate.Text = "";
            }
        }

        private void Country_Leave(object sender, EventArgs e)
        {
            if (Country.Text == "")
            {
                Country.Text = "Не выбрано";
            }
        }

        private void City_Leave(object sender, EventArgs e)
        {
            if (City.Text == "")
            {
                City.Text = "Не выбрано";
            }
        }

        private void CenterPanel_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void CenterPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X - LeftPanel.Width, -e.Y);
                IsMouseDown = true;
            }
        }

        private void CenterPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                Point mousePosition = MousePosition;
                mousePosition.Offset(mouseOffset);
                Location = mousePosition;
            }
        }

        void LoadCountry()
        {
            Country.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Country Order By CountryName";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Country.Items.Add(reader["CountryName"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadCountry():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        string GetCountryID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From Country Where CountryName = '{Country.SelectedItem}'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader["CountryID"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("GetCountryID():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
            return "Error";
        }

        private void Country_TextChanged(object sender, EventArgs e)
        {
            LoadCity();
        }

        void LoadCity()
        {
            City.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From City Where CountryID = '{GetCountryID()}' Order By CityName";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        City.Items.Add(reader["CityName"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadCity():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        string GenerateRandomCode()
        {
            string randomCode = string.Empty;
            Random random = new Random();
            for (int i = 1; i <= 6; i++)
            {
                int number = random.Next(10);
                randomCode += number.ToString();
            }
            return randomCode;
        }

        void SendCode()
        {
            MailAddress fromAddress = new MailAddress("89640338120oleg@gmail.com", "Send Fa.");
            MailAddress toAddress = new MailAddress(EMail.Text);

            using (MailMessage message = new MailMessage(fromAddress, toAddress))
            using (SmtpClient client = new SmtpClient())
            {
                message.Subject = "Регистрация новой учётной записи Send";
                message.Body = "Здравствуйте!\n" + "Этот адрес электронной почты был указан для регистрации новой учётной записи. Если Вы действительно регистрировались в сети Send, пожалуйста, введите в окно подтверждения следующий код:\n" + randomCode + "\n\n" + "Если Вы не регистрировались в сети Send - просто проигнорируйте это сообщение.\n\nС уважением,\nРазработчики Send F.";

                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(fromAddress.Address, "Andersantino2001-");

                client.Send(message);
            }
        }
    }
}
