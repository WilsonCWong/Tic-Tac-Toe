/*
    Project: Tic Tac Toe
    File: MainForm.cs
    Names: Wilson Wong, Jun Yu Huang, Joseph Yap
    Date Written: 11/27/2016
    Section: S11
    Purpose: To provide an interactive Tic-Tac-Toe game with lots of interactive elements.
*/
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
using System.Media;

namespace Tic_Tac_Toe
{
    public partial class MainForm : Form
    {
        //Initialized variable
        SoundPlayer soundPlayer = new SoundPlayer();

        public MainForm()
        {
            InitializeComponent();
 
            //Load the player's portrait, if any. Defaults to usericon.png
            LoadPlayerPortrait();
            //Load stats from previous play session, if any.
            LoadStats();
            //Welcome the user by their name, if any. Default is User.
            welcomeLabel.Text = "Welcome back, " + Player.userName;

            //Play and loop the background music
            soundPlayer.Stream = Properties.Resources.retroGroveLoop;
            soundPlayer.PlayLooping();

            //Setup event handlers
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

            //Make the text backgrounds of the labels the same as the background gif
            titleLabel.Parent = animatedBackgroundPictureBox;
            subtitleLabel.Parent = animatedBackgroundPictureBox;
            quickMatchButton.Parent = animatedBackgroundPictureBox;
            tournamentButton.Parent = animatedBackgroundPictureBox;
            exitButton.Parent = animatedBackgroundPictureBox;
            statsGroupBox.Parent = animatedBackgroundPictureBox;
            welcomeLabel.Parent = animatedBackgroundPictureBox;
            changeNameLabel.Parent = animatedBackgroundPictureBox;
            changePictureButton.Parent = animatedBackgroundPictureBox;

        }

        //Starts the quick match form
        private void quickMatchButton_Click(object sender, EventArgs e)
        {             
            QuickMatchForm qmForm = new QuickMatchForm();
            qmForm.ShowDialog();
            //Updates the stats after the play session.
            UpdateStatLabels();

            //Clear the form from memory, just in case
            qmForm.Dispose();
            soundPlayer.Stop();
            //Play and loop the background music
            soundPlayer.Stream = Properties.Resources.retroGroveLoop;
            soundPlayer.PlayLooping();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Save stats before we exit.
            SaveStats();
            this.Close();
        }

        //Prompts the user for a profile picture
        private void changePictureButton_Click(object sender, EventArgs e)
        {        
            //If the user selects a file successfully, we can assign the picture
            if (profilePictureDialog.ShowDialog() == DialogResult.OK)
            {
                //We get the file and create a new bitmap from it
                string picFile = profilePictureDialog.FileName;
                Bitmap profilePic = new Bitmap(picFile);
                //We assign the picture to the player's profile and update the picturebox
                Player.profilePicture = profilePic;
                profilePictureBox.Image = profilePic;
                //Save file path of image to settings
                Properties.Settings.Default["ProfileImage"] = picFile;
                Properties.Settings.Default.Save();
            }
        }

        //Opens the tournament form
        private void tournamentButton_Click(object sender, EventArgs e)
        {         
            TournamentForm tournamentForm = new TournamentForm();
            tournamentForm.ShowDialog();
            //Update stats after tournament.
            UpdateStatLabels();

            //Clear the form from memory
            tournamentForm.Dispose();
            soundPlayer.Stop();
            //Play and loop the background music
            soundPlayer.Stream = Properties.Resources.retroGroveLoop;
            soundPlayer.PlayLooping();
        }

        //Updates the stat labels on the main form.
        private void UpdateStatLabels()
        {
            wltLabel.Text = Player.matchWins + "/" + Player.matchLoss + "/" + Player.matchTies;
            tWonLabel.Text = Player.tournamentsWon.ToString();
            tLossLabel.Text = Player.tournamentsLost.ToString();
        }

        //Writes all the player's stats to a file called "player_stats.txt".
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

        //Sees if windows form's executable path has the player_stats.txt file, and if it does, load the data in
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
                //Update the stat labels after everything is loaded.
                UpdateStatLabels();
            }
            else
                //All the numerical stats will default to 0, we just need to assign a default
                //username, which is User in this case.
                Player.userName = "User";
        }

        //Loads the player's portrait
        private void LoadPlayerPortrait()
        {
            if (File.Exists((string)Properties.Settings.Default["ProfileImage"]))
            {
                //Gets the image from the file path we stored in settings from before
                Player.profilePicture = new Bitmap((string)Properties.Settings.Default["ProfileImage"]);
                profilePictureBox.Image = Player.profilePicture;
            }
            else
            {
                //Clear the settings as the image no longer exists there
                Properties.Settings.Default["ProfileImage"] = "";
                //Default image
                Player.profilePicture = Properties.Resources.usericon;
                profilePictureBox.Image = Player.profilePicture;
            }
        }

        //Prompts the user to change their name
        private void changeNameLabel_Click(object sender, EventArgs e)
        {
            NamePrompt namePrompt = new NamePrompt();
            namePrompt.ShowDialog();
            //Make sure the length is adequate
            if (namePrompt.userName.Length > 0)
            {
                //Assign the name and update the label.
                Player.userName = namePrompt.userName;
                welcomeLabel.Text = "Welcome back, " + Player.userName;
            }

        }
    }
}
