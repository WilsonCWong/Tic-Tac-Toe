namespace Tic_Tac_Toe
{
    partial class PiecePrompt
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
            this.pieceLabel = new System.Windows.Forms.Label();
            this.pieceDropdown = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pieceLabel
            // 
            this.pieceLabel.AutoSize = true;
            this.pieceLabel.BackColor = System.Drawing.Color.Transparent;
            this.pieceLabel.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieceLabel.ForeColor = System.Drawing.Color.White;
            this.pieceLabel.Location = new System.Drawing.Point(23, 27);
            this.pieceLabel.Name = "pieceLabel";
            this.pieceLabel.Size = new System.Drawing.Size(133, 22);
            this.pieceLabel.TabIndex = 0;
            this.pieceLabel.Text = "Choose your piece:";
            // 
            // pieceDropdown
            // 
            this.pieceDropdown.FormattingEnabled = true;
            this.pieceDropdown.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Advanced"});
            this.pieceDropdown.Location = new System.Drawing.Point(162, 28);
            this.pieceDropdown.Name = "pieceDropdown";
            this.pieceDropdown.Size = new System.Drawing.Size(121, 21);
            this.pieceDropdown.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.okButton.Location = new System.Drawing.Point(122, 55);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 32);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // PiecePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.blurredbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(313, 96);
            this.ControlBox = false;
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.pieceDropdown);
            this.Controls.Add(this.pieceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PiecePrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Difficulty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pieceLabel;
        private System.Windows.Forms.ComboBox pieceDropdown;
        private System.Windows.Forms.Button okButton;
    }
}