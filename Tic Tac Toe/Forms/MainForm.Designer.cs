namespace Tic_Tac_Toe
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.quickMatchButton = new System.Windows.Forms.Button();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.tLossLabel = new System.Windows.Forms.Label();
            this.tWonLabel = new System.Windows.Forms.Label();
            this.wltLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tournamentButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.changeNameLabel = new System.Windows.Forms.Label();
            this.changePictureButton = new System.Windows.Forms.Button();
            this.profilePictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.animatedBackgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.statsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animatedBackgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(232, 60);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(321, 53);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Tic Tac Toe";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.Color.Black;
            this.subtitleLabel.Location = new System.Drawing.Point(269, 113);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(247, 30);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "The Video Game";
            // 
            // quickMatchButton
            // 
            this.quickMatchButton.BackColor = System.Drawing.Color.Transparent;
            this.quickMatchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.quickMatchButton.FlatAppearance.BorderSize = 0;
            this.quickMatchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.quickMatchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.quickMatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quickMatchButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickMatchButton.ForeColor = System.Drawing.Color.Black;
            this.quickMatchButton.Location = new System.Drawing.Point(278, 188);
            this.quickMatchButton.Name = "quickMatchButton";
            this.quickMatchButton.Size = new System.Drawing.Size(229, 50);
            this.quickMatchButton.TabIndex = 2;
            this.quickMatchButton.Text = "Quick Match";
            this.quickMatchButton.UseVisualStyleBackColor = true;
            this.quickMatchButton.Click += new System.EventHandler(this.quickMatchButton_Click);
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.statsGroupBox.Controls.Add(this.tLossLabel);
            this.statsGroupBox.Controls.Add(this.tWonLabel);
            this.statsGroupBox.Controls.Add(this.wltLabel);
            this.statsGroupBox.Controls.Add(this.label3);
            this.statsGroupBox.Controls.Add(this.label2);
            this.statsGroupBox.Controls.Add(this.label1);
            this.statsGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsGroupBox.ForeColor = System.Drawing.Color.White;
            this.statsGroupBox.Location = new System.Drawing.Point(12, 445);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(259, 104);
            this.statsGroupBox.TabIndex = 4;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Stats";
            // 
            // tLossLabel
            // 
            this.tLossLabel.BackColor = System.Drawing.Color.Transparent;
            this.tLossLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLossLabel.ForeColor = System.Drawing.Color.White;
            this.tLossLabel.Location = new System.Drawing.Point(139, 72);
            this.tLossLabel.Name = "tLossLabel";
            this.tLossLabel.Size = new System.Drawing.Size(114, 17);
            this.tLossLabel.TabIndex = 9;
            this.tLossLabel.Text = "0";
            this.tLossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tWonLabel
            // 
            this.tWonLabel.BackColor = System.Drawing.Color.Transparent;
            this.tWonLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tWonLabel.ForeColor = System.Drawing.Color.White;
            this.tWonLabel.Location = new System.Drawing.Point(139, 48);
            this.tWonLabel.Name = "tWonLabel";
            this.tWonLabel.Size = new System.Drawing.Size(114, 17);
            this.tWonLabel.TabIndex = 9;
            this.tWonLabel.Text = "0";
            this.tWonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wltLabel
            // 
            this.wltLabel.BackColor = System.Drawing.Color.Transparent;
            this.wltLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wltLabel.ForeColor = System.Drawing.Color.White;
            this.wltLabel.Location = new System.Drawing.Point(139, 24);
            this.wltLabel.Name = "wltLabel";
            this.wltLabel.Size = new System.Drawing.Size(114, 17);
            this.wltLabel.TabIndex = 9;
            this.wltLabel.Text = "0/0/0";
            this.wltLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tournaments Lost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tournaments Won";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Win / Loss / Tie";
            // 
            // tournamentButton
            // 
            this.tournamentButton.BackColor = System.Drawing.Color.Transparent;
            this.tournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tournamentButton.FlatAppearance.BorderSize = 0;
            this.tournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tournamentButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentButton.ForeColor = System.Drawing.Color.Black;
            this.tournamentButton.Location = new System.Drawing.Point(278, 265);
            this.tournamentButton.Name = "tournamentButton";
            this.tournamentButton.Size = new System.Drawing.Size(229, 50);
            this.tournamentButton.TabIndex = 2;
            this.tournamentButton.Text = "Tournament";
            this.tournamentButton.UseVisualStyleBackColor = true;
            this.tournamentButton.Click += new System.EventHandler(this.tournamentButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(354, 342);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(77, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.welcomeLabel.Location = new System.Drawing.Point(375, 508);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(262, 17);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "Welcome back, User.";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // changeNameLabel
            // 
            this.changeNameLabel.AutoSize = true;
            this.changeNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.changeNameLabel.Location = new System.Drawing.Point(570, 530);
            this.changeNameLabel.Name = "changeNameLabel";
            this.changeNameLabel.Size = new System.Drawing.Size(67, 17);
            this.changeNameLabel.TabIndex = 9;
            this.changeNameLabel.Text = "Not you?";
            this.changeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changeNameLabel.Click += new System.EventHandler(this.changeNameLabel_Click);
            // 
            // changePictureButton
            // 
            this.changePictureButton.BackColor = System.Drawing.Color.Transparent;
            this.changePictureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePictureButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.changePictureButton.FlatAppearance.BorderSize = 0;
            this.changePictureButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changePictureButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changePictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePictureButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePictureButton.ForeColor = System.Drawing.Color.White;
            this.changePictureButton.Location = new System.Drawing.Point(644, 390);
            this.changePictureButton.Name = "changePictureButton";
            this.changePictureButton.Size = new System.Drawing.Size(128, 25);
            this.changePictureButton.TabIndex = 2;
            this.changePictureButton.Text = "Change Picture...";
            this.changePictureButton.UseVisualStyleBackColor = true;
            this.changePictureButton.Click += new System.EventHandler(this.changePictureButton_Click);
            // 
            // profilePictureDialog
            // 
            this.profilePictureDialog.Filter = "Image (*.bmp, *.jpg, *.jpeg, *.png, *.gif) | *.bmp; *.jpg; *.jpeg; *.png; *.gif";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePictureBox.Image = global::Tic_Tac_Toe.Properties.Resources.usericon;
            this.profilePictureBox.Location = new System.Drawing.Point(644, 421);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(128, 128);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 3;
            this.profilePictureBox.TabStop = false;
            // 
            // animatedBackgroundPictureBox
            // 
            this.animatedBackgroundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animatedBackgroundPictureBox.Image = global::Tic_Tac_Toe.Properties.Resources.purpleGridLoop;
            this.animatedBackgroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.animatedBackgroundPictureBox.Name = "animatedBackgroundPictureBox";
            this.animatedBackgroundPictureBox.Size = new System.Drawing.Size(787, 564);
            this.animatedBackgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animatedBackgroundPictureBox.TabIndex = 10;
            this.animatedBackgroundPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.changeNameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.statsGroupBox);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tournamentButton);
            this.Controls.Add(this.changePictureButton);
            this.Controls.Add(this.quickMatchButton);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.animatedBackgroundPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animatedBackgroundPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Button quickMatchButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.Button tournamentButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label changeNameLabel;
        private System.Windows.Forms.Button changePictureButton;
        private System.Windows.Forms.OpenFileDialog profilePictureDialog;
        private System.Windows.Forms.Label tLossLabel;
        private System.Windows.Forms.Label tWonLabel;
        private System.Windows.Forms.Label wltLabel;
        private System.Windows.Forms.PictureBox animatedBackgroundPictureBox;
    }
}

