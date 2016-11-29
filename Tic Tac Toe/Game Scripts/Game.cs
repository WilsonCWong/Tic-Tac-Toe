/*
    Project: Tic Tac Toe
    File: Game.cs
    Names: Wilson Wong, Jun Yu Huang, Joseph Yap
    Date Written: 11/27/2016
    Section: S11
    Purpose: These classes and structs are responsible for managing the game. The Game class
    contains everything the game needs to function.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public class Game
    {
        //Constants 
        const float AI_DELAY = 1.0f;
        const float DELAY_SPEED = 0.1f;
        const float PLAYER_TIME_LIMIT = 20.0f;

        //Enums to represent the game status and participants
        public enum Participant { Player, AI }
        public enum State { Playing, Lost, Tie, Won }

        public AI aiPlayer;
        public bool GameStarted { get; set; }

        //Determines the delay before an AI makes a move, the delay corresponds to the countdown speed.
        float delaySpeed = DELAY_SPEED;
        public float AIDelay { get; private set; } = AI_DELAY;
        public float PlayerTimer { get; private set; } = PLAYER_TIME_LIMIT;
        
        //Game state handlers, for determining current status, whose turn it is, and the difficulty.
        public State GameState { get; set; }
        public Participant CurrentPlayer { get; set; }
        public Difficulty GameDifficulty { get; set; }

        //Represents the pieces
        public Piece PlayerPiece { get; set; }
        public Piece AIPiece { get; set; }
        public Piece WinnerPiece { get; set; }

        //The game board object.
        public Board gameBoard;

        //Constructor
        public Game(Difficulty d)
        {
            //Create a board
            gameBoard = new Board();
            GameDifficulty = d;
        }

        //Reset the delay timer
        public void ResetAIDelay()
        {
            AIDelay = AI_DELAY;
        }

        //Reduce the delay timer
        public void DelayCountdown()
        {
            AIDelay -= delaySpeed;
        }

        //Reduce the player's timer
        public void PlayerTimerCountdown()
        {
            PlayerTimer -= delaySpeed;
        }

        //Switch the current player
        public void SwitchTurns()
        {
            if (CurrentPlayer == Participant.Player)
                CurrentPlayer = Participant.AI;
            else
            {
                CurrentPlayer = Participant.Player;
                //Reset the player's time limit
                PlayerTimer = PLAYER_TIME_LIMIT;
            }
        }

        //Get the opposite piece given a piece as a parameter
        public static Piece GetOppositePiece(Piece p)
        {
            Piece otherPiece;
            switch (p)
            {
                case Piece.X:
                    otherPiece = Piece.O;
                    break;
                case Piece.O:
                    otherPiece = Piece.X;
                    break;
                default:
                    MessageBox.Show("Error determining player's piece.");
                    otherPiece = p;
                    break;
            }
            return otherPiece;
        }

        /* 
            Checks for a full match, and returns the game state, as well as assigning the winner if any.
            This code grabs the first cell of a row/column/diagonal, and sees if the other cells in it 
            matches that cell. If it does, we know that there is a full match.
        */
        public State CheckVictory()
        {          
            //Check rows
            for (int row = 0; row < gameBoard.Grid.GetLength(0); row++)
            {
                //Starting cell used for reference
                Cell startCell = gameBoard.Grid[row, 0];
                for (int col = 1; col < gameBoard.Grid.GetLength(1); col++)
                {
                    //Sees if starting cell is empty, or if the piece in the next cell doesn't match
                    if (startCell.CellPiece == Piece.None || startCell.CellPiece != gameBoard.Grid[row, col].CellPiece)
                        break;
                    else if (col == gameBoard.Grid.GetLength(1) - 1)
                    {
                        //If all of them match, we know there is 3 in this row
                        WinnerPiece = startCell.CellPiece;
                        return State.Won;
                    }     
                }
            }
            //Check cols
            for (int col = 0; col < gameBoard.Grid.GetLength(1); col++)
            {
                Cell startCell = gameBoard.Grid[0, col];
                for (int row = 1; row < gameBoard.Grid.GetLength(0); row++)
                {
                    if (startCell.CellPiece == Piece.None || startCell.CellPiece != gameBoard.Grid[row, col].CellPiece)
                        break;
                    else if (row == gameBoard.Grid.GetLength(0) - 1)
                    {
                        WinnerPiece = startCell.CellPiece;
                        return State.Won;
                    }
                }
            }
          
            //Determines the amount of diagonal spaces there are, which is the smaller value of the columns or rows
            var diagonalSpaces = (gameBoard.Grid.GetLength(0) < gameBoard.Grid.GetLength(1)) ?
                gameBoard.Grid.GetLength(0) : gameBoard.Grid.GetLength(1);

            //Check left diagonal
            Cell topleft = gameBoard.Grid[0, 0];
            for (int i = 1; i < diagonalSpaces; i++)
            {
                if (topleft.CellPiece == Piece.None || topleft.CellPiece != gameBoard.Grid[i, i].CellPiece)
                    break;
                else if (i == diagonalSpaces - 1)
                {
                    WinnerPiece = topleft.CellPiece;
                    return State.Won;
                }
            }

            //The columns go to 0 as we go down the rows
            int diagonalCol = diagonalSpaces - 1;
            //Check for right diagonal
            Cell topright = gameBoard.Grid[0, diagonalCol];           
            //Rows goes to the max amount of diagonal cells as we subtract from the columns
            for (int row = 0; row < diagonalSpaces; row++)
            {
                if (topright.CellPiece == Piece.None || topright.CellPiece != gameBoard.Grid[row, diagonalCol].CellPiece)
                    break;
                else if (diagonalCol == 0)
                {
                    WinnerPiece = topright.CellPiece;
                    return State.Won;
                }
                //Column approaches 0
                diagonalCol--;
            }

            //Check for tie
            bool emptySlots = false;
            for (int row = 0; row < gameBoard.Grid.GetLength(0); row++)
            {
                for (int col = 0; col < gameBoard.Grid.GetLength(1); col++)
                {
                    if (gameBoard.Grid[row,col].CellPiece == Piece.None)
                    {
                        //Found an empty slot
                        emptySlots = true;
                        break;
                    }
                }
                //We know there is no tie, so we break
                if (emptySlots) break;
            }

            if (!emptySlots)
            {
                //There are no empty slots, so it has to be a tie
                WinnerPiece = Piece.None;
                return State.Tie;
            }
            else
            {
                //Empty slots, and no winner returned, so we are still playing
                WinnerPiece = Piece.None;
                return State.Playing;
            }

        }

    }

    //The class that contains the physical grid of the game board.
    public class Board
    {
        const int COLS = 3;
        const int ROWS = 3;
        public Cell[,] Grid;

        public Board()
        {
            Grid = new Cell[COLS, ROWS];
            InitBoard();
        }

        //Initialize the board and set all cells to empty.
        private void InitBoard()
        {
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    Grid[row, col] = new Cell(Piece.None);
                }
            }
        }
    }

    //Enum for the pieces.
    public enum Piece { None, X, O }
    //Enum for the difficulties
    public enum Difficulty { Easy, Normal, Advanced }

    //A cell of the game board. It is a class because we need to reference the specific instances
    //of the cells.
    public class Cell
    {
        //The piece in that cell.
        public Piece CellPiece { get; set; }
        public Cell(Piece p)
        {
            CellPiece = p;
        }
    }

    //A vector for storing xy coordinates.
    public struct Vector2D
    {
        public int x;
        public int y;

        public Vector2D (int xCoord, int yCoord)
        {
            x = xCoord;
            y = yCoord;
        }
    }
}
