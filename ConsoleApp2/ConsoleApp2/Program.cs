using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOFGuesses = false;

            while (guess != secretWord && !outOFGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOFGuesses = true;
                }
            }

            if (outOFGuesses)
                {
                    Console.Write("You Lose");
                }
                else
                {
                    Console.WriteLine("You guessed right");
                }

            


                Console.ReadLine();
        }
    }
}
