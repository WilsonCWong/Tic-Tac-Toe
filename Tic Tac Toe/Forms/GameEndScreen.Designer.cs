namespace Tic_Tac_Toe
{
    partial class GameEndScreen
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
            this.playAgainButton = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.forfeitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.Transparent;
            this.playAgainButton.FlatAppearance.BorderSize = 0;
            this.playAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgainButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playAgainButton.Location = new System.Drawing.Point(228, 447);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(150, 32);
            this.playAgainButton.TabIndex = 2;
            this.playAgainButton.Text = "PLAY AGAIN";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.resultPictureBox.Image = global::Tic_Tac_Toe.Properties.Resources.Victory;
            this.resultPictureBox.Location = new System.Drawing.Point(65, 14);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(582, 428);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultPictureBox.TabIndex = 4;
            this.resultPictureBox.TabStop = false;
            // 
            // forfeitButton
            // 
            this.forfeitButton.BackColor = System.Drawing.Color.Transparent;
            this.forfeitButton.FlatAppearance.BorderSize = 0;
            this.forfeitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.forfeitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.forfeitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forfeitButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forfeitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.forfeitButton.Location = new System.Drawing.Point(384, 447);
            this.forfeitButton.Name = "forfeitButton";
            this.forfeitButton.Size = new System.Drawing.Size(100, 32);
            this.forfeitButton.TabIndex = 2;
            this.forfeitButton.Text = "QUIT";
            this.forfeitButton.UseVisualStyleBackColor = false;
            this.forfeitButton.Click += new System.EventHandler(this.forfeitButton_Click);
            // 
            // GameEndScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.blurredbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 491);
            this.ControlBox = false;
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.forfeitButton);
            this.Controls.Add(this.playAgainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameEndScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End Screen";
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Button forfeitButton;
    }
}