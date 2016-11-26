﻿using System;
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
    public partial class QuickMatchForm : Form
    {
        Game currentGame;

        public QuickMatchForm()
        {
            InitializeComponent();
            //Set the player image
            playerPictureBox.Image = Player.profilePicture;

            //Prompt the player for the difficulty of the match
            DifficultyPrompt diffPrompt = new DifficultyPrompt();
            diffPrompt.ShowDialog();

            //Create a new "game"
            currentGame = new Game((Difficulty)diffPrompt.selectedDifficulty);

            //Let the player choose the piece they wish to be, and assign it
            PiecePrompt piecePrompt = new PiecePrompt();
            piecePrompt.ShowDialog();
            currentGame.PlayerPiece = piecePrompt.selectedPiece;

            //Create a new AI player, and assign it the piece opposite of the player
            currentGame.aiPlayer = new AI();
            currentGame.aiPlayer.AIPiece = Game.GetOppositePiece(currentGame.PlayerPiece);
            currentGame.AIPiece = currentGame.aiPlayer.AIPiece;

            //Determine who goes first
            DiceRollPrompt diceRoll = new DiceRollPrompt();
            diceRoll.ShowDialog();
            currentGame.CurrentPlayer = diceRoll.firstToGo;
            
            //Start the game
            currentGame.GameStarted = true;
            currentGame.GameState = Game.State.Playing;

            //Start the game timers
            gameTimer.Start();
            countdownTimer.Start();
        }

        private void CheckWinner()
        {
            Console.WriteLine("Game State: " + currentGame.GameState + ", Winner: " + currentGame.WinnerPiece);
            if (currentGame.GameState != Game.State.Playing)
            {
                gameTimer.Stop();
                countdownTimer.Stop();
                if (currentGame.WinnerPiece == currentGame.PlayerPiece)
                {
                    MessageBox.Show("You have won this match.");
                }
                else if (currentGame.WinnerPiece == Piece.None)
                {
                    MessageBox.Show("This match has ended in a draw.");
                }
                else
                {
                    MessageBox.Show("You have lost this match.");
                }
                this.Close();
            }
        }

        //We use this timer for game updates that need to run constantly.
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //If it is the AI's turn, the delay timer has ticked out, and we're still playing, we calculate the AI's move and reset
            //the delay timer.
            if (currentGame.CurrentPlayer == Game.Participant.AI && currentGame.GameState == Game.State.Playing && currentGame.AIDelay <= 0)
            {
                currentGame.ResetAIDelay();
                currentGame.aiPlayer.CalculateMove(ref currentGame.gameBoard, currentGame.GameDifficulty);
                currentGame.SwitchTurns();
                //Repaint the board so the AI's piece shows up.
                RepaintGame();
                currentGame.GameState = currentGame.CheckVictory();
                CheckWinner();
            }
            else if (currentGame.CurrentPlayer == Game.Participant.Player && currentGame.PlayerTimer <= 0)
            {
                currentGame.SwitchTurns();
                timerLabel.Text = "Player lost a turn after failing to respond.";
            }
        }

        //For determining the player's move.
        private void cell_Click(object sender, MouseEventArgs e)
        {
            if (currentGame.CurrentPlayer == Game.Participant.Player && currentGame.GameState == Game.State.Playing)
            {
                //Get the picturebox clicked, and the coordinate of the picturebox.
                PictureBox pictureBox = (PictureBox)sender;
                Vector2D coords = CoordFromPictureBox(pictureBox);

                //If it is an empty cell, we can place the player's piece there, and switch turns.
                if (currentGame.gameBoard.Grid[coords.x, coords.y].CellPiece == Piece.None)
                {
                    currentGame.gameBoard.Grid[coords.x, coords.y].CellPiece = currentGame.PlayerPiece;
                    currentGame.SwitchTurns();

                    //Repaint the game and call the cell_Enter Event Handler to change the hover color.
                    RepaintGame();
                    cell_Enter(pictureBox, EventArgs.Empty);
                }
                //See if anyone won
                currentGame.GameState = currentGame.CheckVictory();
                CheckWinner();
            }
        }

        private void cell_Enter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Vector2D coords = CoordFromPictureBox(pictureBox);

            if (currentGame.gameBoard.Grid[coords.x, coords.y].CellPiece == Piece.None)
            {
                pictureBox.BackColor = Color.Green;
            }
            else
            {
                pictureBox.BackColor = Color.Red;
            }

        }

        private void cell_Exit(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        //From a Vector2D, we can get the corresponding picturebox on the grid thanks to a good naming scheme.
        public Vector2D CoordFromPictureBox(PictureBox pictureBox)
        {
            string boxName = pictureBox.Name;
            int x = int.Parse(boxName.Substring(boxName.Length - 2, 1));
            int y = int.Parse(boxName.Substring(boxName.Length - 1, 1));

            return new Vector2D(x, y);
        }

        //Gets the picture of a piece.
        public Bitmap GetPiecePicture(Piece p)
        {
            Bitmap img;
            switch (p)
            {
                case Piece.X:
                    img = Properties.Resources.x;
                    break;
                case Piece.O:
                    img = Properties.Resources.o;
                    break;
                case Piece.None:
                    img= Properties.Resources.cell;
                    break;
                default:
                    MessageBox.Show("Error getting piece picture.");
                    img = Properties.Resources.cell;
                    break;
            }

            return img;
        }

        //Repaints the entire game grid.
        private void RepaintGame()
        {
            for (int row = 0; row < currentGame.gameBoard.Grid.GetLength(0); row++)
            {
                for (int col = 0; col < currentGame.gameBoard.Grid.GetLength(1); col++)
                {
                    Piece cellPiece = currentGame.gameBoard.Grid[row, col].CellPiece;
                    Control pb = Controls["pb_Cell" + row + col];
                    PictureBox cellPicBox = pb as PictureBox;
                    cellPicBox.Image = GetPiecePicture(cellPiece);
                }
            }
        }

        //Timer for countdown-related operations.
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            //Reduces the delay time of the AI.
            if (currentGame.CurrentPlayer == Game.Participant.AI)
                currentGame.DelayCountdown();
            if (currentGame.CurrentPlayer == Game.Participant.Player)
            {
                currentGame.PlayerTimerCountdown();
                UpdateTimer();
            }

        }

        private void UpdateTimer()
        {
            timerLabel.Text = String.Format("Time Left: {0:N1}", currentGame.PlayerTimer);
        }
    }
}
