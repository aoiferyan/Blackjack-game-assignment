using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_New
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerInstructions();

            string x = "";
            //WHILE LOOP FOR THE WHOLE GAME WHICH CONTINUES UNTIL PLAYER SAYS no
            while (x != "no")
            {
                //ARRAY FOR ALL 52 CARDS OF THE DECK AND WHERE RANDOM NUMBERS ARE STORED
                int[] CardsDealt = new int[52];
                //random number object Wth player and card objects
                Random random = new Random();
                Player Player1 = new Player();
                Player Dealer1 = new Player();
                Card PlayerCard = new Card();
                Card DealerCard = new Card();
                Console.WriteLine("\nXXXXXXXXXXXXXXX PLAYER'S TURN XXXXXXXXXXXXXXX\n");

                //while loop for PLAYERS TURN
                int PlayerTurn = 0;
                while (PlayerTurn < 2)
                {
                    int randomnum = (random.Next(1, 53));
                    Console.WriteLine($"Card dealt is the {PlayerCard.GetCardName(randomnum)} of {PlayerCard.GetSuit(randomnum)}, value {PlayerCard.GetCardWorth(randomnum)}");
                    Console.ReadLine();
                    //check if random number is already in the array
                    if (randomnum != CardsDealt[randomnum - 1])
                    {
                        //checking for value of ace using Ace method in an if statement
                        if(PlayerCard.GetCardWorth(randomnum) == 1)
                        {
                            //figure out what ace is worth 11 or 1
                            Console.WriteLine($"Player Score is {Player1.PlayerScore}");
                            Console.WriteLine($"Ace is worth {Player1.AceValue(Player1.PlayerScore)}");
                            Player1.PlayerScore += Player1.AceValue(Player1.PlayerScore);
                            Console.WriteLine($"Player Score is now {Player1.PlayerScore}");
                        }
                        else
                        {
                            Console.WriteLine($"Player Score is now {Player1.PlayerScore += PlayerCard.GetCardWorth(randomnum)}");
                        }

                        PlayerCardsDealt(randomnum, Player1, PlayerCard);
                        Console.ReadLine();
                        PlayerTurn++;
                    }
                    else
                    {
                        Console.WriteLine($"{randomnum} is a duplicate! Dealing another card");
                    }
                }//END OF PLAYER WHILE LOOP

                //START OF STICK OR TWIST WHILE LOOP WHICH CONTINUES UNTIL THE PLAYER STICKS
                string decision = "";
                Console.WriteLine("Do you want to stick or twist? s or t");
                decision = Console.ReadLine();
                while (decision == "t")
                {
                    Console.WriteLine("Dealing card");
                    int randomnum = (random.Next(1, 53));
                    Console.WriteLine($"Card dealt is the {PlayerCard.GetCardName(randomnum)} of {PlayerCard.GetSuit(randomnum)}, value {PlayerCard.GetCardWorth(randomnum)}");
                    Console.ReadLine();
                    if (randomnum != CardsDealt[randomnum - 1])
                    {
                        //checking for Ace value
                        if (PlayerCard.GetCardWorth(randomnum) == 1)
                        {
                            //figure out what ace is worth 11 or 1
                            Console.WriteLine($"Player Score is {Player1.PlayerScore}");
                            Console.WriteLine($"Ace is worth {Player1.AceValue(Player1.PlayerScore)}");
                            Player1.PlayerScore += Player1.AceValue(Player1.PlayerScore);
                            Console.WriteLine($"Player Score is now {Player1.PlayerScore}");
                        }
                        else
                        {
                            Console.WriteLine($"Player Score is now {Player1.PlayerScore += PlayerCard.GetCardWorth(randomnum)}");
                        }
                        PlayerCardsDealt(randomnum, Player1, PlayerCard);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"{randomnum} is a duplicate! Dealing another card");
                    }

                    Console.WriteLine("Do you want to stick or twist? s or t");
                    decision = Console.ReadLine();
                }//END OF STICK OR TWIST LOOP

                Console.WriteLine("\nXXXXXXXXXXXX DEALER'S TURN XXXXXXXXXXXXX");
                Console.ReadLine();

                //START OF DEALER WHILE LOOP
                int DealerTurn = 0;
                while (DealerTurn < 2)
                {
                    int randomnum = (random.Next(1, 53));
                    Console.WriteLine($"Card dealt is the {DealerCard.GetCardName(randomnum)} of {DealerCard.GetSuit(randomnum)}, value {DealerCard.GetCardWorth(randomnum)}");
                    Console.ReadLine();
                    if (randomnum != CardsDealt[randomnum - 1])
                    {
                        //checking for Ace value
                        if (DealerCard.GetCardWorth(randomnum) == 1)
                        {
                            //figure out what ace is worth 11 or 1
                            Console.WriteLine($"Dealer Score is {Dealer1.PlayerScore}");
                            Console.WriteLine($"Ace is worth {Dealer1.AceValue(Dealer1.PlayerScore)}");
                            Dealer1.PlayerScore += Dealer1.AceValue(Dealer1.PlayerScore);
                            Console.WriteLine($"Dealer Score is now {Dealer1.PlayerScore}");
                        }
                        else
                        {
                            Console.WriteLine($"Dealer Score is now {Dealer1.PlayerScore += DealerCard.GetCardWorth(randomnum)}");
                        }
                        PlayerCardsDealt(randomnum, Dealer1, DealerCard);
                        Console.ReadLine();
                        DealerTurn++;
                    }
                    else
                    {
                        Console.WriteLine($"{randomnum} is a duplicate! Dealing another card");
                    }
                }//END OF DEALER WHILE LOOP

                //DEALING DEALER EXTRA CARDS IF SCORE <17
                while (Dealer1.PlayerScore < 17)
                {
                    int randomnum = (random.Next(1, 53));
                    Console.WriteLine($"Card dealt is the {DealerCard.GetCardName(randomnum)} of {DealerCard.GetSuit(randomnum)}, value {DealerCard.GetCardWorth(randomnum)}");
                    Console.ReadLine();
                    //checking for Ace value
                    if (DealerCard.GetCardWorth(randomnum) == 1)
                    {
                        //figure out what ace is worth 11 or 1
                        Console.WriteLine($"Dealer Score is {Dealer1.PlayerScore}");
                        Console.WriteLine($"Ace is worth {Dealer1.AceValue(Dealer1.PlayerScore)}");
                        Dealer1.PlayerScore += Dealer1.AceValue(Dealer1.PlayerScore);
                        Console.WriteLine($"Dealer Score is now {Dealer1.PlayerScore}");
                    }
                    else
                    {
                        Console.WriteLine($"Dealer Score is now {Dealer1.PlayerScore += DealerCard.GetCardWorth(randomnum)}");
                    }
                    PlayerCardsDealt(randomnum, Dealer1, DealerCard);
                    Console.ReadLine();
                }//END OF EXTRA CARDS WHILE LOOP

                //FINAL SCORES OF PLAYER AND DEALER
                Player1.GetFinalScore(Player1.PlayerScore, Dealer1.PlayerScore);
                Console.WriteLine("");
                Console.ReadLine();

                //ADDITIONAL FEATURE ADDED. ASSOCIATED WITH THE METHOD PlayerCardsDealt BELOW. 
                Console.WriteLine($"the cards dealt to the player are \n{Player1.CardsDealt}\n");
                Console.ReadLine();
                Console.WriteLine($"the cards dealt to the Dealer are \n{Dealer1.CardsDealt}\n");
                Console.ReadLine();
                
                //DECLARING GAME'S WINNER
                Player1.GetWinner(Player1.PlayerScore, Dealer1.PlayerScore);
                Console.ReadLine();

                Console.WriteLine("Do you want to play again? yes or no");
                x = Console.ReadLine();
            }
            //END OF THE GAME WHILE LOOP

            Console.Clear();
            Console.WriteLine("Thanks for Playing, Come back soon!");
            Console.ReadLine();
        }


        //method for instructions to the game. 
        public static void PlayerInstructions()
        {
            Console.WriteLine("\t\t\tWelcome to Blackjack");
            Console.WriteLine("\nThe rules of the game are simple!");
            Console.WriteLine("You need to have a hand less than or equal to 21");
            Console.WriteLine("The dealer deals you 2 cards and then you can decide whether to stick or twist");
            Console.WriteLine("You can recieve a card until you stick or go bust");
            Console.WriteLine("When you stick the dealer deals 2 cards for themselves");
            Console.WriteLine("your opponent then repeats this process until they have more than 17 or go bust");
            Console.WriteLine("You then compare scores and the highest score wins\n");
            Console.WriteLine("Can you beat the dealer?\n");
            Console.WriteLine("GOOD LUCK!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Let's Play!");
            Console.ReadLine();
            Console.Clear();
        }

        //ADDITIONAL GAME FEATURE WHICH RECORDS THE CARD NAME AND SUIT THAT HAS BEEN DEALT.
        //THEN WE CAN CALL THE CARDS THAT HAVE BEEN DEALT FOR BOTH THE PLAYER AND THE DEALER AS CAN BE SEEN IN LINE 162 ABOVE.
        public static void PlayerCardsDealt(int randnum, Player anyplayer, Card anycard)
        {
            anyplayer.CardsDealt += $"{anycard.GetCardName(randnum)} of {anycard.GetSuit(randnum)} \n";
        }


    }
    
}
