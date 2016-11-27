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
        //Odds or evens selected by player
        int selectedIndex = 0;
        //The one who won the dice roll
        public Game.Participant firstToGo;

        public DiceRollPrompt()
        {
            InitializeComponent();
            //Init event handlers
            this.rollButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.rollButton.MouseLeave += CommonEvents.menuButton_MouseLeave;

            //Sets everyone's profile
            playerPictureBox.Image = Player.profilePicture;
            playerChoiceLabel.Text = "Choice: Evens";
            aiChoiceLabel.Text = "Choice: Odds";
            evenButton.ForeColor = Color.White;

            //Prevents border around the buttons
            evenButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            oddButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        //Roll the dice
        private void rollButton_Click(object sender, EventArgs e)
        {
            //Generate a random number
            int chosenNumber;
            Random rand = new Random();
            chosenNumber = rand.Next(1, 7);

            if (chosenNumber % 2 == 0) //evens
            {
                //Sees who chose even, and determine the winner
                if (selectedIndex == 0)
                    firstToGo = Game.Participant.Player;
                else
                    firstToGo = Game.Participant.AI; 
            }
            else // odds
            {
                if (selectedIndex == 0)
                    firstToGo = Game.Participant.AI;
                else
                    firstToGo = Game.Participant.Player;
            }

            //Change the die image
            diePictureBox.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("die_" + chosenNumber);
            diePictureBox.BackColor = Color.White;

            //Tell the user who won, and who's going first
            rollLabel.Text = firstToGo.ToString() + " will be going first.";
            //Change the roll button to be a ok button that closes the form
            rollButton.Text = "Ok";
            rollButton.Click -= rollButton_Click;
            rollButton.Click += ok_Click;
        }

        //Changes the selected choice to evens
        private void evenButton_Click(object sender, EventArgs e)
        {
            selectedIndex = 0;
            playerChoiceLabel.Text = "Choice: Evens";
            aiChoiceLabel.Text = "Choice: Odds";
            evenButton.ForeColor = Color.White;
            oddButton.ForeColor = Color.Black;
        }

        //Changes the selected choice to odd
        private void oddButton_Click(object sender, EventArgs e)
        {
            selectedIndex = 1;
            playerChoiceLabel.Text = "Choice: Odds";
            aiChoiceLabel.Text = "Choice: Evens";
            oddButton.ForeColor = Color.White;
            evenButton.ForeColor = Color.Black;
        }

        //Closes the form
        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
