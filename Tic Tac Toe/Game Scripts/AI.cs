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

        //Calculates the AI's next move depending on the difficulty of the game.
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
                    CalculateAdvancedMove(ref board);
                    break;
                default:
                    MessageBox.Show("The AI's brain has imploded while calculating a move.");
                    break;
            }
            return false;
        }

        //Returns the opposite piece of the one supplied by the parameter. 
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

        /*
            The weakest AI possible, randomly places a piece in the grid.
        */
        private void CalculateEasyMove(ref Board board)
        {
            //Initialize the variables needed
            Random rand = new Random();
            bool piecePlaced = false;
            int selectedRow;
            int selectedCol;

            while (!piecePlaced)
            {
                //Generate a random row and column
                selectedRow = rand.Next(board.Grid.GetLength(0));
                selectedCol = rand.Next(board.Grid.GetLength(1));
                //If there is no piece, place the piece in that cell.
                if (board.Grid[selectedRow, selectedCol].CellPiece == Piece.None)
                {
                    board.Grid[selectedRow, selectedCol].CellPiece = AIPiece;
                    piecePlaced = true;
                }
            }

        }

        /*
            A little explanation here: The normal AI's priority is to build as much matches
            as possible, completely ignoring the player. It will place the piece in
            a row/column/diagonal with the most matches. For example, a diagonal with two cells
            occupied and an empty third one will override a row with one cell occupied. The AI
            ignores any row/column/diagonal block off by the player. This same concept is used
            throughout this loop.
        */
        private void CalculateNormalMove(ref Board board)
        {
            //The amount of matches of the AI's piece
            int matches = 0;
            //Coordinates and piecePlaced flag
            Vector2D cellCoord = new Vector2D(0, 0);
            bool piecePlaced = false;

            while (!piecePlaced)
            {
                //Check row
                for (int row = 0; row < board.Grid.GetLength(0); row++)
                {
                    int colMatches = CheckHorizontal(ref board, AIPiece, row);
                    int playerColMatches = CheckHorizontal(ref board, GetOppositePiece(AIPiece), row);
                    //If the row has not been blocked by the player, and the matches in this row is greater
                    //than any matches found previously, then we use this row. This is the same throughout the
                    //other checks.                   
                    if (playerColMatches == 0 && colMatches > matches)
                    {
                        //This is now the new highest match.
                        matches = colMatches;
                        //Get the free cell in this row
                        cellCoord = GetFreeCellRow(ref board, row);
                        //Flag the piece as placed.
                        piecePlaced = true;
                    }
                }

                //Check column
                for (int col = 0; col < board.Grid.GetLength(1); col++)
                {
                    int rowMatches = CheckVertical(ref board, AIPiece, col);
                    int playerRowMatches = CheckVertical(ref board, GetOppositePiece(AIPiece), col);
                    if (playerRowMatches == 0 && rowMatches > matches)
                    {
                        matches = rowMatches;
                        cellCoord = GetFreeCellCol(ref board, col);
                        piecePlaced = true;
                    }
                }

                //Gets the smallest of the row or column, as that will give the number of diagonal cells.
                int diagonalSpaces = (board.Grid.GetLength(0) < board.Grid.GetLength(1)) ?
                board.Grid.GetLength(0) : board.Grid.GetLength(1);

                //Check the left diagonal for matches
                int leftDiagMatches = CheckLeftDiagonal(ref board, AIPiece);
                if (CheckLeftDiagonal(ref board, GetOppositePiece(AIPiece)) == 0 && leftDiagMatches > matches)
                {
                    matches = leftDiagMatches;
                    cellCoord = GetFreeCellLeftDiag(ref board, diagonalSpaces);
                    piecePlaced = true;
                }

                //Check the right diagonal for matches
                int rightDiagMatches = CheckRightDiagonal(ref board, AIPiece);
                if (CheckRightDiagonal(ref board, GetOppositePiece(AIPiece)) == 0 && rightDiagMatches > matches)
                {
                    matches = rightDiagMatches;
                    cellCoord = GetFreeCellRightDiag(ref board, diagonalSpaces);
                    piecePlaced = true;
                }

                //If we can not find a move, the AI defaults to Easy AI.
                if (!piecePlaced)
                {
                    piecePlaced = true;
                    CalculateEasyMove(ref board);
                }
                else
                {
                    //Place the piece down.
                    board.Grid[cellCoord.x, cellCoord.y].CellPiece = AIPiece;
                }
            }
        }

        /*
            A step up from Normal, this now checks for if the player is about to win.
            If so, the AI will sabotage them. It will, however, prioritize itself first.
            If it's about to get a row/column/diagonal of full matches, it will do that instead,
            hence the selfVictory flag. The only weakness of this AI is that a smart player can
            devise a strategy that can create two openings for the player to win in one turn, as the AI can 
            only block one of them.
        */
        private void CalculateAdvancedMove(ref Board board)
        {
            //Stores the coordinate of where the piece is to be placed
            Vector2D cellCoord = new Vector2D(0, 0);
            //Whether a piece has been placed or not
            bool piecePlaced = false;
            //Whether the AI has chosen a move the will ensure victory
            bool selfVictory = false;

            while (!piecePlaced)
            {
                //Check row for whether AI can win in next move, then whether player win in next move
                int rowLength = board.Grid.GetLength(0);
                for (int row = 0; row < rowLength; row++)
                {
                    int colMatches = CheckHorizontal(ref board, AIPiece, row);
                    int playerColMatches = CheckHorizontal(ref board, GetOppositePiece(AIPiece), row);
                    //Checks whether the AI will win first, then whether or not the player will win in the next move
                    //Notice that this checks whether or not the AI is one move away from winning, and whether the last slot of the row is free
                    if (colMatches == rowLength - 1 && playerColMatches == 0)
                    {
                        cellCoord = GetFreeCellRow(ref board, row);
                        piecePlaced = true;
                        selfVictory = true;
                        break;
                    } //This method checks the same, but with the player instead
                    else if (!selfVictory && playerColMatches == rowLength - 1 && colMatches == 0)
                    {
                        cellCoord = GetFreeCellRow(ref board, row);
                        piecePlaced = true;
                    } 
                }

                //Check column for self win, then player win
                int colLength = board.Grid.GetLength(1);
                for (int col = 0; col < colLength; col++)
                {
                    int rowMatches = CheckVertical(ref board, AIPiece, col);
                    int playerRowMatches = CheckVertical (ref board, GetOppositePiece(AIPiece), col);
                    //Checks whether the AI will win first, then whether or not the player will win in the next move
                    if (rowMatches == colLength - 1 && playerRowMatches == 0)
                    {
                        cellCoord = GetFreeCellCol(ref board, col);
                        piecePlaced = true;
                        selfVictory = true;
                        break;
                    }
                    else if (!selfVictory && playerRowMatches == colLength - 1 && rowMatches == 0)
                    {
                        cellCoord = GetFreeCellCol (ref board, col);
                        piecePlaced = true;
                    }
                }

                //Determine the amount of diagonal spaces
                int diagonalSpaces = (board.Grid.GetLength(0) < board.Grid.GetLength(1)) ?
                board.Grid.GetLength(0) : board.Grid.GetLength(1);

                //Check the left diagonal for self win, then player.
                int lDiagMatches = CheckLeftDiagonal(ref board, AIPiece);
                int playerLDiagMatches = CheckLeftDiagonal(ref board, GetOppositePiece(AIPiece));
                if (lDiagMatches == diagonalSpaces - 1 && playerLDiagMatches == 0)
                {
                    cellCoord = GetFreeCellLeftDiag(ref board, diagonalSpaces);
                    piecePlaced = true;
                    selfVictory = true;
                }
                else if (!selfVictory && playerLDiagMatches == diagonalSpaces - 1 && lDiagMatches == 0)
                {
                    cellCoord = GetFreeCellLeftDiag(ref board, diagonalSpaces);        
                    piecePlaced = true;
                    
                }

                //Check the right diagonal for self win, then player.
                int rDiagMatches = CheckRightDiagonal(ref board, AIPiece);
                int playerRDiagMatches = CheckRightDiagonal(ref board, GetOppositePiece(AIPiece));
                if (rDiagMatches == diagonalSpaces -1 && playerRDiagMatches == 0)
                {
                    cellCoord = GetFreeCellRightDiag(ref board, diagonalSpaces);
                    piecePlaced = true;
                    selfVictory = true;
                }
                else if (!selfVictory && playerRDiagMatches == diagonalSpaces - 1 && rDiagMatches == 0)
                {
                    cellCoord = GetFreeCellRightDiag(ref board, diagonalSpaces);
                    piecePlaced = true;
 
                }

                //If a piece still isn't placed, we default to the Normal AI.
                if (!piecePlaced)
                {
                    piecePlaced = true;
                    CalculateNormalMove(ref board);
                    break;
                }
                else
                {
                    //Place the piece down.
                    board.Grid[cellCoord.x, cellCoord.y].CellPiece = AIPiece;
                    break;
                }
            }
        }

        //Find a free column cell in a row, if any.
        private Vector2D GetFreeCellRow(ref Board board, int row)
        {
            int selectedCol = 0;
            for (int col = 0; col < board.Grid.GetLength(1); col++)
            {
                if (board.Grid[row, col].CellPiece == Piece.None)
                {
                    selectedCol = col;
                    return new Vector2D(row, selectedCol);
                }
            }
            return new Vector2D(-1, -1);
        }

        //Find a free row cell in a column, if any.
        private Vector2D GetFreeCellCol(ref Board board, int col)
        {
            int selectedRow = 0;
            for (int row = 0; row < board.Grid.GetLength(0); row++)
            {
                if (board.Grid[row, col].CellPiece == Piece.None)
                {
                    selectedRow = row;
                    return new Vector2D(selectedRow, col);
                }
            }
            return new Vector2D(-1, -1);
        }

        //Find a free left diagonal cell, if any.
        private Vector2D GetFreeCellLeftDiag(ref Board board, int diagSpaces)
        {
            for (int i = 0; i < diagSpaces; i++)
            {
                if (board.Grid[i, i].CellPiece == Piece.None)
                {
                    return new Vector2D(i, i);
                }
            }
            return new Vector2D(-1, -1);
        }

        //Find a free right diagonal cell, if any.
        private Vector2D GetFreeCellRightDiag(ref Board board, int diagSpaces)
        {
            int colCounter = diagSpaces - 1;
            for (int row = 0; row < board.Grid.GetLength(0); row++)
            {
                if (board.Grid[row, colCounter].CellPiece == Piece.None)
                {
                    return new Vector2D(row, colCounter);
                }
                colCounter--;
            }
            return new Vector2D(-1, -1);
        }

        //Checks the row to see how many column cells contain the passed in piece.
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

        //Checks the column to see how many row cells contain the passed in piece.
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

        //Checks the left diagonal cells to see how many of them contain the passed in piece.
        private int CheckLeftDiagonal(ref Board board, Piece p)
        {
            //The smaller of the two values will indicate how many diagonal spaces the grid has
            int diagonalSpaces = (board.Grid.GetLength(0) < board.Grid.GetLength(1)) ?
                board.Grid.GetLength(0) : board.Grid.GetLength(1);

            //Check the left diagonal cells for pieces.
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

        //Checks the right diagonal cells to see how many of them contain the passed in piece.
        private int CheckRightDiagonal(ref Board board, Piece p)
        {
            //The smaller of the two values will indicate how many diagonal spaces the grid has
            int diagonalSpaces = (board.Grid.GetLength(0) < board.Grid.GetLength(1)) ?
                board.Grid.GetLength(0) : board.Grid.GetLength(1);

            int diagPieces = 0;

            int diagonalCol = diagonalSpaces - 1;
            //Check for right diagonal
            for (int row = 0; row < diagonalSpaces; row++)
            {
                if (board.Grid[row, diagonalCol].CellPiece == p)
                {
                    diagPieces++;
                }
                diagonalCol--;
            }

            return diagPieces;
        }
    }
}
