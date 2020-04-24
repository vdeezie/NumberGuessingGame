using System;

namespace guessNumberGame {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("Select your Level : A = Easy , B = Medium , C = Hard");
            string userSelect = Console.ReadLine ();

            if (userSelect == "A") {
                try {
                    Random random = new Random ();  
                    int randomNumber = random.Next (1, 11);
                    int guess = 0;
                    int numberOfGuess = 6;
                    bool gameOver = false;

                    Console.WriteLine ("Easy Mode: Select number between 1 to 10, You have 6 Guess Chances: .....Goodluck");    

                    while (gameOver == false) {
                        guess = Convert.ToInt32 (Console.ReadLine ());
                        numberOfGuess--;

                        if (guess != randomNumber && numberOfGuess == 0) {
                            Console.WriteLine ("You've used up Your 6 Guess chances....GAME OVER!!");
                            gameOver = true;
                        } else if (guess == randomNumber) {
                            Console.WriteLine ("YOU WIN");
                            gameOver = true;
                        } else if (guess > randomNumber) {
                            Console.WriteLine ("Number too high ,  Go low!");
                        } else if (guess < randomNumber) {
                            Console.WriteLine ("Number too low ,  Go high!");
                        }

                    }
                    Console.ReadLine ();
                } catch (FormatException) {
                    Console.WriteLine ("Wrong Input... PLEASE ENTER A NUMBER.");
                }

            } else if (userSelect == "B") {
                try {
                    Random random = new Random ();
                    int randomNumber = random.Next (1, 21);
                    int guess = 0;
                    int numberOfGuess = 4;
                    bool gameOver = false;

                    Console.WriteLine ("Medium: Select number between 1 to 20: ");

                    while (gameOver == false) {
                        guess = Convert.ToInt32 (Console.ReadLine ());
                        numberOfGuess--;

                        if (guess != randomNumber && numberOfGuess == 0) {
                            Console.WriteLine ("You've used up Your 4 Guess chances....GAME OVER!!");
                            gameOver = true;
                        } else if (guess == randomNumber) {
                            Console.WriteLine ("YOU WIN !!");
                            gameOver = true;
                        } else if (guess > randomNumber) {
                            Console.WriteLine ("Number too high ,  Go low!");
                        } else if (guess < randomNumber) {
                            Console.WriteLine ("Number too low ,  Go high!");
                        }
                    }
                    Console.ReadLine ();
                } catch (FormatException) {
                    Console.WriteLine ("Wrong input... PLEASE ENTER A NUMBER.");
                }

            } else if (userSelect == "C") {
                try {
                    Random random = new Random ();
                    int randomNumber = random.Next (1, 51);
                    int guess = 0;
                    int numberOfGuess = 3;
                    bool gameOver = false;

                    Console.WriteLine ("Hard Mode: Select number between 1 to 50, You have 3 Guess Chances: Goodluck ");

                    while (gameOver == false) {
                        guess = Convert.ToInt32 (Console.ReadLine ());
                        numberOfGuess--;

                        if (guess != randomNumber && numberOfGuess == 0) {
                            Console.WriteLine ("You've used up 3 guess chances....GAME OVER!!");
                            gameOver = true;
                        } else if (guess == randomNumber) {
                            Console.WriteLine ("YOU WIN !!");
                            gameOver = true;
                        } else if (guess > randomNumber) {
                            Console.WriteLine ("Number too high ,  Go low!");
                        } else if (guess < randomNumber) {
                            Console.WriteLine ("Number too low ,  Go high!");
                        }
                    }
                    Console.ReadLine ();
                } catch (FormatException) {
                    Console.WriteLine ("Wrong input... PLEASE ENTER A NUMBER.");
                }

            }

        }
    }
}