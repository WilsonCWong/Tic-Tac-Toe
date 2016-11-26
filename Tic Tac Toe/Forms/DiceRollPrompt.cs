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
    public partial class DiceRollPrompt : Form
    {
        int selectedIndex = 0;
        public Game.Participant firstToGo;

        public DiceRollPrompt()
        {
            InitializeComponent();
            this.rollButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.rollButton.MouseLeave += CommonEvents.menuButton_MouseLeave;
            playerPictureBox.Image = Player.profilePicture;
            playerChoiceLabel.Text = "Choice: Evens";
            aiChoiceLabel.Text = "Choice: Odds";
            evenButton.ForeColor = Color.White;
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            int chosenNumber;
            Random rand = new Random();
            chosenNumber = rand.Next(1, 7);

            if (chosenNumber % 2 == 0)
            {
                if (selectedIndex == 0)
                    firstToGo = Game.Participant.Player;
                else
                    firstToGo = Game.Participant.AI; 
            }
            else
            {
                if (selectedIndex == 0)
                    firstToGo = Game.Participant.AI;
                else
                    firstToGo = Game.Participant.Player;
            }

            diePictureBox.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("die_" + chosenNumber);
            diePictureBox.BackColor = Color.White;

            rollLabel.Text = firstToGo.ToString() + " will be going first.";
            rollButton.Text = "Ok";
            rollButton.Click -= rollButton_Click;
            rollButton.Click += ok_Click;
        }

        private void evenButton_Click(object sender, EventArgs e)
        {
            selectedIndex = 0;
            evenButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            playerChoiceLabel.Text = "Choice: Evens";
            aiChoiceLabel.Text = "Choice: Odds";
            evenButton.ForeColor = Color.White;
            oddButton.ForeColor = Color.Black;
        }

        private void oddButton_Click(object sender, EventArgs e)
        {
            selectedIndex = 1;
            oddButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            playerChoiceLabel.Text = "Choice: Odds";
            aiChoiceLabel.Text = "Choice: Evens";
            oddButton.ForeColor = Color.White;
            evenButton.ForeColor = Color.Black;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
