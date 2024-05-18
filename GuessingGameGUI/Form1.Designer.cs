namespace GuessingGameGUI
{
    partial class frmGuessingGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.stbMain = new System.Windows.Forms.StatusStrip();
            this.stbOutput = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstGameNumbers = new System.Windows.Forms.ListBox();
            this.lblIncorrectGuesses = new System.Windows.Forms.Label();
            this.lblIncorrectGuessesCount = new System.Windows.Forms.Label();
            this.lblNumbersRemaining = new System.Windows.Forms.Label();
            this.lblNumbersRemainingCount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.stbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(387, 28);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewGame,
            this.mnuFileSep1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNewGame
            // 
            this.mnuFileNewGame.Name = "mnuFileNewGame";
            this.mnuFileNewGame.Size = new System.Drawing.Size(165, 26);
            this.mnuFileNewGame.Text = "&New Game";
            this.mnuFileNewGame.Click += new System.EventHandler(this.mnuFileNewGame_Click);
            // 
            // mnuFileSep1
            // 
            this.mnuFileSep1.Name = "mnuFileSep1";
            this.mnuFileSep1.Size = new System.Drawing.Size(162, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(165, 26);
            this.mnuFileExit.Text = "&Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // stbMain
            // 
            this.stbMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbOutput});
            this.stbMain.Location = new System.Drawing.Point(0, 438);
            this.stbMain.Name = "stbMain";
            this.stbMain.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.stbMain.Size = new System.Drawing.Size(387, 22);
            this.stbMain.SizingGrip = false;
            this.stbMain.TabIndex = 0;
            this.stbMain.Text = "statusStrip1";
            // 
            // stbOutput
            // 
            this.stbOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stbOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stbOutput.Name = "stbOutput";
            this.stbOutput.Size = new System.Drawing.Size(371, 16);
            this.stbOutput.Spring = true;
            this.stbOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstGameNumbers
            // 
            this.lstGameNumbers.ColumnWidth = 30;
            this.lstGameNumbers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstGameNumbers.FormattingEnabled = true;
            this.lstGameNumbers.ItemHeight = 28;
            this.lstGameNumbers.Location = new System.Drawing.Point(25, 72);
            this.lstGameNumbers.MultiColumn = true;
            this.lstGameNumbers.Name = "lstGameNumbers";
            this.lstGameNumbers.Size = new System.Drawing.Size(321, 284);
            this.lstGameNumbers.TabIndex = 1;
            this.lstGameNumbers.Click += new System.EventHandler(this.lstGameNumbers_Click);
            // 
            // lblIncorrectGuesses
            // 
            this.lblIncorrectGuesses.AutoSize = true;
            this.lblIncorrectGuesses.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncorrectGuesses.Location = new System.Drawing.Point(12, 382);
            this.lblIncorrectGuesses.Name = "lblIncorrectGuesses";
            this.lblIncorrectGuesses.Size = new System.Drawing.Size(120, 19);
            this.lblIncorrectGuesses.TabIndex = 3;
            this.lblIncorrectGuesses.Text = "Incorrect Guesses:";
            // 
            // lblIncorrectGuessesCount
            // 
            this.lblIncorrectGuessesCount.AutoSize = true;
            this.lblIncorrectGuessesCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIncorrectGuessesCount.Location = new System.Drawing.Point(138, 371);
            this.lblIncorrectGuessesCount.Name = "lblIncorrectGuessesCount";
            this.lblIncorrectGuessesCount.Size = new System.Drawing.Size(25, 30);
            this.lblIncorrectGuessesCount.TabIndex = 4;
            this.lblIncorrectGuessesCount.Text = "0";
            // 
            // lblNumbersRemaining
            // 
            this.lblNumbersRemaining.AutoSize = true;
            this.lblNumbersRemaining.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumbersRemaining.Location = new System.Drawing.Point(180, 380);
            this.lblNumbersRemaining.Name = "lblNumbersRemaining";
            this.lblNumbersRemaining.Size = new System.Drawing.Size(136, 19);
            this.lblNumbersRemaining.TabIndex = 5;
            this.lblNumbersRemaining.Text = "Numbers Remaining:";
            // 
            // lblNumbersRemainingCount
            // 
            this.lblNumbersRemainingCount.AutoSize = true;
            this.lblNumbersRemainingCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumbersRemainingCount.Location = new System.Drawing.Point(321, 369);
            this.lblNumbersRemainingCount.Name = "lblNumbersRemainingCount";
            this.lblNumbersRemainingCount.Size = new System.Drawing.Size(25, 30);
            this.lblNumbersRemainingCount.TabIndex = 6;
            this.lblNumbersRemainingCount.Text = "0";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(41, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 23);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Guess a number between 1 and 100";
            // 
            // frmGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 460);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNumbersRemainingCount);
            this.Controls.Add(this.lblNumbersRemaining);
            this.Controls.Add(this.lblIncorrectGuessesCount);
            this.Controls.Add(this.lblIncorrectGuesses);
            this.Controls.Add(this.lstGameNumbers);
            this.Controls.Add(this.stbMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "frmGuessingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.frmGuessingGame_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.stbMain.ResumeLayout(false);
            this.stbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileNewGame;
        private ToolStripSeparator mnuFileSep1;
        private ToolStripMenuItem mnuFileExit;
        private StatusStrip stbMain;
        private ToolStripStatusLabel stbOutput;
        private ListBox lstGameNumbers;
        private Label lblIncorrectGuesses;
        private Label lblIncorrectGuessesCount;
        private Label lblNumbersRemaining;
        private Label lblNumbersRemainingCount;
        private Label lblTitle;
    }
}