/*
    Project: Tic Tac Toe
    File: CommonEvents.cs
    Names: Wilson Wong, Jun Yu Huang, Joseph Yap
    Date Written: 11/27/2016
    Section: S11
    Purpose: A bunch of common event handlers for use in other forms. Allows us to reuse the same event handler
    over and over.
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
    //Common event handlers for use
    public static class CommonEvents
    {
        //Menu button hovering event handlers
        public static void menuButton_MouseHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.ForeColor = Color.FromArgb(224, 224, 224);
        }

        public static void menuButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.ForeColor = Color.Black;
        }
    }
}
