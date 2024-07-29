using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanWinForms
{
    public partial class Main : Form
    {
        private Player? player;
        private int guessCount = 0;
        private const string HighscoreFilePath = @"C:\DevProj\HangmanWinForms\highScore.txt";
        private List<Player> highscoreList = new List<Player>();

        public Main()
        {
            InitializeComponent();
            InitializeHighscoreGrid();
            LoadHighscores();
            InitializeGame();

            nameBox.KeyPress += NameBox_KeyPress;
            inputBox.KeyPress += InputBox_KeyPress;
        }

        private void InitializeGame()
        {
            GameMechanics.StartGame();
            maskedDisplay.Text = GameMechanics.GetMaskedWord();
            player = null;
            guessCount = 0;
            guessDisplay.Text = guessCount.ToString();
            messageDisplay.Text = "Please enter your name.";
            nameBox.ReadOnly = false;
            inputBox.ReadOnly = false;
            nameBox.Clear();
            inputBox.Clear();

            // Reset maskedDisplay styles
            maskedDisplay.BackColor = SystemColors.Window;
            maskedDisplay.ForeColor = SystemColors.ControlText;
            maskedDisplay.Font = new Font(maskedDisplay.Font, FontStyle.Regular);
            restartButton.BackColor = SystemColors.Control;

            EnableGameControls(true);
            nameBox.Focus();
        }

        private void InitializeHighscoreGrid()
        {
            // Set the properties
            highscoreGrid.ReadOnly = true;
            highscoreGrid.AllowUserToAddRows = false;
            highscoreGrid.RowHeadersVisible = false;
            highscoreGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Add columns
            highscoreGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "NameColumn",
                HeaderText = "Name",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
            });

            highscoreGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ScoreColumn",
                HeaderText = "Score",
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight },
                SortMode = DataGridViewColumnSortMode.Programmatic // Set SortMode to Programmatic
            });
        }

        private void LoadHighscores()
        {
            if (File.Exists(HighscoreFilePath))
            {
                var lines = File.ReadAllLines(HighscoreFilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                    {
                        highscoreList.Add(new Player(parts[0]) { Score = score });
                    }
                }
            }

            UpdateHighscoreGrid();
        }

        private void SaveHighscores()
        {
            var lines = highscoreList.Select(p => $"{p.Name},{p.Score}").ToArray();
            File.WriteAllLines(HighscoreFilePath, lines);
        }

        private void UpdateHighscoreGrid()
        {
            highscoreGrid.Rows.Clear();
            foreach (var player in highscoreList)
            {
                highscoreGrid.Rows.Add(player.Name, player.Score.ToString());
            }
        }

        private void confirmNameButton_Click(object sender, EventArgs e)
        {
            ValidateAndSetPlayerName();
        }

        private void NameBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (nameBox.Focused)
                {
                    ValidateAndSetPlayerName();
                    e.Handled = true; // Handle the Enter key press for nameBox
                }
            }
        }

        private void ValidateAndSetPlayerName()
        {
            string name = nameBox.Text.Trim();
            if (name.Length < 2)
            {
                messageDisplay.Text = "Please type a minimum length of two characters.";
            }
            else
            {
                player = new Player(name);
                messageDisplay.Text = $"Welcome, {player.Name}!";
                nameBox.ReadOnly = true;
                inputBox.Focus();
            }
        }

        private void InputBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (player == null)
                {
                    messageDisplay.Text = "Please enter your name first!";
                    nameBox.Focus();
                    return;
                }

                string input = inputBox.Text.Trim();
                if (input.Length != 1 || !char.IsLetter(input[0]))
                {
                    messageDisplay.Text = "Please enter a single letter.";
                    return;
                }

                char guessedLetter = char.ToUpper(input[0]);

                // Check if the letter has already been guessed
                if (player.GuessedLetters.Contains(guessedLetter))
                {
                    messageDisplay.Text = $"You already guessed the letter '{guessedLetter}'. Try another letter.";
                    inputBox.Clear();
                    return;
                }

                // Proceed with the guess if it's new
                bool letterFound = GameMechanics.CheckLetter(guessedLetter, player);

                maskedDisplay.Text = GameMechanics.GetMaskedWord();

                if (!letterFound)
                {
                    messageDisplay.Text = $"Letter '{guessedLetter}' is not in the word.";
                }
                else
                {
                    messageDisplay.Text = $"Letter '{guessedLetter}' found!";
                }

                previousDisplay.Text = string.Join(", ", player.GuessedLetters);
                guessCount++; // Increment guess count only for new guesses
                guessDisplay.Text = guessCount.ToString();

                if (GameMechanics.IsGameWon())
                {
                    EndGame();
                }

                inputBox.Clear();
            }
        }

        private void EndGame()
        {
            messageDisplay.Text = $"Well done! You have solved the hidden word. You managed this in {guessCount} guesses.";
            nameBox.ReadOnly = true;
            inputBox.ReadOnly = true;
            messageDisplay.Text += "\n Reset or quit?";

            // Change the background color of maskedDisplay to green
            maskedDisplay.BackColor = Color.FromArgb(0, 117, 58); // Using RGB values for PMS 348C color

            // Change the text color to white, and make it bold and italic
            maskedDisplay.ForeColor = Color.White;
            maskedDisplay.Font = new Font(maskedDisplay.Font, FontStyle.Bold | FontStyle.Italic);

            // Ensure the maskedDisplay is read-only after applying styles
            maskedDisplay.ReadOnly = false; // Allow style changes
            maskedDisplay.ReadOnly = true;  // Set it back to read-only

            // Add player name and score to highscore list and update the grid
            if (player != null)
            {
                highscoreList.Add(player);
                SortHighscoreGrid();
                LimitHighscoreGrid();
                SaveHighscores();
                UpdateHighscoreGrid();
            }

            // Disable all controls except the Restart button
            EnableGameControls(false);

            // Highlight the Restart button
            restartButton.BackColor = Color.Yellow;
        }

        private void SortHighscoreGrid()
        {
            highscoreList = highscoreList.OrderBy(p => p.Score).ToList();
        }

        private void LimitHighscoreGrid()
        {
            if (highscoreList.Count > 5)
            {
                highscoreList = highscoreList.Take(5).ToList();
            }
        }

        private void EnableGameControls(bool enable)
        {
            nameBox.ReadOnly = !enable;
            inputBox.ReadOnly = !enable;
            confirmNameButton.Enabled = enable;

            // Ensure the restart button is always enabled
            restartButton.Enabled = true;
        }

        private void inputBox_TextChanged(object? sender, EventArgs e)
        {
            // I need to look at this further down the road
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            InitializeGame();
            guessDisplay.Text = "0";
            previousDisplay.Text = "";
            inputBox.Focus();
        }

        private async void quitButton_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                messageDisplay.Text = $"Welcome back, {player.Name}";
                await Task.Delay(1500); // Wait for 1.5 seconds
                Application.Exit();
            }
        }
    }
}
