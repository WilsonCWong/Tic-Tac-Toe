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

        public enum State { Empty, O, X }
        
        public struct Cell
        {
            public State CellState { get; set; }
        }

        public void InitBoard()
        {
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    Grid[row, col].CellState = State.Empty;
                }
            }
        }

    }
}
