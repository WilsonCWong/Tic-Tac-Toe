namespace Tic_Tac_Toe
{
    partial class TournamentForm
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.pb_Cell00 = new System.Windows.Forms.PictureBox();
            this.pb_Cell11 = new System.Windows.Forms.PictureBox();
            this.pb_Cell20 = new System.Windows.Forms.PictureBox();
            this.pb_Cell22 = new System.Windows.Forms.PictureBox();
            this.pb_Cell12 = new System.Windows.Forms.PictureBox();
            this.pb_Cell10 = new System.Windows.Forms.PictureBox();
            this.pb_Cell02 = new System.Windows.Forms.PictureBox();
            this.pb_Cell01 = new System.Windows.Forms.PictureBox();
            this.pb_Cell21 = new System.Windows.Forms.PictureBox();
            this.aiPictureBox = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.surrenderButton = new System.Windows.Forms.Button();
            this.resultTimer = new System.Windows.Forms.Timer(this.components);
            this.aiNameLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 17;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // pb_Cell00
            // 
            this.pb_Cell00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Cell00.Image = global::Tic_Tac_Toe.Properties.Resources.cell;
            this.pb_Cell00.Location = new System.Drawing.Point(312, 172);
            this.pb_Cell00.Name = "pb_Cell00";
            this.pb_Cell00.Size = new System.Drawing.Size(128, 128);
            this.pb_Cell00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Cell00.TabIndex = 0;
            this.pb_Cell00.TabStop = false;
            this.pb_Cell00.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cell_Click);
            this.pb_Cell00.MouseEnter += new System.EventHandler(this.cell_Enter);
            this.pb_Cell00.MouseLeave += new System.EventHandler(this.cell_Exit);
            // 
            // pb_Cell11
            // 
            this.pb_Cell11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Cell11.Image = global::Tic_Tac_Toe.Properties.Resources.cell;
            this.pb_Cell11.Location = new System.Drawing.Point(440, 300);
            this.pb_Cell11.Name = "pb_Cell11";
            this.pb_Cell11.Size = new System.Drawing.Size(128, 128);
            this.pb_Cell11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Cell11.TabIndex = 1;
            this.pb_Cell11.TabStop = false;
            this.pb_Cell11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cell_Click);
            this.pb_Cell11.MouseEnter += new System.EventHandler(this.cell_Enter);
            this.pb_Cell11.MouseLeave += new System.EventHandler(this.cell_Exit);
            // 
            // pb_Cell20
            // 
            this.pb_Cell20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Cell20.Image = global::Tic_Tac_Toe.Properties.Resources.cell;
            this.pb_Cell20.Location = new System.Drawing.Point(312, 428);
            this.pb_Cell20.Name = "pb_Cell20";
            this.pb_Cell20.Size = new System.Drawing.Size(128, 128);
            this.pb_Cell20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Cell20.TabIndex = 2;
            this.pb_Cell20.TabStop = false;
            this.pb_Cell20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cell_Click);
            this.pb_Cell20.MouseEnter += new System.EventHandler(this.cell_Enter);
            this.pb_Cell20.MouseLeave += new System.EventHandler(this.cell_Exit);
            // 
            // pb_Cell22
            // 
            this.pb_Cell22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Cell22.Image = global::Tic_Tac_Toe.Properties.Resources.cell;
            this.pb_Cell22.Location = new System.Drawing.Point(568, 428);
            this.pb_Cell22.Name = "pb_Cell22";
            this.pb_Cell22.Size = new System.Drawing.Size(128, 128);
            this.pb_Cell22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Cell22.TabIndex = 3;
            this.pb_Cell22.TabStop = false;
            this.pb_Cell22.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cell_Click);
            this.pb_Cell22.MouseEnter += new System.EventHandler(this.cell_Enter);
            this.pb_Cell22.MouseLeave += new System.EventHandler(this.cell_Exit);
            // 
            // pb_Cell12
            // 
            this.pb_Cell12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Cell12.Image = global::Tic_Tac_Toe.Properties.Resources.cell;
            this.pb_Cell12.Location = new System.Drawing.Point(568, 300);
            this.pb_Cell12.Name = "pb_Cell12";
            this.pb_Cell12.Size = new System.Drawing.Size(128, 128);
            this.pb_Cell12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Cell12.TabIndex = 4;
            this.pb_Cell12.TabStop = false;
            this.pb_Cell12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cell_Click);
            this.pb_Cell12.MouseEnter += new System.EventHandler(this.cell_Enter);
            this.pb_Cell12.MouseLeave += new System.EventHandler(this.cell_Exit);
            // 
            // pb_Cell10
            // 
            this.pb_Cell10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Cell10.Image = global::Tic_Tac_Toe.Properties.Resources.cell;
            this.pb_Cell10.Location = new System.Drawing.Point(312, 300);
            this.pb_Cell10.Name = "pb_Cell10";
            this.pb_Cell10.Size = new System.Drawing.Size(128, 128);
            this.pb_Cell10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Cell10.TabIndex = 5;
            this.pb_Cell10.TabStop = false;
            this.pb_Cell10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cell_Click);
            this.pb_Cell10.MouseEnter += new System.EventHandler(this.cell_Enter);
            this.pb_Cell10.MouseLeave += new System.EventHandler(this.cell_Exit);
            // 
            // pb_Cell02
            // 
            this.pb_Cell02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Cell02.Image = global::Tic_Tac_Toe.Properties.Resources.cell;
            this.pb_Cell02.Location = new System.Drawing.Point(568, 172);
            this.pb_Cell02.Name = "pb_Cell02";
            this.pb_Cell02.Size = new System.Drawing.Size(128, 128);
            this.pb_Cell02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Cell02.TabIndex = 6;
            this.pb_Cell02.TabStop = false;
            this.pb_Cell02.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cell_Click);
            this.pb_Cell02.MouseEnter += new System.EventHandler(this.cell_Enter);
            this.pb_Cell02.MouseLeave += new System.EventHandler(this.cell_Exit);
            // 
            // pb_Cell01
            // 
            this.pb_Cell01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Cell01.Image = global::Tic_Tac_Toe.Properties.Resources.cell;
            this.pb_Cell01.Location = new System.Drawing.Point(440, 172);
            this.pb_Cell01.Name = "pb_Cell01";
            this.pb_Cell01.Size = new System.Drawing.Size(128, 128);
            this.pb_Cell01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Cell01.TabIndex = 7;
            this.pb_Cell01.TabStop = false;
            this.pb_Cell01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cell_Click);
            this.pb_Cell01.MouseEnter += new System.EventHandler(this.cell_Enter);
            this.pb_Cell01.MouseLeave += new System.EventHandler(this.cell_Exit);
            // 
            // pb_Cell21
            // 
            this.pb_Cell21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Cell21.Image = global::Tic_Tac_Toe.Properties.Resources.cell;
            this.pb_Cell21.Location = new System.Drawing.Point(440, 428);
            this.pb_Cell21.Name = "pb_Cell21";
            this.pb_Cell21.Size = new System.Drawing.Size(128, 128);
            this.pb_Cell21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Cell21.TabIndex = 8;
            this.pb_Cell21.TabStop = false;
            this.pb_Cell21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cell_Click);
            this.pb_Cell21.MouseEnter += new System.EventHandler(this.cell_Enter);
            this.pb_Cell21.MouseLeave += new System.EventHandler(this.cell_Exit);
            // 
            // aiPictureBox
            // 
            this.aiPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.aiPictureBox.Image = global::Tic_Tac_Toe.Properties.Resources.aipicture;
            this.aiPictureBox.Location = new System.Drawing.Point(868, 12);
            this.aiPictureBox.Name = "aiPictureBox";
            this.aiPictureBox.Size = new System.Drawing.Size(128, 128);
            this.aiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aiPictureBox.TabIndex = 9;
            this.aiPictureBox.TabStop = false;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.playerPictureBox.Location = new System.Drawing.Point(12, 12);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(128, 128);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBox.TabIndex = 10;
            this.playerPictureBox.TabStop = false;
            // 
            // timerLabel
            // 
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabel.Location = new System.Drawing.Point(312, 31);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(384, 94);
            this.timerLabel.TabIndex = 11;
            this.timerLabel.Text = "Time Left: 20.0";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundLabel
            // 
            this.roundLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.White;
            this.roundLabel.Location = new System.Drawing.Point(12, 626);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(158, 94);
            this.roundLabel.TabIndex = 11;
            this.roundLabel.Text = "Round 1";
            this.roundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surrenderButton
            // 
            this.surrenderButton.BackColor = System.Drawing.Color.Transparent;
            this.surrenderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.surrenderButton.FlatAppearance.BorderSize = 0;
            this.surrenderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.surrenderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.surrenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.surrenderButton.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surrenderButton.ForeColor = System.Drawing.Color.Black;
            this.surrenderButton.Location = new System.Drawing.Point(341, 611);
            this.surrenderButton.Name = "surrenderButton";
            this.surrenderButton.Size = new System.Drawing.Size(327, 63);
            this.surrenderButton.TabIndex = 13;
            this.surrenderButton.Text = "SURRENDER";
            this.surrenderButton.UseVisualStyleBackColor = true;
            this.surrenderButton.Click += new System.EventHandler(this.surrenderButton_Click);
            // 
            // resultTimer
            // 
            this.resultTimer.Interval = 1000;
            this.resultTimer.Tick += new System.EventHandler(this.resultTimer_Tick);
            // 
            // aiNameLabel
            // 
            this.aiNameLabel.AutoSize = true;
            this.aiNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.aiNameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiNameLabel.ForeColor = System.Drawing.Color.White;
            this.aiNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aiNameLabel.Location = new System.Drawing.Point(832, 12);
            this.aiNameLabel.Name = "aiNameLabel";
            this.aiNameLabel.Size = new System.Drawing.Size(30, 22);
            this.aiNameLabel.TabIndex = 14;
            this.aiNameLabel.Text = "AI";
            this.aiNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerNameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.ForeColor = System.Drawing.Color.White;
            this.playerNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playerNameLabel.Location = new System.Drawing.Point(146, 12);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(66, 22);
            this.playerNameLabel.TabIndex = 14;
            this.playerNameLabel.Text = "Player";
            this.playerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TournamentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.blurredbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.aiNameLabel);
            this.Controls.Add(this.surrenderButton);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.aiPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.pb_Cell21);
            this.Controls.Add(this.pb_Cell01);
            this.Controls.Add(this.pb_Cell02);
            this.Controls.Add(this.pb_Cell10);
            this.Controls.Add(this.pb_Cell12);
            this.Controls.Add(this.pb_Cell22);
            this.Controls.Add(this.pb_Cell20);
            this.Controls.Add(this.pb_Cell11);
            this.Controls.Add(this.pb_Cell00);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TournamentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe - Tournament";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.PictureBox pb_Cell00;
        private System.Windows.Forms.PictureBox pb_Cell11;
        private System.Windows.Forms.PictureBox pb_Cell20;
        private System.Windows.Forms.PictureBox pb_Cell22;
        private System.Windows.Forms.PictureBox pb_Cell12;
        private System.Windows.Forms.PictureBox pb_Cell10;
        private System.Windows.Forms.PictureBox pb_Cell02;
        private System.Windows.Forms.PictureBox pb_Cell01;
        private System.Windows.Forms.PictureBox pb_Cell21;
        private System.Windows.Forms.PictureBox aiPictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Button surrenderButton;
        private System.Windows.Forms.Timer resultTimer;
        private System.Windows.Forms.Label aiNameLabel;
        private System.Windows.Forms.Label playerNameLabel;
    }
}