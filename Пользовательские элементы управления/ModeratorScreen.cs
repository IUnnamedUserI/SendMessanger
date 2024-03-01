using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Send.Пользовательские_элементы_управления
{
    public partial class ModeratorScreen : UserControl
    {
        public string username;

        public ModeratorScreen()
        {
            InitializeComponent();
        }

        public void ChangeNames_Button_Click(object sender, EventArgs e)
        {
            ChangeNameList_Panel.BringToFront();
            ChangeNameList_Panel.LoadQuerys();
            ChangeNameList_Panel.username = username;
        }

        private void Votes_Button_Click(object sender, EventArgs e)
        {
            VoteList_Panel.username = username;
            VoteList_Panel.BringToFront();
            VoteList_Panel.LoadVotes();
        }
    }
}
