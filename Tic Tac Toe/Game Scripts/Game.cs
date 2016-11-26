﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public class Game
    {
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
                Cell startCell = gameBoard.Grid[row, 0];
                for (int col = 1; col < gameBoard.Grid.GetLength(1); col++)
                {
                    if (startCell.CellPiece == Piece.None || startCell.CellPiece != gameBoard.Grid[row, col].CellPiece)
                        break;
                    else if (col == gameBoard.Grid.GetLength(1) - 1)
                    {
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

            Cell topright = gameBoard.Grid[0, diagonalSpaces - 1];
            int diagonalCol = diagonalSpaces - 1;
            //Check for right diagonal
            for (int row = 0; row < diagonalSpaces; row++)
            {
                if (topright.CellPiece == Piece.None || topright.CellPiece != gameBoard.Grid[row, diagonalCol].CellPiece)
                    break;
                else if (diagonalCol == 0)
                {
                    WinnerPiece = topright.CellPiece;
                    return State.Won;
                }
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
                        emptySlots = true;
                        break;
                    }
                }
                if (emptySlots) break;
            }

            if (!emptySlots)
            {
                WinnerPiece = Piece.None;
                return State.Tie;
            }
            else
            {
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

    public enum Piece { None, X, O }
    public enum Difficulty { Easy, Normal, Advanced }

    //A cell of the game board.
    public class Cell
    {
        public Piece CellPiece { get; set; }
        public Cell(Piece p)
        {
            CellPiece = p;
        }
    }

    //A vector for storing coordinates.
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
