using System.Security.Cryptography;

namespace HängaGubbe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = GenerateSecretWord();
            int[] letterIndex = GenerateLetterIndex(secretWord.Length);

            int guessCount = 10;
            while(guessCount > 0)
            {
                DisplayScore(secretWord, letterIndex);
                MatchInput(secretWord, letterIndex);
            }
        }
        static string GenerateSecretWord()
        {
            string[] wordList = {
                "buss", "ägg", "blomma", "katt", "kratta",
                "byxor", "lampa", "bok", "stol", "bord"
            };
            Random rand = new Random();
            int index = rand.Next(wordList.Length);
            return wordList[index];
        }
        static int[] GenerateLetterIndex(int length)
        {
            int[] letterIndex = new int[length];
            for(int i = 0; i < letterIndex.Length; i++)
            {
                letterIndex[i] = 0;
            }
            return letterIndex;
        }
        static void DisplayScore(string secretWord, int[] letterIndex)
        {
            for(int i = 0; i < letterIndex.Length; i++)
            {
                if (letterIndex[i] == 1)
                {
                    Console.Write(secretWord[i] + " ");
                }
                else
                {
                    Console.Write("_" + " ");
                }
            }
        }

        static void MatchInput(string secretWord, int[] letterIndex)
        {
            string input = Console.ReadLine();
            for(int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == input[0])
                {
                    letterIndex[i] = 1;
                }
            }
        }
    }
}