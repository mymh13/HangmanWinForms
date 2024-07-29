class Player
{
    public string Name { get; private set; }
    public int Score { get; set; }
    public List<char> GuessedLetters { get; } = new List<char>();

    public Player(string name)
    {
        Name = name;
        Score = 0;
    }

    public bool HasGuessedLetter(char letter)
    {
        return GuessedLetters.Contains(letter);
    }
}
