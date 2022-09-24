using System;

namespace Rock___Paper___Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";
            Console.WriteLine($"Choose [r]ock, [p]aper or [s]cissors");
            Console.WriteLine("if you want to stop the game, write end");
            string playerMove = Console.ReadLine();
            while (playerMove != "end")
            {
                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = scissors;
                }
                else
                {
                    Console.WriteLine("Invalid inpu. Try again...");
                    return;
                }
                Random random = new Random();
                int compRandom = random.Next(1, 4);
                string compMove = "";
                switch (compRandom)
                {
                    case 1:
                        compMove = rock;
                        break;

                    case 2:
                        compMove = paper;
                        break;

                    case 3:
                        compMove = scissors;
                        break;
                }
                Console.WriteLine($"The computer choose {compMove}");
                if ((playerMove == rock && compMove == rock) || (playerMove == paper && compMove == paper) ||
                        (playerMove == scissors && compMove == scissors))
                {
                    Console.WriteLine("Draw");
                }
                else if ((playerMove == rock && compMove == scissors) || (playerMove == paper && compMove == rock) ||
                        (playerMove == scissors && compMove == paper))
                {
                    Console.WriteLine("You win");
                }
                else
                {
                    Console.WriteLine("You lose");
                }
                playerMove = Console.ReadLine();
            }

        }
    }
}
