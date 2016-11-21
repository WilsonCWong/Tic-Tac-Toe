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

        public AI aiPlayer;
        public Participant CurrentPlayer { get; set; }
        public Difficulty GameDifficulty { get; set; }

        public Board GameBoard { get; private set; }

        public Game(Difficulty d)
        {
            GameBoard = new Board();
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
