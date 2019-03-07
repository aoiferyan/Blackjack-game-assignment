using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_New
{
    class Player
    {
        //properties

        public int PlayerScore { get; set; }
        public int AceCount { get; set; }
        public string CardsDealt { get; set; }


        //constructors
        public Player(int playerscore, int acecount, string cardsdealt)
        {

            PlayerScore = playerscore;
            AceCount = acecount;
            CardsDealt = cardsdealt;
            
        }
        public Player()
        {

        }

        //Ace Value Method checks to see if the Ace card should be worth 1 or 11.

        public int AceValue(int total)
        {
            int result;
            if (total <= 10)
            {
                result = 11;
            }
            else
            {
                result = 1;
            }
            return result;
        }

        //Final Score Method used an if statement to check the final score or decide if the player has gone bust
        public void GetFinalScore(int Score1, int score2)
        {
            if (Score1 > 21)
            {
                Console.WriteLine("You have gone bust");
            }
            else
            {

                Console.WriteLine($"Your final score is {Score1}");
            }

            if (score2 > 21)
            {
                Console.WriteLine("Dealer has gone bust");
            }
            else
            {

                Console.WriteLine($"Dealers final score is {score2}");
            }
        }

        //The winner method displays a message to the console as to whether the player has won, lost or drawn the game
        public void GetWinner(int Score1, int Score2)
        {
            
            if (Score1 > Score2 && Score1 <= 21)
            {
                Console.WriteLine("Congratualations! You have beaten the Dealer!");
            }
            else if (Score2 > 21 && Score1 <=21)
            {
                Console.WriteLine("Congratualations! You have beaten the Dealer!");
            }
            else if (Score2 > Score1 && Score2 <= 21)
            {
                Console.WriteLine("You lose! Better luck next time...");
            }
            else if (Score1 > 21 && Score2 <= 21)
            {
                Console.WriteLine("You lose! Better luck next time...");
            }
            else if (Score1 > 21 && Score2 > 21)
            {
                Console.WriteLine("You both went bust so it's a DRAW! Better luck next time...");
            }
            else if (Score1 == Score2)
            {
                Console.WriteLine("You both went bust so it's a DRAW! Better luck next time...");
            }
            
        }
}
}
