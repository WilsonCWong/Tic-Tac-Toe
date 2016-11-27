namespace Tic_Tac_Toe
{
    partial class DiceRollPrompt
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
            this.rollLabel = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.diePictureBox = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.aiPictureBox = new System.Windows.Forms.PictureBox();
            this.oddButton = new System.Windows.Forms.Button();
            this.evenButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.aiNameLabel = new System.Windows.Forms.Label();
            this.playerChoiceLabel = new System.Windows.Forms.Label();
            this.aiChoiceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rollLabel
            // 
            this.rollLabel.BackColor = System.Drawing.Color.Transparent;
            this.rollLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollLabel.ForeColor = System.Drawing.Color.White;
            this.rollLabel.Location = new System.Drawing.Point(162, 21);
            this.rollLabel.Name = "rollLabel";
            this.rollLabel.Size = new System.Drawing.Size(389, 22);
            this.rollLabel.TabIndex = 0;
            this.rollLabel.Text = "Roll the die to determine who is going first.";
            this.rollLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.Transparent;
            this.rollButton.FlatAppearance.BorderSize = 0;
            this.rollButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rollButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rollButton.Location = new System.Drawing.Point(319, 316);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(74, 32);
            this.rollButton.TabIndex = 2;
            this.rollButton.Text = "ROLL";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // diePictureBox
            // 
            this.diePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.diePictureBox.Image = global::Tic_Tac_Toe.Properties.Resources.die_question;
            this.diePictureBox.Location = new System.Drawing.Point(273, 104);
            this.diePictureBox.Name = "diePictureBox";
            this.diePictureBox.Size = new System.Drawing.Size(167, 166);
            this.diePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diePictureBox.TabIndex = 4;
            this.diePictureBox.TabStop = false;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.playerPictureBox.Location = new System.Drawing.Point(12, 122);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(128, 128);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBox.TabIndex = 5;
            this.playerPictureBox.TabStop = false;
            // 
            // aiPictureBox
            // 
            this.aiPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.aiPictureBox.Image = global::Tic_Tac_Toe.Properties.Resources.aipicture;
            this.aiPictureBox.Location = new System.Drawing.Point(572, 122);
            this.aiPictureBox.Name = "aiPictureBox";
            this.aiPictureBox.Size = new System.Drawing.Size(128, 128);
            this.aiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aiPictureBox.TabIndex = 5;
            this.aiPictureBox.TabStop = false;
            // 
            // oddButton
            // 
            this.oddButton.BackColor = System.Drawing.Color.Transparent;
            this.oddButton.FlatAppearance.BorderSize = 0;
            this.oddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.oddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.oddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oddButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oddButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.oddButton.Location = new System.Drawing.Point(405, 52);
            this.oddButton.Name = "oddButton";
            this.oddButton.Size = new System.Drawing.Size(103, 46);
            this.oddButton.TabIndex = 2;
            this.oddButton.Text = "ODDS";
            this.oddButton.UseVisualStyleBackColor = false;
            this.oddButton.Click += new System.EventHandler(this.oddButton_Click);
            // 
            // evenButton
            // 
            this.evenButton.BackColor = System.Drawing.Color.Transparent;
            this.evenButton.FlatAppearance.BorderSize = 0;
            this.evenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.evenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.evenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evenButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.evenButton.Location = new System.Drawing.Point(205, 52);
            this.evenButton.Name = "evenButton";
            this.evenButton.Size = new System.Drawing.Size(126, 46);
            this.evenButton.TabIndex = 2;
            this.evenButton.Text = "EVENS";
            this.evenButton.UseVisualStyleBackColor = false;
            this.evenButton.Click += new System.EventHandler(this.evenButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(53, 97);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(47, 22);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aiNameLabel
            // 
            this.aiNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiNameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiNameLabel.ForeColor = System.Drawing.Color.White;
            this.aiNameLabel.Location = new System.Drawing.Point(572, 97);
            this.aiNameLabel.Name = "aiNameLabel";
            this.aiNameLabel.Size = new System.Drawing.Size(128, 22);
            this.aiNameLabel.TabIndex = 0;
            this.aiNameLabel.Text = "AI";
            this.aiNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerChoiceLabel
            // 
            this.playerChoiceLabel.AutoSize = true;
            this.playerChoiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerChoiceLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerChoiceLabel.ForeColor = System.Drawing.Color.White;
            this.playerChoiceLabel.Location = new System.Drawing.Point(12, 253);
            this.playerChoiceLabel.Name = "playerChoiceLabel";
            this.playerChoiceLabel.Size = new System.Drawing.Size(67, 20);
            this.playerChoiceLabel.TabIndex = 0;
            this.playerChoiceLabel.Text = "Choice:";
            this.playerChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aiChoiceLabel
            // 
            this.aiChoiceLabel.AutoSize = true;
            this.aiChoiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiChoiceLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiChoiceLabel.ForeColor = System.Drawing.Color.White;
            this.aiChoiceLabel.Location = new System.Drawing.Point(568, 253);
            this.aiChoiceLabel.Name = "aiChoiceLabel";
            this.aiChoiceLabel.Size = new System.Drawing.Size(67, 20);
            this.aiChoiceLabel.TabIndex = 0;
            this.aiChoiceLabel.Text = "Choice:";
            this.aiChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiceRollPrompt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.blurredbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 369);
            this.ControlBox = false;
            this.Controls.Add(this.aiPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.diePictureBox);
            this.Controls.Add(this.evenButton);
            this.Controls.Add(this.oddButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.aiNameLabel);
            this.Controls.Add(this.aiChoiceLabel);
            this.Controls.Add(this.playerChoiceLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.rollLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DiceRollPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roll the Dice";
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rollLabel;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.PictureBox diePictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox aiPictureBox;
        private System.Windows.Forms.Button oddButton;
        private System.Windows.Forms.Button evenButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label aiNameLabel;
        private System.Windows.Forms.Label playerChoiceLabel;
        private System.Windows.Forms.Label aiChoiceLabel;
    }
}