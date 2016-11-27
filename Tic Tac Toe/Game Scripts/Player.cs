using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public static class Player
    {
        //Player's name
        public static string userName;
        //The actual image of the player
        public static Bitmap profilePicture;
        //The stats of the player
        public static int tournamentsWon, tournamentsLost, matchWins, 
            matchTies, matchLoss;
    }
}
