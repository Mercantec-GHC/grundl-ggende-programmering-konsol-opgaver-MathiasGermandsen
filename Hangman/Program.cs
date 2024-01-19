using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

namespace HangmanAppTest
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
                Console.Write("\u0305");
            }
        }

        static void main(string[] args)
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

        }

    }
}