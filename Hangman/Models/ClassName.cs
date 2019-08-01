using System;

namespace Hangman.Models
{
    public class Game
    {
        public bool GameIsOver { get; set; }
        public string Word { get; set; }
        public int GuessesLeft { get; set; }
        public char[] LetterArray { get; set; }

        public Game(string word)
        {
            GameIsOver = false;
            Word = word;
            GuessesLeft = 6;
            LetterArray = Word.ToCharArray();
        }
    }
}