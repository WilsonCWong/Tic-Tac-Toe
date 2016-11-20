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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Game game = new Game();
        }

        private void menuButton_MouseHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.ForeColor = Color.Black;
        }

        private void quickMatchButton_Click(object sender, EventArgs e)
        {
            QuickMatchForm qmForm = new QuickMatchForm();
            qmForm.ShowDialog();
        }
    }
}
