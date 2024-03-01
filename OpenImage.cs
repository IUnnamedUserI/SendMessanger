using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Send
{
    public partial class OpenImage : Form
    {
        public string path = string.Empty;
        public OpenImage()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DownloadPicture_Button_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                File.Copy(path, SaveFile.FileName, true);
            }
        }
    }
}
