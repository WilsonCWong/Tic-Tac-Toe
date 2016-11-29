/*
    Project: Tic Tac Toe
    File: GameEndScreen.cs
    Names: Wilson Wong, Jun Yu Huang, Joseph Yap
    Date Written: 11/27/2016
    Section: S11
    Purpose: Shows the result of a match/tournament.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class GameEndScreen : Form
    {
        //Delay before music is played
        const float MUSIC_DELAY = 2.0f;

        //Init vars
        public Game.State gameResult;
        public SoundPlayer soundPlayer = new SoundPlayer();
        float musicDelay = MUSIC_DELAY;
        public int selectedChoice = 0;

        public GameEndScreen()
        {
            InitializeComponent();
            //Initialize events
            this.playAgainButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.playAgainButton.MouseLeave += CommonEvents.menuButton_MouseLeave;

            this.forfeitButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.forfeitButton.MouseLeave += CommonEvents.menuButton_MouseLeave;      
        }

        //Stops the music, and closes the form.
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            musicDelayTimer.Stop();
            soundPlayer.Stop();
            this.Close();
        }

        //Change the choice to indicate player is done playing.
        private void forfeitButton_Click(object sender, EventArgs e)
        {
            musicDelayTimer.Stop();
            soundPlayer.Stop();
            selectedChoice = 1;
            this.Close();
        }

        //Play the announcement assigned to it by QuickMatchForm or TournamentForm
        private void GameEndScreen_Load(object sender, EventArgs e)
        {
            //We don't have anything for tiebreakers, so silence will do.
            if (gameResult != Game.State.Tie)
            {
                soundPlayer.Play();
                musicDelayTimer.Start();
            }
        }

        //Delays the playing of the music score
        private void musicDelayTimer_Tick(object sender, EventArgs e)
        {
            musicDelay -= 0.1f;
            if (musicDelay <= 0)
            {
                //Plays the corresponding music
                if (gameResult == Game.State.Won)
                    soundPlayer.Stream = Properties.Resources.VictoryMusic;
                else if (gameResult == Game.State.Lost)
                    soundPlayer.Stream = Properties.Resources.DefeatMusic;

                soundPlayer.Play();
                //Prevents the music from being played from start over and over.
                musicDelayTimer.Stop();
            }
        }
    }
}
