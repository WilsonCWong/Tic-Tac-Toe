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
        }

        private void quickMatchButton_Click(object sender, EventArgs e)
        {
            quickMatchButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            QuickMatchForm qmForm = new QuickMatchForm();
            qmForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
