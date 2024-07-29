using System.Text;

namespace HangmanWinForms
{
    internal class GameMechanics
    {
        private static string? maskedWord;
        private static char[]? letters;

        public static void StartGame()
        {
            string[] maskedPath;
            try
            {
                maskedPath = File.ReadAllLines(@"C:\DevProj\HangmanWinForms\maskedWord.txt");
            }
            catch
            {
                maskedPath = new string[] { "football", "icehockey", "fishing", "explore" };
            }

            Random random = new Random();
            maskedWord = maskedPath[random.Next(0, maskedPath.Length)];

            letters = new char[maskedWord.Length];
            for (int i = 0; i < maskedWord.Length; i++)
                letters[i] = '-';
        }

        public static string GetMaskedWord()
        {
            if (maskedWord == null || letters == null)
                throw new InvalidOperationException("Game not initialized.");

            StringBuilder masked = new StringBuilder();
            for (int i = 0; i < maskedWord.Length; i++)
            {
                if (letters[i] != '-')
                    masked.Append(letters[i]);
                else
                    masked.Append('-');
            }
            return masked.ToString();
        }

        public static bool CheckLetter(char guessedLetter, Player? player)
        {
            if (maskedWord == null || letters == null)
                throw new InvalidOperationException("Game not initialized.");

            bool letterFound = false;
            if (player != null)
            {
                for (int i = 0; i < maskedWord.Length; i++)
                {
                    if (char.ToLower(guessedLetter) == char.ToLower(maskedWord[i]))
                    {
                        letters[i] = char.ToUpper(guessedLetter);
                        letterFound = true;
                    }
                }

                if (!player.GuessedLetters.Contains(guessedLetter))
                {
                    player.GuessedLetters.Add(guessedLetter);
                    player.Score++;
                }
            }
            return letterFound;
        }

        public static bool IsGameWon()
{
    if (maskedWord == null || letters == null)
        throw new InvalidOperationException("Game not initialized.");

    return maskedWord.ToUpper() == new string(letters).ToUpper();
}
    }
}