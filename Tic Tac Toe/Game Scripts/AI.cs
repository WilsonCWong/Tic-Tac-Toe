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
                    CalculateEasyMove(ref board);
                    break;
                case Difficulty.Normal:
                    CalculateNormalMove(ref board);
                    break;
                case Difficulty.Advanced:
                    break;
                default:
                    MessageBox.Show("The AI's brain has imploded while calculating a move.");
                    break;
            }
            return false;
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

        private void CalculateEasyMove(ref Board board)
        {
            Random rand = new Random();
            bool piecePlaced = false;
            int selectedRow;
            int selectedCol;

            while (!piecePlaced)
            {
                selectedRow = rand.Next(3);
                selectedCol = rand.Next(3);
                if (board.Grid[selectedRow, selectedCol].CellPiece == Piece.None)
                {
                    board.Grid[selectedRow, selectedCol].CellPiece = AIPiece;
                    piecePlaced = true;
                }
            }

        }

        private void CalculateNormalMove(ref Board board)
        {
            int matches = 0;
            Vector2D cellCoord = new Vector2D(0, 0);
            bool piecePlaced = false;

            while (!piecePlaced)
            {
                for (int counter = 0; counter < board.Grid.GetLength(0); counter++)
                {
                    int colMatches = CheckHorizontal(ref board, AIPiece, counter);
                    if (CheckPlayerPlacedRow(ref board, GetOppositePiece(AIPiece), counter) && colMatches > 0)
                    {
                        if (colMatches > matches)
                        {
                            matches = colMatches;
                            cellCoord = GetFreeCellCol(ref board, counter);
                            piecePlaced = true;
                        }
                    }

                }

                for (int counter = 0; counter < board.Grid.GetLength(1); counter++)
                {
                    int rowMatches = CheckHorizontal(ref board, AIPiece, counter);
                    if (CheckPlayerPlacedCol(ref board, GetOppositePiece(AIPiece), counter) && rowMatches > 0)
                    {
                        if (rowMatches > matches)
                        {
                            matches = rowMatches;
                            cellCoord = GetFreeCellRow(ref board, counter);
                            piecePlaced = true;
                        }
                    }
                }

                if (!piecePlaced)
                {
                    CalculateEasyMove(ref board);
                }
            }

            board.Grid[cellCoord.x, cellCoord.y].CellPiece = AIPiece;
        }

        private void CalculateAdvancedMove(ref Board board)
        {
            //
        }

        private Vector2D GetFreeCellRow(ref Board board, int row)
        {
            int selectedCol = 0;
            for (int col = 0; col < board.Grid.GetLength(1); col++)
            {
                if (board.Grid[row, col].CellPiece == Piece.None)
                {
                    selectedCol = col;
                }
            }
            return new Vector2D(row, selectedCol);
        }

        private Vector2D GetFreeCellCol(ref Board board, int col)
        {
            int selectedRow = 0;
            for (int row = 0; row < board.Grid.GetLength(0); row++)
            {
                if (board.Grid[row, col].CellPiece == Piece.None)
                {
                    selectedRow = row;
                }
            }
            return new Vector2D(selectedRow, col);
        }

        private bool CheckPlayerPlacedRow (ref Board board, Piece p, int row)
        {
            for (int col = 0; col < board.Grid.GetLength(1); col++)
            {
                if (board.Grid[row, col].CellPiece == p)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckPlayerPlacedCol(ref Board board, Piece p, int col)
        {
            for (int row = 0; row < board.Grid.GetLength(0); row++)
            {
                if (board.Grid[row, col].CellPiece == p)
                {
                    return true;
                }
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
