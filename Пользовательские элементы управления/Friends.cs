using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Send
{
    public partial class Friends : UserControl
    {
        public string username;

        public Friends()
        {
            InitializeComponent();
        }

        public void Friends_Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button.Image == null)
            {
                SlidePanel.Width = button.Width;
                SlidePanel.Left = button.Left;
            }

            FriendsList_Panel.BringToFront();
            FriendsList_Panel.username = username;
            FriendsList_Panel.LoadFriends();
        }

        public void IncomingQuery_Button_Click(object sender, EventArgs e)
        {
            ShowIncoming();
        }

        public void OutcomingQuery_Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            SlidePanel.Width = button.Width;
            SlidePanel.Left = button.Left;
            //Code
            OutcomingQuerys_Panel.BringToFront();
            OutcomingQuerys_Panel.username = username;
            OutcomingQuerys_Panel.LoadQuerys(username);
        }

        public void ShowIncoming()
        {
            SlidePanel.Width = IncomingQuery_Button.Width;
            SlidePanel.Left = IncomingQuery_Button.Left;
            //Code
            IncomingQuerys_Panel.BringToFront();
            IncomingQuerys_Panel.username = username;
            IncomingQuerys_Panel.LoadQuerys(username);
        }
    }
}
