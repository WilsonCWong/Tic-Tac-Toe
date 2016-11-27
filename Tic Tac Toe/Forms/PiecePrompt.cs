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
        //Piece selected
        public Piece selectedPiece;

        public PiecePrompt()
        {
            InitializeComponent();
            //Init event handler
            this.okButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.okButton.MouseLeave += CommonEvents.menuButton_MouseLeave;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Submits the piece selected in the drop down
            int i = pieceDropdown.SelectedIndex;
            selectedPiece = (i == 0) ? Piece.X : Piece.O;
            this.Close();
        }

        private void PiecePrompt_Load(object sender, EventArgs e)
        {
            //Gives a default value so at least something will be assigned if form is force closed.
            pieceDropdown.SelectedIndex = 0;
        }
    }
}
