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
            LoadPlayerPortrait();
            LoadStats();
            welcomeLabel.Text = "Welcome back, " + Player.userName;

            this.quickMatchButton.MouseHover += new System.EventHandler(CommonEvents.menuButton_MouseHover);
            this.quickMatchButton.MouseLeave += new System.EventHandler(CommonEvents.menuButton_MouseLeave);

            this.tournamentButton.MouseHover += new System.EventHandler(CommonEvents.menuButton_MouseHover);
            this.tournamentButton.MouseLeave += new System.EventHandler(CommonEvents.menuButton_MouseLeave);

            this.exitButton.MouseHover += new System.EventHandler(CommonEvents.menuButton_MouseHover);
            this.exitButton.MouseLeave += new System.EventHandler(CommonEvents.menuButton_MouseLeave);

            //Gets rid of border that appears around buttons when another form is loaded.
            quickMatchButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            changePictureButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            tournamentButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            exitButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

        }

        private void quickMatchButton_Click(object sender, EventArgs e)
        {             
            QuickMatchForm qmForm = new QuickMatchForm();
            qmForm.ShowDialog();
            UpdateStatLabels();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            SaveStats();
            this.Close();
        }

        private void changePictureButton_Click(object sender, EventArgs e)
        {        
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
            TournamentForm tournamentForm = new TournamentForm();
            tournamentForm.ShowDialog();
            UpdateStatLabels();
        }

        private void UpdateStatLabels()
        {
            wltLabel.Text = Player.matchWins + "/" + Player.matchLoss + "/" + Player.matchTies;
            tWonLabel.Text = Player.tournamentsWon.ToString();
            tLossLabel.Text = Player.tournamentsLost.ToString();
        }

        private void SaveStats()
        {
            using (StreamWriter sw = new StreamWriter("player_stats.txt"))
            {
                sw.WriteLine(Player.userName);
                sw.WriteLine(Player.matchWins);
                sw.WriteLine(Player.matchLoss);
                sw.WriteLine(Player.matchTies);
                sw.WriteLine(Player.tournamentsWon);
                sw.WriteLine(Player.tournamentsLost);
            }
        }

        private void LoadStats()
        {
            if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\player_stats.txt"))
            {
                using (StreamReader sr = new StreamReader("player_stats.txt"))
                {
                    Player.userName = sr.ReadLine();
                    Player.matchWins = int.Parse(sr.ReadLine());
                    Player.matchLoss = int.Parse(sr.ReadLine());
                    Player.matchTies = int.Parse(sr.ReadLine());
                    Player.tournamentsWon = int.Parse(sr.ReadLine());
                    Player.tournamentsLost = int.Parse(sr.ReadLine());
                }
                UpdateStatLabels();
            }
            else
                Player.userName = "User";
        }

        private void LoadPlayerPortrait()
        {
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
        }

        private void changeNameLabel_Click(object sender, EventArgs e)
        {
            NamePrompt namePrompt = new NamePrompt();
            namePrompt.ShowDialog();
            if (namePrompt.userName.Length > 0)
            {
                Player.userName = namePrompt.userName;
                welcomeLabel.Text = "Welcome back, " + Player.userName;
            }

        }
    }
}
