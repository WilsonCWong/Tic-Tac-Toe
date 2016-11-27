/*
    Project: Tic Tac Toe
    File: Player.cs
    Names: Wilson Wong, Jun Yu Huang, Joseph Yap
    Date Written: 11/27/2016
    Section: S11
    Purpose: Store all the info about the player.
*/
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
