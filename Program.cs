using System;

namespace NumberGuessingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NumberGuessingGame\n");

            //variables
            Random random = new Random();
            bool endGame = false;

            //Game loop
            while(endGame == false)
            {
                int guessNumber = random.Next(1,50);
                int userGuess = 0;
                int nrofGuesses = 0;

                Console.Write("Welcome! Select a mode A = 'easy', B = 'medium', C = 'Hard' ");
                string userSelect = Console.ReadLine();

                if (userSelect == "A")
                {
                    Console.Write("Enter a number between 1 and 10:");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    ++nrofGuesses;

                    if (userGuess < guessNumber)
                    {
                        Console.WriteLine("That was wrong");
                        ++nrofGuesses;
                    }
                    else
                    {
                        Console.WriteLine("You got it right! The number was {0}!", guessNumber);
                        Console.WriteLine("It took you {0} {1}.\n", userGuess, userGuess == 1? "try" : "tries");
                        
                        break;
                    }


                if (userSelect == "B")
                {
                    Console.Write("Enter a number between 1 and 20:");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    ++nrofGuesses;
                    if (userGuess < guessNumber)
                    {
                        Console.WriteLine("That was wrong");
                        ++nrofGuesses;
                    }
                    else
                    {
                        Console.WriteLine("You got it right! The number was {0}!", guessNumber);
                        Console.WriteLine("It took you {0} {1}.\n", userGuess, userGuess == 1? "try" : "tries");
                        
                        break;
                    }
                }

                if (userSelect == "C")
                {
                    Console.Write("Enter a number between 1 and 50:");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                   
                    if (userGuess < guessNumber)
                    {
                        Console.WriteLine("That was wrong");
                        ++nrofGuesses;
                    }
                    else
                    {
                        Console.WriteLine("You got it right! The number was {0}!", guessNumber);
                        Console.WriteLine("It took you {0} {1}.\n", userGuess, userGuess == 1? "try" : "tries");
                        
                        break;
                    }
                }
            }
        }
    }
}