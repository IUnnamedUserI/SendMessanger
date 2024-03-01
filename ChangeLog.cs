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
    public partial class ChangeLog : Form
    {
        string connectionString = string.Empty;
        public ChangeLog()
        {
            InitializeComponent();
            Authorization login = new Authorization();
            connectionString = login.connectionString;
        }

        async void LoadVersionData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $@"Select * From ChangeLog Order By VersionID Desc";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = await command.ExecuteReaderAsync();
                    if (reader.Read())
                    {
                        Version_Label.Text = reader["VersionNumber"].ToString();
                        Date_Label.Text = reader["VersionDate"].ToString().Split(' ')[0];
                        string[] versionCommentSplit = reader["VersionComment"].ToString().Split(';');
                        string versionComment = string.Empty;
                        foreach (string str in versionCommentSplit)
                        {
                            versionComment += "[-] " + str + "\n";
                        }
                        ChangeLog_Label.Text = versionComment;
                    }
                    this.Activate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LoadVersionData():\n" + ex.Message, ex.Source);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void ChangeLog_Load(object sender, EventArgs e)
        {
            LoadVersionData();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
