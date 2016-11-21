using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public class AI
    {
        //Determines the piece (X or O) that the AI is controlling.
        public Piece AIPiece { get; set; }

        public bool CalculateMove(ref Board board, Difficulty diff)
        {
            switch (diff)
            {
                case Difficulty.Easy:
                    break;
                case Difficulty.Normal:
                    break;
                case Difficulty.Advanced:
                    break;
                default:
                    MessageBox.Show("The AI's brain has imploded while calculating a move.");
                    break;
            }
            return false;
        }

        private int CheckHorizontal(ref Board board, Piece p, int row)
        {
            var rowPieces = 0;
            for (int col = 0; col < board.Grid.GetLength(1); col++)
            {
                if (board.Grid[row, col].CellPiece == p)
                {
                    rowPieces++;
                }
            }
            return rowPieces;
        }

        private int CheckVertical(ref Board board, Piece p, int col)
        {
            var colPieces = 0;
            for (int row = 0; row < board.Grid.GetLength(0); row++)
            {
                if (board.Grid[row, col].CellPiece == p)
                {
                    colPieces++;
                }
            }
            return colPieces;
        }

        private int CheckDiagonal(ref Board board, Piece p)
        {
            //The smaller of the two values will indicate how many diagonal spaces the grid has
            var diagonalSpaces = (board.Grid.GetLength(0) < board.Grid.GetLength(1)) ?
                board.Grid.GetLength(0) : board.Grid.GetLength(1);

            var diagPieces = 0;
            for (int i = 0; i < diagonalSpaces; i++)
            {
                if (board.Grid[i, i].CellPiece == p)
                {
                    diagPieces++;
                }
            }
            return diagPieces;
        }
    }
}
