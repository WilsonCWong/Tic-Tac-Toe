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
    public partial class GameEndScreen : Form
    {
        public int selectedChoice = 0;

        public GameEndScreen()
        {
            InitializeComponent();
            this.playAgainButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.playAgainButton.MouseLeave += CommonEvents.menuButton_MouseLeave;

            this.forfeitButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.forfeitButton.MouseLeave += CommonEvents.menuButton_MouseLeave;
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void forfeitButton_Click(object sender, EventArgs e)
        {
            selectedChoice = 1;
            this.Close();
        }
    }
}
