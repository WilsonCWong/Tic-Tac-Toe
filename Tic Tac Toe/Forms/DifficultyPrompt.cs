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
    public partial class DifficultyPrompt : Form
    {
        public int selectedDifficulty;

        public DifficultyPrompt()
        {
            InitializeComponent();
            //Init event handlers
            this.okButton.MouseHover += CommonEvents.menuButton_MouseHover;
            this.okButton.MouseLeave += CommonEvents.menuButton_MouseLeave;
        }

        //Sets the selected difficulty
        private void okButton_Click(object sender, EventArgs e)
        {
            selectedDifficulty = difficultyDropdown.SelectedIndex;
            this.Close();
        }

        private void DifficultyPrompt_Load(object sender, EventArgs e)
        {
            //Give a default value, as a failsafe for if the player doesn't select
            //anything or somehow closes this form.
            difficultyDropdown.SelectedIndex = 0;
        }
    }
}
