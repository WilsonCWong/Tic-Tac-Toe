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
    public partial class TournamentMatchPrompt : Form
    {
        public int selectedChoice;

        public TournamentMatchPrompt()
        {
            InitializeComponent();
            this.yesButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.yesButton.MouseLeave += CommonEvents.menuButton_MouseLeave;

            this.noButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.noButton.MouseLeave += CommonEvents.menuButton_MouseLeave;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            selectedChoice = 0;
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            selectedChoice = 1;
            this.Close();
        }
    }
}
