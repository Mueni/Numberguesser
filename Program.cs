using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            //App Info

            getAppInfo();

            // Welcome user
            getUserDetails();

            // The actual game
            theGame();



        }

        static void getAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mueni Michelle";

            // change intro textcolor
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0} : Version {1} By {2}", appName, appVersion, appAuthor);


            Console.ResetColor();
        }

        static void getUserDetails()
        {
            Console.WriteLine("What is your Name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hey {0}, Welcome to our game ...", inputName);
        }

        static void colorUp(ConsoleColor color, string message)
        {
            //Change color to prefered
            Console.ForegroundColor = color;

            //message for user
            Console.WriteLine(message);

            //Reset color
            Console.ResetColor();


        }

        static void theGame()
        {
            while (true)
            {
                //create a random object

                Random random = new Random();

                //init correctNumber
                int correctNumber = random.Next(1, 10);


                int guess = 0;

                // ask user for number
                Console.WriteLine("Guess a number between 0 and 10");


                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //lets ensure this is a number

                    if (!int.TryParse(input, out guess))
                    {
                        colorUp(ConsoleColor.Red, "Please input an actual number");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {

                        // error message
                        colorUp(ConsoleColor.Red, "Shoot it's wrong, Try again");

                    }
                }


                // success message
                colorUp(ConsoleColor.Yellow, "Yeeeeey You Got It.!!!");


                // Ask user to play again
                Console.WriteLine("Would you like to Play again?");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }

                else if (answer == "N")
                {
                    colorUp(ConsoleColor.Blue, "Sad to see you leave, Bye");
                    return;
                }

                else
                {
                    return;
                }
            }
        }
    }
}
