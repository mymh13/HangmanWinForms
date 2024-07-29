namespace HangmanWinForms
{
    internal static class Program
    {
        // static string? maskedWord;
        // static string maskedWord = "hangman";
        // static char[]? letters;
        // static Player? player;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}