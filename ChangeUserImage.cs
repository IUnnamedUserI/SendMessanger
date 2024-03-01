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
    public partial class ChangeUserImage : Form
    {
        string connectionString = string.Empty;
        string selectedPicture = "None";
        public string username;
        bool Pavel = false;

        public ChangeUserImage()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        private void Picture1_PictureBox_Click(object sender, EventArgs e)
        {
            Picture1_PictureBox.BorderStyle = BorderStyle.FixedSingle;
            Picture2_PictureBox.BorderStyle = BorderStyle.None;
            Picture3_PictureBox.BorderStyle = BorderStyle.None;
            Picture4_PictureBox.BorderStyle = BorderStyle.None;
            SelectedUserPicture_PictureBox.BorderStyle = BorderStyle.None;
            selectedPicture = "DefaultIcon1.png";
            Pavel = false;

        }

        private void Picture2_PictureBox_Click(object sender, EventArgs e)
        {
            Picture1_PictureBox.BorderStyle = BorderStyle.None;
            Picture2_PictureBox.BorderStyle = BorderStyle.FixedSingle;
            Picture3_PictureBox.BorderStyle = BorderStyle.None;
            Picture4_PictureBox.BorderStyle = BorderStyle.None;
            SelectedUserPicture_PictureBox.BorderStyle = BorderStyle.None;
            selectedPicture = "DefaultIcon2.png";
            Pavel = false;
        }

        private void Picture3_PictureBox_Click(object sender, EventArgs e)
        {
            Picture1_PictureBox.BorderStyle = BorderStyle.None;
            Picture2_PictureBox.BorderStyle = BorderStyle.None;
            Picture3_PictureBox.BorderStyle = BorderStyle.FixedSingle;
            Picture4_PictureBox.BorderStyle = BorderStyle.None;
            SelectedUserPicture_PictureBox.BorderStyle = BorderStyle.None;
            selectedPicture = "DefaultIcon3.png";
            Pavel = false;
        }

        private void Picture4_PictureBox_Click(object sender, EventArgs e)
        {
            Picture1_PictureBox.BorderStyle = BorderStyle.None;
            Picture2_PictureBox.BorderStyle = BorderStyle.None;
            Picture3_PictureBox.BorderStyle = BorderStyle.None;
            Picture4_PictureBox.BorderStyle = BorderStyle.FixedSingle;
            SelectedUserPicture_PictureBox.BorderStyle = BorderStyle.None;
            selectedPicture = "DefaultIcon4.png";
            Pavel = false;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (Pavel == false)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $@"Update Users Set Picture = '{selectedPicture}' Where Username = '{username}'";
                    SqlCommand command = new SqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        this.Hide();
                        ((MainForm)(MainForm.ActiveForm)).LoadProfile();
                        ((MainForm)(MainForm.ActiveForm)).Panel_EditProfile.LoadProfile();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Save_Button_Click():\n" + ex.Message, ex.Source);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                string endPath = Directory.GetCurrentDirectory();
                DirectoryInfo directoryInfo = new DirectoryInfo(endPath);
                File.Copy(Path_TextBox.Text, directoryInfo.Parent.Parent.FullName + @"\Resources\UserIcons\" + selectedPicture);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $@"Update Users Set Picture = '{selectedPicture}' Where Username = '{username}'";
                    SqlCommand command = new SqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        this.Hide();
                        ((MainForm)(MainForm.ActiveForm)).LoadProfile();
                        ((MainForm)(MainForm.ActiveForm)).Panel_EditProfile.LoadProfile();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Save_Button_Click():\n" + ex.Message, ex.Source);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void View_Button_Click(object sender, EventArgs e)
        {
            Picture1_PictureBox.BorderStyle = BorderStyle.None;
            Picture2_PictureBox.BorderStyle = BorderStyle.None;
            Picture3_PictureBox.BorderStyle = BorderStyle.None;
            Picture4_PictureBox.BorderStyle = BorderStyle.None;
            SelectedUserPicture_PictureBox.BorderStyle = BorderStyle.FixedSingle;

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Pavel = true;
                Path_TextBox.Text = OpenFileDialog.FileName;
                SelectedUserPicture_PictureBox.Image = Image.FromFile(Path_TextBox.Text);
                selectedPicture = OpenFileDialog.SafeFileName;
            }
        }
    }
}
