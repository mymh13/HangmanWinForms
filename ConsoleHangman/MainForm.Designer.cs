


namespace HangmanWinForms
{
    partial class Main
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
            introBox = new TextBox();
            inputBox = new TextBox();
            labelInputLetter = new Label();
            restartButton = new Button();
            quitButton = new Button();
            labelMasked = new Label();
            previousDisplay = new TextBox();
            guessDisplay = new TextBox();
            labelGuesscount = new Label();
            labelPrevious = new Label();
            nameBox = new TextBox();
            labelName = new Label();
            maskedDisplay = new TextBox();
            confirmNameButton = new Button();
            labelHighScore = new Label();
            messageDisplay = new TextBox();
            label1 = new Label();
            highscoreGrid = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            ScoreColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)highscoreGrid).BeginInit();
            SuspendLayout();
            // 
            // introBox
            // 
            introBox.Location = new Point(12, 12);
            introBox.Multiline = true;
            introBox.Name = "introBox";
            introBox.ReadOnly = true;
            introBox.Size = new Size(296, 114);
            introBox.TabIndex = 3;
            introBox.Text = "Welcome to the Hangman game!\r\n\r\nStart by entering your name, then try to figure out the letters in the masked word by guessing letters one by one.\r\n\r\nTry use as few guesses as possible. Good luck!";
            // 
            // inputBox
            // 
            inputBox.Location = new Point(251, 151);
            inputBox.MaxLength = 1;
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(75, 23);
            inputBox.TabIndex = 4;
            inputBox.TextChanged += inputBox_TextChanged;
            inputBox.Enter += inputBox_TextChanged;
            // 
            // labelInputLetter
            // 
            labelInputLetter.AutoSize = true;
            labelInputLetter.Location = new Point(251, 133);
            labelInputLetter.Name = "labelInputLetter";
            labelInputLetter.Size = new Size(65, 15);
            labelInputLetter.TabIndex = 5;
            labelInputLetter.Text = "Input letter";
            // 
            // restartButton
            // 
            restartButton.Enabled = false;
            restartButton.Location = new Point(251, 249);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(75, 23);
            restartButton.TabIndex = 12;
            restartButton.Text = "Restart";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Click += restartButton_Click;
            // 
            // quitButton
            // 
            quitButton.Location = new Point(251, 278);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(75, 23);
            quitButton.TabIndex = 13;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // labelMasked
            // 
            labelMasked.AutoSize = true;
            labelMasked.Location = new Point(344, 15);
            labelMasked.Name = "labelMasked";
            labelMasked.Size = new Size(122, 15);
            labelMasked.TabIndex = 9;
            labelMasked.Text = "Masked/Hidden word";
            // 
            // previousDisplay
            // 
            previousDisplay.Location = new Point(344, 77);
            previousDisplay.Multiline = true;
            previousDisplay.Name = "previousDisplay";
            previousDisplay.ReadOnly = true;
            previousDisplay.Size = new Size(267, 49);
            previousDisplay.TabIndex = 6;
            previousDisplay.Text = "Previous guesses";
            // 
            // guessDisplay
            // 
            guessDisplay.Location = new Point(251, 194);
            guessDisplay.Name = "guessDisplay";
            guessDisplay.ReadOnly = true;
            guessDisplay.Size = new Size(75, 23);
            guessDisplay.TabIndex = 10;
            guessDisplay.Text = "Guesses";
            // 
            // labelGuesscount
            // 
            labelGuesscount.AutoSize = true;
            labelGuesscount.Location = new Point(251, 176);
            labelGuesscount.Name = "labelGuesscount";
            labelGuesscount.Size = new Size(69, 15);
            labelGuesscount.TabIndex = 11;
            labelGuesscount.Text = "Guesscount";
            // 
            // labelPrevious
            // 
            labelPrevious.AutoSize = true;
            labelPrevious.Location = new Point(344, 59);
            labelPrevious.Name = "labelPrevious";
            labelPrevious.Size = new Size(133, 15);
            labelPrevious.TabIndex = 7;
            labelPrevious.Text = "Previous guessed letters";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(403, 151);
            nameBox.MaxLength = 20;
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(127, 23);
            nameBox.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(405, 133);
            labelName.Name = "labelName";
            labelName.Size = new Size(72, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Player name";
            // 
            // maskedDisplay
            // 
            maskedDisplay.Location = new Point(344, 33);
            maskedDisplay.Name = "maskedDisplay";
            maskedDisplay.ReadOnly = true;
            maskedDisplay.Size = new Size(267, 23);
            maskedDisplay.TabIndex = 8;
            // 
            // confirmNameButton
            // 
            confirmNameButton.Location = new Point(536, 150);
            confirmNameButton.Name = "confirmNameButton";
            confirmNameButton.Size = new Size(75, 23);
            confirmNameButton.TabIndex = 1;
            confirmNameButton.Text = "Confirm name";
            confirmNameButton.UseVisualStyleBackColor = true;
            confirmNameButton.Click += confirmNameButton_Click;
            // 
            // labelHighScore
            // 
            labelHighScore.AutoSize = true;
            labelHighScore.Location = new Point(12, 133);
            labelHighScore.Name = "labelHighScore";
            labelHighScore.Size = new Size(61, 15);
            labelHighScore.TabIndex = 15;
            labelHighScore.Text = "Highscore";
            // 
            // messageDisplay
            // 
            messageDisplay.Location = new Point(344, 180);
            messageDisplay.Multiline = true;
            messageDisplay.Name = "messageDisplay";
            messageDisplay.ReadOnly = true;
            messageDisplay.Size = new Size(267, 125);
            messageDisplay.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 162);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 17;
            label1.Text = "Message";
            // 
            // highscoreGrid
            // 
            highscoreGrid.AllowUserToAddRows = false;
            highscoreGrid.AllowUserToDeleteRows = false;
            highscoreGrid.AllowUserToResizeColumns = false;
            highscoreGrid.AllowUserToResizeRows = false;
            highscoreGrid.BackgroundColor = SystemColors.ActiveCaption;
            highscoreGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            highscoreGrid.Columns.AddRange(new DataGridViewColumn[] { NameColumn, ScoreColumn });
            highscoreGrid.GridColor = SystemColors.GradientActiveCaption;
            highscoreGrid.Location = new Point(12, 151);
            highscoreGrid.MultiSelect = false;
            highscoreGrid.Name = "highscoreGrid";
            highscoreGrid.ReadOnly = true;
            highscoreGrid.RowHeadersVisible = false;
            highscoreGrid.ScrollBars = ScrollBars.None;
            highscoreGrid.Size = new Size(215, 150);
            highscoreGrid.TabIndex = 18;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 162;
            // 
            // ScoreColumn
            // 
            ScoreColumn.HeaderText = "Score";
            ScoreColumn.Name = "ScoreColumn";
            ScoreColumn.ReadOnly = true;
            ScoreColumn.Width = 50;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(623, 314);
            Controls.Add(highscoreGrid);
            Controls.Add(label1);
            Controls.Add(messageDisplay);
            Controls.Add(labelHighScore);
            Controls.Add(confirmNameButton);
            Controls.Add(maskedDisplay);
            Controls.Add(labelName);
            Controls.Add(nameBox);
            Controls.Add(labelPrevious);
            Controls.Add(labelGuesscount);
            Controls.Add(guessDisplay);
            Controls.Add(previousDisplay);
            Controls.Add(labelMasked);
            Controls.Add(quitButton);
            Controls.Add(restartButton);
            Controls.Add(labelInputLetter);
            Controls.Add(inputBox);
            Controls.Add(introBox);
            Name = "Main";
            Text = "Hangman";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)highscoreGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox introBox;
        private TextBox inputBox;
        private Label labelInputLetter;
        private Button restartButton;
        private Button quitButton;
        private Label labelMasked;
        private TextBox previousDisplay;
        private TextBox guessDisplay;
        private Label labelGuesscount;
        private Label labelPrevious;
        private TextBox nameBox;
        private Label labelName;
        private TextBox maskedDisplay;
        private Button confirmNameButton;
        private Label labelHighScore;
        private TextBox messageDisplay;
        private Label label1;
        private DataGridView highscoreGrid;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn ScoreColumn;
    }
}
