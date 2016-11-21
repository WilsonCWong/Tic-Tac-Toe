using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class QuickMatchForm : Form
    {
        bool gameStarted;
        Game currentGame;
        Piece playerPiece;
        AI aiPlayer;

        public QuickMatchForm()
        {
            InitializeComponent();

            DifficultyPrompt diffPrompt = new DifficultyPrompt();
            diffPrompt.ShowDialog();

            currentGame = new Game((Difficulty)diffPrompt.selectedDifficulty);

            PiecePrompt piecePrompt = new PiecePrompt();
            piecePrompt.ShowDialog();

            playerPiece = piecePrompt.selectedPiece;

            currentGame.aiPlayer = new AI();
            currentGame.aiPlayer.AIPiece = currentGame.GetOppositePiece(playerPiece);

            currentGame.CurrentPlayer = Game.Participant.Player;
            
            gameStarted = true;
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (currentGame.CurrentPlayer == Game.Participant.AI)
            {
                currentGame.aiPlayer.CalculateMove(ref currentGame.gameBoard, currentGame.GameDifficulty);
                currentGame.CurrentPlayer = Game.Participant.Player;
                RepaintGame();
            }
        }

        public void cell_Click(object sender, MouseEventArgs e)
        {
            if (currentGame.CurrentPlayer == Game.Participant.Player)
            {
                PictureBox pictureBox = (PictureBox)sender;
                Vector2D coords = CoordFromPictureBox(pictureBox);

                if (currentGame.gameBoard.Grid[coords.x, coords.y].CellPiece == Piece.None)
                {
                    currentGame.gameBoard.Grid[coords.x, coords.y].CellPiece = playerPiece;
                    currentGame.CurrentPlayer = Game.Participant.AI;

                    pictureBox.Image = new Bitmap(GetPiecePicture(playerPiece));
                    cell_Enter(pictureBox, EventArgs.Empty);
                }
            }
        }

        public void cell_Enter(object sender, EventArgs e)
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

        public void cell_Exit(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        public Vector2D CoordFromPictureBox(PictureBox pictureBox)
        {
            string boxName = pictureBox.Name;
            int x = int.Parse(boxName.Substring(boxName.Length - 2, 1));
            int y = int.Parse(boxName.Substring(boxName.Length - 1, 1));

            return new Vector2D(x, y);
        }

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
    }
}
