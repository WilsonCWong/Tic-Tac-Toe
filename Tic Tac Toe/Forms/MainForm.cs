using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tic_Tac_Toe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (File.Exists((string)Properties.Settings.Default["ProfileImage"]))
            {
                Player.profilePicture = new Bitmap((string)Properties.Settings.Default["ProfileImage"]);
                profilePictureBox.Image = Player.profilePicture;
            }
            else
            {
                Properties.Settings.Default["ProfileImage"] = "";
                Player.profilePicture = Properties.Resources.usericon;
                profilePictureBox.Image = Player.profilePicture;
            }

            this.quickMatchButton.MouseHover += new System.EventHandler(CommonEvents.menuButton_MouseHover);
            this.quickMatchButton.MouseLeave += new System.EventHandler(CommonEvents.menuButton_MouseLeave);

            this.tournamentButton.MouseHover += new System.EventHandler(CommonEvents.menuButton_MouseHover);
            this.tournamentButton.MouseLeave += new System.EventHandler(CommonEvents.menuButton_MouseLeave);

            this.exitButton.MouseHover += new System.EventHandler(CommonEvents.menuButton_MouseHover);
            this.exitButton.MouseLeave += new System.EventHandler(CommonEvents.menuButton_MouseLeave);
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

        private void changePictureButton_Click(object sender, EventArgs e)
        {
            changePictureButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            if (profilePictureDialog.ShowDialog() == DialogResult.OK)
            {
                string picFile = profilePictureDialog.FileName;
                Bitmap profilePic = new Bitmap(picFile);
                Player.profilePicture = profilePic;
                profilePictureBox.Image = profilePic;
                Properties.Settings.Default["ProfileImage"] = picFile;
                Properties.Settings.Default.Save();
            }
        }

        private void tournamentButton_Click(object sender, EventArgs e)
        {
            tournamentButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            TournamentForm tournamentForm = new TournamentForm();
            tournamentForm.ShowDialog();
        }
    }
}
