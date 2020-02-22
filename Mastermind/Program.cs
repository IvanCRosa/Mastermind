using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {
        const int MaxGuesses = 10;
        const int ListSize = 4;
        static void Main(string[] args)
        {
            Console.WriteLine("Mastermind, guess the 4 digits, in 10 tries");

            Random myRandom = new Random();

            List<int> numbers = new List<int>();
            int guesses = 0;

            string result = string.Empty;

            string strGuess;

            int guess;

            for (int i = 0; i < ListSize; i++)
                numbers.Add(myRandom.Next(1, 6));

            Console.WriteLine("Guess the {0} digit code, Under {1} tries!", ListSize, MaxGuesses);

            do
            {
                if (guesses > MaxGuesses)
                    Console.WriteLine("You have went over 10 tries");
                else
                {
                    Console.WriteLine("Guess a number between 1 and 6");
                    strGuess = Console.ReadLine();
                    if (int.TryParse(strGuess, out guess))
                    {
                        guesses++;
                        if (numbers[0] == guess)
                        {
                            Console.WriteLine("+");
                            numbers.Remove(numbers[0]);
                            result += guess;
                        }
                        else numbers.Contains(guess);
                        Console.WriteLine("-");
                    }
                    else
                        Console.WriteLine("This is not a number");
                }
            } while (guesses <= MaxGuesses && numbers.Count > 0);

            if (guesses < MaxGuesses)
                Console.WriteLine("Correct! It took {0} guesses to come up with the pattern {1}", guesses, result);
            else
                Console.WriteLine("You took to many tries! Game Over");

            Console.ReadLine();
        }
    }
}
