using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

namespace Hangman
{
    internal class Program
    {
        private static void printHangman(int wrong)
        {
            if (wrong == 0)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 1)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 2)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 3)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|  |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 4)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 5)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/   |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 6)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("/ \\  |");
                Console.WriteLine("    ===");
            }
        }

        private static int PrintWord(List<char> gueesedLettters, string randomWord)
        {
            int counter = 0;
            int rightLetters = 0;
            Console.Write("\r\n");

            foreach (char c in randomWord)
            {
                if (gueesedLettters.Contains(c))
                {
                    Console.Write(c + " ");
                    rightLetters++;
                }
                else
                {
                    Console.Write(" ");
                }
                counter++;
            }
            return rightLetters;
        }

        private static void printLines(string randomWord)
        {
            Console.Write("\r");
            foreach (char c in randomWord)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\u0305 ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman :D");
            Console.WriteLine("-----------------------");

            Random random = new Random();
            List<string> wordList = new List<string>()
            {
                "bil", "bus", "tog", "fly", "båd", "cykel", "motorcykel", "knallert", "traktor", "lastbil",
                "hus", "lejlighed", "villa", "sommerhus", "garage", "trappe", "tag", "vindue", "dør",
                "kat", "hund", "hamster", "fisk", "fugl", "edderkop", "orm", "snegl", "bille", "sommerfugl",
                "træ", "busk", "blomst", "græs", "blad", "stang", "gren", "top", "rod",
                "bjerg", "bakke", "dal", "flod", "sø", "hav", "strand", "kyst", "ø", "vandfald"
            };
            int index = random.Next(wordList.Count);
            string randomWord = wordList[index];

            foreach (char x in randomWord)
            {
                Console.Write("_ ");
            }

            int LengthOfWordToGuess = randomWord.Length;
            int AmountOfTimeWrong = 0;
            wordList<char> currentLetterGuessed = new wordList<char>();
            int currentLettersRight = 0;

            while (AmountOfTimeWrong != 6 && currentLettersRight != LengthOfWordToGuess)
            {
                Console.Write("\nLetters Guessed So far: ");
                foreach (char letter in currentLetterGuessed)
                {
                    Console.Write(letter + " ");
                }
                //Ask user for inputs
                Console.Write("\nGuess a letter: ");
                char letterGuessed = Console.ReadLine()[0];
                //We check if the letter has already been guessed

                if(currentLetterGuessed.Contains(letterGuessed))
                {
                    Console.Write("\r\nYou have already guessed that letter.");
                    printHangman(AmountOfTimeWrong);
                    currentLettersRight = PrintWord(currentLetterGuessed, randomWord);
                    printLines(randomWord);
                }
                else
                {
                    //check if the letter is in the word
                    bool right = false;
                     for (int i = 0; i < randomWord.Length; i++) { if (letterGuessed == randomWord[i]) { right = true; } }

                    if (right)
                    {
                        printHangman(AmountOfTimeWrong);
                        currentLetterGuessed.Add(letterGuessed);
                        currentLettersRight = PrintWord(currentLetterGuessed, randomWord);
                        Console.Write("\r\n");
                        printLines(randomWord);
                    }
                    else 
                    {
                        AmountOfTimeWrong++;
                        currentLetterGuessed.Add(letterGuessed);
                        printHangman(AmountOfTimeWrong);
                        currentLettersRight = PrintWord(currentLetterGuessed, randomWord);
                        Console.Write("\r\n");
                        printLines(randomWord);
                    }
                }
            }
            Console.WriteLine("\r\n The Game Is Now Over. Thank you for playing :D");
        }

    }
}