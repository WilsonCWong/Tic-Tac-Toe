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
    public partial class PiecePrompt : Form
    {
        public Piece selectedPiece;

        public PiecePrompt()
        {
            InitializeComponent();
            this.okButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.okButton.MouseLeave += CommonEvents.menuButton_MouseLeave;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int i = pieceDropdown.SelectedIndex;
            selectedPiece = (i == 0) ? Piece.X : Piece.O;
            this.Close();
        }

    }
}
