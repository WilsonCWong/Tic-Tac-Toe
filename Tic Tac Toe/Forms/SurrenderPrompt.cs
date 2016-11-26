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
    public partial class SurrenderPrompt : Form
    {
        public int selectedChoice;

        public SurrenderPrompt()
        {
            InitializeComponent();
            this.okButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.okButton.MouseLeave += CommonEvents.menuButton_MouseLeave;

            this.cancelButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.cancelButton.MouseLeave += CommonEvents.menuButton_MouseLeave;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            selectedChoice = 0;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            selectedChoice = 1;
            this.Close();
        }
    }
}
