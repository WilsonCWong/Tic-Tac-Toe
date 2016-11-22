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
        public enum Participant { Player, AI }
        public enum State { Playing, Lost, Tie, Won }

        public AI aiPlayer;
        public State GameState { get; private set; }
        public Participant CurrentPlayer { get; set; }
        public Difficulty GameDifficulty { get; set; }

        public Board gameBoard;

        public Game(Difficulty d)
        {
            gameBoard = new Board();
            GameDifficulty = d;
        }

        public Piece GetOppositePiece(Piece p)
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

        public State CheckVictory(out Piece winner)
        {          
            //Check rows
            for (int row = 0; row < gameBoard.Grid.GetLength(0); row++)
            {
                Cell startCell = gameBoard.Grid[row, 0];
                for (int col = 1; col < gameBoard.Grid.GetLength(1); col++)
                {
                    if (startCell.CellPiece != gameBoard.Grid[row, col].CellPiece)
                        break;
                    else if (col == gameBoard.Grid.GetLength(1) - 1 && startCell.CellPiece != Piece.None)
                    {
                        winner = startCell.CellPiece;
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
                    if (startCell.CellPiece != gameBoard.Grid[row, col].CellPiece)
                        break;
                    else if (row == gameBoard.Grid.GetLength(0) - 1 && startCell.CellPiece != Piece.None)
                    {
                        winner = startCell.CellPiece;
                        return State.Won;
                    }
                }
            }         
            //Check left diagonal
            var diagonalSpaces = (gameBoard.Grid.GetLength(0) < gameBoard.Grid.GetLength(1)) ?
                gameBoard.Grid.GetLength(0) : gameBoard.Grid.GetLength(1);
            Cell topleft = gameBoard.Grid[0, 0];
            for (int i = 1; i < diagonalSpaces; i++)
            {
                if (topleft.CellPiece != gameBoard.Grid[i, i].CellPiece)
                    break;
                else if (i == diagonalSpaces - 1 && topleft.CellPiece != Piece.None)
                {
                    winner = topleft.CellPiece;
                    return State.Won;
                }
            }
            Cell topright = gameBoard.Grid[diagonalSpaces - 1, 0];
            for (int i = diagonalSpaces - 2; i > 0; i--)
            {
                if (topright.CellPiece != gameBoard.Grid[i, i].CellPiece)
                    break;
                else if (i == 1 && topright.CellPiece != Piece.None)
                {
                    winner = topright.CellPiece;
                    return State.Won;
                }
            }
            //Check for tie
            bool emptySlots = false;
            for (int row = 0; row < gameBoard.Grid.GetLength(0); row++)
            {
                for (int col = 0; col < gameBoard.Grid.GetLength(1); col++)
                {
                    if (gameBoard.Grid[row,col].CellPiece != Piece.None)
                    {
                        emptySlots = true;
                    }
                }
            }

            if (!emptySlots)
            {
                winner = Piece.None;
                return State.Tie;
            }
            else
            {
                winner = Piece.None;
                return State.Playing;
            }

        }

    }

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

    public class Cell
    {
        public Piece CellPiece { get; set; }
        public Cell(Piece p)
        {
            CellPiece = p;
        }
    }

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
