namespace Tic_Tac_Toe
{
    partial class QuickMatchForm
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell21)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 17;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            // 
            // pb_Cell00
            // 
            this.pb_Cell00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Cell00.Image = global::Tic_Tac_Toe.Properties.Resources.cell;
            this.pb_Cell00.Location = new System.Drawing.Point(200, 88);
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
            this.pb_Cell11.Location = new System.Drawing.Point(328, 216);
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
            this.pb_Cell20.Location = new System.Drawing.Point(200, 344);
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
            this.pb_Cell22.Location = new System.Drawing.Point(456, 344);
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
            this.pb_Cell12.Location = new System.Drawing.Point(456, 216);
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
            this.pb_Cell10.Location = new System.Drawing.Point(200, 216);
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
            this.pb_Cell02.Location = new System.Drawing.Point(456, 88);
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
            this.pb_Cell01.Location = new System.Drawing.Point(328, 88);
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
            this.pb_Cell21.Location = new System.Drawing.Point(328, 344);
            this.pb_Cell21.Name = "pb_Cell21";
            this.pb_Cell21.Size = new System.Drawing.Size(128, 128);
            this.pb_Cell21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Cell21.TabIndex = 8;
            this.pb_Cell21.TabStop = false;
            this.pb_Cell21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cell_Click);
            this.pb_Cell21.MouseEnter += new System.EventHandler(this.cell_Enter);
            this.pb_Cell21.MouseLeave += new System.EventHandler(this.cell_Exit);
            // 
            // QuickMatchForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.blurredbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.Name = "QuickMatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe - Quick Match";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cell21)).EndInit();
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
    }
}