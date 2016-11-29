/*
    Project: Tic Tac Toe
    File: QuickMatchForm.cs
    Names: Wilson Wong, Jun Yu Huang, Joseph Yap
    Date Written: 11/27/2016
    Section: S11
    Purpose: This form manages the Quick Match mode of the game.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class QuickMatchForm : Form
    {
        //Initialize variables
        SoundPlayer soundPlayer = new SoundPlayer();
        const float END_SCREEN_DELAY = 1.0f;
        Game currentGame;
        float endScreenDelay = END_SCREEN_DELAY;

        public QuickMatchForm()
        {
            InitializeComponent();
            //Initialize button events, etc.
            surrenderButton.MouseHover += CommonEvents.menuButton_MouseHover;
            surrenderButton.MouseLeave += CommonEvents.menuButton_MouseLeave;
            surrenderButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            //Set the player's profile
            playerPictureBox.Image = Player.profilePicture;
            playerNameLabel.Text = Player.userName;

            StartGame();
         
        }

        private void StartGame()
        {
            //Play the preparation music
            soundPlayer.Stream = Properties.Resources.Preparation;
            soundPlayer.Play();

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

            //Play battle music
            soundPlayer.Stop();
            soundPlayer.Stream = Properties.Resources.BattleMusic;
            soundPlayer.PlayLooping();
        }

        //Checks to see if there is a winner
        private void CheckWinner()
        {
            if (currentGame.GameState != Game.State.Playing)
            {
                gameTimer.Stop();
                countdownTimer.Stop();
                //Check happens at the endScreen_Tick event handler
                endScreenTimer.Start();
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
                //We know the AI has won
                if (currentGame.GameState == Game.State.Won)
                    currentGame.GameState = Game.State.Lost;
                CheckWinner();
            }
            else if (currentGame.CurrentPlayer == Game.Participant.Player && currentGame.PlayerTimer <= 0)
            {
                //Ran out of time, player loses turn
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

        //Changes cell color depending on what is in the cell
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

        //Changes back to default control color for the cell
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

        //Updates the timer display
        private void UpdateTimer()
        {
            timerLabel.Text = String.Format("Time Left: {0:N1}", currentGame.PlayerTimer);
        }

        //Determines if player wants to surrender
        private void surrenderButton_Click(object sender, EventArgs e)
        {           
            //Stop the game
            gameTimer.Stop();
            countdownTimer.Stop();
            SurrenderPrompt sPrompt = new SurrenderPrompt();
            sPrompt.ShowDialog();
            if (sPrompt.selectedChoice == 0)
            {
                //Player surrenders, counts as loss
                Player.matchLoss += 1;
                this.Close();
            }
            gameTimer.Start();
            countdownTimer.Start();
        }

        private void endScreenTimer_Tick(object sender, EventArgs e)
        {
            endScreenDelay -= 1.0f;
            if (endScreenDelay <= 0)
            {
                //Repaint the game again.
                RepaintGame();
                //Check only happens once, so we reset the timer.
                endScreenTimer.Stop();
                endScreenDelay = END_SCREEN_DELAY;
                GameEndScreen gameEndScreen = new GameEndScreen();
                PictureBox resultPictureBox = (PictureBox)gameEndScreen.Controls["resultPictureBox"];
                //Used to see if player wants to play again.
                bool quitting = false;
                if (currentGame.WinnerPiece == currentGame.PlayerPiece)
                {
                    //Win screen
                    Player.matchWins += 1;
                    //Assign the appropriate info to the end screen
                    gameEndScreen.soundPlayer.Stream = Properties.Resources.VictoryAnnouncer;
                    gameEndScreen.gameResult = currentGame.GameState;
                    resultPictureBox.Image = Properties.Resources.Victory;
                    gameEndScreen.ShowDialog();
                    //See if the player wants to play again
                    if (gameEndScreen.selectedChoice == 0)
                        quitting = false;
                    else
                        quitting = true;
                }
                else if (currentGame.WinnerPiece == Piece.None)
                {
                    //Tie screen
                    Player.matchTies += 1;
                    gameEndScreen.gameResult = currentGame.GameState;
                    resultPictureBox.Image = Properties.Resources.Tie;
                    gameEndScreen.ShowDialog();
                    if (gameEndScreen.selectedChoice == 0)
                        quitting = false;
                    else
                        quitting = true;
                }
                else if (currentGame.WinnerPiece == currentGame.AIPiece)
                {
                    //Make sure the board is up to date.
                    RepaintGame();
                    //Lose screen
                    Player.matchLoss += 1;
                    gameEndScreen.soundPlayer.Stream = Properties.Resources.DefeatAnnouncer;
                    gameEndScreen.gameResult = currentGame.GameState;
                    resultPictureBox.Image = Properties.Resources.Defeat;
                    gameEndScreen.ShowDialog();
                    //See if the player wants to play again
                    if (gameEndScreen.selectedChoice == 0)
                        quitting = false;
                    else
                        quitting = true;
                }
                //Clear the end screen from memory.
                gameEndScreen.Dispose();
                //Determine whether to restart the game or not
                if (quitting)
                    this.Close();
                else
                {
                    StartGame();
                    //Repaint the grid so it's empty again
                    RepaintGame();
                }               
            }     
        }
    }
}
