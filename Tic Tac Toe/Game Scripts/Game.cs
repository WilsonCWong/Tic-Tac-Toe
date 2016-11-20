using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class Game
    {
        public Board GameBoard { get; private set; }
        public Game()
        {
            GameBoard = new Board();
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
        }

        //Initialize the board and set all cells to empty.
        public void InitBoard()
        {
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    Grid[row, col].CellPiece = Piece.None;
                }
            }
        }
    }

    public enum Piece { None, X, O }

    public struct Cell
    {
        public Piece CellPiece { get; set; }
        public Cell (Piece p)
        {
            CellPiece = p;
        }
    }
}
