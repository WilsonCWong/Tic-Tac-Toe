using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public static class CommonEvents
    {
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
