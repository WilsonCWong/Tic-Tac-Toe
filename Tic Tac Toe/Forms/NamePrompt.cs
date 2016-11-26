using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class NamePrompt : Form
    {
        public string userName;
 

        public NamePrompt()
        {
            InitializeComponent();
            this.okButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.okButton.MouseLeave += CommonEvents.menuButton_MouseLeave;

            this.cancelButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.cancelButton.MouseLeave += CommonEvents.menuButton_MouseLeave;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("You need to put something in the field!");
            }
            else
            {
                userName = nameTextBox.Text;
                this.Close();
            }        
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            userName = "";
            this.Close();
        }
    }
}
